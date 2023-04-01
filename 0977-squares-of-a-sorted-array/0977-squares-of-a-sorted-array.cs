public class Solution {
    public int[] SortedSquares(int[] nums) {
        // int size=nums.Length;
        // int[] square=new int[size];
        // for(int i=0; i<nums.Length; i++)
        // {
        //     square[i]=nums[i]*nums[i];
        // }
        // Array.Sort(square);
        // return square;

        int[] square = new int[nums.Length];
        int start= 0;
        int end = nums.Length-1;
        int value=nums.Length-1;
        while (start<=end)
        {
            if(Math.Abs(nums[start])>Math.Abs(nums[end]))
            {
                square[value]=nums[start]*nums[start];
                start++;
                value--;
            }
            else
            {
                square[value]=nums[end]*nums[end];
                end--;
                value--;

            }

        }
        return square;
    }
}