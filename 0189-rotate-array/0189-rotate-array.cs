public class Solution {
    public void Rotate(int[] nums, int k) {
        //  k = k % nums.Length; 
        //  int[] temp=new int[nums.Length];
        //  for(int i=0;i<nums.Length; i++)
        //  {
        //      temp[(i+k)%nums.Length]=nums[i];
        //  }
        //  for(int i=0;i<temp.Length;i++)
        //  {
        //      nums[i]=temp[i];
        //  }

        k = k % nums.Length; 
        Reverse(nums,0,nums.Length-1);
        Reverse(nums,0,k-1);
        Reverse(nums,k,nums.Length-1);
}
public void Reverse(int[] arr, int start, int end)
{
    while(start<end)
    {
        int temp=arr[start];
        arr[start]=arr[end];
        arr[end]=temp;
        start++;
        end--;
    }
}
}