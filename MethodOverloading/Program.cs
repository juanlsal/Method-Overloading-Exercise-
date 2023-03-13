namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(2,3));
            Console.WriteLine(Add(6.5,9.9));
            Console.WriteLine(Add(100,30, true));
            Console.WriteLine(Add(-3, 4, true));
            Console.WriteLine(Add(1, 3, false));

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static string Add(int x, int y, Boolean k)
        {
            if (k == true)
            {
                int z = Add(x, y);
                if (Add(x, y) == 1)
                {
                    return ($"{z} dollar");
                    }
                else
                {
                    return ($"{z} dollars");
                }
            }
            else
            {
                return ("false");
            }
        }
    }
}
