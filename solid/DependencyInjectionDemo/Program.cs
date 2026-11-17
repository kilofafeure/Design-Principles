using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<ISaver<User>, UserService>();
// services.AddSingleton<ISaver<User>, UserRepository>();
services.AddSingleton<User>();
services.AddSingleton<ISaver<Sale>, SaleRepository>();
services.AddSingleton<Sale>();

var serviceProvider = services.BuildServiceProvider();

var user = serviceProvider.GetRequiredService<User>();
user.Name = "John Doe";
user.Email = "john.doe@example.com";
user.Save();

var user2 = serviceProvider.GetRequiredService<User>();
user2.Name = "Jane Doe";
user2.Email = "jane.doe@example.com";
user2.Save();

var sale = serviceProvider.GetRequiredService<Sale>();
sale.Id = 1;
sale.Amount = 100.50m;
sale.Save();


// interfaces
public interface ISaver<T>
{
    void Save(T user);
}

// User

public class User(ISaver<User> userSaver)
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    private ISaver<User> _userSaver = userSaver;

    public void Save()
    {
        _userSaver.Save(this);
    }
}


public class UserRepository : ISaver<User>
{
     public void Save(User user)
     {
         Console.WriteLine($"Usuario guardado: {user.Name}, {user.Email}");
     }
}

public class UserService : ISaver<User>
{
    public void Save(User user)
    {
        Console.WriteLine($"Usuario enviado a servicio: {user.Name}, {user.Email}");
    }
}

// Sale
public class Sale
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    private ISaver<Sale> _saleSaver;

    public Sale(ISaver<Sale> saleSaver)
    {
        _saleSaver = saleSaver;
    }

    public void Save()
    {
        _saleSaver.Save(this);
    }
}

public class SaleRepository : ISaver<Sale>
{
    public void Save(Sale sale)
    {
        Console.WriteLine($"Venta guardada: {sale.Id}, {sale.Amount}");
    }
}
