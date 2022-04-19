// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Negativ-Beispiel
public class BadEmployee
{
    //Datenstruktur
    public int Id { get; set; }
    public string Name { get; set; }


    //Methode im DataAccess Layer
    public void InsertEmployeeToTable(BadEmployee employee)
    {
        //any Code
    }


    //Export-Methode - Service Layer oder Export->UI Präsentation-Layer
    public void GenerateReport()
    {
        //any Code
    }
}
#endregion


#region Bessere Variante

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class EmployeeRepository
{
    public void Insert(Employee employee)
    {
        //Any Code
    }

    //weitere Methoden 
}

public class GenerateReport
{
    public void Generate()
    {
        //any Code
    }
}


#endregion