namespace Assigment2c_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Q1:Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("Pls Enter Number : ");
            int Num = int.Parse(Console.ReadLine());
            if (Num % 3 == 0 && Num % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion
        }
    }
}
