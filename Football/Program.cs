using System;
using System.Collections.Generic;
using System.Linq;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> players = Console.ReadLine().ToList();
            int count0 = 0;
            int count1 = 0;
            int status = 0;
            foreach (var player in players)
            {
                if (player == '0')
                {
                    count1 = 0;
                    count0++;
                    if (count0 > 6)
                    {
                        status = 1;
                    }

                }
                else
                {
                    count1++;
                    count0 = 0;
                    if (count1 > 6)
                    {
                        status = 1;
                    }
                }
            }

            var ans = status == 1 ? "YES" : "NO";
            Console.WriteLine(ans);
        }

       
    }
}
