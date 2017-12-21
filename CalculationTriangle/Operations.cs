using System;
namespace CalculationTriangle
{
    public class Operations
    {
        public static float CalculationPerimetr(float a, float b, float c, ref p)
        {
           
                if (Check(a, b, c) == false)
                    return 0;
                float p = a + b + c;
                float sum = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
             //   Console.WriteLine("Периметр - {0} \tПлощадь - {1:2}", p, sum);
                return p;
        }
        public static float CalculationSum(float a, float b, float c, ref sum)
        {

            if (Check(a, b, c) == false)
                return 0;
            float sum = (float)Math.Sqrt(CalculationPerimetr.p * (p - a) * (p - b) * (p - c));
            //   Console.WriteLine("Периметр - {0} \tПлощадь - {1:2}", p, sum);
            return sum;
        }


        private static bool Check(float a, float b, float c)
        {
            if (a > 0 && b > 0 && c > 0 && c < Math.Sqrt(a * a) + (b - b))
                return true;
            else
            //Console.WriteLine("Can't great triangle");
            return false;
            
        }
        public static float Calculation(float a)
        {
            float p = 3*a;
            float sum = (float)Math.Sqrt(p * (p - a) * (p - a) * (p - a));
      //      Console.WriteLine("Периметр - {0} \tПлощадь - {1:2}", p, sum);
            return sum;
        }
    }
}

