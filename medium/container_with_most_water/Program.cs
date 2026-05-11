using System.Runtime.CompilerServices;

public class Solution {
    public int MaxArea(int[] height) {
        var left = 0;
        var right = height.Length-1;

        var res = 0;
        while(left != right)
        {
            var area =calcArea(left,right,height);
            if(area > res) res = area;
            if(height[left] > height[right]) right--;
            else left++;
        }

        return res;
    }

    private int calcArea(int left, int right, int[] height)
    {
        var width = right-left;
        return height[left] > height[right] ? height[right] * width : height[left] * width;
    }

    static void Main(string[] args)
    {
        Solution sol = new();
        int[] input = [1,8,6,2,5,4,8,3,7];
        var res = sol.MaxArea(input);
        System.Console.WriteLine($"The res is {res}");

    }

}