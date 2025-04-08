namespace N8__YP__Task_5_08._04._2025
{
    internal class Program
    {
        static void FindMin(int[]array, out int minElement, out int minIndex)
        {
            minElement = array[0];
            minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement= array[i];
                    minIndex = i;
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("enter mass A:");
            int[] A = new int[5];
            for (int i = 0; i < 5 ; i++) A[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter mass B:");
            int[] B = new int[5];
            for (int i = 0; i < 5; i++) B[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter mass C:");
            int[] C = new int[5];
            for (int i = 0; i < 5; i++) C[i] = int.Parse(Console.ReadLine());

            int minA, indexA, minB, indexB, minC, indexC;
            FindMin(A,out minA,out indexA);
            FindMin(B,out minB,out indexB);
            FindMin(C,out minC,out indexC);

            int overallMin = Math.Min(Math.Min(minA, minB), minC);
            if (overallMin == minA)
                Console.WriteLine($"min element: {minA}, index: {indexA}, mass A ");
            else if (overallMin == minB)
                Console.WriteLine($"min element: {minB}, index: {indexB}, mass B ");
            else 
                Console.WriteLine($"min element: {minC}, index: {indexC}, mass C ");
        }
    }
}
