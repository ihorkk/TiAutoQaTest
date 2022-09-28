
using System;

namespace TeamPT
{
    class Triangle
    {
        static void Main()
        {

            // Ask the user to enter coordinate x of dot A.
            Console.WriteLine("Enter coordinate x of dot A:");
            var xA = Convert.ToDouble(Console.ReadLine());


            // Ask the user to enter coordinate y of dot A.
            Console.WriteLine("Enter coordinate y of dot A:");
            var yA = Convert.ToDouble(Console.ReadLine());


            // Ask the user to enter coordinate x of dot B.
            Console.WriteLine("Enter coordinate x of dot B:");
            var xB = Convert.ToDouble(Console.ReadLine());


            // Ask the user to enter coordinate y of dot B.
            Console.WriteLine("Enter coordinate y of dot B:");
            var yB = Convert.ToDouble(Console.ReadLine());


            // Ask the user to enter coordinate x of dot C.
            Console.WriteLine("Enter coordinate x of dot C:");
            var xC = Convert.ToDouble(Console.ReadLine());


            // Ask the user to enter coordinate y of dot C.
            Console.WriteLine("Enter coordinate y of dot C:");
            var yC = Convert.ToDouble(Console.ReadLine());



            // Calculate side AB
            double AB = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2));


            //Calculate side BC
            double BC = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));


            //Calculate side AC
            double AC = Math.Sqrt(Math.Pow((xA - xC), 2) + Math.Pow((yA - yC), 2));



            // Show to user the length of triangle sides.
            Console.WriteLine("\nLenght of AB is: '" + AB + "'");
            Console.WriteLine("Lenght of BC is: '" + BC + "'");
            Console.WriteLine("Lenght of AC is: '" + AC + "'");



            // Is it equilateral triangle?
            if (AB == BC && BC == AC)
            {
                Console.WriteLine("\nTriangle IS 'Equilateral'");
            }
            else
            {
                Console.WriteLine("\nTriangle IS NOT 'Equilateral'");
            }


            // Is it isosceles triangle?
            if (AB == BC || BC == AC || AC == AB)
            {
                Console.WriteLine("Triangle IS 'Isosceles'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Isosceles'");
            }


            // Is it right triangle?
            bool flag = false;
            if (AB > BC && AB > AC)
            {
                if (Math.Round(AB) == Math.Round(Math.Sqrt(BC * BC + AC * AC)))
                {
                    flag = true;
                    Console.WriteLine("The triangle IS 'Right'");
                }
            }
            if (BC > AB && BC > AC)
            {
                if (Math.Round(BC) == Math.Round(Math.Sqrt(AB * AB + AC * AC)))
                {
                    flag = true;
                    Console.WriteLine("The triangle IS 'Right'");
                }
            }
            if (AC > AB && AC > BC)
            {
                if (Math.Round(AC) == Math.Round(Math.Sqrt(AB * AB + BC * BC)))
                {
                    flag = true;
                    Console.WriteLine("The triangle IS 'Right'");
                }
            }
            if (!flag)
            {
                Console.WriteLine("The triangle is NOT 'Right'");
            }



            // Show to user the Perimeter of the triangle.
            double P = (AB + AC + BC);
            Console.WriteLine("\nPerimeter: '" + P + "'");




            // Print even numbers from 0 to value of triangle perimeter
            Console.WriteLine("\nParity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= P; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
