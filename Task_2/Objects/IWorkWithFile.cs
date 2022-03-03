using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Objects
{
    public interface IWorkWithFile
    {
        void WriteToFile(Buket flowers);
        void ReadFromFile(Buket flowers);
    }
}