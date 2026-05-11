using System.Runtime.CompilerServices;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> set = new();

        for(int i = 0; i < nums.Length; i++)
        {
            set.Add(nums[i],i);
        }

        for(int i = 0; i < nums.Length; i++)
        {
            var remains = target - nums[i];
            if (set.ContainsKey(remains))
            {
                return[i,set[remains]];
            }
        }
        return[0,0];
    }
    static void Main(string[] args)
    {
        var sol = new Solution();

        var res = sol.TwoSum([2,7,11,12],9);
        Console.WriteLine($"Found solution: {res[0]} and {res[1]}");
    }
}


