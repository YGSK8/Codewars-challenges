namespace Katas.Prime;

public static class Kata
{
  public static bool IsPrime(int n)
  {
    if(n<=0||n==1)return false;
    bool prime = true;
    for(int x = 2; x <= Math.Sqrt(n); x++)
        {
            if(n%x==0)prime = false;
            //-- n=2 will not run in the loop since starting value of x is 2, and 2 is not less than 2, so it does not meet criteria of running in the loop
        }
    return prime; // TODO
  }
}