using OOP_Uygulama1.Exceptions;
using OOP_Uygulama1.Models;
namespace OOP_Uygulama1.Repository;
// Exception Handling : Hata Ayıklama
public class ModelRepository
{
    private List<Model> _models;

    public ModelRepository()
    {
        _models = new List<Model>();
    }


    public List<Model> GetAll()
    {
        return _models;
    }

    public void Add(Model model)
    {
        _models.Add(model);
    }

    public Model GetById(int id)
    {
        Model? model = _models.Find(x=> x.Id==id);

    if (model == null)
        {
            throw new NotFoundException(id);
        }

    return model;
    }


    public void Delete(int id)
    {
        Model? model = _models.Find(x => x.Id == id);

        if (model == null)
        {
            throw new NotFoundException(id);
        }
        _models.Remove(model);
    }
}
