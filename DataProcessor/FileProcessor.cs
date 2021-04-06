﻿using static System.Console;
using System.IO;
namespace DataProcessor
{
    internal class FileProcessor
    {
        public string InputFilePath { get; }

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public void Process()
        {
            WriteLine($"begin process of {InputFilePath}");

            // check if exist
            if (!File.Exists(InputFilePath))
            {
                WriteLine($"ERROR : file {InputFilePath} does not exist.");
                return;
            }

            string rootDirectoryPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName;
            WriteLine($"Root data path is {rootDirectoryPath}");
        }
    }
}