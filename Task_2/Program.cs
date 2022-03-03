using System;
using Task_2.Objects;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Buket buket = new Buket();
            UserInterface userInterface = new UserInterface(buket);
            userInterface.CreateBuket();
            userInterface.ShowBuketPrice();
            userInterface.ProgrammEnd();
        }
    }
}