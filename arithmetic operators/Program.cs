using System.Transactions;

namespace arithmetic_operators
{
    internal class Program
    {
        static void main()
        {
            double circumfe = circumf(10);
            Console.WriteLine(circumfe);
            double areab = area(10);
            Console.WriteLine(areab);
            bool modulusb = modulus(16, 4);
            Console.WriteLine(modulusb);
            double pythag = pythagoras(10, 15);
            Console.WriteLine(pythag);
            

            
        }
        static double circumf(double radius)
        {
            double circumf = 2 * radius * Math.PI;
            return circumf;
        }
        static double area(double radius)
        {
            double area = radius * radius * Math.PI;
            area = Math.Round(area, 2);
            return area;
        }
        static bool modulus(double a, double b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static double pythagoras(double len1, double len2)
        {
            double hypotenuse = Math.Sqrt(len1 * len1 + len2 * len2);
            return hypotenuse;
        }
        static void bookPerStudent(int student, int books)
        {
            Console.WriteLine("each student gets: " + books / student);
            Console.WriteLine(books % student + " books are left over");
        }
        //task 6
        static int cacSpace(double size)
        {
            return (int)Math.Ceiling(size * 1024 / 512);
        }
        //task 7
        static void cacSavings()
        {
            double earned = double.Parse(Console.ReadLine());
            double savPercent = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("you save: " + 52.1429 * (earned * savPercent));
        }
    }
}