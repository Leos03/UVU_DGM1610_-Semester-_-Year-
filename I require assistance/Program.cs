using System;

namespace I_require_assistance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's try the comment thingy 
            // Success!!
            // Reminder to commit all and push 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Kethup and Mustard");
            Console.WriteLine("Potatoes");
            const int number = 15;
            Console.WriteLine(number);

            string name = "Toaster";
            Console.WriteLine(name);
            Console.WriteLine(number + " " + name);

            string kitchens = "Oven";
            string bestAppliance = (name + " " + kitchens);
            Console.WriteLine(bestAppliance + "   " + bestAppliance);
        }
    }
}
