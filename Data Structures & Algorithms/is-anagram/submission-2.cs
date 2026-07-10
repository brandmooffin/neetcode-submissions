public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sSorted = s.ToList().OrderBy(c=>c).ToList();
        var tSorted = t.ToList().OrderBy(c=>c).ToList();

        for (int i = 0; i < sSorted.Count(); i++){
            if (tSorted[i] != sSorted[i]) {
                return false;
            }
        }

        return true;
    }
}
