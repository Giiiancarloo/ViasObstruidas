using System;

class ProgramaRegistroVias
{
    //INICIO DE MÉTODOS PARA EL LOGIN
    static string rutaArchivo = "usuarios.txt";

    static void RegistrarUsuario()
    {
        Console.WriteLine("\n--- Registro de Usuario ---");
        Console.Write("Nuevo usuario: ");
        string usuario = Console.ReadLine();

        if (UsuarioExiste(usuario))
        {
            Console.WriteLine("El usuario ya existe.");
            return;
        }

        Console.Write("Nueva contraseña: ");
        string contrasena = LeerContrasena();

        File.AppendAllText(rutaArchivo, $"{usuario},{contrasena}{Environment.NewLine}");
        Console.WriteLine("\nUsuario registrado exitosamente.");
    }

    static void IniciarSesion()
    {
        Console.WriteLine("\n--- Inicio de Sesión ---");
        Console.Write("Usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Contraseña: ");
        string contrasena = LeerContrasena();

        if (ValidarCredenciales(usuario, contrasena))
        {
            Console.WriteLine("\n¡Inicio de sesión exitoso!");
            MostrarMenuUsuario(usuario);
        }
        else
        {
            Console.WriteLine("\nUsuario o contraseña incorrectos.");
        }
    }

    static void MostrarMenuUsuario(string usuario)
    {
        int opcion1;
        do
        {
            Console.Clear();
            Console.WriteLine($"=== Menú De Usuario (Usuario: {usuario}) ===");
            Console.WriteLine("1. Ver perfil");
            Console.WriteLine("2. Configuración");
            Console.WriteLine("3. Ayuda");
            Console.WriteLine("4. Cerrar sesión");
            Console.WriteLine("5. Menu vías obstruidas");
            Console.Write("Selecciona una opción (1-5): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out opcion1))
            {
                switch (opcion1)
                {
                    case 1:
                        Console.WriteLine("Mostrando perfil...");
                        break;
                    case 2:
                        Console.WriteLine("Entrando a configuración...");
                        break;
                    case 3:
                        Console.WriteLine("Mostrando ayuda...");
                        break;
                    case 4:
                        Console.WriteLine("Cerrando sesión...");
                        break;
                    case 5:
                         MenuVias(usuario);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                opcion1 = 0;
            }

            if (opcion1 != 5)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion1 != 5);
    }

    static bool UsuarioExiste(string usuario)
    {
        if (!File.Exists(rutaArchivo))
            return false;

        string[] lineas = File.ReadAllLines(rutaArchivo);
        foreach (string linea in lineas)
        {
            string[] partes = linea.Split(',');
            if (partes[0] == usuario)
                return true;
        }
        return false;
    }

    static bool ValidarCredenciales(string usuario, string contrasena)
    {
        if (!File.Exists(rutaArchivo))
            return false;

        string[] lineas = File.ReadAllLines(rutaArchivo);
        foreach (string linea in lineas)
        {
            string[] partes = linea.Split(',');
            if (partes.Length == 2 && partes[0] == usuario && partes[1] == contrasena)
                return true;
        }
        return false;
    }

    static string LeerContrasena()
    {
        string contrasena = "";
        ConsoleKeyInfo tecla;

        do
        {
            tecla = Console.ReadKey(true);

            if (tecla.Key != ConsoleKey.Backspace && tecla.Key != ConsoleKey.Enter)
            {
                contrasena += tecla.KeyChar;
                Console.Write("*");
            }
            else if (tecla.Key == ConsoleKey.Backspace && contrasena.Length > 0)
            {
                contrasena = contrasena.Substring(0, contrasena.Length - 1);
                int pos = Console.CursorLeft;
                Console.SetCursorPosition(pos - 1, Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(pos - 1, Console.CursorTop);
            }
        } while (tecla.Key != ConsoleKey.Enter);

        return contrasena;
    }


    //Arreglos para el registro de vías obstruidas
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
    static void OpcionesVias()
    {
        Console.Clear();
        Console.WriteLine("Algoritmo para el registro y monitoreo de vías con sugerencia de trayectos alternos en Managua");
        Console.WriteLine();
        Console.WriteLine("MENU DEL ALGORITMO");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Registrar vía obstruida");
        Console.WriteLine("2. Listar vías obstruidas");
        Console.WriteLine("3. Cambiar usuario");
        Console.Write("Ingrese su opción: ");
    }

    static void OpcInvalida()
    {
        Console.Clear();
        Console.WriteLine("¡Opción inválida!");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadLine();
    }

    //Método de el menu de vías obstruidas
    static void MenuVias(string usuario)
    {
        bool salir = false;
        while (!salir)
        {
            OpcionesVias();
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    //Condicion de "if" para verificar que la cantidad de vias obstruidas registradas no pase el límite establecido
                    if (contadorViasObstruidas <= MAX_VIAS_OBSTRUIDAS)
                    {
                        int index = contadorViasObstruidas;

                        idViaObstruida[index] = index;

                        bool atrasobstru = false;

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
                                    Console.Clear();
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
                                                atrasobstru = true;
                                                break;
                                            default:
                                                OpcInvalida();
                                                atrasobstru = true;
                                                secD1valido = true;
                                                break;
                                        }
                                    }
                                    break;

                                case "2":
                                    Console.Clear();
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
                                                Console.Clear();
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
                                                            OpcInvalida();
                                                            atrasobstru = true;
                                                            comarcaD2valido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                    }
                                                }

                                                break;

                                            case "2":
                                                Console.Clear();
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
                                                            OpcInvalida();
                                                            atrasobstru = true;
                                                            sectorD2valido = true;
                                                            comOsecvalido = true;
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "3":
                                                comOsecvalido = true;
                                                atrasobstru = true;
                                                break;

                                            default:
                                                OpcInvalida();
                                                comOsecvalido = true;
                                                atrasobstru = true;
                                                break;
                                        }
                                    }
                                    break;


