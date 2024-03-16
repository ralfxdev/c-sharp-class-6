int[] calificaciones;
calificaciones = new int[] { 85, 77, 68, 94, 75 };

foreach (int calificacion in calificaciones)
{
    Console.WriteLine(calificacion);
}

string[] ciudades;
ciudades = new string[] { "Guatemala", "Tokyo", "Pueblo Paleta" };

foreach (string ciudad in ciudades)
{
    Console.WriteLine(ciudad);
}


int[] notas;
notas = new int[] { 80, 75, 90, 95, 73, 79, 54 };

int total = 0;

foreach (int nota in notas)
{
    total += nota;
}

for(int i=0; i<notas.Length; i++)
{
    Console.WriteLine($"Nota: {notas[i]}");
}


Console.WriteLine($"Notas Ordenadas");
Array.Sort(notas);

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota: {notas[i]}");
}

float promedio = total / notas.Length;
Console.WriteLine($"El promedio es: {promedio}");

bool isAproved = Array.Exists(notas, calif => calif >= 60);

if (isAproved) Console.WriteLine($"Aprobaste");
if (!isAproved) Console.WriteLine($"No Aprobaste");

string[] nombres, nombresReverse;
nombres = new string[] { "Juan", "Ana", "Pedro", "Monica", "Andrea" };
nombresReverse = new string[nombres.Length];

for (int indiceIzquierdo = 0; indiceIzquierdo < nombres.Length / 2; indiceIzquierdo++)
{
    int indiceDerecho = nombres.Length - indiceIzquierdo - 1;
    string temporal = nombres[indiceIzquierdo];
    nombresReverse[indiceIzquierdo] = nombres[indiceDerecho];
    nombresReverse[indiceDerecho] = temporal;
}

foreach (string nombre in nombresReverse)
{
    Console.WriteLine(nombre);
}
