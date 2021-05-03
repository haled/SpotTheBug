using System;
using System.IO;
using System.Collections.Generic;

namespace FileHandles
{
    public class DataWriter
    {

        public StreamWriter OpenFile(string fileName)
        {
            return new StreamWriter(fileName);
        }

        public bool WriteData(StreamWriter writer, List<string> data)
        {
            foreach (var line in data)
            {
                writer.WriteLine(line);
            }

            return true;
        }

        public bool CloseFile(StreamWriter writer)
        {
            writer.Close();
            writer.Dispose();
            return true;
        }
    }

    public class Program
    {
	    public static void Main(string[] args)
	    {
    	    var dataWriter = new DataWriter();

    	    var writer = dataWriter.OpenFile("data.txt");

    	    var lines = new List<string>
    	    {
        		"This is the first string.",
        		"Another string that needs writing.",
        		"Yet another string for writing."
    	    };

    	    var result = dataWriter.WriteData(writer, lines);
    	}
    }
}
