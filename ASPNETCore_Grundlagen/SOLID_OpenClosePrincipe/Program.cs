// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}


#region Bad Code
public class BadReportGenerator
{
    public string ReportType { get; set; } = string.Empty;

    public void GenerateReport(Employee em)
    {
        if (ReportType == "CR")
        {
            //Möglickeiten mit Crystal Report Dll zusammen zu arbeiten
        }
        else if (ReportType == "List10")
        {

        }
        else if (ReportType == "PDF")
        {

        }
    }
}
#endregion

//Open Part
public abstract class ReportGenerator
{
    public abstract void GenerateReport(Employee emp);
}


//Close-Part
public class PdfReportGenerator : ReportGenerator
{
    //Shortcut -> [STRG] + '.'
    public override void GenerateReport(Employee emp)
    {
        //PDf generieren 
    }
}

//Close-Prinzip Implementiert 
public class CrystalReports : ReportGenerator
{
    public override void GenerateReport(Employee em)
    {

    }

    //Template Vorlagen
    //Template Verzeichnis
}