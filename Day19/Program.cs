namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option:\n1.Valid first name\n2.Valid last name\n3.Valid Email\n4.Valid Mobile number(+91 1234567890)\n5.Minimum 8 characters\n6.At least 1 upper case\n7.At least 1 numberic value");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UC1.ValidFirstName();
                    break;
                case 2:
                    UC2.ValidateLastName();
                    break;
                case 3:
                    UC3.ValidateEmail();
                    break;
                case 4:
                    UC4.ValidateMobileNumber();
                    break;
                case 5:
                    Console.WriteLine("Enter a password : ");
                    string input1 = Console.ReadLine();
                    UC5.ValidatePassword(input1);
                    break;
                case 6:
                    Console.WriteLine("Enter a password : ");
                    string input2 = Console.ReadLine();
                    UC6.ValidatePassword(input2);
                    break;
                case 7:
                    Console.WriteLine("Enter a password : ");
                    string input3 = Console.ReadLine();
                    UC7.ValidatePassword(input3);
                    break;

            }
        }
    }
}