// Composición: Sale colabora con objetos Customer y TaxCalculator para
// construir su comportamiento, en lugar de heredar de esas clases.

var customer = new Customer("Pedro");
var taxCalculator = new TaxCalculator(0.2m);
var sale = new Sale(100m, customer, taxCalculator);
Console.WriteLine(sale.GetInfo());

public class Sale
{
    public decimal Amount { get; private set; }
    private Customer _customer;

    private TaxCalculator _taxCalculator;

    public Sale(decimal amount, Customer customer, TaxCalculator taxCalculator)
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

public class TaxCalculator
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

public class Customer
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