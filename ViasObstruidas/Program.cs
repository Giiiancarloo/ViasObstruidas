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
        Console.WriteLine();
        Console.WriteLine("MENU DEL ALGORITMO");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Registrar vía obstruida");
        Console.WriteLine("2. Listar vías obstruidas");
        Console.WriteLine("3. Salir");
    }

    static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine();
        Console.WriteLine("Algoritmo para el registro y monitoreo de vías con sugerencia de trayectos alternos");

        do
        {
           MenuPrin();

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("¡Opción inválida!");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    if (contadorViasObstruidas <= MAX_VIAS_OBSTRUIDAS)
                    {
                        int index = contadorViasObstruidas;

                        idViaObstruida[index] = index;

                        Console.WriteLine("-----------------------");
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
                        Console.WriteLine("-----------------------");

                        contadorViasObstruidas++;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Máximo de vías registradas alcanzado");
                        Console.WriteLine("-----------------------");
                    }
                    break;

                case 2:
                    if (contadorViasObstruidas > 1)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Listado de vías obstruidas registradas:");

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
                    }
                    else
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("¡No se ha registrado ninguna vía!");
                        Console.WriteLine("-----------------------");
                    }
                    break;

                case 3:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Cerrando algoritmo...");
                    Console.WriteLine("-----------------------");
                    break;

                default:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("¡Opción inválida!");
                    Console.WriteLine("-----------------------");
                    break;
            }

        } while (opcion != 3);

        Console.WriteLine("¡Gracias por utilizar nuestro algoritmo!");
    }
}
