using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory_CSharp
{
    public class Creador
    {
        public const int SOFTWARE = 1;
        public const int MULTIMEDIA = 2;
        public const int DESARROLLO_SIMULACIONES = 3;
        public const int DISENO_INDUSTRIAL = 4;
        public const int ENERGIAS_RENOVABLES = 5;
        public const int INFORMATICA_FORENSE = 6;
        public const int INTELIGENCIA_ARTIFICIAL = 7;
        public const int MANUFACTURA_AUTOMATIZADA = 8;
        public const int INTELIGENCIAARTIFICIAL = 9;
        public const int MANUFACTURAAUTOMATIZADA = 10;
        public const int MANUFACTURAMEDICA = 10;
        public const int MECATRONICA = 11;
        public const int REDES = 12;
        public const int SEGURIDAD = 13;
        public const int SONIDO = 14;
        public const int TELECOMUNICACIONES = 15;



        public static Carrera CreadorCarrera(int Tipo)
        {

            switch (Tipo)
            {
                case SOFTWARE:
                    return new Software();
                case MULTIMEDIA:
                    return new Multimedia();
                case DESARROLLO_SIMULACIONES:
                    return new Desarrollo_de_Simulaciones_Interactivas_y_Videojuegos();
                case DISENO_INDUSTRIAL:
                    return new Diseño_Industrial();
                case ENERGIAS_RENOVABLES:
                    return new Energías_Renovables();
                case INFORMATICA_FORENSE:
                    return new Informática_Forense();
                case INTELIGENCIAARTIFICIAL:
                    return new Informática_Forense();
                case MANUFACTURAAUTOMATIZADA:
                    return new Manufactura_Automatizada();
                case MECATRONICA:
                    return new Mecatrónica();
                case REDES:
                    return new Redes_de_la_Información();
                case SEGURIDAD:
                    return new Seguridad_Informática();
                case SONIDO:
                    return new Sonido();
                case TELECOMUNICACIONES:
                    return new Telecomunicaciones();
                default: return null;

            }                  
        }
        
    }
}
