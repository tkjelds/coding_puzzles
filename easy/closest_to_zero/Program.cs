public class Solution {
    public int FindClosestNumber(int[] nums) {

        // Item1 = absolute -- Item2
        Tuple<int,int> res = new(int.MaxValue, int.MinValue);
        foreach (var n in nums)
        {
            var distanceToZero = Math.Abs(n);
            if(distanceToZero < res.Item1)
            {
                res = new(distanceToZero,n);
            }

            if(distanceToZero == res.Item1)
            {
                res = new (distanceToZero, Math.Max(n,res.Item2));
            }
        }
        return res.Item2;
    }

    static void Main(string[] args)
    {
        var sol = new Solution();
        int[] input = [2,-1,1]; 
        System.Console.WriteLine($"The solution is {sol.FindClosestNumber(input)}");
    }
}