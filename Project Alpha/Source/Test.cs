using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Alpha.Source
{
    public static class Test
    {
        /**
         * @param Input the value to be tested 
         * @param ExpectedResult the expected result that the Input should be equal to
         * 
         * @returns Returns true if Input == Expected result, false if not
         */
        public static bool AssertEquals(Vector Input, Vector ExpectedResult)
        {
            Console.WriteLine($"\n{Input == ExpectedResult}");
            if(Input == ExpectedResult) { Console.WriteLine("Test Passed!"); }
            else
            {
                Console.WriteLine($"Test Failed: Expected {ExpectedResult}, instead got {Input}");
            }
            return Input == ExpectedResult;
        }
    }
}
