
namespace OOP_Uygulama1.Models;

public class Brand : BaseModel
{
    public string Name { get; set; }


    public override string ToString()
    {
        return $"Brand[ Id :{Id} , Oluşturma Tarihi : {CreatedTime}, Adı : {Name} ]";
    }


}
