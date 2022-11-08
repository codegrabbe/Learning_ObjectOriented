using Learning_ObjectOriented.Encapsulation;
using Learning_ObjectOriented.Inheritance;
using Learning_ObjectOriented.Polymorphism;
using Learning_ObjectOriented.Abstraction;

/// <summary>
/// Program Class
/// </summary>
public class Program 
{
    /// <summary>
    /// Main Method to see the result
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Introduction to Object Oriented Programming");

        //Abstraction
        Console.WriteLine("Abstraction");
        AbstractChild abstractChild = new AbstractChild();
        abstractChild.AbstractPrintName();

        //Encapsulation
        Console.WriteLine("Encapsulation");
        Encapsulation encapsulation = new Encapsulation("Elango");
        encapsulation.PrintName();

        //Inheritance
        Console.WriteLine("Inheritance");
        InheritanceBase inheritanceBase = new InheritanceBase();
        inheritanceBase.PrintName();
        InheritanceChild inheritanceChild = new InheritanceChild();
        inheritanceChild.PrintBaseName();

        //Polymorphism
        Console.WriteLine("Polymorphism");
        Polymorphism polymorphism = new Polymorphism("Elango");
        polymorphism.PrintPolymorphismName();
        polymorphism.PrintPolymorphismName("Madhu");
        polymorphism.PrintName();


        Console.ReadLine();//Hold the console
    }
}

