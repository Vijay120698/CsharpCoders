using System;

namespace ThreeIntegerSub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size:\t");
            int Size = int.Parse(Console.ReadLine());
            int[] nums = new int[Size];

            Console.WriteLine("enter the values:");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            // Sort the array
            Array.Sort(nums);

            bool found = false;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicates for the first element
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                    int left = i + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        int sum = nums[i] + nums[left] + nums[right];

                        if (sum == 0)
                        {
                            Console.WriteLine($"[{nums[i]}, {nums[left]}, {nums[right]}]");
                            found = true;


                            // Move the left pointer and skip duplicates
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            // Move the right pointer and skip duplicates
                            while (left < right && nums[right] == nums[right - 1])
                                right--;

                            // Move the pointers inward
                            left++;
                            right--;
                        }
                        else if (sum < 0)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                
            }

            if (!found)
            {
                Console.WriteLine("No distinct triplets found.");
            }

            Console.ReadLine();
        }
    }
}
