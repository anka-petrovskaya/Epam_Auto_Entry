using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Task_2.Objects;

namespace Task_2.Parsers
{
    class FileParserTxt : IWorkWithFile
    {
        string txtFilePath = @"..\..\..\FilesExtensions\File.txt";
        public void WriteToFile(Buket buket)
        {
            using (FileStream fs = new FileStream(txtFilePath, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (var Flower in buket)
                {
                    sw.WriteLine(Flower);
                }
            }
        }
        public void ReadFromFile(Buket buket)
        {
            using (FileStream fs = new FileStream(txtFilePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                Regex regexFlower = new Regex(@"Rose|Tulip|Violet");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Match match = regexFlower.Match(line);
                    if (match.Success)
                    {
                        string flower = match.Value.ToString();
                        buket.AddFlower(flower);
                    }
                }
            }
        }
    }
}