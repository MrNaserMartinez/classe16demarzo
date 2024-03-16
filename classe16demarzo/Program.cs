////ejemplo 1

using System.Security.Cryptography;

static void ejemplo1()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 77, 68, 94, 75 };
    Console.WriteLine(calificaciones[2]);
}
//ejemplo1(); 

//Ejemplo 2
static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";

    foreach(string nombre in nombres)
    {
        Console.WriteLine("nombre="+nombre);
    }

}
//ejemplo2();

//ejemplo3

static void ejemplo3prome()
{
    int[] notas = {80,75,90,95,73,79};
    double promedios = 0;

    foreach(int nota in notas) 
    {
      promedios += nota;
    }
    double prom = promedios / notas.Length;
    Console.WriteLine("el promedio es: "+prom);
}
//ejemplo3prome();

//ejemplo 4

static void ejemplo4()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    double promedios = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        promedios += notas[i];
    }
    double prom = promedios/ notas.Length;
    Console.WriteLine(prom);
    
    Array.Sort(notas);
}


//ejemplo4();

static void ejemplo5()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    bool hayaprobados = Array.Exists(notas, calif => calif >= 60);
    if (hayaprobados == true)
    {
        Console.WriteLine("nice");
    }
    else
    {
        Console.WriteLine("valiste");
    }
}
//ejemplo5();

static void ejercicio1()
{

    string[] name = { "Juan", "Ana", "Pedro", "Maria", "Andrea" };
    string[] name2 = new string[name.Length];
    
        for(int i =0; i < name.Length; i++)
        {
            name2[i] = name[name.Length - 1 - i];
        }

        for(int i = 0; i < name2.Length; i++)
    {
        Console.WriteLine(name2[i]);    
    }

}

ejercicio1();

//Hola


