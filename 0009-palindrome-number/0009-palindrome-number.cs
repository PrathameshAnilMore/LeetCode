public class Solution {
    public bool IsPalindrome(int x) {
       if(x<0)
       return false;

       int reverse=0;
       int org=x;

       while(x!=0)
       {
           int digit=x%10;
           reverse=reverse*10+digit;
           x=x/10;
       }

       return org==reverse;


    }
}