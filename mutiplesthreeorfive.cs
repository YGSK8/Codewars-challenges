namespace Katas.Multiple3or5;

public static class Kata
{
  public static int Solution(int value)
  {
    int sum =0;
    for(int x = 0; x < value; x++)
        {
            if(x%3==0||x%5==0)sum+=x;
        }
    return sum;
  }
}
