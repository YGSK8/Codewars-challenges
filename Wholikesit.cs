namespace Katas.WhoLikesit;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string output = name.Length switch
    {
        0 => EmptySingle(name),
        1 => EmptySingle(name),
        2=> TwoThree(name),
        3=>TwoThree(name),
        _ =>Fourplus(name)
    };
    return output;
    string EmptySingle(string [] array)
        {
            if(array.Length == 0)return "no one likes this";
            else return $"{array[0]} likes this";
        }
    string TwoThree(string[] array)
        {
            if(array.Length == 2) return $"{array[0]} and {array[1]} like this";
            else return $"{array[0]}, {array[1]} and {array[2]} like this";
        }
    string Fourplus(string[] array)
        {
            return $"{array[0]}, {array[1]} and {array.Length-2} others like this";
        }
  }
}