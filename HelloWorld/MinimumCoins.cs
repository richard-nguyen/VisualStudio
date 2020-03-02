using System;
namespace HelloWorld
{
    public class MinimumCoins
    {
        public static int GetCount(double total)
        {
            int count = 0;
            while(total > .25)
            {
                total -= .25;
                count += 1;
            }

            while (total > .1)
            {
                total -= .1;
                count += 1;
            }

            while(total > .05)
            {
                total -= .05;
                count += 1;
            }

            while (total > .01)
            {
                total -= .01;
                count += 1;
            }

            Console.WriteLine(count);
            return count;
        }
    }
}
