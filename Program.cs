// See https://aka.ms/new-console-template for more information
using Katas.Level6;

int []a = [1,2,2,3,4,5,5,7,8,9];
int []b = [1,5,5];

int [] array = Kata.ArrayDiff(a,b);
foreach(int item in array)
{
    Console.WriteLine(item);
}
