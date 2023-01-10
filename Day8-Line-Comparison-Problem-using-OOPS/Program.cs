namespace Day8_Line_Comparison_Problem_using_OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Welcome to Line Comparison Problem using OOPS!!!");

            //Find length of line
            FindLength obj1 = new FindLength(-6, 4, -4, 6);
            double length = obj1.FindingLength();
            Console.WriteLine("Length of Line is: " + length);
        }
    }
}