using System;
namespace HelloWorld
{
    public class PermuteString
    {

        public static void Permute(String input)
        {
            int n = input.Length;

            // Number of permutations is 2^n
            //shift 1 bit to the left N times
            //ex. 0001 << 3 = 1000 (8)
            int max = 1 << n;

            // Converting string 
            // to lower case 
            input = input.ToLower();

            // Using all subsequences 
            // and permuting them 
            for (int i = 0; i < max; i++)
            {
                char[] combination = input.ToCharArray();

                // If j-th bit is set, we 
                // convert it to upper case

                // Ex: 'abc'
                // i = 0 : [0000, 0000, 0000] & 0001 = abc
                // i = 1 : [0001, 0000, 0000] & 0001 = Abc
                // i = 2 : [0010, 0001, 0000] & 0001 = aBc
                // i = 3 : [0011, 0001, 0000] & 0001 = ABc
                // i = 4 : [0100, 0010, 0001] & 0001 = abC
                // i = 5 : [0101, 0010, 0001] & 0001 = AbC
                // i = 6 : [0110, 0011, 0001] & 0001 = aBC
                // i = 7 : [0111, 0011, 0001] & 0001 = ABC
                
                for (int j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1)
                        combination[j] = Char.ToUpper(combination[j]);
                }

                // Printing current combination 
                Console.WriteLine(combination);
            }
        }
    }
}

