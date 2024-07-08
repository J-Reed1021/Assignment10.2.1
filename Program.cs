namespace Assignment10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Three Parts of a LINQ Query:
            //1. Data source
            int[] numbers = [1, 4, 0, -5, 9, -11];

            //2. Query creation.
            //numQuery is an IEnumerable<int>
            var numQuery = from num in numbers
                           where (num % 2) >= 0
                           select num;

            //3. Query execution
            foreach (int num in numQuery)
            {
                Console.Write("{0, 1} " , num);
            }
        }
    }
}
