namespace Practice
{
    public class Program
    {
        public delegate int Calculation(int x, int y);
        public static void Main(String[] args)
        {
           Calculation calculation = Add;

           Console.WriteLine(calculation.Invoke(2, 3));
           
           // anonymus function
           Calculation calculation2 = (x, y) => x + y;

           Console.WriteLine(calculation2.Invoke(2, 2));

           TakeFunction(calculation2);
        }
        public static int Add(int x, int y) => x + y;

        public static void TakeFunction(Calculation Add)
        {
            Console.WriteLine(Add.Invoke(1, 1));
        }

    }
}
