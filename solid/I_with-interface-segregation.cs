public interface IBasicCrud
{
    void Create();
    void Read();
}

public interface IUpdate
{
    void Update();
}

public interface IDelete
{
    void Delete();
}

public class Users : IBasicCrud, IUpdate, IDelete
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

public class Sale : IBasicCrud
{
    public void Create()
    {
        // Implementation for creating a product
    }

    public void Read()
    {
        // Implementation for reading a product
    }
}