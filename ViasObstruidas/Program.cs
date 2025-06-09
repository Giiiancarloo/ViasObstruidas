using System;

class ProgramaRegistroVias
{
    const int MAX_VIAS_OBSTRUIDAS = 100;

    static int contadorViasObstruidas = 1;
    static int[] idViaObstruida = new int[MAX_VIAS_OBSTRUIDAS];
    static string[] distrito = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] barrio = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] sector = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] comarca = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] nameUsu = new string[MAX_VIAS_OBSTRUIDAS];
    static string[] tipoObstru = new string[MAX_VIAS_OBSTRUIDAS];

    //metodo para el menú principal
    static void MenuPrin()
    {
        Console.Clear();
        Console.WriteLine("Algoritmo para el registro y monitoreo de vías con sugerencia de trayectos alternos en Managua");
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
        bool salir = false;


        while (!salir)
        {
           MenuPrin();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    //Condicion de "if" para verificar que la cantidad de vias obstruidas registradas no pase el límite establecido
                    if (contadorViasObstruidas <= MAX_VIAS_OBSTRUIDAS)
                    {
                        int index = contadorViasObstruidas;

                        idViaObstruida[index] = index;


                        bool dvalido = false;
                        while (!dvalido)

                        {
                            Console.Clear();
                            Console.WriteLine("Ingresar datos de la vía obstruida:");
                            Console.WriteLine("Seleccione el Distrito en el que se encuentra");
                            Console.WriteLine("1. Distrito I");
                            Console.WriteLine("2. Distrito II");
                            Console.WriteLine("3. Distrito III");
                            Console.WriteLine("4. Distrito IV");
                            Console.WriteLine("5. Distrito V");
                            Console.WriteLine("6. Distrito VI");
                            Console.WriteLine("7. Distrito VII");
                            Console.WriteLine("8. Atras");
                            Console.Write("Ingrese su opción: ");
                            string selecdistrito = Console.ReadLine();

                            switch (selecdistrito)
                            {
                                case "1":
                                    bool secD1valido = false;
                                    distrito[index] = "Distrito I";
                                    Console.WriteLine($"Seleccione el sector del  {distrito[index]}");
                                    Console.WriteLine("1. Carlos Reyna");
                                    Console.WriteLine("2. Santo Domingo Oeste");
                                    Console.WriteLine("3. Santo Domingo Este");
                                    Console.WriteLine("4. 19 de Julio 1");
                                    Console.WriteLine("5. 19 de Julio 2");
                                    Console.WriteLine("6. Francisco Meza Norte");
                                    Console.WriteLine("7. Francisco Meza Sur");
                                    Console.WriteLine("8. Largaespada");
                                    Console.WriteLine("9. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string selecsectorD1 = Console.ReadLine();

                                    while (!secD1valido)
                                    {
                                        switch (selecsectorD1)
                                        {
                                            case "1":
                                                sector[index] = "Carlos Reyna";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "2":
                                                sector[index] = "Santo Domingo Oeste";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "3":
                                                sector[index] = "Santo Domingo Este";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "4":
                                                sector[index] = "19 de Julio 1";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "5":
                                                sector[index] = "19 de Julio 2";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "6":
                                                sector[index] = "Francisco Meza Norte";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "7":
                                                sector[index] = "Francisco Meza Sur";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "8":
                                                sector[index] = "Largaespada";
                                                secD1valido = true;
                                                dvalido = true;
                                                break;
                                            case "9":
                                                secD1valido = true;
                                                break;
                                            default:
                                                Console.WriteLine("Opción inválida");
                                                break;
                                        }
                                    }

                                    break;

                                case "2":
                                    bool comOsecvalido = false;
                                    distrito[index] = "Distrito II";
                                    Console.WriteLine($"Seleccione una opción del , {distrito[index]}");
                                    Console.WriteLine("1. Comarca");
                                    Console.WriteLine("2. Sector");
                                    Console.WriteLine("3. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string comarcaOsector = Console.ReadLine();

                                    while (!comOsecvalido)
                                    {
                                        switch (comarcaOsector)
                                        {
                                            case "1":
                                                bool comarcaD2valido = false;
                                                Console.WriteLine($"Seleccione una comarca del ", distrito[index]);
                                                Console.WriteLine("1. Nejapa");
                                                Console.WriteLine("2. Chiquilistagua");
                                                Console.WriteLine("3. Cedro Galán");
                                                Console.WriteLine("4. San Isidro Libertador");
                                                Console.WriteLine("5. Ticomo");
                                                Console.WriteLine("6. Pochocuape");
                                                Console.WriteLine("7. Monte Tabor");
                                                Console.WriteLine("8. Atras");
                                                string comarcaD2 = Console.ReadLine();

                                                while (!comarcaD2valido)
                                                {
                                                    switch (comarcaD2)
                                                    {
                                                        case "1":
                                                            comarca[index] = "Nejapa";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "2":
                                                            comarca[index] = "Chiquilistagua";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "3":
                                                            comarca[index] = "Cedro Galán";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "4":
                                                            comarca[index] = "San Isidro Libertador";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "5":
                                                            comarca[index] = "Ticomo";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "6":
                                                            comarca[index] = "Pochocuape";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "7":
                                                            comarca[index] = "Monte Tabor";
                                                            comarcaD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "8":
                                                            comarcaD2valido = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine("Opción inválida");
                                                            break;
                                                    }
                                                }
                                                
                                                break;

                                            case "2":
                                                bool sectorD2valido = false;
                                                Console.WriteLine($"Seleccione un sector del {distrito[index]}");
                                                Console.WriteLine("1. Valle Dorado");
                                                Console.WriteLine("2. Linda Vista");
                                                Console.WriteLine("3. Rafael Ángel Ríos");
                                                Console.WriteLine("4. Dignidad 4 de mayo");
                                                Console.WriteLine("5. Monseñor Lezcano S-3");
                                                Console.WriteLine("6. Monseñor Lezcano S-4");
                                                Console.WriteLine("7. Villa Virgen de Guadalupe");
                                                Console.WriteLine("8. Alemania Democrática");
                                                string sectorD2 = Console.ReadLine();

                                                while (!sectorD2valido)
                                                {
                                                    switch (sectorD2)
                                                    {
                                                        case "1":
                                                            sector[index] = "Valle Dorado";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "2":
                                                            sector[index] = "Linda Vista";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "3":
                                                            sector[index] = "Rafael Ángel Ríos";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "4":
                                                            sector[index] = "Dignidad 4 de Mayo";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "5":
                                                            sector[index] = "Monseñor Lexcano S-4";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "6":
                                                            sector[index] = "Monseñor Lezcano S-3";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "7":
                                                            sector[index] = "Villa Virgen de Guadalupe";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        case "8":
                                                            sector[index] = "Alemania Democrática";
                                                            sectorD2valido = true;
                                                            dvalido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine("Opción inválida");
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "3":
                                                comOsecvalido = true;
                                                break;

                                            default:
                                                Console.WriteLine("Opción inválida");
                                                break;
                                        }
                                    } 
                                    break;


                                case "3":
                                    bool secD3valido = false;
                                    distrito[index] = "Distrito III";
                                    Console.WriteLine($"Seleccione un sector del {distrito[index]}");
                                    Console.WriteLine("1. Altagracia Norte");
                                    Console.WriteLine("2. Altagracia Central");
                                    Console.WriteLine("3. San Ignacio");
                                    Console.WriteLine("4. Santa Ana");
                                    Console.WriteLine("5. Bertha Calderón");
                                    Console.WriteLine("6. Recreo Norte");
                                    Console.WriteLine("7. Recreo Central");
                                    Console.WriteLine("8. Recreo Sur");
                                    Console.WriteLine("9. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string selecsectorD3 = Console.ReadLine();

                                    while (!secD3valido)
                                    {
                                        switch (selecsectorD3)
                                        {
                                            case "1":
                                                sector[index] = "Altagracia Norte";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "2":
                                                sector[index] = "Altagracia Central";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "3":
                                                sector[index] = "San Ignacio";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "4":
                                                sector[index] = "Santa Ana";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "5":
                                                sector[index] = "Bertha Calderón";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "6":
                                                sector[index] = "Recreo Norte";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "7":
                                                sector[index] = "Recreo Central";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "8":
                                                sector[index] = "Recreo Sur";
                                                secD3valido = true;
                                                dvalido = true;
                                                break;
                                            case "9":
                                                dvalido = true;
                                                break;
                                            default:
                                                Console.WriteLine("Opción inválida");
                                                break;
                                        }
                                    }
                                    
                                    break;


                                case "4":
                                    bool secObarD4 = false;
                                    distrito[index] = "Distrito IV";
                                    Console.WriteLine($"Seleccione una opción del {distrito[index]}");
                                    Console.WriteLine("1. Sector");
                                    Console.WriteLine("2. Barrio");
                                    Console.WriteLine("3. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string sectorObarrioD4 = Console.ReadLine();

                                    while (!secObarD4)
                                    {
                                        switch (sectorObarrioD4)
                                        {
                                            case "1":
                                                bool sectorD4valido = false;
                                                Console.WriteLine($"Seleccione un sector del {distrito[index]}");
                                                Console.WriteLine("1. Benedicto Valverde");
                                                Console.WriteLine("2. Las Tórres");
                                                Console.WriteLine("3. Hilario Sanchez");
                                                Console.WriteLine("4. Pedro Joaquín");
                                                Console.WriteLine("5. Chamorro");
                                                Console.WriteLine("6. Domitila Lugo");
                                                Console.WriteLine("7. Selim Shible");
                                                Console.WriteLine("8. Santa Clara");
                                                Console.WriteLine("9. Atras");
                                                Console.Write("Ingrese su opción: ");
                                                string sectorD4 = Console.ReadLine();

                                                while (sectorD4valido)
                                                {
                                                    switch (sectorD4)
                                                    {
                                                        case "1":
                                                            sector[index] = "Benedicto Valverde";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "2":
                                                            sector[index] = "Las Tórres";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "3":
                                                            sector[index] = "Hilario Sanchez";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "4":
                                                            sector[index] = "Pedro Joaquín";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "5":
                                                            sector[index] = "Chamorro";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "6":
                                                            sector[index] = "Domitila Lugo";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "7":
                                                            sector[index] = "Selim Shible";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "8":
                                                            sector[index] = "Santa Clara";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4 = true;
                                                            break;
                                                        case "9":
                                                            secObarD4 = true;
                                                            break;

                                                        default:
                                                            Console.WriteLine("Opción inválida");
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "2":
                                                bool barrioD4valido = false;
                                                Console.WriteLine($"Seleccione un barrio del {distrito[index]}");
                                                Console.WriteLine("1. Barrio San José Oriental");
                                                Console.WriteLine("2. Barrio San José Occidental");
                                                Console.WriteLine("3. Barrio San José Central");
                                                Console.WriteLine("4. Barrio San José Sur");
                                                string barrioD4 = Console.ReadLine();

                                                while (barrioD4valido)
                                                {
                                                    switch (barrioD4)
                                                    {
                                                        case "1":
                                                            barrio[index] = "Barrio San José Oriental";
                                                            break;
                                                        case "2":
                                                            barrio[index] = "Barrio San José Occidental";
                                                            break;
                                                        case "3":
                                                            barrio[index] = "Barrio San José Central";
                                                            break;
                                                        case "4":
                                                            barrio[index] = "Barrio San José Sur";
                                                            break;
                                                        case "5":
                                                            barrioD4valido = true;
                                                            break;

                                                        default:
                                                            Console.WriteLine("Opción inválida");
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "3":
                                                secObarD4 = true;
                                                break;

                                            default:
                                                Console.WriteLine("Opción inválida");
                                                break;
                                        }
                                    }
                                    break;


                                case "5":
                                    distrito[index] = "Distrito V";
                                    break;


                                case "6":
                                    distrito[index] = "Distrito VI";
                                    break;


                                case "7":
                                    distrito[index] = "Distrito VII";
                                    break;

                                case "8":
                                    dvalido = true;
                                    break;


                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opción inválida");
                                    Console.WriteLine("Presione cualquier tecla para continuar...");
                                    break;
                            }
                        }

                        dvalido = false;











                        /*
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
                        
                         */
                        if (dvalido == false)
                        {
                            bool obsvalido = false;
                            Console.WriteLine("Ingrese el tipo de obstrucción: ");
                            Console.WriteLine("1. Obras de construcción");
                            Console.WriteLine("2. Inundaciones");
                            Console.WriteLine("3. Accidentes de tránsito");
                            Console.WriteLine("4. Tráfico congestionado");
                            Console.WriteLine("5. Atras");
                            string obsts = Console.ReadLine();

                            while (!obsvalido)
                            {
                                switch (obsts)
                                {
                                    case "1":
                                        tipoObstru[index] = "Obras de construcción";
                                        obsvalido = true;
                                        break;
                                    case "2":
                                        tipoObstru[index] = "Inundaciones";
                                        obsvalido = true;
                                        break;
                                    case "3":
                                        tipoObstru[index] = "Accidentes de tránsito";
                                        obsvalido = true;
                                        break;
                                    case "4":
                                        tipoObstru[index] = "Tráfico congestionado";
                                        obsvalido = true;
                                        break;
                                    case "5":
                                        obsvalido = true;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                                        Console.WriteLine("Presione cualquier tecla para continuar...");
                                        Console.ReadLine();
                                        obsvalido = false;
                                        break;

                                }
                            }
                            

                            Console.WriteLine();
                            Console.WriteLine("¡La vía obstruida ha sido registrada con éxito!");

                            contadorViasObstruidas++;

                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadLine();
                        }


                        

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR: Máximo de vías registradas alcanzado");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                    }
                    break;

                case "2":
                    if (contadorViasObstruidas > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Listado de vías obstruidas registradas:");
                        Console.WriteLine("-----------------------");

                        for (int x = 1; x < contadorViasObstruidas; x++)
                        {
                            Console.WriteLine($"ID: {idViaObstruida[x]}");
                            Console.WriteLine($"Distrito: {distrito[x]}");
                            Console.WriteLine($"Barrio: {barrio[x]}");
                            Console.WriteLine($"Sector: {sector[x]}");
                            Console.WriteLine($"Comarca: {comarca[x]}");
                            Console.WriteLine($"Tipo de obstrucción: {tipoObstru[x]}");
                            Console.WriteLine($"Reportante: {nameUsu[x]}");
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

                case "3":
                    Console.Clear();
                    Console.WriteLine("Cerrando algoritmo...");
                    salir = true;  
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

        } 

        Console.WriteLine("¡Gracias por utilizar nuestro algoritmo!");
    }
}
