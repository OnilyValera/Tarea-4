using System;
using System.Collections.Generic;
using System.Text;

namespace PatronState_CSharp
{
    class AvailableServerState:PrinterState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Disponible 100%");
        }
    }
}
