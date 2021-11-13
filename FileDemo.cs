﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    public class FileDemo
    {
        public static void ReadDemo(string file)
        {
            string path = "C:/Users/lucia/Downloads";

            string fileToRead = $"{path}/{file}";

            Console.WriteLine($"Reading File:{fileToRead}");

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    Console.WriteLine($"Starting to read {fileToRead}");
                    string line;
                    while ((line = sr.ReadLine()) is not null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToRead} could not be read");
                Console.WriteLine(e.Message);
            }

        }

        public static void WriteDemo(string file, string[] heroes)
        {
            string path = "C:/Users/lucia/Downloads";
            
            string fileToWrite = $"{path}/{file}";
             


            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite))
                {
                    foreach (string hero in heroes)
                    {
                        sw.WriteLine(hero);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToWrite} could not be written");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}