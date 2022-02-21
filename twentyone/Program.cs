using static System.Console;

namespace twentyone
{
    class Program
    {
        private static int[,] field;
        private static int m;
        private static int n;
        static void Main()
        {
    Mark1:  Write("Input n = ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0) throw new Exception("Error of input!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                goto Mark1;
            }
    Mark2:  Write("Input m = ");
            try
            {
                m = Convert.ToInt32(Console.ReadLine());
                if (m <= 0) throw new Exception("Error of input!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                goto Mark2;
            }
            field = new int[n, m];
            ThreadStart twice2 = new ThreadStart(sad2);
            Thread trice2 = new Thread(twice2);
            trice2.Start();
            sad1();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        private static void sad1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (field[i, j] == 0)
                        field[i, j] = 1;
                    Thread.Sleep(5);
                }
            }
        }
        private static void sad2()
        {
            for (int i = m - 1; i > 0; i--)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    if (field[j, i] == 0)
                        field[j, i] = 2;
                    Thread.Sleep(5);
                }
            }
        }
    }
}