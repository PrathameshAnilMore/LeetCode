public class Solution {
    public int MaxArea(int[] height) 
    {
        



        //brute force method - O(n^2)
        // int maxarea=0;
        // int area;
        // for (int i=0; i<height.Length-1; i++)
        // {
        //     for (int j=i+1; j<height.Length; j++)
        //     {
        //         area=Math.Min(height[i],height[j])*(j-i);
        //         maxarea=Math.Max(maxarea,area);

        //     }

        // }
        // return maxarea;


        //O(n)
        int maxarea=0,area;
        int lp=0;
        int rp=height.Length-1;

        while(lp<rp)
        {
            if(height[lp]<height[rp])
            {
                area=Math.Min(height[lp],height[rp])*(rp-lp);
                maxarea=Math.Max(area,maxarea);
                lp++;

            }
            else
            {
                area=Math.Min(height[lp],height[rp])*(rp-lp);
                maxarea=Math.Max(area,maxarea);
                rp--;
            }

            
        }
        return maxarea;
        

























    }
}