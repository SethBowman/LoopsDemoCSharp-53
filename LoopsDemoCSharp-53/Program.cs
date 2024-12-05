namespace LoopsDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        //while loop
        Console.WriteLine("WHILE LOOP:");

        // var cont = "yes";
        //
        // while (cont == "yes")
        // {
        //     Console.WriteLine("Do you want to continue? (yes/no)");
        //     cont = Console.ReadLine();
        // }

        var number = 1;

        while (number <= 5)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine("Continue on..");
        
        //do while loop
        Console.WriteLine("DO WHILE LOOP:");

        number = 1;
        
        do
        {
            Console.WriteLine(number);
            number++;
        } while (number <= 10);
        
        Console.WriteLine("Continue on..");
        
        //for loop
        Console.WriteLine("FOR LOOP:");

        // for (int i = 1; i <= 20; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // for (int i = 100; i >= 1; i--)
        // {
        //     Console.WriteLine(i);
        // }

        for (int i = 999; i >= 3; i-=3)
        {
            Console.WriteLine(i);
        }
        
        //foreach loop
        Console.WriteLine("FOREACH LOOP:");
        
        var numbers = new[] { 1, 2, 3, 12, 5, 90, 7, 54, 9, 23 };

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
