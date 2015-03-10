using System;

class IndexOfLetters
{
    static public int binarySearch(char[] array, char key, int low, int high)
    {
        if (low > high)
        {
            return -1;
        }
        int middle = (low + high) / 2;
        if (array[middle] == key)
        {
            return middle;
        }
        else if (key < array[middle])
        {
            return binarySearch(array, key, low, middle - 1);
        }
        else
        {
            return binarySearch(array, key, middle + 1, high);
        }
    }
    static void Main()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char key = 'c';
        Console.WriteLine(binarySearch(alphabet, key, 0, alphabet.Length));
    }
}