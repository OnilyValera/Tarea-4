using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PatronState_CSharp
{
    class NotAvailablePrinterState:PrinterState
    {
        public override void Respuesta()
        {
            Task.Delay(50);
            Console.WriteLine("Impresora no disponible");
        }

    }
}
