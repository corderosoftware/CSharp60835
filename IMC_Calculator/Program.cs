using IMCServices;
namespace IMC_Calculator
{
    internal class Program
    {
        static IMCService imcService = new IMCService();
        static void Main(string[] args)
        {
            

            const int NRO_LINEAS = 100; //Definimos una Constante
                     
            double IMC = 0;
            string Input; //Como entrada de datos
          
            Console.WriteLine("Calculador IMC v 1.0");

            Paciente paciente = new Paciente();

            Console.WriteLine("Indica tu nombre y apellido: ");
            paciente.NombrePaciente = Console.ReadLine();

            Console.WriteLine("Indica tu genero (M,F,X): ");
            Input = Console.ReadLine();

            paciente.Genero = char.Parse(Input);

            Console.WriteLine("Indica tu edad: ");
            paciente.Edad = byte.Parse(Console.ReadLine());

            Console.WriteLine("Indica tu Peso: ");
            paciente.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Indica tu Altura: ");
            paciente.Altura = Convert.ToDouble(Console.ReadLine());

            //Le damos la bienvenida
            MostrarBienvenida(paciente.Genero, paciente.NombrePaciente);
            Console.WriteLine("Presiona <Enter> para continuar ...");
            Console.ReadLine();


            //Procedemos a hacer los calculos
            //IMC = Peso / (Altura * Altura);
            //IMC = paciente.Peso / Math.Pow(paciente.Altura, 2); // Elevarlo a la potencia 2
            IMC = imcService.CalcularIMC(paciente.Peso, paciente.Altura);

            Console.WriteLine($"Tu IMC es: {IMC}");

            //Le mostramos el diagnostico al usuario
            Console.WriteLine($"Tu Diagnóstico es: { imcService.ObtenerDiagnostico(IMC) }");
            
        } // Fin método Main
               

        //Método que da la bievenida (NO retorna valor, solo ejecuta operaciones)
        static void MostrarBienvenida(char Genero, string Nombre)
        {
            
            Console.WriteLine(imcService.RetornarBienvenida(Genero, Nombre));
            
        }
               

        


    }
}