using OOP_Uygulama1.Exceptions;
using OOP_Uygulama1.Models;

namespace OOP_Uygulama1.Repository;
public class BrandRepository
{
    private List<Brand> _brands;

    public BrandRepository()
    {
        _brands = new List<Brand>(); 
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }

    public Brand GetById(int id)
    {
        Brand? brand = _brands.Find(b=> b.Id == id);
        if(brand is null)
        {
            throw new NotFoundException(id);

        }

        return brand; 
    }

    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }


    public void Delete(int id)
    {
        Brand? brand = _brands.FirstOrDefault(x=> x.Id == id);
        if (brand is null)
        {
            throw new NotFoundException(id);
        }

        _brands.Remove(brand);
    }



}
