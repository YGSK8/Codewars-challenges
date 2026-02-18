// See https://aka.ms/new-console-template for more information
using Katas.Level6;

int []a = [1, 2, 2, 2, 3];
int []b = [2];

int [] array = Kata.ArrayDiff(a,b);
foreach(int item in array)
{
    Console.WriteLine(item);
}
