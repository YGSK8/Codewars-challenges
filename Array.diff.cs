namespace Katas.Level6;
public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
       int counter = 0;
       for (int x = 0; x < a.Length; x++) //-- If element in a is not in b, it should be in the final array. Size of the array is value of counter
        {
            if(Array.IndexOf(b,a[x])==-1)counter ++; 
        }
        int[] newarray = new int [counter];
        int newarraycounter = 0;
        for(int y =0;y< a.Length; y++)
        {
            if(Array.IndexOf(b,a[y]) == -1)
            {
                newarray[newarraycounter] = a[y];
                newarraycounter++;
            }
        }
        return newarray;
    }
}