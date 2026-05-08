public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            int CTarg = target - nums[i];

            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                {
                    if (CTarg == nums[j])
                    {
                        return new int[2] {i, j};
                    }
                }
            }
        }
        return new int[0];
    }
}
