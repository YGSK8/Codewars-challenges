namespace Katas.Roman;

public class RomanDecode
{
	public static int Solution(string roman)
	{
        List<int> list =[];
        int sum = 0;
		foreach (char character in roman)
        {
            int current = character switch
            {
                'I'=>1,
                'V'=>5,
                'X'=>10,
                'L'=>50,
                'C'=>100,
                'D'=>500,
                'M'=>1000,
                _ =>0
            };
        sum += current;
        list.Add(current);
        }
        for(int x=0;x<list.Count-1; x++)
        {
            if(list[x]<list[x+1]){sum-=list[x]*2;}
        }
        return sum;
	}
}