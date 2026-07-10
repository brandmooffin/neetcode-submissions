public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool duplicateFound = false;
        for (int i = 0; i < nums.Length; i++) {
            var currentNumber = nums[i];
            for (int j = 0; j < nums.Length; j++){
                if (currentNumber == nums[j] && i != j) {
                    duplicateFound = true;
                }
            }
        }
        return duplicateFound;
    }
}