int target = 9;
int[] nums = { 2, 7, 11, 15 };
int[] result = new int[2];

int[] TwoSum(int[] nums, int target)
{

    // I'm going to create an outer for loop to go through each index of the array
    for (int i = 0; i < nums.Length; i++)
    {

        // I'm going to create an inner for loop to access the index of i + 1 so that I can check if those 
        // two numbers == the target
        for (int j = i + 1; j < nums.Length; j++)
        {
            // I'll use an if statement to check if the sum of the two values I have accessed right now ==
            // the target, if so I'm going to push them into my results array
            if (nums[i] + nums[j] == target)
            {
                result[0] = i;
                result[1] = j;

            }
        }
    }
    // I'll return my results
    return result;
}

// I'll invoke the function and then write the results to the console
TwoSum(nums, target);
Console.WriteLine("Results: {0} {1}", result[0], result[1]);
Console.ReadLine();