namespace OOP_Uygulama1.Models.Dtos;
public class CarResponseDto
{
    public string BrandName { get; set; }

    public string ModelName { get; set; }
    public int ModelYear { get; set; }

    public string ColorName { get; set; }

    public double DailyPrice { get; set; }


    public override string ToString()
    {
        return $"Marka Adı : {BrandName}, Model Adı : {ModelName}, Model Yılı : {ModelYear} " +
            $"Rengi : {ColorName}, Günlük Fiyatı : {DailyPrice}";
    }




}
