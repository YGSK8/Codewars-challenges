namespace Katas.Oddint;

// [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).

public class Kata
{
        public static int find_it(int[] seq)
    {
        int oddvalue = 0;
        foreach(int item in seq)
        {
            int count = 0;
            for(int x = 0; x < seq.Length; x++)
            {
                if (item == seq[x]) count++; 
            }
            if(count%2==1) oddvalue = item;
        }
        return oddvalue;
    }
          
}