// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Bad-Code
public class BadKirsche
{
    public int TageDerReife = 100;

    public string GetColor()
    {
        return "rot";
    }
}

public class BadErbeere : BadKirsche
{
    public string GetColor()
    {
        return base.GetColor();
    }
}
#endregion


#region Better
//Open 
public abstract class Fruits
{
    public abstract string GetColor();
}


//Close
public class Kirsche : Fruits
{
    public Kirsche()
    {

    }

    public override string GetColor()
    {
        return "rot";
    }
}

public class Erbeer : Fruits
{
    public override string GetColor()
    {
        return "rot";
    }
}

#endregion