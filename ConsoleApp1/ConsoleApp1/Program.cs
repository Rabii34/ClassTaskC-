namespace ConsoleApp1
{
    internal class Program
    {
        //Q7: Write a function to calculate the area of a rectangle the length of the rectangle
        //is 20cm and the width is 12cm.
        public static double rec(double width, double length)
        {
            Console.WriteLine("CALCULATE AREA OF RECTANGLE");
            double area = width * length;
            Console.WriteLine($"The Width of Rectangle is:{width} and length of Rectangle is:{length}");
            Console.WriteLine($"The area of Rectanagle is:");
            return area;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Program area = new Program();
            Console.WriteLine(Program.rec(12, 20));
        }
    }
}
