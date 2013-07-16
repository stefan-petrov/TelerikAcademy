using System;

namespace Ex03CompareFloatingPointNumbers
{
    class Ex03CompareFloatingPointNumbers
    {
        static void Main()
        {
            // usually this is NOT good variable naming, but it is used this way 
            // only for the purpose of the exercise.

            float float1 = 5.3f;
            float float2 = 6.01f;
            Console.WriteLine(float1 == float2);

            float float3 = 5.00000001f;
            float float4 = 5.00000003f;
            Console.WriteLine(float3 == float4);

            // usually this is NOT good variable naming, but it is used this way 
            // only for the purpose of the exercise.
        }
    }
}
