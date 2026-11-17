// Clase abstracta: define una base común que no se instancia directamente.
// Employee comparte ShowName y exige a cada subtipo implementar CalculateTotal.

var employee = new NormalEmployee(5000);
Console.WriteLine("Total: " + employee.CalculateTotal());

var hourlyEmployee = new HourlyEmployee(50, 160);
Console.WriteLine("Total: " + hourlyEmployee.CalculateTotal());

public abstract class Employee
{
    public string Name { get; set; }

    public void ShowName ()
    {
        Console.WriteLine("Empleado: " +Name);
    }

    public abstract decimal CalculateTotal();
}

public class NormalEmployee : Employee
{
    private decimal _salary;

    public NormalEmployee(decimal salary)
    {
        _salary = salary;
    }

    public override decimal CalculateTotal()
    {
        return _salary;
    }
    
}

public class HourlyEmployee : Employee
{
    private decimal _hourlyRate;
    private int _hoursWorked;

    public HourlyEmployee(decimal hourlyRate, int hoursWorked)
    {
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }

    public override decimal CalculateTotal()
    {
        return _hourlyRate * _hoursWorked;
    }
}