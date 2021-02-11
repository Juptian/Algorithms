using System;

namespace Project_Alpha.Source
{
    class Program
    {
        private static Vector vec = new Vector(1f, 2f, 3f);
        private static Vector otherVec = new Vector(3f, 2f, 1f);
        private static string[] ooga = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static void Main(string[] args)
        {
            string[] a = Algorithms.BogoSortAlgo(ooga);
            Console.WriteLine($"{Join(a)}");
            a = Algorithms.BogoSortAlgo(ooga);
            Console.WriteLine($"{Join(a)}");
            a = Algorithms.BogoSortAlgo(ooga);
            Console.WriteLine($"{Join(a)}");
            a = Algorithms.BogoSortAlgo(ooga);
            Console.WriteLine($"{Join(a)}");

            Vector vec3 = vec + otherVec;
            Console.WriteLine($"Variable: Vec3: {vec3}");
            Console.WriteLine(vec.Deconstruct());
            Console.WriteLine($"Variable: Vec3 + Scalar(2f, 3f, 4f): {vec3 + new Vector(2f, 3f, 4f)}");
            Test.AssertEquals(vec3, vec + otherVec);
            Test.AssertEquals(vec3, vec);
            Console.ReadLine();
        }
        

        public static string Join(string[] arr)
        {
            string result = new string("");
            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
    }
}
