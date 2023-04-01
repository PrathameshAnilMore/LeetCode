public class Solution {
    public int Fib(int n) {
        int sum=0;
        Dictionary<int,int> Fibi = new Dictionary<int,int>();
        if (n==0)
        {
            return 0;
        }
        else if (n==1)
        {
            return 1;
        }
        else 
        { 
            if (Fibi.ContainsKey(n-1))
            {
                sum=Fibi[n-1]+Fib(n-2);
            }
            else if (Fibi.ContainsKey(n-2))
            {
                sum=Fibi[n-2]+Fib(n-1);
            }
            else 
            {
                sum= Fib(n-1)+Fib(n-2);
                Fibi[n]=sum;
            }
            
        }
        return sum;
    }
}