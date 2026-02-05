namespace WhileLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*While loop:-
              It is a condition based loop
              It should be used when we don’t have the range.
            Syntax: -
            Initialization;
            While (condition)
            {
            Statements;
            Increment /decrement;*/
            Console.WriteLine("<===Program on While loop===>");
            int i = 1; //Here we are declaring and Initiallisation
            int sum = 0;
            while (i <= 5)
            {
                Console.WriteLine("Hello programar");
                sum = sum + i;
                Console.WriteLine($"The sum of the {i} is {sum}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
