// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Que el usuario capture 16 números, si su promedio es capturados " +
    "es mayor a 79, determinar cual es el mayor, y si el promedio es menor a 79, " +
    "determinar cual es el menor.");
//Datos de entrada
double[] numeros = new double[16];
double suma = 0;
double prom = 0;
double mayor = 0;
double menor = 0;
//Procedimiento Capturar los 16 numeros
Console.WriteLine("Capturaremos 16 números");
for (int i = 0; i < numeros.Length; i++)//Capturamos los 16 numeros
{
    Console.WriteLine("Número No. " + (i+1));
    numeros[i] = double.Parse(Console.ReadLine());//Leemos y posteriormente hacemos las operaciones necesarias
    suma = suma + numeros[i];//Acumulamos
    prom = suma / numeros.Length;//Promediamos
}
if (prom>79)//Evaluamos la primera condición para determinar el mayor
{
    for (int k = 0; k < numeros.Length; k++)//Comenzamos con un ordenamiento de burbuja. 
    {
        for (int i = 0; i < numeros.Length-1; i++)//Con el menos 1 comparamos en pares los números. 
        {
            if (numeros[i] < numeros[i+1])//Aquí evaluaremos si el primero y el segundo(sucesivamente)estan en su posición
            {//Por el como va el signo de comparación "<", el mayor estará en la primera posición [0]
                //Comenzamos los intercambios
                double temp = numeros[i]; //Este es para guardar la primera posición en una variable "extra"
                numeros[i] = numeros[i+1];
                numeros[i+1] = temp;//Aquí ya tenemos acomodado el mayor a menor
            }
        }
    }
    //Imprimo el mayor de todos
    mayor = numeros[0];
    Console.WriteLine($"El número mayor que capturaste es {mayor}");
}
if (prom<79)//Evaluaremos la segunda condición si el promedio fuese menor que 79
{
    for (int i = 0; i < numeros.Length; i++)
    {
        for (int l = 0; l < numeros.Length-1; l++)
        {
            if (numeros[l] > numeros[l+1])//La condición de >, nos
                                          //ayudará para colocar en la primera posición el menor(ordenamiento de menor a mayor)
            {//Comienza el intercambio para arrojar el menor en la primera posición
                double tempo = numeros[l];//Creamos otra variable"adicional" para el acomodo
                numeros[l] = numeros[l + 1];
                numeros[l + 1] = tempo;//Cambiamos las posiciones para darnos en la primera posición el menor
            }
        }
    }
    menor = numeros[0];
    Console.WriteLine($"El menor de los que capturaste es {menor}");
}
if (prom !> 79 && prom !< 79)
{
    Console.WriteLine("Lograste ser exacto");
}