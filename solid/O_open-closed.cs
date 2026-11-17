var creditCalculateTax = new CreditCalculateTax();
var cashCalculateTax = new CashCalculateTax();
var foreignCalculateTax = new ForeignCalculateTax();

var creditSale = new Sale(creditCalculateTax, 1000m);
var cashSale = new Sale(cashCalculateTax, 1000m);
var foreignSale = new Sale(foreignCalculateTax, 1000m);

Console.WriteLine($"Credit Sale Total: {creditSale.GetTotal()}");
Console.WriteLine($"Cash Sale Total: {cashSale.GetTotal()}");
Console.WriteLine($"Foreign Sale Total: {foreignSale.GetTotal()}");

// Sin Principio Abierto-Cerrado ****************************************
public class SaleAll
{
    public decimal Amount { get; private set; }
    public string Type { get; private set; }

    public SaleAll(decimal amount, string type)
    {
        Amount = amount;
        Type = type;
    }

    public decimal GetTotal()
    {
        if (Type == "Credit")
        {
            return Amount * 0.1m; // 10% tax for credit sales
        }
        else if (Type == "Cash")
        {
            return Amount * 0.2m; // 20% tax for cash sales
        } 
        else if (Type == "Foreign")
        {
            return Amount * 0.3m; // 30% tax for foreign sales
        }

        return Amount * 0.05m;
    }
}

// Con Principio Abierto-Cerrado ******************************************************************************************
public interface ICalculateTax
{
    decimal CalculateTax(decimal amount);
}

public class Sale
{
    public decimal Amount { get; private set; }
    private readonly ICalculateTax _calculateTax;

    public Sale(ICalculateTax calculateTax, decimal amount)
    {
        _calculateTax = calculateTax;
        Amount = amount;
    }

    public decimal GetTotal()
    {
        return Amount + _calculateTax.CalculateTax(Amount);
    }

}

public class CreditCalculateTax : ICalculateTax
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.1m; // 10% tax for credit sales
    }
}

public class CashCalculateTax : ICalculateTax
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.2m; // 20% tax for cash sales
    }
}

public class ForeignCalculateTax : ICalculateTax
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.3m; // 30% tax for foreign sales
    }
}
