// Estado de un objeto: sus datos actuales describen su situación y cambian
// cuando se invocan operaciones. Aquí, Add y Subtract actualizan el saldo.
// Este ejemplo muestra estado mutable; no implementa el patrón State.

var account = new Account(100);
Console.WriteLine(account.Balance);
account.Add(50);
Console.WriteLine(account.Balance);
account.Subtract(30);
Console.WriteLine(account.Balance);

public class Account(decimal initialBalance)
{
    public decimal Balance { get; set; } = initialBalance;

    public void Add(decimal amount)
    {
        Balance += amount;
    }

    public void Subtract(decimal amount)
    {
        Balance -= amount;
    }
}
