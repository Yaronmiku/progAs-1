using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void mainMenu()
        {
            Console.WriteLine("1. Total of your work hours per month");
            Console.WriteLine("2. Total of your paid salary");
            Console.WriteLine("3. Punishment for your latency");
            Console.WriteLine("4. Average total your income");
            Console.WriteLine("Please input your choice");
        }
        static void Main(String[] args)
        {
            Console.Write("Please input work days: ");
            decimal wd = Convert.ToInt32(Console.ReadLine()); Console.Write("Please input leave days: ");
            decimal ld = Convert.ToInt32(Console.ReadLine()); Console.Write("Please input hours per day: ");
            decimal hpd = Convert.ToInt32(Console.ReadLine()); Console.Write("Please input latency hours: ");
            decimal lh = Convert.ToInt32(Console.ReadLine()); Console.Write("Please input paid per hours: ");
            decimal pph = Convert.ToInt32(Console.ReadLine());
            bool cl = true;
            mainMenu();
            while (cl)
            {
                mainMenu();
                decimal choice = Convert.ToDecimal(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        decimal workhours = wd * hpd; // so gio lam trong 1 thang
                        Console.WriteLine("Total of work hours: " + workhours); Console.ReadLine();
                        break;
                    case 2:
                        decimal totalofpaid = wd * hpd * pph; // so tien phai tra cho tung nguoi
                        Console.WriteLine("Total of paid work: " + totalofpaid); Console.ReadLine();
                        break;
                    case 3:
                        decimal Punishmentforlatency = lh * pph; // so tien phat vi di tre
                        Console.WriteLine("Punishment of latency: " + Punishmentforlatency); Console.ReadLine();
                        break;
                    case 4:
                        decimal Averageincome = (wd * hpd * pph - lh * pph) / (wd + ld); //trung binh tien cua moi nguoi lam viec trong 1 thang//
                        Console.WriteLine("Average income: " + Averageincome); Console.ReadLine();
                        break;
                    case 5:
                        cl = false;
                        Console.WriteLine(" Input valid option! do it again!");
                        break;
                }
            }
        }
    }
}

# test