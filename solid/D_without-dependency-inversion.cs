public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    /*private UserRepository _userRepository;

    public User()
    {
        _userRepository = new UserRepository();
    }

    public void Save()
    {
        _userRepository.Save(this);
    }*/

    private UserService _userService;

    public User()
    {
        _userService = new UserService();
    }

    public void Send()
    {
        _userService.Send(this);
    }

}

public class UserRepository
{
     public void Save(User user)
     {
         Console.WriteLine($"Usuario guardado: {user.Name}, {user.Email}");
     }
}

public class UserService
{
    public void Send(User user)
    {
        Console.WriteLine($"Usuario enviado a servicio: {user.Name}, {user.Email}");
    }
}