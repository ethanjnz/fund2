// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// THREE BASIC ARRAYS
using System.Net;

int[] IntArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] StringArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };

bool[] BoolArray = new bool[10];
for (int i = 0; i < BoolArray.Length; i++)
{
    if (i % 2 == 0)
    {
        BoolArray[i] = true;
    }
    else
    {
        BoolArray[i] = false;
    }
}
// checks for the values in arrays
foreach (int num in IntArray)
{
    // Console.WriteLine(num);
}

// -------------------------------------


//LIST OF FLAVORS

List<string> StringList = new List<string>();
StringList.Add("Strawberry");
StringList.Add("Chocolate");
StringList.Add("Banana");
StringList.Add("Cupcake");
StringList.Add("Vanilla");
StringList.RemoveAt(2);
Console.WriteLine(StringList.Count);
Console.WriteLine(StringList[2]);


// ------------------------------------


// User Dictionary

Dictionary<string, string> DictionaryList = new Dictionary<string, string>();

for (int j = 0; j < StringArray.Length; j++)
{
    Random idx = new();
    int index = idx.Next(StringList.Count);
    DictionaryList.Add(StringArray[j], StringList[index]);
}

foreach (KeyValuePair<string, string> entry in DictionaryList)
{
    Console.WriteLine($"{entry.Key}, {entry.Value}");
}