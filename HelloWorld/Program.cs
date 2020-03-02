using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPermuteString();
            //TestMaximumSumSubsequenceNonAdjacent();
            TestMinimumCoins();
        }


        static void TestPermuteString()
        {
            PermuteString.Permute("abc");
        }

        static void TestStackUsingLinkedList()
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Pop();
            stack.Pop();
            stack.Display();
        }

        static void TestMaximumSumSubsequenceNonAdjacent()
        {
            /*
           You are provided a set of positive integers (an array of integers). Each integer represents a number of nights users request on Airbnb.com. If you are a host, you need to design and implement an algorithm to find out the maximum number of nights you can accommodate. The constraint is that you have to reserve at least one day between each request, so that you have time to clean the room.
           Example:
           1) Input: [1, 2, 3]; output: 4, because you will pick 1 and 3
           2) input: [5, 1, 2, 6]; output: 11, because you will pick 5 and 6
           3) input: [5, 1, 2, 6, 20, 2]; output: 27, because you will pick 5, 2, 20
           */
            int[] input = new int[] { 1, 2, 3};
            MaximumSumSubsequenceNonAdjacent.MaxSumDP(input);
            input = new int[] { 5, 1, 2, 6 };
            MaximumSumSubsequenceNonAdjacent.MaxSumDP(input);
            input = new int[] { 5, 1, 2, 6, 20, 2 };
            MaximumSumSubsequenceNonAdjacent.MaxSumDP(input);
        }


        static void TestMinimumCoins()
        {
            // $2.14 will result in 8 quarters, 1 dime, 4 pennies = 13
            MinimumCoins.GetCount(2.14);
            // $1.32 will result in 5 quarters, 1 nickle, 2 pennies = 8
            MinimumCoins.GetCount(1.32);
        }
    }
}
