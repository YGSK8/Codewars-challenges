namespace Katas.Isograms;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        bool norepeatletters = true;
        foreach(char character in str.ToLower())
        {
            int count = 0;
            for(int x = 0; x < str.Length; x++)
            {
               if(str.ToLower()[x] == character)count++;
            }
            if(count > 1) norepeatletters = false;
        }
        return norepeatletters;
    }
}