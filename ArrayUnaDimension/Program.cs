// See https://aka.ms/new-console-template for more information

int[] arregloEnteros = new int[6];//Declaración y creación
//Asignar valores al arreglo
arregloEnteros[0] = 15;
arregloEnteros[1] = 24;
arregloEnteros[2] = 36;
arregloEnteros[3] = 7;
arregloEnteros[4] = -80;
arregloEnteros[5] = int.Parse ("1");

//Obtener un valor del arreglo
int valor = arregloEnteros[4];
Console.WriteLine($"El valor obtenido es: { valor }");

//Recorriendo el arreglo
for (int Index = 0; Index < arregloEnteros.Length; Index++)
{
    arregloEnteros[Index] = arregloEnteros[Index] * 2;
    Console.WriteLine(arregloEnteros[Index]);
}

foreach (int Item in arregloEnteros)
{
    Console.WriteLine(Item);
}

