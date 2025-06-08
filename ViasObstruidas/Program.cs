using System;

class ProgramaRegistroVias
{
    const int MAX_VIAS_OBSTRUIDAS = 100;

    static int contadorViasObstruidas = 1;
    static int[] idViaObstruida = new int[MAX_VIAS_OBSTRUIDAS];
    static string[] barrio_distrito = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] direccion = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] tipoObstruccion = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] nombreUsuario = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] departamento_regionUsuario = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] municipioUsuario = new string[MAX_VIAS_OBSTRUIDAS];

    //metodo para el menú principal
    static void MenuPrin()
    {
        Console.Clear();
        Console.WriteLine("Algoritmo para el registro y monitoreo de vías con sugerencia de trayectos alternos");
        Console.WriteLine();
        Console.WriteLine("MENU DEL ALGORITMO");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Registrar vía obstruida");
        Console.WriteLine("2. Listar vías obstruidas");
        Console.WriteLine("3. Salir");
        Console.Write("Ingrese su opción: ");
    }


    static void Main(string[] args)
    {
        int opcion;

        do
        {
           MenuPrin();

            // Validar la entrada del usuario

            if (!int.TryParse(Console.ReadLine(), out opcion))
            //TryParse intenta convertir la entrada en un número entero, si la conversión es exitosa significa que
            //el resultado será true y se ejecutará el bloque "if", sin embargo, necesitamos que esto no pase si es int, por lo que
            //invertimos la lógica del "if" con un "!", haciendo de que el resultado sea false, evitando que se ejecute el "if"

            //en caso de que la entrada no sea un int, la conversión será false, pero como se invierte el resultado, será true
            //y se ejecutará el bloque "if", mostrando un mensaje de error y volviendo a mostrar el menú.
            {
                Console.Clear();
                Console.WriteLine("¡Opción inválida!");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadLine();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    //Condicion de "if" para verificar que la cantidad de vias obstruidas registradas no pase el límite establecido
                    if (contadorViasObstruidas <= MAX_VIAS_OBSTRUIDAS)
                    {
                        int index = contadorViasObstruidas;

                        idViaObstruida[index] = index;

                        Console.Clear();
                        Console.WriteLine("Ingresar datos de la vía obstruida");
                        Console.WriteLine();

                        Console.Write("Ingrese el departamento o región en el que se encuentra: ");
                        departamento_regionUsuario[index] = Console.ReadLine();

                        Console.Write($"Ingrese el municipio de {departamento_regionUsuario[index]} en el que se encuentra: ");
                        municipioUsuario[index] = Console.ReadLine();

                        Console.Write("¿En qué barrio o distrito se encuentra la vía obstruida? ");
                        barrio_distrito[index] = Console.ReadLine();

                        Console.Write($"Escriba la dirección de la vía obstruida de {barrio_distrito[index]}: ");
                        direccion[index] = Console.ReadLine();

                        Console.Write("Ingrese el tipo de obstrucción en la vía: ");
                        tipoObstruccion[index] = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Ingresar datos del reportante");

                        Console.Write("Ingrese su nombre completo: ");
                        nombreUsuario[index] = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("¡La vía obstruida ha sido registrada con éxito!");

                        contadorViasObstruidas++;

                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR: Máximo de vías registradas alcanzado");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                    }
                    break;

                case 2:
                    if (contadorViasObstruidas > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Listado de vías obstruidas registradas:");
                        Console.WriteLine("-----------------------");

                        for (int x = 1; x < contadorViasObstruidas; x++)
                        {
                            Console.WriteLine($"ID: {idViaObstruida[x]}");
                            Console.WriteLine($"Departamento o región: {departamento_regionUsuario[x]}");
                            Console.WriteLine($"Municipio: {municipioUsuario[x]}");
                            Console.WriteLine($"Barrio o distrito: {barrio_distrito[x]}");
                            Console.WriteLine($"Dirección: {direccion[x]}");
                            Console.WriteLine($"Tipo de obstrucción: {tipoObstruccion[x]}");
                            Console.WriteLine($"Reportante: {nombreUsuario[x]}");
                            Console.WriteLine("-----------------------");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("¡No se ha registrado ninguna vía!");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Cerrando algoritmo...");
                    break;

                //En caso de que la entrada de opción no sea ni 1, 2 o 3, se ejecutará el bloque "default"
                //mostrando un mensaje de error y volviendo a mostrar el menú
                default:
                    Console.Clear();
                    Console.WriteLine("¡Opción inválida!");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadLine();
                    break;
            }

        } while (opcion != 3);

        Console.WriteLine("¡Gracias por utilizar nuestro algoritmo!");
    }
}
