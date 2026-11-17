// Abstracción: expone una operación sencilla (Serve) y oculta los pasos internos
// necesarios para realizarla, como fermentar, carbonatar y enfriar.

var beer = new Beer();
beer.Serve();

public class Beer
{
    public void Serve()
    {
        Ferment();
        Carbonate();
        Cool();

        Console.WriteLine("Cerveza lista para servir");
    }

    private void Ferment()
    {
        Console.WriteLine("Fermentando...");
    }

    private void Carbonate()
    {
        Console.WriteLine("Carbonatando...");
    }

    private void Cool()
    {
        Console.WriteLine("Enfriando...");
    }
}