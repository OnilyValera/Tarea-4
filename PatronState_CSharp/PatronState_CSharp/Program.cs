using System;

namespace PatronState_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterContext printer = new PrinterContext();
            printer.State = new AvailableServerState();
            printer.Help();

        }
    }
}
