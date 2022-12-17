using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class strNSimbol
    {
        public string Write(int n)
        {
            if (n<1 || n > 26)
            {
                throw new ArgumentException();
            }
            string str = "";
            for (char c = 'A'; c < 'A' + n; c++)
            {
                str = str + c;
            }
            return str;
        }
    }
    public class QuadEquation
    {
        private double a, b, c;
        public QuadEquation(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException();
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double[] Solution()
        {
            double D = b * b - (4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2;
                double x2 = (-b - Math.Sqrt(D)) / 2;
                Math.Round(x1, 2);
                Math.Round(-x2, 2);
                return new double[] { x1, x2 };
            }
            else if (D == 0)
            {
                double x = (-b - Math.Sqrt(D)) / 2;
                Math.Round(x, 2);
                return new double[] { x };
            }
            else
            {
                return new double[0];
            }
        }
    }
    public class Visokos
    {
        int year;
        public Visokos(int year)
        {
            if (year < 1)
            {
                throw new ArgumentException();
            }
            this.year = year;
        }
        public int NumDays(int year)
        {
            if (year % 4 == 0)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                    return 365;
                else
                    return 366;
            }
            else
                return 365;
        }
    }
    public class Regular
    {
        Regex regex = new Regex(@"^[a-zA-Z]\w{3,20}@[a-z]{2,10}\.[a-z]{2,5}");
        public bool ISEmail(string line)
        {
            return regex.IsMatch(line);
        }
    }
    public class Number
    {
        public int Sum(string str)
        {
            int sum = 0;
            for (int i=0; i< str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    throw new ArgumentException();
                }
                sum += str[i] - '0';
            }
            return sum;
        }
    }
}
