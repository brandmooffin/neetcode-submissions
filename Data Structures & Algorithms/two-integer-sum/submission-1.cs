public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] targetIndexes = new int[2];

        for(int i = 0; i < nums.Length; i++) {

            for (int j = 0; j < nums.Length; j++) {

                var potentialTarget = nums[i] + nums[j];

                if (potentialTarget == target && i != j) {
                    targetIndexes[0] = i;
                    targetIndexes[1] = j;
                    return targetIndexes;
                }
            }
        }

        return targetIndexes;
    }
}
