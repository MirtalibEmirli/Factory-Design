 


interface FurnitureFactory
{
    public Chair createChair();

    public CoffeTable createCoffeTable();

    public Sofa createSofa();
}

interface Chair {
    public void hasLegs();
    public void sitOn();
}

interface CoffeTable{

    public void hasLegs();
    public void putOn();
}

interface Sofa{

    public void hasLegs();
    public void sitOn();
}


class ModernFurnitureFactory : FurnitureFactory
{
    public Chair createChair() => new ModernChair() ;

    public CoffeTable createCoffeTable() => new ModernCoffeTable();

    public Sofa createSofa() => new ModernSofa();


}
class VicFurnitureFactory : FurnitureFactory
{
    public Chair createChair() => new VicChair();

    public CoffeTable createCoffeTable() => new VicCoffeTable();

    public Sofa createSofa() => new VicSofa();
}



class ModernChair : Chair
{
    public void hasLegs()
    {
        Console.WriteLine("has");

    }

    public void sitOn()
    {
        Console.WriteLine("do");

    }
}
class VicChair : Chair
{
    public void hasLegs()
    {
        Console.WriteLine("has");

    }

    public void sitOn()
    {
        Console.WriteLine("do");

    }
}


class ModernSofa : Sofa
{
    public void hasLegs()
    {
        Console.WriteLine("has");
    }

    public void sitOn()
    {
        Console.WriteLine("do");
    }
}

class VicSofa : Sofa
{
    public void hasLegs()
    {
        Console.WriteLine("has");
    }

    public void sitOn()
    {
        Console.WriteLine("do");
    }
}

class ModernCoffeTable : CoffeTable
{
    public void hasLegs()
    {
        Console.WriteLine("has");
    }

    public void putOn()
    {
        Console.WriteLine("has");
    }
}
class VicCoffeTable : CoffeTable
{
    public void hasLegs()
    {
       Console.WriteLine("has");
    }

    public void putOn()
    {
        Console.WriteLine("has");
    }
}

class Client
{
    private readonly Chair chair = null;
    private readonly Sofa sofa =  null;
    private readonly CoffeTable coffeTable = null;

    public Client(FurnitureFactory furniturefac)
    {
        chair = furniturefac.createChair();
        sofa = furniturefac.createSofa();
        coffeTable = furniturefac.createCoffeTable();
    }

}


