public class Solution {
    public int MaximumWealth(int[][] accounts) {
       int final=0;
        for (int i=0; i<accounts.Length; i++)
        {
            
            int Sum=0;
            for (int j=0; j<accounts[i].Length;j++)
            {
               
                Sum=Sum+accounts[i][j];
                if (Sum>final)
                {
                    final=Sum;
                }

            }
            
        }
        return final;
    }
}