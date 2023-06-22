using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Azis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = "1";
            string date;
            int svobodnimesta;
            int countpurchasedtickets;
            Console.Write("Коя дата сме? ");
            date = Console.ReadLine();
            Console.Write("Колко свободни места има? ");
            svobodnimesta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Колко закупени билета има? ");
            countpurchasedtickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Данни:");
            Console.WriteLine("     Код на полета: "+code);
            Console.WriteLine("     Дата: "+ date);
            Console.WriteLine("     Свободни места: " + svobodnimesta);
            Console.WriteLine("     Закупени билети: " + countpurchasedtickets);







        }
    }
}
