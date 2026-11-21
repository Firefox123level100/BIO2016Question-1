namespace BIO2016Question_1
{
    internal class Program
    {
        public static bool IsPallindrom(int number)
        {
            string Number = Convert.ToString(number);

            if (Number.Length % 2 == 0)
            {
                int HalfLengthOfString = Number.Length / 2;

                string Parta = Number.Remove(0, HalfLengthOfString);
                string Partb = new string (Number.Remove(HalfLengthOfString, HalfLengthOfString).ToCharArray().Reverse().ToArray());

                if (Parta == Partb)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                int HalfLengthOfString = (Number.Length - 1) / 2;

                string Parta = Number.Remove(HalfLengthOfString, Number.Length - HalfLengthOfString);
                string Partb = new string (Number.Remove(0, Number.Length - HalfLengthOfString).ToCharArray().Reverse().ToArray());

                if (Parta == Partb)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        static void Main(string[] args)
        {
            int StartNumber = Convert.ToInt32(Console.ReadLine());

            int PalindromeNumber = 0;
            int Counter = StartNumber++;

            while (PalindromeNumber < StartNumber)
            {
                if (IsPallindrom(Counter))
                {
                    PalindromeNumber = Counter;
                }

                Counter++;
            }

            Console.WriteLine(PalindromeNumber);
        }
    }
}
