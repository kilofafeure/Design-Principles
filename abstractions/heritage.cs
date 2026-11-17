// Herencia: SaleInfo deriva de Sale y reutiliza su colección de artículos.
// La clase hija amplía el comportamiento añadiendo la operación GetInfo.

var sale = new SaleInfo();
sale.Add("Apple", 1.2m);
sale.Add("Banana", 0.8m);
Console.WriteLine(sale.GetInfo());

public class Sale
{
    protected Dictionary<string, decimal> items;

    public Sale()
    {
        items = new Dictionary<string, decimal>();
    }

    public void Add(string item, decimal price)
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
}