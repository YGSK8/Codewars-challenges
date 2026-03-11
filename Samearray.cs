namespace Katas.SameArray;
class AreTheySame
{
  public static bool comp(int[]? a, int[]? b)
  {
    // your code
    if(a == null || b == null) return false;
    if(a.Length != b.Length) return false;
    bool arraya = true;
    foreach(int element in a)
        {
            if(Array.IndexOf(b,element*element) ==-1) arraya = false;
            // Console.WriteLine(Math.Sqrt(element));
        }
    bool arrayb=true;
    foreach(int element in b)
        {
            
            if(Array.IndexOf(a,(int)Math.Sqrt(element))==-1)arrayb = false;
        }
    bool mult = true;
    foreach(int element in a)
        {
            int count = 0;
            for(int x = 0; x < b.Length; x++)
            {
                if(b[x]==element*element)count++;
            }
            int counter = 0;
            for(int x = 0; x < a.Length; x++)
            {
                if(a[x]==element)counter++;
            }
            if(count != counter) mult =false;
        }
    if(arraya && arrayb && mult)return true;
    else return false;
  }
}