using System;
using System.Globalization;
using System.Runtime.Versioning;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            CultureInfo global = CultureInfo.InvariantCulture;
            

            float [,] matrixA = new float [2, 2];
            float [] matrixB = new float [2];

            float arg1= float.Parse(args[0], global);
            matrixA[0, 0]= arg1;

            float arg2= float.Parse(args[1], global);
            matrixA[0, 1]= arg2;

            float arg3= float.Parse(args[2], global);
            matrixA[1, 0]= arg3;

            float arg4= float.Parse(args[3], global);
            matrixA[1, 1]= arg4;

            float arg5= float.Parse(args[4], global);
            matrixB[0]= arg5;

            float arg6= float.Parse(args[5], global);
            matrixB[1]= arg6;
        
            float[] a = new float[2];

            for (int i = 0; i < 2; i++)
            {
                a[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    a[i] += matrixA[i, j] * matrixB[j];
                }
            }
            foreach (float value in a)
            {
                Console.WriteLine($"| {value:f2} |");
            }
        }
    }
}
 