//Nombre del Autor: Luis Eduardo Santiago Mendoza
//Fecha:29-06-2016
//Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luis_santiago_65
{
    class Program
    {
        static void Main(string[] args)
        {
            string contrasena = "";
            int intentos = 0;
            do
            {
                Portada();
                Console.Write("\nIngrese la contraseña: ");
                contrasena = Console.ReadLine();
                if (contrasena == "301303")
                {
                    intentos = 0;
                    Menu();
                }
                else
                {
                    intentos++;
                    Console.WriteLine("Contraseña incorrecta.");
                    Console.WriteLine("Presione una tecla para reintentar...");
                    Console.ReadKey();
                }
            } while (intentos < 2);
            if (intentos >= 2)
            {
                Console.WriteLine("Ha superado el número de intentos máximos permitidos.");
            }
            Console.WriteLine("\nPresione una tecla para terminar...");
            Console.ReadKey();
        }

        public static void Portada()
        {
            Console.Clear();
            Console.WriteLine("UNAD");
            Console.WriteLine("Universidad Nacional Abierta y a Distancia");
            Console.WriteLine("Escuela de Ciencias Básicas Tecnología e Ingenierías");
            Console.WriteLine("ECBTI");
            Console.WriteLine("Programa: Ingeniería de Telecomunicaciones");
            Console.WriteLine("Curso: ALGORITMOS 301303");
            Console.WriteLine("Tutora: EYDY DEL CARMEN SUAREZ");
            Console.WriteLine("Grupo: 301303_65");
            Console.WriteLine("Evaluación final: Práctica de laboratorio");
            Console.WriteLine("Valledupar, Cesar");
            Console.WriteLine("29-06-2016");
        }

        public static void Menu()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menú");
                Console.WriteLine("1. Cerrar sesión");
                Console.WriteLine("2. Definición de Diagrama de flujo de datos");
                Console.WriteLine("3. Definición de Algoritmos");
                Console.WriteLine("4. Definición de Condicional");
                Console.WriteLine("5. Ejemplo con condicional");
                Console.WriteLine("6. Definición de Ciclo");
                Console.WriteLine("7. Definición de Tipos de Ciclos");
                Console.WriteLine("8. Ejemplo de Ciclos");
                Console.WriteLine("9. Definición de Contador");
                Console.WriteLine("10. Ejemplo de Contador");
                Console.WriteLine("11. Definición de Acumulador");
                Console.WriteLine("12. Ejemplo de Acumulador");
                Console.WriteLine("13. Nombre del autor - CEAD - Código");
                Console.WriteLine("14. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        CerrarSesion();
                        return;
                    case 2:
                        DefinicionDiagrama();
                        break;
                    case 3:
                        DefinicionAlgoritmos();
                        break;
                    case 4:
                        DefinicionCondicional();
                        break;
                    case 5:
                        EjemploCondicional();
                        break;
                    case 6:
                        DefinicionCiclo();
                        break;
                    case 7:
                        DefinicionTiposDeCiclos();
                        break;
                    case 8:
                        EjemploCiclos();
                        break;
                    case 9:
                        DefinicionContador();
                        break;
                    case 10:
                        EjemploContador();
                        break;
                    case 11:
                        DefinicionAcumulador();
                        break;
                    case 12:
                        EjemploAcumulador();
                        break;
                    case 13:
                        NombreAutor();
                        break;
                    case 14:
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Ha seleccionado una opción incorrecta.");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para volver...");
                Console.ReadKey();
                opcion = 0;
            } while (opcion < 1 || opcion > 14);
        }

        public static void CerrarSesion()
        {
            Console.WriteLine("Cerrando sesión...");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void DefinicionDiagrama()
        {
            Console.WriteLine("2. Definición de Diagrama de flujo de datos");
            Console.WriteLine("Es un gráfico lógico del plan de trabajo que se ejecutará para la solución de un determinado problema. A través de él, se planifica la solución del problema independiente del lenguaje de computación a usar. De esta manera se separa loas instrucción es un lenguaje determinado con todas las reglas.");
        }

        public static void DefinicionAlgoritmos()
        {
            Console.WriteLine("3. Definición de Algoritmos");
            Console.WriteLine("Un Algoritmo, se puede definir como una secuencia de instrucciones que representan un modelo de solución para determinado tipo de problemas. O bien como un conjunto de instrucciones que realizadas en orden conducen a obtener la solución de un problema. Por lo tanto podemos decir que es un conjunto ordenado y finito de pasos que nos permite solucionar un problema. "
                + "\n"
                + "Los algoritmos son independientes de los lenguajes de programación.En cada problema el algoritmo puede escribirse y luego ejecutarse en un lenguaje de diferente programación.El algoritmo es la infraestructura de cualquier solución, escrita luego en cualquier lenguaje de programación.");
        }

        public static void DefinicionCondicional()
        {
            Console.WriteLine("4. Definición de Condicional");
            Console.WriteLine("Un condicional en la programación es una sentencia o grupo de sentencias que puede ejecutarse o no en función del valor de una condición."
                + "Los tipos más conocidos de condicionales son el SI(IF) y el SEGÚN(case o switch), aunque también podríamos mencionar al lanzamiento de errores como una alternativa más moderna para evitar el 'anidamiento' de condicionales."
                + "Los condicionales constituyen junto con los bucles los pilares de la programación estructurada, y su uso es una evolución de una sentencia de lenguaje ensamblador que ejecutaba la siguiente línea o no en función del valor de una condición.");
        }

        public static void EjemploCondicional()
        {
            Console.WriteLine("5. Ejemplo con condicional");
            Console.WriteLine("\nEjercicio 1: Leer 4 números por teclado e indicar si la suma de los 3 primeros es igual al 4to número.");
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            Console.Write("\nIngrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el tercer número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el cuarto número: ");
            n4 = int.Parse(Console.ReadLine());
            if (n1 + n2 + n3 == n4)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", n1, n2, n3, n4);
                Console.WriteLine("La suma de los tres primeros es igual al cuarto número.");
            }
            else
            {
                Console.WriteLine("{0} + {1} + {2} != {3}", n1, n2, n3, n4);
                Console.WriteLine("La suma de los tres primeros NO es igual al cuarto número.");
            }
        }

        public static void DefinicionCiclo()
        {
            Console.WriteLine("6. Definición de Ciclo");
            Console.WriteLine("Un bucle o ciclo, en programación, es una sentencia que se realiza repetidas veces a un trozo aislado de código, hasta que la condición asignada a dicho bucle deje de cumplirse."
                + "\n"
                + "Generalmente, un bucle es utilizado para hacer una acción repetida sin tener que escribir varias veces el mismo código, lo que ahorra tiempo, deja el código más claro y facilita su modificación en el futuro.");
        }

        public static void DefinicionTiposDeCiclos()
        {
            Console.WriteLine("7. Definición de Tipos de Ciclos");
            Console.WriteLine("Los tres bucles (ciclos) más utilizados en programación son el bucle while, el bucle for y el bucle repetir.");
            Console.WriteLine("\nEl bucle while o bucle mientras es una estructura de la mayoría de los lenguajes de programación estructurados cuyo propósito es repetir un bloque de código mientras una condición se mantenga verdadera.");
            Console.WriteLine("\nEl bucle for o ciclo for es una estructura de control en programación en la que se puede indicar de antemano el número mínimo de iteraciones que la instrucción realizará. Está disponible en casi todos los lenguajes de programación imperativos.");
            Console.WriteLine("\nEl bucle repetir comprueba la condición de finalización al final del cuerpo del bucle, y si ésta es cierta continua con el resto del programa, a veces esto resulta más adecuado.");
        }

        public static void EjemploCiclos()
        {
            int ciclo;
            do
            {
                Console.Clear();
                Console.WriteLine("8. Ejemplo de Ciclos");
                Console.WriteLine("Tipos de ciclos:");
                Console.WriteLine("1. Ciclo para");
                Console.WriteLine("2. Ciclo mientras");
                Console.WriteLine("3. Ciclo repita");
                Console.WriteLine("4. Volver");
                Console.Write("Seleccione una opción: ");
                ciclo = int.Parse(Console.ReadLine());
            } while (ciclo < 1 || ciclo > 4);
            Console.Clear();
            switch (ciclo)
            {
                case 1:
                    CicloPara();
                    break;
                case 2:
                    CicloMientras();
                    break;
                case 3:
                    CicloRepita();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }
        }

        public static void DefinicionContador()
        {
            Console.WriteLine("9. Definición de Contador");
            Console.WriteLine("Es una variable en la memoria que se incrementará en una unidad cada vez que se ejecute el proceso."
                + "\n"
                + "El contador se utiliza para llevar la cuenta de determinadas acciones que se pueden solicitar durante la resolución de un problema."
                + "\n"
                + "En las instrucciones de preparación se realiza la inicialización del contador o contadores.La inicialización consiste en poner el valor inicial de la variable que representa al contador.Generalmente se inicializa con el valor 0.");
        }

        public static void EjemploContador()
        {
            Console.WriteLine("10. Ejemplo de Contador");
            Console.WriteLine("Ejercicio 12: Realizar un algoritmo que permita realizar una encuesta (a n personas) para las siguientes elecciones presidenciales en Colombia con los candidatos inscritos en el momento");
            int amarillos = 0, azules = 0, rojos = 0;
            int encuestados = 0, votantes = 0;
            char encuestar = 's';
            do
            {
                if (encuestar == 's')
                {
                    encuestados++;
                    Console.WriteLine("\nEncuestado # {0}", encuestados);
                    char votar;
                    do
                    {
                        Console.Write("\n¿Va a votar? (S/N): ");
                        votar = char.ToLower(Console.ReadKey().KeyChar);
                    } while (votar != 's' && votar != 'n');
                    if (votar == 's')
                    {
                        votantes++;
                        int partido;
                        do
                        {
                            Console.WriteLine("\nEstos son los partidos inscritos en el momento:");
                            Console.WriteLine("1. Partido Amarillo");
                            Console.WriteLine("2. Partido Azul");
                            Console.WriteLine("3. Partido Rojo");
                            Console.Write("Seleccione el partido por el que va a votar: ");
                            partido = int.Parse(Console.ReadLine());
                        } while (partido < 1 || partido > 3);
                        switch (partido)
                        {
                            case 1:
                                amarillos++;
                                break;
                            case 2:
                                azules++;
                                break;
                            case 3:
                                rojos++;
                                break;
                            default:
                                Console.WriteLine("Partido no válido.");
                                break;
                        }
                    }
                }
                Console.Write("\n¿Desea encuestar otra persona? (S/N): ");
                encuestar = char.ToLower(Console.ReadKey().KeyChar);
            } while (encuestar != 'n');
            int abstencionistas = encuestados - votantes;
            float porcentajeAbstencion = (float)abstencionistas / encuestados;
            Console.WriteLine("\n\nResultados de la encuesta.");
            Console.WriteLine("\nEl porcentaje de votantes es: {0}%", (float)votantes * 100 / encuestados);
            Console.WriteLine("\nEl porcentaje de abstencionistas es: {0}%", porcentajeAbstencion * 100);
            if (votantes != 0)
            {
                string partidoRepunteando = "";
                if (amarillos >= azules && amarillos >= rojos)
                {
                    partidoRepunteando = "Partido Amarillo";
                }
                if (azules >= amarillos && azules >= rojos)
                {
                    partidoRepunteando = "Partido Azul";
                }
                if (rojos >= amarillos && rojos >= azules)
                {
                    partidoRepunteando = "Partido Rojo";
                }
                Console.WriteLine("\nEl partido que está repunteando es el: {0}.", partidoRepunteando);
                Console.WriteLine("\nPorcentaje de votantes por partido:");
                Console.WriteLine("Partido Amarillo: {0}%", (float)amarillos * 100 / votantes);
                Console.WriteLine("Partido Azul: {0}%", (float)azules * 100 / votantes);
                Console.WriteLine("Partido Rojo: {0}%", (float)rojos * 100 / votantes);
            }
        }

        public static void DefinicionAcumulador()
        {
            Console.WriteLine("11. Definición de Acumulador");
            Console.WriteLine("Un acumulador es una variable en la memoria cuya misión es almacenar cantidades variables."
                + "\n"
                + "Se utiliza para efectuar sumas sucesivas. La principal diferencia con el contador es que el incremento o decremento de cada suma es variable en lugar de constante como en el caso del contador.");
        }

        public static void EjemploAcumulador()
        {
            Console.WriteLine("12. Ejemplo de Acumulador");
            Console.WriteLine("Ejercicio propuesto: Realizar un programa que registre n números y calcule: el promedio general y la suma de los impares.");
            int n = 0;
            float total = 0;
            float promedio = 0;
            float sumaImpares = 0;
            char seguir = 's';
            while (seguir == 's')
            {
                n++;
                Console.WriteLine("\nElemento # {0}", n);
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                total += num;
                if (num % 2 != 0)
                {
                    sumaImpares += num;
                }
                do
                {
                    Console.Write("\n¿Desea registrar otro número? (S/N): ");
                    seguir = char.ToLower(Console.ReadKey().KeyChar);
                } while (seguir != 's' && seguir != 'n');
            }
            promedio = total / n;
            Console.WriteLine("\nEl promedio general es: {0}", promedio);
            Console.WriteLine("La suma de los impares es: {0}", sumaImpares);
        }

        public static void NombreAutor()
        {
            Console.WriteLine("13. Nombre del autor - CEAD - Código");
            Console.WriteLine("Autor: Luis Eduardo Santiago Mendoza");
            Console.WriteLine("CEAD: UNAD Valledupar");
            Console.WriteLine("Código: ");
        }

        public static void Salir()
        {
            Console.WriteLine("¡Hasta luego!");
            Console.WriteLine("\nPresione una tecla para terminar...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void CicloPara()
        {
            Console.WriteLine("8.1 Ciclo para");
            Console.WriteLine("Ejercicio 10: Diseñar un Algoritmo que lea un número entero (lado) y a partir de él cree un cuadrado de asteriscos con ese tamaño."
                + "/n"
                + "Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.");
            char simbolo = '*';
            Console.Write("Ingrese el tamaño del lado del cuadrado: ");
            int n = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n)
                    {
                        Console.Write(simbolo);
                    }
                    else if (j == 1 || j == n)
                    {
                        Console.Write(simbolo);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }

        public static void CicloMientras()
        {
            Console.WriteLine("8.2 Ciclo mientras");
            Console.WriteLine("Ejercicio 11: La serie fibonacci es un ejercicio interesante, el cual se construye a partir de los dos primeros números que son el 0 y 1, y a partir de ahí se construye la serie ejemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55..."
                + "\n"
                + "Desarrollar un algoritmo que permita, calcular n números de esta serie.");
            int fibo, anterior, siguiente; anterior = 1;
            siguiente = 0;
            Console.Write("Ingrese la cantidad de números de la serie que desea obtener: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Los primeros {0} números de la serie Fibonacci son: ", n);
            Console.Write(0 + ", ");
            while ((n--) > 1)
            {
                fibo = anterior + siguiente;
                anterior = siguiente;
                siguiente = fibo;
                Console.Write(fibo + ", ");
            }
        }

        public static void CicloRepita()
        {
            Console.WriteLine("8.3 Ciclo repita");
            Console.WriteLine("Ejercicio 14.b: Realizar un programa que permita dibujar un triángulo con * (asteriscos), de acuerdo a la fórmula y con la utilización de ciclos.");
            int x = 0;
            Console.Write("Ingrese la altura del triángulo: ");
            x = int.Parse(Console.ReadLine());
            int y = x * 2;
            int contador = 0;
            do
            {
                for (int espacios = x - 1; espacios >= contador; espacios--)
                {
                    Console.Write(" ");
                }
                for (int asteriscos = 0; asteriscos <= (1 * contador + contador); asteriscos++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                contador++;
            } while (contador < x);
        }
    }
}
