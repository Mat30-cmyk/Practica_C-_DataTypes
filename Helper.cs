using System;

namespace NameCAI_Sln
{
    public class Helper
    {
        public void Menu()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Enteros");
                Console.WriteLine("2. Strings");
                Console.WriteLine("3. Arreglos");
                Console.WriteLine("4. Booleanas");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==========================");
                Console.Write("Selecciona una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            ProcesarEnteros();
                            break;
                        case 2:
                            ProcesarStrings();
                            break;
                        case 3:
                            ProcesarArreglos();
                            break;
                        case 4:
                            ProcesarBooleanos();
                            break;
                        case 5:
                            opcion = 9999; // Salir
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intenta de nuevo.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("❌ Error: Debes ingresar un número entero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ Ocurrió un error inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 9999);
        }
        private void ProcesarEnteros()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Operaciones con Enteros ===");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Radicación");
                Console.WriteLine("6. Volver");
                Console.Write("Selecciona una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingresa el primer número: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el segundo número: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {a + b}");
                            break;
                        case 2:
                            Console.Write("Ingresa el primer número: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el segundo número: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {a - b}");
                            break;
                        case 3:
                            Console.Write("Ingresa el primer número: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el segundo número: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {a * b}");
                            break;
                        case 4:
                            Console.Write("Ingresa el numerador: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el denominador: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            if (b != 0)
                                Console.WriteLine($"Resultado: {a / b}");
                            else
                                Console.WriteLine("❌ No se puede dividir entre cero.");
                            break;
                        case 5:
                            Console.Write("Ingresa el número: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el índice de la raíz: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Math.Pow(a, 1 / b)}");
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("⚠️ Entrada no válida.");
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }
        private void ProcesarStrings()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Operaciones con Cadenas ===");
                Console.WriteLine("1. Concatenar");
                Console.WriteLine("2. Buscar texto");
                Console.WriteLine("3. Cambiar formato (mayúsculas/minúsculas)");
                Console.WriteLine("4. Volver");
                Console.Write("Selecciona una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Primera cadena: ");
                            string s1 = Console.ReadLine();
                            Console.Write("Segunda cadena: ");
                            string s2 = Console.ReadLine();
                            Console.WriteLine($"Resultado: {s1 + s2}");
                            break;
                        case 2:
                            Console.Write("Texto base: ");
                            string texto = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(texto))
                            {
                                Console.WriteLine("⚠️ El texto base no puede estar vacío.");
                                break;
                            }

                            Console.Write("Palabra a buscar: ");
                            string buscar = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(buscar))
                            {
                                Console.WriteLine("⚠️ La palabra a buscar no puede estar vacía.");
                                break;
                            }

                            // Buscar ignorando mayúsculas y minúsculas
                            int posicion = texto.IndexOf(buscar, StringComparison.OrdinalIgnoreCase);

                            if (posicion != -1)
                            {
                                Console.WriteLine($"✅ Palabra encontrada en la posición {posicion} del texto.");
                            }
                            else
                            {
                                Console.WriteLine("❌ Palabra no encontrada.");
                            }
                            break;
                        case 3:
                            Console.Write("Texto: ");
                            string t = Console.ReadLine();
                            Console.WriteLine("1. Mayúsculas\n2. Minúsculas");
                            int formato = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(formato == 1 ? t.ToUpper() : t.ToLower());
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("⚠️ Entrada no válida.");
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }
        private void ProcesarArreglos()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Operaciones con Arreglos ===");
                Console.WriteLine("1. Crear arreglo");
                Console.WriteLine("2. Ordenar arreglo");
                Console.WriteLine("3. Buscar elemento");
                Console.WriteLine("4. Unir dos arreglos");
                Console.WriteLine("5. Volver");
                Console.Write("Selecciona una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Tamaño del arreglo: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[n];

                            for (int i = 0; i < n; i++)
                            {
                                Console.Write($"Elemento {i + 1}: ");
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.WriteLine("\n✅ Arreglo creado correctamente.");
                            Console.WriteLine("📋 Arreglo ingresado: " + string.Join(", ", arr));
                            break;

                        case 2:
                            Console.Write("Tamaño del arreglo: ");
                            int t = Convert.ToInt32(Console.ReadLine());
                            int[] nums = new int[t];

                            for (int i = 0; i < t; i++)
                            {
                                Console.Write($"Elemento {i + 1}: ");
                                nums[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            Array.Sort(nums);
                            Console.WriteLine("\n✅ Arreglo ordenado correctamente.");
                            Console.WriteLine("📋 Arreglo ordenado: " + string.Join(", ", nums));
                            break;

                        case 3:
                            Console.Write("Tamaño del arreglo: ");
                            int tam = Convert.ToInt32(Console.ReadLine());
                            int[] datos = new int[tam];

                            for (int i = 0; i < tam; i++)
                            {
                                Console.Write($"Elemento {i + 1}: ");
                                datos[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.Write("\nNúmero a buscar: ");
                            int buscar = Convert.ToInt32(Console.ReadLine());

                            int pos = Array.IndexOf(datos, buscar);
                            if (pos != -1)
                                Console.WriteLine($"✅ Elemento encontrado en la posición {pos + 1}.");
                            else
                                Console.WriteLine("❌ Elemento no encontrado.");
                            break;

                        case 4:
                            Console.WriteLine("🔹 Primer arreglo (3 elementos):");
                            int[] a1 = new int[3];
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write($"Elemento {i + 1}: ");
                                a1[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.WriteLine("\n🔹 Segundo arreglo (3 elementos):");
                            int[] a2 = new int[3];
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write($"Elemento {i + 1}: ");
                                a2[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            int[] union = new int[a1.Length + a2.Length];
                            a1.CopyTo(union, 0);
                            a2.CopyTo(union, a1.Length);

                            Console.WriteLine("\n✅ Arreglos unidos correctamente.");
                            Console.WriteLine("📋 Resultado: " + string.Join(", ", union));
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("⚠️ Entrada no válida.");
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }
        private void ProcesarBooleanos()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Operaciones Booleanas ===");
                Console.WriteLine("1. Comparar dos números");
                Console.WriteLine("2. Evaluar si un número es par");
                Console.WriteLine("3. Generar valor aleatorio (true/false)");
                Console.WriteLine("4. Volver");
                Console.Write("Selecciona una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Número 1: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Número 2: ");
                            int y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(x == y ? "Son iguales" : "Son diferentes");
                            break;
                        case 2:
                            Console.Write("Número: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(num % 2 == 0 ? "Es par" : "Es impar");
                            break;
                        case 3:
                            Random rnd = new Random();
                            bool valor = rnd.Next(0, 2) == 1;
                            Console.WriteLine($"Valor generado: {valor}");
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("⚠️ Entrada no válida.");
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (true);
        }
    }
}
