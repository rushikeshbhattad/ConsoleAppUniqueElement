using System;

namespace UniqueRepetedOnceDemo
{
    class UniqueCounter
    {
        public int uniqueElem(int[] arr)
        {
            int n = arr.Length, count, notRepeted = 0, unique = 0;
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                count = 1;
                if (visited[i] == true)
                {
                    continue;
                }
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                if (count == 1)//Replace count == 2 to show elements which are repeted twice
                {
                    notRepeted++;
                }
                Console.WriteLine(arr[i] + "\t\t\t" + count);
                unique++;
            }
            Console.WriteLine("Number of unique Elements: " + unique);
            return notRepeted;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int n;
            Console.Write("Enter Number of Elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements\t Repeted Times");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Number of Elements which are not repeted: " + new UniqueCounter().uniqueElem(arr));
            Console.ReadKey();
        }
    }
}