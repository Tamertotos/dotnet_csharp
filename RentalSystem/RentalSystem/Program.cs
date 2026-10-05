using RentalSystem.Models;

namespace RentalSystem;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop = new Laptop("acer", true, 1000, 8, 8);
        Console.WriteLine(laptop);
        
        Laptop laptop2 = new Laptop("acer", true, 1000, 8, 8);
        Console.WriteLine(laptop2);


    }
}