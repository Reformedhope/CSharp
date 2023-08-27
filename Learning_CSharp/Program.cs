namespace Learning_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int age;

           Console.WriteLine("What is your name?");
           firstName = Console.ReadLine();
           Console.WriteLine($"Hello my name is, {firstName}");
            // doing cw tab tab should give you the write line
            Console.WriteLine("What is your age");
            age = Convert.ToInt32 (Console.ReadLine());
                if (age >= 16) { 
            Console.WriteLine($"Hello my name is {firstName} and I am {age} I  can drive");
            }
            else   
                    {
            Console.WriteLine($"Hello my name is {firstName} and I am {age} I  cant drive");
            }


        }
    }
}