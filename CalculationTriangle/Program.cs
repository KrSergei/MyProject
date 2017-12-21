using System;

namespace CalculationTriangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int type;
            Console.WriteLine("Enter type triangle: 1 (versatile) or 2 (equilateral)");
            type = int.Parse(Console.ReadLine());
            if (type == 1)
            {

                Console.WriteLine("Enter the first side");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second side");
                float y = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third side");
                float z = float.Parse(Console.ReadLine());

            }
            else if (type == 2)
            {
                float calc;
                Console.WriteLine("Enter leght side");
                float x = float.Parse(Console.ReadLine());
                calc = Operations.Calculation(x);
            }
            else
            {
                Console.WriteLine("Choise 1 or 2");
            }
            float calc;
            calc = Operations.CalculationPerimetr(ref p);
            Console.WriteLine("Leght perimetr: ", p);
        }
    }
}