using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorDeTriangulo.ConsoleApp
{
    internal class Triangulo
    {
        public double lado_1;
        public double lado_2;
        public double lado_3;
       
        public string VerificaTipoDeTriangulo()
        {
            if (VerificaLadoValido(lado_1, lado_2, lado_3) is false)
            {
                return "Triangulo Inválido";
            }

            else if (lado_1 == lado_2 & lado_1 == lado_3 & lado_2 == lado_3)
            {
                return "Triangulo Equilátero";
            }

            else if (lado_1 == lado_2 | lado_1 == lado_3 | lado_2 == lado_3)
            {
                return "Isóceles";

            }

            else if (lado_1 != lado_2 & lado_1 != lado_3 & lado_2 != lado_3)
            {
                return "Escaleno";

            }else
                return "Triangulo Inválido";
        }
        private bool VerificaLadoValido(double Lado_1, double Lado_2, double Lado_3)
        {
            double SomaLados1e2 = Lado_1 + Lado_2;
            double SomaLados1e3 = Lado_1 + Lado_3;
            double SomaLados2e3 = Lado_2 + Lado_3;

            if (SomaLados1e2 < Lado_3 | SomaLados1e3 < Lado_2 | SomaLados2e3 < Lado_1)
            {
                return false;
            }
            if (Lado_1 == 0 | Lado_2 == 0 | Lado_3 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
