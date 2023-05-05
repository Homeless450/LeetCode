using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    class KWeakestRowsTask
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            List<int> soldiersCounter = new List<int>();
            for (int i = 0; i<mat.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        counter++;
                    }
                }
                soldiersCounter.Add(counter);
            }
            int[] result = new int[k];
            for (int i = 0; i< k; i++)
            {
                int temp = 100;
                for (int j = 0;j < soldiersCounter.Count; j++)
                {
                    if (soldiersCounter[j] < temp)
                    {
                        temp = soldiersCounter[j];
                    }
                }
                int index = soldiersCounter.FindIndex(a => a == temp);
                result[i] = index;
                soldiersCounter[index] = 100;
            }

            return result;
        }

        private int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = arr[leftIndex];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(arr, leftIndex, j);
            if (i < rightIndex)
                QuickSort(arr, i, rightIndex);
            return arr;
        }
    }
}
