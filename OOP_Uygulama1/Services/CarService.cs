using OOP_Uygulama1.Exceptions;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Models.Dtos;
using OOP_Uygulama1.Repository;
using OOP_Uygulama1.Services.Converter;

namespace OOP_Uygulama1.Services;
// Car : ColorName alanı minimum 2 karakterli olmalıdır.
// Car : DailyPrice kolonuna kdv tutarını da ekleyerek kdv li fiyatını veri tabanına yanısıtın.
public class CarService
{
    private CarRepository _carRepository;
    private CarConverter carConverter;

    public CarService()
    {
        _carRepository = new CarRepository();
        carConverter = new CarConverter();
    }

    public void Add(Car car)
    {
        try
        {
            ColorNameValidator(car.ColorName);
            car.DailyPrice = car.DailyPrice * 1.2;


            _carRepository.Add(car);
        }

        catch (BusinessException ex)
        {
            Console.WriteLine("BusinessException Fırlatıldı.");
            Console.WriteLine(ex.Message);
        }


   

       // _carRepository.GetAllCars().ForEach(c => Console.WriteLine(car));
    }

    // List<Car> -> List<CarResponseDto>
    // Car -> CarResponseDto
    public void GetAll()
    {
        List<Car> cars = _carRepository.GetAllCars();
        List<CarResponseDto> carResponseDtos = carConverter.ConvertToResponseDtoList(cars);

        foreach(CarResponseDto dto in carResponseDtos)
        {
            Console.WriteLine(dto);
        }

    }

    public void Delete(int id)
    {
        _carRepository.Delete(id);
    }

    public void GetById(int id)
    {
        Car car = _carRepository.GetById(id);
        CarResponseDto carResponseDto = carConverter.ConvertToResponseDto(car);
        Console.WriteLine(carResponseDto);
    }

    private void ColorNameValidator(string colorName)
    {
        if (colorName.Length<2)
        {
            throw new BusinessException("Aracın ColorName alanı minimum 2 karakterli olmalıdır.");
        }
    }

    // İlgili nesne bulunmadığı zaman atılan Exception -> NotFoundException
    // İlgili iş kuralın uymadığı zaman atılan Exception -> BusinessException
}
