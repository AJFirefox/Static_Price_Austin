namespace Static_Price_Austin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer Operations
            Console.WriteLine("Integer Operations:");
            Console.WriteLine($"Add(5, 3) = {Calculate.Add(5, 3)}");
            Console.WriteLine($"Subtract(10, 4) = {Calculate.Subtract(10, 4)}");
            Console.WriteLine($"Multiply(6, 7) = {Calculate.Multiply(6, 7)}");
            Console.WriteLine($"Divide(20, 4) = {Calculate.Divide(20, 4)}");

            Console.WriteLine();

            // Float Operations
            Console.WriteLine("Float Operations:");
            Console.WriteLine($"Add(5.5, 3.2) = {Calculate.Add(5.5f, 3.2f)}");
            Console.WriteLine($"Subtract(10.5, 4.3) = {Calculate.Subtract(10.5f, 4.3f)}");
            Console.WriteLine($"Multiply(6.1, 7.2) = {Calculate.Multiply(6.1f, 7.2f)}");
            Console.WriteLine($"Divide(20, 4) = {Calculate.Divide(20f, 4f)}");
        }
    }
}
