using OOP_Uygulama1.Models;
using OOP_Uygulama1.Models.Dtos;
using OOP_Uygulama1.Repository;

namespace OOP_Uygulama1.Services;
// Car : ColorName alanı minimum 2 karakterli olmalıdır.
// Car : DailyPrice kolonuna kdv tutarını da ekleyerek kdv li fiyatını veri tabanına yanısıtın.
public class CarService
{
    private CarRepository _carRepository;

    public CarService()
    {
        _carRepository = new CarRepository();
    }

    public void Add(Car car)
    {
        if (car.ColorName.Length < 2)
        {
            Console.WriteLine("Aracın ColorName alanı minimum 2 karakterli olmalıdır.");
        }

        car.DailyPrice = car.DailyPrice * 1.2;


        _carRepository.Add(car);

       // _carRepository.GetAllCars().ForEach(c => Console.WriteLine(car));
    }

    public void GetAll()
    {
        foreach (Car car in _carRepository.GetAllCars())
        {
            CarResponseDto carResponseDto = new CarResponseDto()
            {
                BrandName = car.Brand.Name,
                ColorName = car.ColorName,
                DailyPrice = car.DailyPrice,
                ModelName = car.Model.Name,
                ModelYear = car.Model.Year         
            };
            Console.WriteLine(carResponseDto);
        }

    }

    public void Delete(int id)
    {
        _carRepository.Delete(id);
    }

    public void GetById(int id)
    {
        Car car = _carRepository.GetById(id);
        CarResponseDto carResponseDto = new CarResponseDto()
        {
            BrandName = car.Brand.Name,
            ColorName = car.ColorName,
            DailyPrice = car.DailyPrice,
            ModelName = car.Model.Name,
            ModelYear = car.Model.Year
        };

        Console.WriteLine(carResponseDto);
    }

}
