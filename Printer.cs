namespace Katas.Printer;
public class Printer 
{
    public static string PrinterError(String s) 
    {
        string [] valid = ["a","b","c","d","e","f","g","h","i","j","k","l","m"];
        int countinvalid = 0;
        foreach(char charac in s){
            if(Array.IndexOf(valid,charac.ToString()) == -1) countinvalid++;
        }
        return $"{countinvalid}/{s.Length}";
    }
}