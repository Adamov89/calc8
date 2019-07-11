using System;

namespace calc8
{
    public interface IMath
    {
        string OperationName
        {
            get;
        }
        double Calc(double x, double y, double result, string op);

    }
    public class Sum : IMath
    {
        public string OperationName
        {
            get
            {
                return "Add";
            }
        }

        public double Calc(double x, double y, double result, string op) => x + y;
    }

  /*  public class Multi : IMath

    {
        public string OperationName
        {
            get
            {
                return "Multiplication";
            }

        }
        public double Calc(double x, double y, double result, string op)
        {
            return x * y;
        }
    }

    public class Divide : IMath

    {
        public string OperationName
        {
            get
            {
                return "Division";
            }

        }
        public double Calc(double x, double y, double result, string op)
        {
            return x / y;
        }
    }

    public class Subtract : IMath

    {
        public string OperationName
        {
            get
            {
                return "Subtraction";
            }

        }
        public double Calc(double x, double y, double result, string op)
        {
            return x - y;
        }
    }

*/
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            while (true)
            {
                double result = 0;

                Console.Write("Type a number, and then press Enter: ");
                string x = Console.ReadLine();

                Console.Write("Type another number, and then press Enter: ");
                string y = Console.ReadLine();

                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Sum.Calc();
                    Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch
                {

                }
        }
    }

}
    }