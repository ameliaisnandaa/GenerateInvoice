using System;

namespace SimpleGenerateInvoice
{
    class Program
    {            
        public string getDate()
        {
            string dd = DateTime.Now.Day.ToString();
            return dd;
        }
        public string getMonth()
        {
            string mm = DateTime.Now.ToString("MM");
            return mm;
        }
        public string getYear()
        {
            string yyyy = DateTime.Now.ToString("yyyy");
            return yyyy;
        }
        public string getDay()
        { 
            string x = DateTime.Now.DayOfWeek.ToString();
            string y = x.ToUpper();
            string z = y.Substring(0, 2);
            return z;
        }
        public string cvToRomawi(string x)
        {
            int y = int.Parse(x);
            string r = "";
            string r2;
            while (y != 0)
            {
                if (y>=10)
                {
                    r2 = "X";
                    r = string.Concat(r, r2);
                    y -= 10;
                }
                else if (y==9)
                {
                    r2 = "IX";
                    r = string.Concat(r, r2);
                }
                else if (y >= 5)
                {
                    r2 = "V";
                    r = string.Concat(r, r2);
                    y -= 5;
                }
                else if (y == 4)
                {
                    r2 = "IV";
                    r = string.Concat(r, r2);
                }
                else if (y >= 1)
                {
                    r2 = "I";
                    r = string.Concat(r, r2);
                    y -= 1;
                }
            }
            return r;
        }

        static void Main(string[] args)
        {
            string a, i = "INV";            
            Console.Write("INPUT\t: ");
            Program p = new Program();
            a = Console.ReadLine();
            Console.WriteLine("OUTPUT\t: "+ i + "/" + p.getYear() + p.getMonth() + "/" + p.getDay() + "/" + p.cvToRomawi(p.getDate()) + "/" + p.cvToRomawi(p.getYear().Substring(2,2)) + "/" + a);
        }
    }
}
