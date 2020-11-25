using System;
using System.Collections.Generic;
using System.Text;

namespace PatronState_CSharp
{
    public class PrinterContext
    {
        private PrinterState state;

        public PrinterState State
        {
            get
            {
                return state;
            }
            set 
            {
                state = value;
            }
        }
        public void Help()
        {
            state.Respuesta();
        }
    }
}
