// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



IShip mockObject = new ShipMockObjet();

IShip myProductiveShip = new Ship();

IShipYard yard = new ShipYard();
yard.Service(mockObject);
yard.Service(myProductiveShip);








#region beispiel Feste Kopplung

//Programmierer A: 5 Tage 
public class BadShip
{
    public string Marke { get; set; }
    public string Modell { get; set; }  
    public int Baujahr { get; set; }    
}


//Programmierer B: 3 Tage 
public class BadShipYard
{
    //Feste Kopplung -> Klaaw ShipYard kennt die Klasse Ship 
    public void Service(BadShip ship)
    {

        //Reperatur eines Schiffes
    }
}

#endregion


#region Loose Kopplung

public interface IShip
{
    string Marke { get; set; }
    string Modell { get; set; }
    int Baujahr { get; set; }
}

public interface IShipVersion2 : IShip
{
    double Tiefgang { get; set; }
}

public interface IShipYard
{
    //Hier wird die loose Kopplung definiert 
    void Service(IShip ship);
}

//Implementierungen in Klassen

//Programmierer A: 5 Tage 
public class Ship : IShip
{
    public string Marke { get; set; }
    public string Modell { get; set; }
    public int Baujahr { get; set; }


}

//Programmierer B: 3 Tage 
public class ShipYard : IShipYard
{
    public void Service(IShip ship)
    {
        //Schiff wird gewartet
    }
}

//ProgrammiererB kann an Tag 4 und 5 ein Mock-Objekt bauen

public class ShipMockObjet : IShip
{
    public string Marke { get; set; } = "Segler";
    public string Modell { get; set; } = "Modell Holz";
    public int Baujahr { get; set; } = 2022;
}

#endregion

