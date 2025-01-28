using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_
{
    internal static class Helper
    {


        public static int LinearSearch<T>(T[] Arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {

                    if (equalityComparer.Equals(Arr[i],Value)) { return i; }
                }
            }

            return -1;
        }

        public static void BubbleSort<T>(T[] Arr,IComparer<T> comparer) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (comparer.Compare(Arr[j], Arr[j+1]) > 0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }

                    }
                }

            }

        }
        #region Generic IComparable
        //public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j].CompareTo(Arr[j + 1]) > 0)
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }

        //            }
        //        }

        //    }

        //}

        public static void PrintArray<T>(T[] Arr)
        {
            foreach (T item in Arr)
            {

                Console.WriteLine($"{item} ");
            }
        }
        #endregion

        #region Non-Generic Bubble
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }

        //            }
        //        }

        //    }
        //} 
        //public static void PrintArray(int[] Arr)
        //{
        //    for (int i = 0; i < Arr.Length; i++)
        //    {

        //        Console.Write($"{Arr[i]} ");
        //    }
        //}
        #endregion




        #region Generic Linear Search
        //public static int LinearSearch<T>(T[] Arr, T Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            if (Arr[i].Equals(Value)) { return i; }
        //        }
        //    }

        //    return -1;
        //}

        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {

        //            if (Arr[i] == Value) { return i; }
        //        }
        //    }

        //    return -1;
        //} 
        #endregion


        #region Generic
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion


        #region Non Generic
        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion
    }
}
