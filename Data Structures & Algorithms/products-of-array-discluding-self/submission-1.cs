public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProductOutput = 1;
        int[] output = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++) {
            var currentNum = nums[i];
            for (int j = 0; j < nums.Length; j++) {
                if (i != j) {
                    totalProductOutput *= nums[j];
                }
            }

            output[i] = totalProductOutput;
            totalProductOutput = 1;
        }

        return output;
    }
}
