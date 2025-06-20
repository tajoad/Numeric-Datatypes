using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-90000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            String textPrecison = "5.0000001";
            float precision = Convert.ToSingle(textPrecison);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);


            //int x = 10,
            //    y = 20,
            //    z = 30;

            //int age = 23;

            //Console.WriteLine(age);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            long numBigNumber = 900000000L;
            Console.WriteLine(bigNumber);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.20;
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float numPrecision = 5.000001F;
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal numMoney = 14.99M;
            Console.WriteLine(numMoney);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            Console.ReadLine();
        }
    }
}
