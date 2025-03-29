using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica1.Models
{
    public class Operacion
    {
        public string? Operacio  { get; set; }
        public double Operador1   { get; set; }
        public double Operador2   { get; set; }

        public double Calcular()
        {
            double resultado = 0;
            switch (Operacio)
            {
                case "suma":
                    resultado = Operador1 + Operador2;
                    break;
                case "resta":
                    resultado = Operador1 - Operador2;
                    break;
                case "multiplicar":
                    resultado = Operador1 * Operador2;
                    break;
                case "dividir":
                    if(Operador2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    resultado = Operador1 / Operador2;
                    break;
            }
            return resultado;
        }
    
    }
}