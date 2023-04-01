public class Solution {
    public bool IsMonotonic(int[] nums) {
    //     int start=0,c=0;
    //     int end=nums.Length-1;
    //     if (nums[start]<=nums[end])
    //     {
    //         while(start>=end)
    //         {
    //             if(start==end) 
    //             {
    //                 if(nums[start-1]<nums[start] && nums[start]<nums[start+1]))
    //                 c++;
    //             }
    //             if(nums[start]<=nums[end])
    //             {
    //                 start++;
    //                 end--;
    //             }
    //              else 
    //             {
    //                 c++;
    //             }
    //         }
            
    //         // if(c>0)
    //         //     return false;
    //         // else
    //         //     return true;

    //     }


    //    if (nums[start]>=nums[end])
    //     {
    //         while(start>=end)
    //         {
    //             if(nums[start]>=nums[end])
    //             {
    //                 start++;
    //                 end--;
    //             }
    //             else
    //             {
    //                 c++;
    //             }
    //         }
    //         // if(c>0)
    //         //     return false;
    //         // else
    //         //     return true;

    //     }
    //     if(c>0)
    //             return false;
    //         else
    //             return true;
    bool increasing = true;
    bool decreasing = true;
    
    for (int i = 1; i < nums.Length; i++) {
        if (nums[i] < nums[i-1]) {
            increasing = false;
        }
        if (nums[i] > nums[i-1]) {
            decreasing = false;
        }
    }
    
    return increasing || decreasing;
    }
}