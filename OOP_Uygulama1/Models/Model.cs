namespace OOP_Uygulama1.Models;

public class Model : BaseModel
{
    public string Name { get; set; }

    public int Year { get; set; }

    public override string ToString()
    {
        return $" Model [ Id : {Id}, Oluşturma Tarihi : {CreatedTime}, Adı : {Name}, Yılı : {Year}]";
    }

}
