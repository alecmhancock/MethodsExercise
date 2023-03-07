namespace MethodsExercise
{
    public class Program
    {
        //staging for methods
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
                return answer;

        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;

        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;

        }
        
        public static int Remainder(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;

        }

        //variable definitions

        static void Main(string[] args)
        {

            var lunchOrders = Sum(31, 17);
            var veganPercent = Divide(48, 4);
            var breadAmount = Remainder(48, 12);
            var totalCost = Multiply(48, 7);

            //write line, could use work but LB's will do

            Console.WriteLine("There are " + lunchOrders + " lunches left to be ordered today." + "\n" +

                "Of the lunches that need to be ordered, " + veganPercent + "% are vegan." + "\n" 

                + breadAmount + " people also ordered bread." + "\n" + "The total cost of today's lunch is $" + totalCost + ". \n");

            

            Console.WriteLine("Please see the prompts below for a new task." + "\n");


            //lord forgive me for the inefficiency I'm about to write

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




