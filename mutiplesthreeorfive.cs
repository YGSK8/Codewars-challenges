namespace Katas.Multiple3or5;

public static class Kata
{
  public static int Solution(int value)
  {
    if(value<=0) return 0;
    int[] arr = new int[value -1];
    for(int x = 0; x < arr.Length; x++)
        {
            arr[x]=x+1;
        }
    int sum = 0;
    foreach(int val in arr)
        {
            if(val%3==0 || val % 5 == 0)
            {
                sum+=val;
            }
        }
    return sum;
  }
}