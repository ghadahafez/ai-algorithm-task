using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Project_1
{
    class MergeSort
    {

        void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] A = new int[n1];
            int[] B = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                A[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                B[j] = arr[m + 1 + j];

          
            i = 0;
            j = 0;

           
            int k = l;
            while (i < n1 && j < n2)
            {
                if (A[i] <= B[j])
                {
                    arr[k] = A[i];
                    i++;
                }
                else
                {
                    arr[k] = B[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = A[i];
                i++;
                k++;
            }

   
            while (j < n2)
            {
                arr[k] = B[j];
                j++;
                k++;
            }
        }

    
        void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
 
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }


        // print array of size n */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }


        public static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            printArray(arr);
            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }
}