                                case "3":
                                    Console.Clear();
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
                                                secD3valido = true;
                                                atrasobstru = true;
                                                break;
                                            default:
                                                OpcInvalida();
                                                secD3valido = true;
                                                atrasobstru = true;
                                                break;
                                        }
                                    }

                                    break;


                                case "4":
                                    Console.Clear();
                                    bool secObarD4valido = false;
                                    distrito[index] = "Distrito IV";
                                    Console.WriteLine($"Seleccione una opción del {distrito[index]}");
                                    Console.WriteLine("1. Sector");
                                    Console.WriteLine("2. Barrio");
                                    Console.WriteLine("3. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string sectorObarrioD4 = Console.ReadLine();

                                    while (!secObarD4valido)
                                    {
                                        switch (sectorObarrioD4)
                                        {
                                            case "1":
                                                Console.Clear();
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

                                                while (!sectorD4valido)
                                                {
                                                    switch (sectorD4)
                                                    {
                                                        case "1":
                                                            sector[index] = "Benedicto Valverde";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "2":
                                                            sector[index] = "Las Tórres";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "3":
                                                            sector[index] = "Hilario Sanchez";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "4":
                                                            sector[index] = "Pedro Joaquín";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "5":
                                                            sector[index] = "Chamorro";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "6":
                                                            sector[index] = "Domitila Lugo";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "7":
                                                            sector[index] = "Selim Shible";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "8":
                                                            sector[index] = "Santa Clara";
                                                            sectorD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "9":
                                                            sectorD4valido = true;
                                                            secObarD4valido = true;
                                                            atrasobstru = true;
                                                            break;

                                                        default:
                                                            OpcInvalida();
                                                            atrasobstru = true;
                                                            secObarD4valido = true;
                                                            sectorD4valido = true;
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "2":
                                                Console.Clear();
                                                bool barrioD4valido = false;
                                                Console.WriteLine($"Seleccione un barrio del {distrito[index]}");
                                                Console.WriteLine("1. Barrio San José Oriental");
                                                Console.WriteLine("2. Barrio San José Occidental");
                                                Console.WriteLine("3. Barrio San José Central");
                                                Console.WriteLine("4. Barrio San José Sur");
                                                string barrioD4 = Console.ReadLine();

                                                while (!barrioD4valido)
                                                {
                                                    switch (barrioD4)
                                                    {
                                                        case "1":
                                                            barrio[index] = "Barrio San José Oriental";
                                                            barrioD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "2":
                                                            barrio[index] = "Barrio San José Occidental";
                                                            barrioD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "3":
                                                            barrio[index] = "Barrio San José Central";
                                                            barrioD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "4":
                                                            barrio[index] = "Barrio San José Sur";
                                                            barrioD4valido = true;
                                                            dvalido = true;
                                                            secObarD4valido = true;
                                                            break;
                                                        case "5":
                                                            barrioD4valido = true;
                                                            atrasobstru = true;
                                                            secObarD4valido = true;
                                                            break;

                                                        default:
                                                            OpcInvalida();
                                                            atrasobstru = true;
                                                            barrioD4valido=true;
                                                            secObarD4valido = true;
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "3":
                                                secObarD4valido = true;
                                                atrasobstru = true;
                                                break;

                                            default:
                                                OpcInvalida();
                                                atrasobstru =true;
                                                secObarD4valido = true;
                                                break;
                                        }
                                    }
                                    break;

                                case "5":
                                    Console.Clear();
                                    bool secObarD5 = false;
                                    distrito[index] = "Distrito V";
                                    Console.WriteLine($"Seleccione una opción del {distrito[index]}");
                                    Console.WriteLine("1. Sector");
                                    Console.WriteLine("2. Barrio");
                                    Console.WriteLine("3. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string sectorObarrioD5 = Console.ReadLine();

                                    while (!secObarD5)
                                    {
                                        switch (sectorObarrioD5)
                                        {
                                            case "1":
                                                Console.Clear();
                                                bool sectorD5valido = false;
                                                Console.WriteLine($"Seleccione un sector del {distrito[index]}");
                                                Console.WriteLine("1. Centro América");
                                                Console.WriteLine("2. Loma del Valle");
                                                Console.WriteLine("3. Pantasma");
                                                Console.WriteLine("4. Granada 1");
                                                Console.WriteLine("5. Carlos Fonseca");
                                                Console.WriteLine("6. Don bosco");
                                                Console.WriteLine("7. Complejo MAO");
                                                Console.WriteLine("8. Nicarao");
                                                Console.WriteLine("9. Atras");
                                                Console.Write("Ingrese su opción: ");
                                                string sectorD5 = Console.ReadLine();
                                                while (!sectorD5valido)
                                                {
                                                    switch (sectorD5)
                                                    {
                                                        case "1":
                                                            sector[index] = "Centro America";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "2":
                                                            sector[index] = "Loma del Valle";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "3":
                                                            sector[index] = "Pantasma";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "4":
                                                            sector[index] = "Granada 1";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "5":
                                                            sector[index] = "Carlos Fonseca";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "6":
                                                            sector[index] = "Don Bosco";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "7":
                                                            sector[index] = "Complejo MAO";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "8":
                                                            sector[index] = "Nicarao";
                                                            sectorD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "9":
                                                            sectorD5valido = true;
                                                            atrasobstru = true;
                                                            secObarD5 = true;
                                                            break;
                                                        default:
                                                            OpcInvalida();
                                                            atrasobstru = true;
                                                            sectorD5valido = true;
                                                            secObarD5 = true;
                                                            break;
                                                    }
                                                }
                                                break;
                                            case "2":
                                                Console.Clear();
                                                bool barrioD5valido = false;
                                                Console.WriteLine($"Seleccione un barrio del {distrito[index]}");
                                                Console.WriteLine("1. Lomas de Santo Domingo");
                                                Console.WriteLine("2. Altamira");
                                                Console.WriteLine("3. Shick");
                                                Console.WriteLine("4. Atras");
                                                Console.Write("Ingrese su opción: ");
                                                string barrioD5 = Console.ReadLine();
                                                while (!barrioD5valido)
                                                {
                                                    switch (barrioD5)
                                                    {
                                                        case "1":
                                                            barrio[index] = "Lomas de Santo Domingo";
                                                            barrioD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "2":
                                                            barrio[index] = "Altamira";
                                                            barrioD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "3":
                                                            barrio[index] = "Shick";
                                                            barrioD5valido = true;
                                                            dvalido = true;
                                                            secObarD5 = true;
                                                            break;
                                                        case "4":
                                                            barrioD5valido = true;
                                                            atrasobstru = true;
                                                            secObarD5 = true;
                                                            break;
                                                        default:
                                                            OpcInvalida();
                                                            atrasobstru = true;
                                                            barrioD5valido = true;
                                                            secObarD5 = true;
                                                            break;
                                                    }
                                                }
                                                break;
                                            case "3":
                                                secObarD5 = true;
                                                atrasobstru = true;
                                                break;
                                        }

                                    }
                                    break;

                                case "6":
                                    Console.Clear();
                                    bool secD6valido = false;
                                    distrito[index] = "Distrito VI";
                                    Console.WriteLine($"Seleccione un sector del {distrito[index]}");
                                    Console.WriteLine("1. La Primavera");
                                    Console.WriteLine("2. Anexo La Primavera");
                                    Console.WriteLine("3. José Dolores Estrada");
                                    Console.WriteLine("4. Jorge Casally");
                                    Console.WriteLine("5. Estrada");
                                    Console.WriteLine("6. Los Rieles de Abajo");
                                    Console.WriteLine("7. Waspán Norte");
                                    Console.WriteLine("8. Hugo Chavez");
                                    Console.WriteLine("9. Villa Reconciliación Sur");
                                    Console.WriteLine("10. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string selecsectorD6 = Console.ReadLine();

                                    while (!secD6valido)
                                    {
                                        switch (selecsectorD6)
                                        {
                                            case "1":
                                                sector[index] = "La Primavera";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "2":
                                                sector[index] = "Anexo La Primavera";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "3":
                                                sector[index] = "José Dolores Estrada";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "4":
                                                sector[index] = "Jorge Casally";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "5":
                                                sector[index] = "Estrada";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "6":
                                                sector[index] = "Los Rieles de Abajo";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "7":
                                                sector[index] = "Waspán Norte";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "8":
                                                sector[index] = "Hugo Chavez";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "9":
                                                sector[index] = "Villa Reconciliación Sur";
                                                secD6valido = true;
                                                dvalido = true;
                                                break;
                                            case "10":
                                                secD6valido = true;
                                                atrasobstru = true;
                                                break;
                                            default:
                                                OpcInvalida();
                                                secD6valido = true;
                                                atrasobstru = true;
                                                break;
                                        }
                                    }
                                    break;

                                case "7":
                                    Console.Clear();
                                    bool secD7valido = false;
                                    distrito[index] = "Distrito VII";
                                    Console.WriteLine($"Seleccione un sector del {distrito[index]}");
                                    Console.WriteLine("1. Georgino Andrade");
                                    Console.WriteLine("2. Américas 1");
                                    Console.WriteLine("3. Villa San Jacinto");
                                    Console.WriteLine("4. Villa Fraternidad");
                                    Console.WriteLine("5. Anexo Villa San Jacinto");
                                    Console.WriteLine("6. Villa Revolución");
                                    Console.WriteLine("7. 10 de Enero");
                                    Console.WriteLine("8. Primero de Mayo");
                                    Console.WriteLine("9. Villa Venezuela");
                                    Console.WriteLine("10. Atras");
                                    Console.Write("Ingrese su opción: ");
                                    string selecsectorD7 = Console.ReadLine();
                                    while (!secD7valido)
                                    {
                                        switch (selecsectorD7)
                                        {
                                            case "1":
                                                sector[index] = "Georgino Andrade";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "2":
                                                sector[index] = "Américas 1";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "3":
                                                sector[index] = "Villa San Jacinto";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "4":
                                                sector[index] = "Villa Fraternidad";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "5":
                                                sector[index] = "Anexo Villa San Jacinto";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "6":
                                                sector[index] = "Villa Revolución";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "7":
                                                sector[index] = "10 de Enero";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "8":
                                                sector[index] = "Primero de Mayo";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "9":
                                                sector[index] = "Villa Venezuela";
                                                secD7valido = true;
                                                dvalido = true;
                                                break;
                                            case "10":
                                                secD7valido = true;
                                                atrasobstru = true;
                                                break;
                                            default:
                                                OpcInvalida();
                                                secD7valido = true;
                                                atrasobstru = true;
                                                break;
                                        }
                                    }
                                    break;

                                case "8":
                                    dvalido = true;
                                    atrasobstru = true;
                                    break;

                                default:
                                    dvalido = true;
                                    atrasobstru = true;
                                    OpcInvalida();
                                    break;
                            }

                            dvalido = false;
                            if (dvalido == false)
                            {
                                if (atrasobstru == false)
                                {
                                    Console.Clear();
                                    bool obsvalido = false;
                                    Console.WriteLine("Ingrese el tipo de obstrucción: ");
                                    Console.WriteLine("1. Obras de construcción");
                                    Console.WriteLine("2. Inundaciones");
                                    Console.WriteLine("3. Accidentes de tránsito");
                                    Console.WriteLine("4. Tráfico congestionado");
                                    Console.WriteLine("5. Cancelar registro de vía obstruida");
                                    Console.Write("Ingrese su opción: ");
                                    string obsts = Console.ReadLine();

                                    bool viaregistrada = false;
                                    while (!obsvalido)
                                    {
                                        switch (obsts)
                                        {
                                            case "1":
                                                tipoObstru[index] = "Obras de construcción";
                                                obsvalido = true;
                                                viaregistrada = true;
                                                dvalido = true;
                                                break;
                                            case "2":
                                                tipoObstru[index] = "Inundaciones";
                                                obsvalido = true;
                                                viaregistrada = true;
                                                dvalido = true;
                                                break;
                                            case "3":
                                                tipoObstru[index] = "Accidentes de tránsito";
                                                viaregistrada = true;
                                                dvalido = true;
                                                obsvalido = true;
                                                break;
                                            case "4":
                                                tipoObstru[index] = "Tráfico congestionado";
                                                obsvalido = true;
                                                viaregistrada = true;
                                                dvalido = true;
                                                break;
                                            case "5":
                                                obsvalido = true;
                                                dvalido = true;
                                                break;

                                            default:
                                                OpcInvalida();
                                                obsvalido = true;
                                                break;

                                        }
                                       
                                    }

                                    if (viaregistrada == true)
                                    {
                                        nameUsu[index] = usuario;
                                        Console.WriteLine();
                                        Console.WriteLine("¡La vía obstruida ha sido registrada con éxito!");
                                        Console.WriteLine("Presione cualquier tecla para continuar...");
                                        Console.ReadLine();
                                        contadorViasObstruidas++;
                                    }
                                }
                            }
                            dvalido = true;
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
                    Console.Clear();
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
                    Console.WriteLine("Cambiando de usuario...");
                    salir = true;
                    break;
                    
                //En caso de que la entrada de opción no sea ni 1, 2 o 3, se ejecutará el bloque "default"
                //mostrando un mensaje de error y volviendo a mostrar el menú
                default:
                    OpcInvalida();
                    break;
            }

        }
    }

    // Método principal que inicia el programa
    static void Main(string[] args)
    {
        //LOGIN EN MAIN
        int opcion1 = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Usuarios ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Salir del algoritmo");
            Console.Write("Selecciona una opción (1-3): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out opcion1))
            {
                switch (opcion1)
                {
                    case 1:
                        RegistrarUsuario();
                        break;
                    case 2:
                        IniciarSesion();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        Console.WriteLine("¡Gracias por utilizar nuestro algoritmo!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }

            if (opcion1 != 3)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion1 != 3);

    }  
}

