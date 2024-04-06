namespace OOP_Uygulama1.Models;

public class Car : BaseModel
{
    public Brand Brand { get; set; }

    public Model Model { get; set; }

    public string ColorName { get; set; }

    public double DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Car [Id : {Id}, OluşturmaTarihi : {CreatedTime}, \n " +
            $" {Brand}, \n {Model} \n Rengi : {ColorName}, Günlük fiyatı : {DailyPrice}]";
    }

}
