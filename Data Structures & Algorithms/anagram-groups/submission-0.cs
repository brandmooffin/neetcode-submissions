public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groupedAnagrams = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            var sortedString = new string(strs[i].ToList().OrderBy(c=>c).ToArray());

            if (!groupedAnagrams.ContainsKey(sortedString)) {
                groupedAnagrams[sortedString] = new List<string>();
            }
            groupedAnagrams[sortedString].Add(strs[i]);
        }

        return groupedAnagrams.Values.ToList<List<string>>();
    }
}
