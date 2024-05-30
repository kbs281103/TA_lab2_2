using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double a = 1; // початок інтервалу
            double b = 6; // кінець інтервалу
            double dx = 0.2; // крок
            double x = a; // поточне значення аргументу

            Console.WriteLine("|   x   |   y   |");
            Console.WriteLine("|-------|-------|");

            while (x <= b)
            {
                double y = Math.Log10(x); // обчислення значення функції

                Console.WriteLine($"| {x,-5} | {y,-5:F3} |");

                x += dx; // збільшення аргументу на крок
            }

            Console.ReadLine(); // Зупинка консолі, чекаємо натискання клавіші Enter
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
        }
    }
}
