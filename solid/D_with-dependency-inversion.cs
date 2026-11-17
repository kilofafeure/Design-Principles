var saverRepository = new UserRepository();
var saverService = new UserService();


var user = new User(saverService)
{
    Name = "John Doe",
    Email = "john.doe@example.com"
};

user.Save();


public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    private ISaverUser _userSaver;

    public User(ISaverUser userSaver)
    {
        _userSaver = userSaver;
    }

    public void Save()
    {
        _userSaver.Save(this);
    }
    

}

public interface ISaverUser
{
    void Save(User user);
}

public class UserRepository : ISaverUser
{
     public void Save(User user)
     {
         Console.WriteLine($"Usuario guardado: {user.Name}, {user.Email}");
     }
}

public class UserService : ISaverUser
{
    public void Save(User user)
    {
        Console.WriteLine($"Usuario enviado a servicio: {user.Name}, {user.Email}");
    }
}