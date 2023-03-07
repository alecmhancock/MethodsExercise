namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a name of a pet.");
            var pet = Console.ReadLine();

            Console.WriteLine("Please give me your least favorite color.");
            var color = Console.ReadLine();

            Console.WriteLine("Please give me a time of day, such as 12:30PM");
            var time = Console.ReadLine();

            Console.WriteLine("It was " + time + " on Saturday, when " + pet + " decided they would eat a " + color + " shirt.");

            Console.WriteLine("We won't miss it much.");

        }
    }
}
