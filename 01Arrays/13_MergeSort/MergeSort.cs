using System;

class MergeSort
{
    static public void doMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);
        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
            {
                temp[tmp_pos++] = numbers[left++];
            }
            else
            {
                temp[tmp_pos++] = numbers[mid++];
            }
        }

        while (left <= left_end)
        {
            temp[tmp_pos++] = numbers[left++];
        }

        while (mid <= right)
        {
            temp[tmp_pos++] = numbers[mid++];
        }

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }

    }

    static public void mergeSort(int[] numbers, int left, int right)
    {

        int mid;

        if (right > left)
        {

            mid = (right + left) / 2;

            mergeSort(numbers, left, mid);

            mergeSort(numbers, (mid + 1), right);

            doMerge(numbers, left, (mid + 1), right);

        }

    }
    static void Main()
    {
        int[] arr = { 1, 5, 2, 3, 10, 4 };
        mergeSort(arr, 0, arr.Length - 1);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}