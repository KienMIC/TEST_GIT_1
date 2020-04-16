using System;

namespace DETERMINE_CLASS_NETWORK
{
    class Program
    {
        public static char FindClass(int ip)
        {
            if (ip >= 1 && ip <= 126)
                return 'A';

            else if (ip >= 128 && ip <= 191)
                return 'B';

            else if (ip >= 192 && ip <= 223)
                return 'C';

            else if (ip >= 224 && ip <= 239)
                return 'D';

            else
                return 'E';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**DETERMINE CLASS OF IPv4 ADDRESS - CODING BY NGO TRUNG KIEN - 74458**");
            string ip = "";     
            Console.WriteLine("Please Enter the IPv4 Address: ");
            ip = Console.ReadLine();
            string[] arr = ip.Split('.');
            int ip1= Convert.ToInt32(arr[0]);
            Console.WriteLine("IP Address belongs to Class " + FindClass(ip1));

        }
    }
}
