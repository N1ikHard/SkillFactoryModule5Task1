using System;
class programm
{
    static int[] SortArrayD(int[] array)
    {
        int memory;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[i] > array[j])
                {
                    memory = array[j];
                    array[j] = array[i];
                    array[i] = memory;
                }
            }
        }
        return array;
    }
    static int[] SortArrayA(int[] array)
    {
        int memory;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[i] < array[j])
                {
                    memory = array[i];
                    array[i] = array[j];
                    array[j] = memory;
                }
            }
        }
        return array;
    }
    static void SoraArray(in int[] ar, out int[] a1, out int[] a2)
    {
        int[] Copy1 = new int[ar.Length];
        int[] Copy2 = new int[ar.Length];
        for(int i = 0; i < ar.Length; i++)
        {
            Copy1[i] = ar[i];
            Copy2[i] = ar[i];
        }
        a1 = SortArrayA(Copy1);
        a2 = SortArrayD(Copy2);
    }
    static void Show(int[] ar)
    {
        for (int i = 0; i < ar.Length; i++)
        {
            Console.Write(ar[i] + " ");
        }
    }
    static void Main()
    {
        int[] ar = new int[] { 2, 3, 6, -9, 2, 0, 14, 111, -7, 2 }; 
        int[] ar1;
         int[] ar2;
        SoraArray(ar,out ar1, out ar2);
        Show(ar1);
        Console.WriteLine();
        Show(ar2);
    }
}    

    
