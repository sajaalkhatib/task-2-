namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// jagged array example 

            //int[][] jagged_arr = new int[4][];

            //jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            //jagged_arr[1] = new int[] { 11, 34, 67 };
            //jagged_arr[2] = new int[] { 89, 23 };
            //jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            //for (int n = 0; n < jagged_arr.Length; n++)
            //{


            //    System.Console.Write("Row({0}): ", n);

            //    for (int k = 0; k < jagged_arr[n].Length; k++)
            //    {

            //        System.Console.Write("{0} ",
            //                             jagged_arr[n][k]);
            //    }
            //    System.Console.WriteLine();
            //}



            // Write a program using function to print the numbers of Fibonacci sequence.
            //    Console.Write("Enter the number of terms in the Fibonacci sequence: ");
            //    int terms = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Fibonacci Sequence:");
            //    PrintFibonacciSequence(terms);
            //}


            //static void PrintFibonacciSequence(int n)
            //{
            //    int first = 0, second = 1;

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(first + " ");
            //        int next = first + second;
            //        first = second;
            //        second = next;
            //    }
            //    Console.WriteLine();



            //Search about if you can throw an exception made by you;  Try it if possible!

            try
            {
                TestException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Caught a custom exception: " + ex.Message);
            }
        }

        static void TestException()
        {
           
            int value = -1;
            if (value < 0)
            {
                throw new CustomException("Value cannot be negative.");
            }

        }
    }
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
