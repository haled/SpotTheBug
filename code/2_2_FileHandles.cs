using System;
using System.IO;
using System.Collections.Generic;

namespace FileHandles
{
public class Program
{
public static void Main(string[] args)
{
var lines = new List<string>
{
"This is the first string.",
"Another string that needs writing.",
"Yet another string for writing."
};
		
using(var dataWriter = new StreamWriter("data.txt"))
{
dataWriter.Open();

foreach(var line in lines)
{
writer.WriteLine(line);
}

dataWriter.Close();  // Good practice
}
}
}

}
