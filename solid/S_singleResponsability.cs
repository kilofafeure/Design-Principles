// Sin Principio *************************************************************
public class EmployeeAll
{
    public string Name { get; private set; }

    public EmployeeAll(string name)
    {
        Name = name;
    }

    public void Save()
    {
        // Lógica para guardar el empleado en la base de datos
    }

    public void SendEmail()
    {
        // Lógica para enviar un correo electrónico relacionado con el empleado
    }

    public void Report()
    {
        // Lógica para generar un reporte relacionado con el empleado
    }
}

// Con Principio de Responsabilidad Única *************************************************************
public class Employee
{
    public string Name { get; private set; }

    public Employee(string name)
    {
        Name = name;
    }
}

public class EmployeeRepository
{
    public void Save(Employee employee)
    {
        // Lógica para guardar el empleado en la base de datos
    }
}

public class EmployeeEmailService
{
    public void SendEmail(Employee employee)
    {
        // Lógica para enviar un correo electrónico relacionado con el empleado
    }
}
public class EmployeeReportService
{
    public void Report(Employee employee)
    {
        // Lógica para generar un reporte relacionado con el empleado
    }
}