int target = 9;
int[] nums = { 2, 7, 11, 15 };
int[] result = new int[2];

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

TwoSum(nums, target);
Console.WriteLine("Results: {0} {1}", result[0], result[1]);
Console.ReadLine();