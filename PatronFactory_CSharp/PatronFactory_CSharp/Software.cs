using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory_CSharp
{
    class Software:Carrera
    {
        public override int Cantidad_De_Creditos_Por_Carrera()
        {
            return 150;
        }
    }
}
