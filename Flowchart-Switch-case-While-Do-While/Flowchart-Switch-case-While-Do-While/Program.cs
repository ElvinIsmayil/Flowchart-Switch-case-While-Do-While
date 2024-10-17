namespace Flowchart_Switch_case_While_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //1.Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapan alqoritm.

            Console.WriteLine("Ededi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            if (n <= 1)
            {
                Console.WriteLine("Bu eded ne sade ne de murekkeb ededdir!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter > 2)
                {
                    Console.WriteLine("Bu eded murekkeb eddeddir!");
                }
                else
                {
                    Console.WriteLine("Bu eded sade eddeddir!");
                }
            }


            #endregion


            #region Task2

            // 2.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.Məs: 23452, output: 5 , Məs: 456, output: 3

            // 1st method

            Console.WriteLine("Ededi daxil edin: ");
            long number = Convert.ToInt64((Console.ReadLine()));
            string numberString = Convert.ToString(number);

            int characters = numberString.Length;

            Console.WriteLine($"Ededin mertebelerinin sayi: {characters} ");


            // 2nd method

            Console.WriteLine("Ededi daxil edin: ");
            long num = Convert.ToInt64(Console.ReadLine());
            int count = 0;

            while (num > 0)
            {
                num /= 10;
                count++;

            }

            Console.WriteLine($"Ededin mertebelerinin sayi: {count} ");

            #endregion
        }
    }
}
