// See https://aka.ms/new-console-template for more information
using System.Collections;

StreamReader sr = new StreamReader("C:\\Users\\samue\\Documents\\Programming\\AOC_2024\\AOCDay1\\input\\input.txt");

String line = sr.ReadLine();
string[] stringsplit;
ArrayList leftside = new ArrayList();
Dictionary<string, int> rightSide = new Dictionary<string,int>();

int total = 0;


while (line != null)
{
    stringsplit = line.Split("   ");
    leftside.Add(stringsplit[0]);
    if(rightSide.ContainsKey(stringsplit[1]))
    {
        rightSide[stringsplit[1]]++;

        Console.WriteLine("True Right");
    }
    else{
        rightSide.Add(stringsplit[1], 1);
    }

    line = sr.ReadLine();
}



foreach(string numbers in leftside)
{
    if(rightSide.ContainsKey(numbers)){
        total += rightSide[numbers] * int.Parse(numbers);
    }
}


Console.WriteLine(total);

sr.Close();






