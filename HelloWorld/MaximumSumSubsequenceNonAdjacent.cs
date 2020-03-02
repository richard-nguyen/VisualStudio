using System;
namespace HelloWorld
{
    public class MaximumSumSubsequenceNonAdjacent
    {
/*
You are provided a set of positive integers (an array of integers). Each integer represents a number of nights users request on Airbnb.com. If you are a host, you need to design and implement an algorithm to find out the maximum number of nights you can accommodate. The constraint is that you have to reserve at least one day between each request, so that you have time to clean the room.
Example:
1) Input: [1, 2, 3]; output: 4, because you will pick 1 and 3
2) input: [5, 1, 2, 6]; output: 11, because you will pick 5 and 6
3) input: [5, 1, 2, 6, 20, 2]; output: 27, because you will pick 5, 2, 20
*/

        //Dynamic Programing
        public static int MaxSumDP(int[] arr)
        {
            int inclusive = arr[0]; // Max sum since the last position
            int exclusive = 0; // Max sum since the 2 position away;

            for (int i = 1;  i < arr.Length; i++)
            {
                //Check if including the number is greater than the current sum
                int oldInclusive = inclusive;
                inclusive = Math.Max(exclusive + arr[i], inclusive);
                exclusive = oldInclusive;
            }

            Console.WriteLine(inclusive);
            return inclusive;
        }


    }
}
