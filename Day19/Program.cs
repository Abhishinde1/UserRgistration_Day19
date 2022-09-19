namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option:\n1.Valid first name");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UC1.ValidFirstName();
                    break;
            }
        }
    }
}