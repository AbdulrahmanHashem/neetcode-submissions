public class Solution {
    public bool hasDuplicate(int[] nums) {

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int ii = 0; ii < nums.Length; ii++)
            {
                if (nums[i] == nums[ii])
                {
                    count++;
                    if (count > 1)
                        return true;
                }
            }
        }
        return false;
    }
}