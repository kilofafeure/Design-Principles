// Interfaz: declara un contrato sin imponer cómo se implementa.
// Process depende de ISave, por lo que puede trabajar con Sale o Document,
// siempre que ambos ofrezcan el método Save.
// var sale = new Sale();

var document = new Document();
var process = new Process(document);
process.Run();

public class Process
{
    private ISave saver;

    public Process(ISave saver)
    {
        this.saver = saver;
    }

    public void Run()
    {
        Console.WriteLine("Iniciando proceso, hace cosas aquí...");
        saver.Save();
        Console.WriteLine("Proceso finalizado.");
    }

}

public class Sale : ISave, ISend
{
    public void Save()
    {
        Console.WriteLine("Guardando Venta...");
    }

    public void Send()
    {
        Console.WriteLine("Enviando Venta...");
    }
}

public class Document : ISave
{
    public void Save()
    {
        Console.WriteLine("Guardando Documento...");
    }
}

public interface ISave
{
    void Save();
}

public interface ISend
{
    void Send();
}
