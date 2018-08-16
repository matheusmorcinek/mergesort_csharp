using System;

namespace mergesort_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vector = new int[] { 17, 10, 9, 23, 37, 2 };
            int[] result = new int[vector.Length];

            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(vector, 0, vector.Length - 1);

        }
    }

    class MergeSort
    {

        public void Sort(int[] vector, int start, int end)
        {

            int middle;

            if (start < end)
            {

                middle = (start + end) / 2;

                Sort(vector, start, middle);
                Sort(vector, middle + 1, end);

                Merge(vector, start, middle, end);

            }

        }

        private void Merge(int[] vector, int start, int middle, int end)
        {

            int n1 = middle - start + 1;
            int n2 = end - middle;

            /* Create temporary vectors */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temporary vectors*/
            for (int x = 0; x < n1; ++x)
            {
                L[x] = vector[start + x];
            }
                
            for (int y = 0; y < n2; ++y)
            {
                R[y] = vector[middle + 1 + y];
            }

            /* Merge the temporary vectors */

            // Initial indexes of first and second subvector
            int i = 0, j = 0;

            // Initial index of merged subvec 
            int k = start;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    vector[k] = L[i];
                    i++;
                }
                else
                {
                    vector[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                vector[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                vector[k] = R[j];
                j++;
                k++;
            }
            
        }

    }

}
