using System;
using System.Collections.Generic;
using System.Text;

class VariationsOfSet
{
    static void Main()
    {
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int index = k - 1;
        int oldValue = 0;
        List<int> nums = new List<int>();
        for (int i = 0; i < k; i++)
        {
            nums.Add(1);
        }

        while (true)
        {
            foreach (int item in nums)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            while (index > -1 && nums[index] == n)
            {
                oldValue = nums[index];
                nums[index] = 1;
                --index;
            }

            if (index == -1 && oldValue == n)
            {
                break;
            }
            ++nums[index];
            index = k - 1;
        }
    }
}