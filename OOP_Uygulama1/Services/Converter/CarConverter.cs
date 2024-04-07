
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Models.Dtos;

namespace OOP_Uygulama1.Services.Converter;

public class CarConverter
{

    public CarResponseDto ConvertToResponseDto(Car car)
    {
        CarResponseDto carResponseDto = new CarResponseDto()
        {
            BrandName = car.Brand.Name,
            ColorName = car.ColorName,
            DailyPrice = car.DailyPrice,
            ModelName = car.Model.Name,
            ModelYear = car.Model.Year
        };
        return carResponseDto;
    }


    public List<CarResponseDto> ConvertToResponseDtoList(List<Car> cars)
    {
        List<CarResponseDto> dtoList = new List<CarResponseDto>();

        foreach (Car car in cars) 
        {
            CarResponseDto carResponseDto = ConvertToResponseDto(car);
            dtoList.Add(carResponseDto);
        }
        return dtoList;
    }

}
