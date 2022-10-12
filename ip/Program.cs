/* GPL-v3 License
 * This Sourcecode contains Packages from Microsoft using MIT-License
 * (c) 2022 Marco Eden
 * For further informations read COPYING.txt in the app folder
 */


using System;
using System.Net;

namespace ip
{
    
    class Program
    {
        public static Random r = new Random();
        static void Main(int v4 = 0, int v6 = 0)
        {
            if (v4 > 0)
                GenIPv4(v4);
            else if (v6 > 0)
                GenIPv6(v6);
        }
        static void GenIPv4(int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine($"{r.Next(1, 255)}.{r.Next(0, 255)}.{r.Next(0, 255)}.{r.Next(0, 255)}");
        }

        static void GenIPv6(int count)
        {
            var data = new byte[16];
            for (int i = 0; i < count; i++)
            {
                new Random().NextBytes(data);
                IPAddress ip = new IPAddress(data);
                Console.WriteLine(ip);
            }
            



        }
    }
}
