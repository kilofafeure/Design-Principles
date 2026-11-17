public interface ICrud
{
    void Create();
    void Read();
    void Update();
    void Delete();
}

public class Users : ICrud
{
    public void Create()
    {
        // Implementation for creating a user
    }

    public void Read()
    {
        // Implementation for reading a user
    }

    public void Update()
    {
        // Implementation for updating a user
    }

    public void Delete()
    {
        // Implementation for deleting a user
    }
}

public class Sale : ICrud
{
    public void Create()
    {
        // Implementation for creating a product
    }

    public void Read()
    {
        // Implementation for reading a product
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}