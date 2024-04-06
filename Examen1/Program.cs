bool continuar = true; 

while (continuar)
{
    MostrarMenu();
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            ejercicio1();
            break;
        case 2:
            ejercicio2();
            break;
        case 3:
            ejercicio3();
            break;
        case 4:
            ejercicio4();
            break;
        case 5:
            ejercicio5();
            break;
        case 6:
            ejercicio6();
            break;
        case 7:
            ejercicio7();
            break;
        case 8:
            Console.WriteLine("Saliendo del programa...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elija una opción válida del menú.");
            break;
    }

    Console.WriteLine("");
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

static void MostrarMenu()
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Ejercicio 1");
    Console.WriteLine("2. Ejercicio 2");
    Console.WriteLine("3. Ejercicio 3");
    Console.WriteLine("4. Ejercicio 4");
    Console.WriteLine("5. Ejercicio 5");
    Console.WriteLine("6. Ejercicio 6");
    Console.WriteLine("6. Ejercicio 7");
    Console.WriteLine("8. Salir\n");
}

static void ejercicio1()
{
    Console.WriteLine("Ingrese un número:");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        Console.WriteLine("Este número es un cero.");
        return;
    }

    string mensaje = numero > 0 ? "El número es positivo." : "El número es negativo.";
    Console.WriteLine(mensaje);
}

static void ejercicio2()
{
    string[] arrayDias = ["Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"];
    Console.WriteLine("Ingrese un número del 1 al 7 para representar un día de la semana:");
    int index = Convert.ToInt32(Console.ReadLine());
    

    if (index >= 1 && index <= 7)
    {
        string dia = arrayDias[index - 1]; 
        Console.WriteLine("El día ingresado es " + dia);
    }
    else
    {
        Console.WriteLine("Número ingresado no válido para representar un día de la semana.");
    }
}

static void ejercicio3()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma += i;
    }

    Console.WriteLine("La suma de los primeros 100 números naturales es:");
    Console.WriteLine(suma); ;
}

static void ejercicio4()
{
    Console.WriteLine("Ingrese un número:");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Números desde 1 hasta el número ingresado:");
    for (int i = 1; i <= numero; i++)
    {
        Console.WriteLine(i);
    }
}

static void ejercicio5()
{
    Console.WriteLine("Ingrese el radio del círculo:");
    double radio = Convert.ToDouble(Console.ReadLine());

    double area = Math.PI * radio * radio;
    Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);

}

static void ejercicio6()
{
    int[] arreglo = { 10, 20, 30, 40, 50 };
    Console.WriteLine("Elementos del arreglo:");

    foreach (int elemento in arreglo)
    {
        Console.WriteLine(elemento);
    }
}

static void ejercicio7()
{
    List<string> nombres = new List<string> { "Gerson", "Rolando", "Carlos", "Luis", "Piero" };
    Console.WriteLine("Nombres de personas:");

    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }

}
