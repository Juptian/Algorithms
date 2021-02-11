using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Alpha.Source
{
    public static class Algorithms
    {
        public static string[] BogoSortAlgo(string[] arr)
        {
            if (arr == null) 
            {
                throw new ArgumentNullException($"Could not randomize {arr} because it is null"); 
            }
            string[] result = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++) { result[i] = " "; } //Array.Fill does the same thing
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int newSpot = rand.Next(arr.Length);
                if (result[newSpot] == " ")
                {
                    result[newSpot] = arr[i];
                }
                else
                {
                    while (result[newSpot] != " ")
                    {
                        newSpot = rand.Next(arr.Length);
                    }
                    result[newSpot] = arr[i];
                }
            }
            if (result == arr)
            {
                BogoSortAlgo(arr);
            }
            return result;
        }
    }
}
