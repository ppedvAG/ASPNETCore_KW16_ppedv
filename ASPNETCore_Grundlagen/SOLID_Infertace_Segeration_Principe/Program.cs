// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Bad Sample
public interface IBadVehicle
{
    void ICanFly();
    void ICanDrive();
    void ICanSwim();
}

public class MultiVehicle : IBadVehicle
{
    public void ICanDrive()
    {
        throw new NotImplementedException();
    }

    public void ICanFly()
    {
        throw new NotImplementedException();
    }

    public void ICanSwim()
    {
        throw new NotImplementedException();
    }
}


public class BadCarVehicle : IBadVehicle
{
    public void ICanDrive()
    {
        //fahren .... 
    }

    public void ICanFly()
    {
        throw new NotImplementedException();
    }

    public void ICanSwim()
    {
        throw new NotImplementedException();
    }
}
#endregion 


public interface IFlyVehicle
{
    void Fly();
}

public interface IDriveVehicle
{
    void Drive();
}

public interface ISwimVehicle
{
    void Swim();
}


public class MultiVehicle2 : IFlyVehicle, IDriveVehicle, ISwimVehicle
{
    public void Drive()
    {
        //kann fahren
    }

    public void Fly()
    {
        //kann fliegen
    }

    public void Swim()
    {
       //kann schwimmen. 
    }
}

public class AmphibischeVehicle : ISwimVehicle, IDriveVehicle
{
    public void Drive()
    {
        //kann fahren
    }

    public void Swim()
    {
        //kann schwimmen
    }
}