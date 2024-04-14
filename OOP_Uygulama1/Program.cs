// Bir Rent A Car projesi yapılması isteniyor.
// Bu projede 3 tane tablomuz olduğunu varsayalım.
// Car , Model , Brand tablolarımız var.
// Bu tablolar için bir veritabanının olduğunu varsayarak( Listeleri kullanarak)
// Listeleme , ekleme, id ye göre getirme , silme operasyonlarını simüle ediniz.
// Car -> Id , CreatedTime , Model , Brand , ColorName, DailyPrice
// Model -> Id, CreatedTime, Name, Year
// Brand -> Id, CreatedTime, Name

using OOP_Uygulama1.Models;
using OOP_Uygulama1.Services;

Model model = new Model()
{
    Id = 2,
    CreatedTime = DateTime.Now,
    Name = "AMG",
    Year=2022
};

Brand brand = new Brand()
{
    Id = 2,
    CreatedTime = DateTime.Now,
    Name = "Mercedes"
};

Car car = new Car()
{
    Id = 2,
    Brand = brand,
    Model = model,
    ColorName = "Yeşil",
    CreatedTime= DateTime.Now,
    DailyPrice= 3500
};

Model model1 = new Model()
{
    Id = 1,
    CreatedTime = DateTime.Now,
    Name = "m5",
    Year = 2022
};

Brand brand1 = new Brand()
{
    Id = 1,
    CreatedTime = DateTime.Now,
    Name = "BMW"
};

Car car1 = new Car()
{
    Id = 1,
    Brand = brand1,
    ColorName = "ı",
    CreatedTime = DateTime.Now,
    DailyPrice = 2500,
    Model = model1
};

ModelService modelService = new ModelService();

//modelService.Add(model1);
modelService.GetById(6);
//modelService.GetAll();
//modelService.Delete(10);
//modelService.GetAll();
CarService carService = new CarService();
//carService.Add(car);
carService.Add(car1);
//carService.GetAll();
//carService.GetById(1);
