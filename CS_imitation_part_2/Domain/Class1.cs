using System;

namespace ArrayLibrary
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    public class Array : IMath
    {
        private int[] array;

        public Array(int[] array)
        {
            this.array = array;
        }

        public int Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public float Avg()
        {
            float sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int num in array)
            {
                if (num == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}