﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Task_2.Objects;

namespace Task_2.Parsers
{
    class FileParserXml : IWorkWithFile
    {
        string xmlFilePath = @"..\..\..\FilesExtensions\File.xml";
        public void WriteToFile(Buket bouquet)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Flower>));
            TextWriter textWriter = new StreamWriter(xmlFilePath);
            List<Flower> templist = new List<Flower>();
            foreach (var Flower in bouquet)
            {
                templist.Add(Flower);
            }
            serializer.Serialize(textWriter, templist);
            textWriter.Close();
        }
        public void ReadFromFile(Buket bouquet)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Flower>));
            TextReader textReader = new StreamReader(xmlFilePath);
            var tempCollection = (List<Flower>)serializer.Deserialize(textReader);
            foreach (var flower in tempCollection)
            {
                bouquet.AddFlower(flower.Name);
            }
            textReader.Close();
        }
    }
}
