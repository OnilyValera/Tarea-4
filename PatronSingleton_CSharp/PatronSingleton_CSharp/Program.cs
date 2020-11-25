using System;

namespace PatronSingleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "Hola Onily";
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
