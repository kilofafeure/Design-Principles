// Encapsulación: protege los datos internos y permite modificarlos mediante
// operaciones controladas. Balance solo se puede cambiar desde Account;
// las transacciones se exponen como una lista de solo lectura.

var account = new Account(100);
Console.WriteLine(account.Balance);
account.Add(50);
Console.WriteLine(account.Balance);
account.Subtract(30);
Console.WriteLine(account.Balance);

// account.Balance = 200;
account.Subtract(20);
Console.WriteLine(account.Balance);

foreach (var transaction in account.Transactions)
{
    Console.WriteLine($"Transacciones: {transaction}");
}

public class Account(decimal initialBalance)
{
    private List<decimal> _transactions = new List<decimal>();
    public IReadOnlyList<decimal> Transactions => _transactions.AsReadOnly();
    public decimal Balance { get; private set; } = initialBalance;

    public void Add(decimal amount)
    {
        Balance += amount;
        _transactions.Add(amount);
    }

    public void Subtract(decimal amount)
    {
        Balance -= amount;
        _transactions.Add(-amount);
    }
}
