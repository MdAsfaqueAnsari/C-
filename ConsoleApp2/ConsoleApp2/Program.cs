// See https://aka.ms/new-console-template for more information
class IfElse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Age");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Console.WriteLine("Vote for Eligible");
            }
            else
            {
                Console.WriteLine("Get your voter card");
            }
        }
    }
}