using System;
using System.Linq;

namespace IP_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("123.2.1.2: " + IPValidator("123.2.1.2"));
            Console.WriteLine("01.02.03.04" + IPValidator("01.02.03.04"));
            Console.WriteLine(".255.245.222" + IPValidator(".255.245.222"));
            Console.WriteLine("298.222.121.222"+ IPValidator("298.222.121.222"));
            Console.WriteLine("-1.22.22.22" + IPValidator("-1.22.22.22"));
            Console.WriteLine("A.2.1.2" + IPValidator("A.2.1.2"));
            Console.WriteLine("0001.002.03.4" + IPValidator("0001.002.03.4"));
            Console.WriteLine("1,2.3.3" + IPValidator("1,2.3.3"));
        }
        static bool IPValidator(string address)
        {
            string[] ipv4= address.Split(".");
            if (ipv4.Length != 4) return false;
            for(int i = 0; i < ipv4.Length; i++)
            {
                if (ipv4[i].Length == 0) return false;
                if (ipv4[i].Length > 1 && ipv4[i][0] == '0') return false;
                if (ipv4[i].Length > 3) return false;
                int check;
                if (!ipv4[i].All(Char.IsDigit)) return false;
                check = int.Parse(ipv4[i]);
                if (check < 0 || check > 255) return false;
            }
            return true;
        }
    }
}
