using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCServices
{
    public class IMCService
    {
        //Método que calcula el IMC (retorna valor)
        public double CalcularIMC(double Peso, double Altura)
        {
            double IMCResult;
            IMCResult = Peso / Math.Pow(Altura, 2);
            return IMCResult;
        }

        //Método que nos devuelve el diagnóstico
        public string ObtenerDiagnostico(double IMC)
        {
            //Declaramos un Array multidimensional
            string[,] ArrayIMCReference = ObtenerDatosReferencia(); //Simulación de obtener Datos Extrenos

            string Diagnostico = "FUERA DE LOS LIMITES";

            for (int fila = 0; fila < 4; fila++)
            {
                if (IMC >= double.Parse(ArrayIMCReference[fila, 0]) && IMC <= double.Parse(ArrayIMCReference[fila, 1]))
                {
                    Diagnostico = ArrayIMCReference[fila, 2];
                    break;
                }
            }

            return Diagnostico;

        }

        //Simulación de datos externos (BD, API, TXT, etc)
        private string[,] ObtenerDatosReferencia()
        {
            //Declaramos un Array multidimensional
            string[,] ArrayData = new string[5, 3];

            //Establecarle los valores
            ArrayData[0, 0] = "0,0";
            ArrayData[0, 1] = "18,5";
            ArrayData[0, 2] = "Bajo peso";
            //
            ArrayData[1, 0] = "18,5";
            ArrayData[1, 1] = "24,9";
            ArrayData[1, 2] = "Peso saludable";
            //
            ArrayData[2, 0] = "25,0";
            ArrayData[2, 1] = "29,9";
            ArrayData[2, 2] = "Sobrepeso";
            //
            ArrayData[3, 0] = "30,0";
            ArrayData[3, 1] = "50,0";
            ArrayData[3, 2] = "Obesidad";
            //
            ArrayData[4, 0] = "50,0";
            ArrayData[4, 1] = "70,0";
            ArrayData[4, 2] = "Obesos digitales";

            return ArrayData;
        }

        //Método que da la bievenida (NO retorna valor, solo ejecuta operaciones)
        public string RetornarBienvenida(char Genero, string Nombre)
        {
            string Bienvenida= string.Empty;
            switch (Genero)
            {
                case 'F':
                    Bienvenida = "Bienvenido(a): " + Nombre;
                    break;
                case 'M':
                    Bienvenida = "Bienvenido: " + Nombre;
                    break;
                default:
                    Bienvenida = "Bienvenidx: " + Nombre;
                    break;
            }
            return Bienvenida;
        }

    }
}
