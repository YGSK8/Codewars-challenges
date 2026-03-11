namespace Katas.WhichAreIn;

class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        int countword=0;
        string[]arr= new string[array1.Length];//--creates an array of equal size to array1. However it can be smaller and length will be modified later in the code.
        foreach(string word in array1){
            bool containsword = false;
            for(int x = 0; x < array2.Length; x++)
            {
                if(array2[x].Contains(word))containsword =true;
            }
        if(containsword){arr[countword]=word;countword++;}
        }
        if(countword < array1.Length)//--this parts check if not all strings in a are found in b. So arr will contain nulls and must be re-instantiated witht he correct length.
        {
            string[] arr2 = new string[countword];
            for(int x = 0; x < countword; x++)
            {
                arr2[x]=arr[x];
            }
            arr = arr2;
        }
        Array.Sort(arr);
        return arr;
    }
}