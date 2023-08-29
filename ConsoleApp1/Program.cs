namespace Practice
{

    //practice delegates and Generic Class
    public class Program
    {
       
        public static void Main(String[] args)
        {
           CList<int> list = new CList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            var newList = list.Where(x => x % 2 == 0).ToList();

            newList.Add(6);

            foreach (var x in newList)
            {
                Console.WriteLine(x);
            }
                
        }
        

    }
    public class CList<T>
    {
        private List<T> List;

        public CList()
        {
            List = new List<T>();
        }

        public List<T> Add(T data)
        {
            List.Add(data);
            return List;
        }
            
        
        public CList<T> Where(Func<T ,bool> condition)
        {
            CList<T> list = new CList<T>();

            //O(n) complexity
            for(int i = 0; i < List.Count; i++)
            {
                if(condition(List[i]))
                {
                    list.Add(List[i]);
                }
            }

            return list;
        }
        public List<T> ToList() => List;

        
       
    }
}
