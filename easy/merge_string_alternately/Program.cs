public class Solution {
    public string MergeAlternately(string word1, string word2) {
        char[] w1 = [.. word1];
        char[] w2 = [.. word2];
        char[] res = new char[word1.Length + word2.Length];


        var l1 = 0;
        var l2 = 0; 

        while(l1 < w1.Length || l2 < w2.Length)
        {
            if(l1 != word1.Length)
            {
                res[l1+l2] = w1[l1];
                l1++;
            }
            if(l2 != word2.Length)
            {
                res[l1+l2] = w2[l2];
                l2++;
            }
        }
        return new string(res);
    }
    static void Main(string[] args)
    {
        Solution sol = new();
        System.Console.WriteLine($"The resuls is {sol.MergeAlternately("fisk123","fisk").ToString()}");
    }
}