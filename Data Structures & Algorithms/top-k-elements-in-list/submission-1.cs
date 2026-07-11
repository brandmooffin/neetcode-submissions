public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var groupBy = nums.ToList().GroupBy(i=>i).OrderByDescending(i=>i.Count()).ToArray();
        var output = new List<int>();

        for (int i = 0; i < k; i++) {
            output.Add(groupBy[i].Key);
        }

        return output.ToArray();
    }
}
