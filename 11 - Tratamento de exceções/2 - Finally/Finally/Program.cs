﻿using System;
using System.IO;
public class ProcessFile
{
    public static void Main()
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(@"C:\Windows\Temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}