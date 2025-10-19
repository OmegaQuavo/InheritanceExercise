using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bird object
            Bird eagle = new Bird()
            {
                Name = "Golden Eagle",
                Age = 5,
                Habitat = "Mountains",
                IsDomestic = false,
                CanFly = true,
                WingSpan = 7.5,
                BeakType = "Hooked",
                FeatherColor = "Brown and Gold"
            };

            Console.WriteLine("=== Bird Info ===");
            Console.WriteLine($"Name: {eagle.Name}");
            Console.WriteLine($"Age: {eagle.Age}");
            Console.WriteLine($"Habitat: {eagle.Habitat}");
            Console.WriteLine($"Domestic? {eagle.IsDomestic}");
            Console.WriteLine($"Can Fly? {eagle.CanFly}");
            Console.WriteLine($"Wingspan: {eagle.WingSpan} ft");
            Console.WriteLine($"Beak Type: {eagle.BeakType}");
            Console.WriteLine($"Feather Color: {eagle.FeatherColor}");
            Console.WriteLine();

            // Reptile object
            Reptile snake = new Reptile()
            {
                Name = "King Cobra",
                Age = 3,
                Habitat = "Rainforest",
                IsDomestic = false,
                HasScales = true,
                SkinColor = "Olive Brown",
                IsVenomous = true,
                PreferredTemperature = "Warm and Humid"
            };

            Console.WriteLine("=== Reptile Info ===");
            Console.WriteLine($"Name: {snake.Name}");
            Console.WriteLine($"Age: {snake.Age}");
            Console.WriteLine($"Habitat: {snake.Habitat}");
            Console.WriteLine($"Domestic? {snake.IsDomestic}");
            Console.WriteLine($"Has Scales? {snake.HasScales}");
            Console.WriteLine($"Skin Color: {snake.SkinColor}");
            Console.WriteLine($"Venomous? {snake.IsVenomous}");
            Console.WriteLine($"Preferred Temperature: {snake.PreferredTemperature}");
        }
    }
}

