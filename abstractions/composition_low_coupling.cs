// Bajo acoplamiento mediante abstracciones: Sale depende de los contratos
// ICustomer e ITaxCalculator, no de clases concretas. Así se pueden cambiar
// las implementaciones (por ejemplo, usar otro cálculo de impuestos).

var customer = new Customer("Pedro");
var companyCustomer = new CompanyCustomer("Pedro", "TechCorp");

var taxCalculator = new TaxCalculator(0.2m);
var foreignTaxCalculator = new ForeignTaxCalculator(0.15m, 10m);

var sale = new Sale(100m, customer, foreignTaxCalculator);
Console.WriteLine(sale.GetInfo());

public class Sale
{
    public decimal Amount { get; private set; }
    private ICustomer _customer;
    private ITaxCalculator _taxCalculator;

    public Sale(decimal amount, ICustomer customer, ITaxCalculator taxCalculator)
    {
        Amount = amount;
        _customer = customer;
        _taxCalculator = taxCalculator;
    }

    public decimal GetTotalAmount()
    {
        return Amount + _taxCalculator.CalculateTax(Amount);
    }

    public string GetInfo()
    {
         return $"Venta: {Amount}, Total: {GetTotalAmount()}, {_customer.GetName()}";
    }

}

public interface ITaxCalculator
{
    decimal CalculateTax(decimal amount);
}

public class TaxCalculator : ITaxCalculator
{
    private decimal _taxRate;
    public TaxCalculator(decimal taxRate)
    {
        _taxRate = taxRate;
    }

    public decimal CalculateTax(decimal amount)
    {
        return amount * _taxRate;
    }
}

public class ForeignTaxCalculator : ITaxCalculator
{
     private decimal _taxRate;
     private decimal _fixedAmount;

     public ForeignTaxCalculator(decimal taxRate, decimal fixedAmount)
     {
         _taxRate = taxRate;
         _fixedAmount = fixedAmount;
     }

     public decimal CalculateTax(decimal amount)
     {
         return amount * _taxRate + _fixedAmount;
     }
}


public interface ICustomer
{
    string GetName();
}

public class Customer : ICustomer
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return $"Cliente: {_name}";
    }
}

public class CompanyCustomer : ICustomer
{
    private string _name;
    private string _companyName;

    public CompanyCustomer(string name, string companyName)
    {
        _name = name;
        _companyName = companyName;
    }

    public string GetName()
    {
        return $"Cliente: {_name}, Empresa: {_companyName}";
    }
} 