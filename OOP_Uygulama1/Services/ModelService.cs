using OOP_Uygulama1.Exceptions;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Repository;

namespace OOP_Uygulama1.Services;

public class ModelService
{
    private ModelRepository _modelRepository;

    public ModelService()
    {
        _modelRepository = new ModelRepository();
    }

    public void GetAll()
    {
        List<Model> models = _modelRepository.GetAll();
        models.ForEach(x=> Console.WriteLine(x));
    }

    public void Add(Model model)
    {
        _modelRepository.Add(model);

        Console.WriteLine($"Model eklendi : \n {model}");
    }

    public void GetById(int id)
    {
        try
        {
            Model model = _modelRepository.GetById(id);
            Console.WriteLine(model);
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine("Bir NotFoundException yakalandı.");
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {

            _modelRepository.Delete(id);
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine("Bir NotFoundException yakalandı.");
            Console.WriteLine(ex.Message);
        }


    }


}
