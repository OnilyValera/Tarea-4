using System;
using System.Collections.Generic;
using System.Text;

namespace PatronSingleton_CSharp
{

        public class Singleton
        {
            private static Singleton instance = null;
            public string mensaje = "";

            protected Singleton()
            {
                mensaje = "Hola Mundo";
            }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }
        }
    
}
