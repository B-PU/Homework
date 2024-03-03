using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModule_2._1
{
    enum TransactionType { Buy, Sell}
    class Program
    {
        static void Main(string[] args)
        {
            //Get data for further calculation
            Console.WriteLine("Please enter nominal of the transaction( nominal of securities traded)");
            int nominal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Trade price");
            int tradeprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Transaction type ('Buy' or 'Sell')");
            //TransactionType trcType;
            string userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);
            //Console.WriteLine(trcType.GetType());
            //Console.WriteLine(trcType.ToString());


            //sign of the transaction

           int sign = trcType==TransactionType.Buy ? 1 : -1;



            //calculate
            int currentvalue = sign * nominal * tradeprice;

            //print

            Console.WriteLine($"Current value: { currentvalue}");

            Console.ReadKey();


        }
    }
}
