using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class SquareFigures
    {
        public static double GetSquare(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius cannot be negative.");
            var square = Math.PI * radius * radius;
            return square;
        }
        public static double GetSquare(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0) 
                return 0;
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Сatheter length cannot be negative.");
            var halfSum = (a + b + c) / 2;
            var square = Math.Sqrt(halfSum*(halfSum - a) * (halfSum - b) * (halfSum - c));
            return square;
        }

        public static bool IsTriangleRight(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0) 
                throw new ArgumentException("Сatheter length cannot be negative.");
            if (a == 0 || b == 0 || c == 0)
                return false;
            var max = a;
            var first = b;
            var second = c;
            if (max < first && first > c)
            {
                var per = max;
                max = first;
                first = per;
            }
            else if (max < second && b < second)
            {
                var per = max;
                max = second;
                second = per;
            }
            if (max * max == (first * first + second * second))
                return true;
            return false;
        }
    }
}
