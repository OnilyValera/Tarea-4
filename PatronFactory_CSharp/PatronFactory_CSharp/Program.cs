using System;

namespace PatronFactory_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera c1 = Creador.CreadorCarrera(Creador.SOFTWARE);
            Console.WriteLine(c1.Cantidad_De_Creditos_Por_Carrera());
        }
    }
}
