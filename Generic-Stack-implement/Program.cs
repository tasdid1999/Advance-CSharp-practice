namespace practice
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Cstack<int> stack = new Cstack<int>(4);

            try
            {
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);

              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                while (stack.Count() > 0)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
           
        }
    }
    public class Cstack<T>
    {
        private T[] Stack = null;
        private int Top = -1;
        private int count = 0;
        public int Size = 0;

        public Cstack()
        {
            this.Stack = new T[1000];
            Size = 1000;
        }
        public Cstack(int size)
        {
            this.Stack = new T[size];
            this.Size= size;
        }
        public bool Push(T data)
        {
            if(Top + 1 < Size )
            {
                Stack[++Top] = data;
                count++;
                return true;
            }

            throw new Exception("stack overflow");
        }
        public T Pop()
        {
            if(Top >= 0)
            {
                count--;
                return Stack[Top--];
            }

            throw new Exception("stack underflow");
           
        }
        public int Count() => this.count;



    }
       
        

}
