namespace Katas.Level6;
public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        int [] difference = a;
        foreach(int value in b)
        {
            int[] temparray;
            if (Array.IndexOf(difference,value) != -1)
            {
                while(Array.IndexOf(difference,value) >= 0)
                {
                    int index = 0;
                    temparray = new int [difference.Length-1];
                    for (int position = 0; position < difference.Length; position++)
                    {
                        if(position != Array.IndexOf(difference, value))
                        {
                            temparray[index] = difference[position];
                            index ++ ;
                        }
                    }
                    difference = temparray;
                }
            
            }
        }
        return difference;
    }
}