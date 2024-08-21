namespace Array;

public class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        int start = 0;
        int[] result = new int[start];
        int track = 0;
        
        while (track < nums.Length)
        {
            if (nums[track] + nums[track + 1] == target)
            {
                start += 2;
                result[0] = nums[track];
                result[start- 1] = nums[track + 1];
            }
            track++;
        }
        return result;
    }
}


// https://leetcode.com/problems/two-sum/