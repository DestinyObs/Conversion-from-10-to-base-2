namespace Conversion_from_10_to_base_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter The Value You Want To Convert:");
            int Num2Covt = int.Parse(Console.ReadLine());
            int ans = Num2Covt;
            string result = "";
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            string reversedResult = new string(charArray);

           
            while (ans >= 1)
            {
                int x = ans % 2;
                ans = ans / 2;
                result = result + x;
            }
            Console.WriteLine(reversedResult);
        }
    }
}