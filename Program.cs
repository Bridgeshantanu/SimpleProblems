namespace SimpleProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] arr = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };

            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            
            foreach (int num in arr)
            {
                if (elementCount.ContainsKey(num))
                {
                    elementCount[num]++;
                }
                else
                {
                    elementCount[num] = 1;
                }
            }

            int totalDuplicates = 0;
            
            foreach (int count in elementCount.Values)
            {
                if (count > 1)
                {
                    totalDuplicates += count - 1;
                }
            }

            Console.WriteLine("Total number of duplicate elements: " + totalDuplicates);



            //2
            int[] arr1 = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };

            HashSet<int> uniqueElements = new HashSet<int>();
            
            foreach (int num in arr1)
            {
                uniqueElements.Add(num);
            }

            Console.WriteLine("Unique elements in the array:");
            
            foreach (int element in uniqueElements)
            {
                Console.WriteLine(element);
            }



            //3
            int[] arr2 = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };
            Dictionary<int, int> elementFrequency = new Dictionary<int, int>();
           
            foreach (int num in arr2)
            {
                if (elementFrequency.ContainsKey(num))
                {
                    elementFrequency[num]++;
                }
                else
                {
                    elementFrequency[num] = 1;
                }
            }

            Console.WriteLine("Element frequencies in the array:");
            
            foreach (var kvp in elementFrequency)
            {
                Console.WriteLine($"Element {kvp.Key}: {kvp.Value} times");
            }



            //4
            int[] arr3 = { 5, 2, 9, 1, 7, 3, 8, 4, 6 };
            int min = arr3[0]; 
            int max = arr3[0]; 
           
            for (int i = 1; i < arr3.Length; i++)
            {
                if (arr3[i] < min)
                {
                    min = arr3[i]; 
                }
                else if (arr3[i] > max)
                {
                    max = arr3[i]; 
                }
            }

            Console.WriteLine("Maximum element in the array: " + max);
            Console.WriteLine("Minimum element in the array: " + min);



            //5
            int rows = 8; 

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            //6
            int rows1 = 7; // Number of rows in the pattern
            int cols = 7; // Number of columns in the pattern

            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (i == 1 || i == rows1 || j == 1 || j == cols)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}