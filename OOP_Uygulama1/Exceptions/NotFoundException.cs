namespace OOP_Uygulama1.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(int id) 
        : base($"İlgili id ye ait Nesne bulunamadı. : {id}")
    {
        
    }
}
