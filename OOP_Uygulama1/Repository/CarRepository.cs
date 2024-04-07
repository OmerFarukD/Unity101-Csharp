using OOP_Uygulama1.Models;

namespace OOP_Uygulama1.Repository;
public class CarRepository
{
   private static List<Car> _cars;
    public CarRepository()
    {
        _cars = new List<Car>();
    }

    public List<Car> GetAllCars()
    {
        return _cars;
    }


    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public Car GetById(int id)
    {
        //1. Yöntem 
        //foreach (Car car in _cars)
        //{
        //    if (car.Id == id) return car;
        //}

        //return new Car();

        Car car = _cars.Find(x=> x.Id==id);
        return car;
    }

    public void Delete(int id)
    {
        Car deleted = new Car();    

        foreach (Car car in _cars)
        {
            if (car.Id == id)
            {
                deleted = car;
            }


        }
        _cars.Remove(deleted);
    }
}
