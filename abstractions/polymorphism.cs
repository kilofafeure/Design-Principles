// Polimorfismo: distintas subclases pueden personalizar la misma operación
// virtual. SaleInfo y SaleUpper redefinen Add para aplicar reglas diferentes.

var sale = new SaleInfo();
sale.Add("Apple", 1.2m);
sale.Add("Banana", 0.8m);
Console.WriteLine(sale.GetInfo());

var saleUpper = new SaleUpper();
saleUpper.Add("Apple", 1.2m);
saleUpper.Add("Banana", 0.8m);
Console.WriteLine(saleUpper.GetInfo());

public class Sale
{
    protected Dictionary<string, decimal> items;

    public Sale()
    {
        items = new Dictionary<string, decimal>();
    }

    public virtual void Add(string item, decimal price)
    {
        items[item] = price;
    }
}

public class SaleInfo : Sale
{
    public string GetInfo()
    {
        string info = "";
        foreach (var item in items)
        {
            info += $"{item.Key}: {item.Value}\n";
        }
        return info;
    }

    public override void Add(string item, decimal price)
    {
        base.Add("Item: " + item, price);
    }
}

public class SaleUpper : SaleInfo
{
    public override void Add(string item, decimal price)
    {
        base.Add(item.ToUpper(), price);
    }
}