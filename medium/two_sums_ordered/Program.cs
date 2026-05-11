using System.Runtime.CompilerServices;

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var start = 0;
        var end = numbers.Length-1;
        while (true)
        {
            var res = numbers[start] + numbers[end];
            if( res > target) end--;
            if( res < target) start++;
            if(res == target)return[start,end];
        }
    }

    static void Main(string[] args)
    {
        Solution sol = new();
        Tuple<int[],int> inputs = new ([2,7,11,15],9);
        var res = sol.TwoSum(inputs.Item1,inputs.Item2);
        System.Console.WriteLine($"The result is {res[0]} and {res[1]}");
    }
}