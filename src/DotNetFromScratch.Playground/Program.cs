// See https://aka.ms/new-console-template for more information
using DotNetFromScratch.Generics;

Console.WriteLine("Hello, World!");



var genericMethods = new GenericMethods();

genericMethods.PrintValue("Sahar");
genericMethods.PrintValue(12);
genericMethods.PrintValue(18.5);


var first = 10;
var second = 20;
genericMethods.Swap(ref first, ref second);
Console.WriteLine($"first {first} and second {second}");

Student student1 = new Student { Name = "Sahar" };
Student student2 = new Student { Name = "Maryam" };
genericMethods.Swap(ref student1, ref student2);
Console.WriteLine($"first {student1.Name} and second {student2.Name}");




public class Student
{
    public string Name  { get; set; }
}

