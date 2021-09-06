using System;

namespace Asignacion1
{
    class Program
    {
        //Capitulo #1 Ejercicio 1
        public static void ImprimirNombre()
        {
            Console.WriteLine("Nombre:Gabriel Bonifacio");
        }
        //Capitulo #1 Ejercicio 5
        public static void ImprimirDatos()
        {
            ImprimirNombre();
            Console.WriteLine("Direccion:SFM \nEdad:21 \nCarrera:Ingenieria en Sistemas \nCedula:056-1637532-0 \nEmail:GabirelB@Gmail.com");
        }
        //Menu
        public static void MenuCapitulo2()
        {
            int opcion = 0;
            Console.WriteLine("=============");
            Console.Write("1-Ejercicio#1 \n2-Ejercicio#3 \n3-Ejercicio#5\n");
            Console.WriteLine("=============");
            Console.Write("Opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Perimetros();
                    break;
                case 2:
                    Grados_A_Radianes();
                    break;
                case 3:
                    Dollar_Y_Euro();
                    break;
                case 4:
                    default:
                    Console.WriteLine("ERROR...");
                    break;

            }
        }
        //Menu
        public static void MenuCapitulo3()
        {
            int opc = 0;
            Console.WriteLine("==============");
            Console.WriteLine("1-Ejercicio#1\n2-Ejercicio#4");
            Console.WriteLine("==============");
            Console.Write("Opcion: ");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Par_O_Impar();
                    break;
                case 2:
                    DiasDeLaSemana();
                    break;
                default:
                    Console.WriteLine("ERROR....");
                    break;

            }

        }
        //Capitulo #3 Ejercicio 4
        public static void DiasDeLaSemana()
        {
            int num = 0;
            Console.Write("Digite un numero entre 1 y 7: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("ERROR....");
                    break;
            }
        }
        //Capitulo #3 ejercicio 1
        public static void Par_O_Impar()
        {
            int num=0;
            Console.Write("Digite un numero: ");

            num = Convert.ToInt32(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"El numero {num} es par");
                Console.WriteLine("=========================");
            }
            else
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"El numero {num} es impar");
                Console.WriteLine("=========================");
            }
        }
        //AQUI VAN TODOS LOS PERIMETROS
        public static void Perimetros()
        {
            int opcion = 0;
            Console.WriteLine("================================");
            Console.WriteLine("Perimetro de Poligonos Regulares");
            Console.WriteLine("================================");
            Console.WriteLine("==============");
            Console.Write("1-Triangulo\n2-Cuadrado\n3-Pentagono\n4-Hexagono\n5-Heptagono\n6-Octagono\n7-Eneagono\n8-Decagono" +
                "\n9-Undecagono\n10-Dodecagono\n");
            Console.WriteLine("==============\n");
            Console.Write("Opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    PerimetroTriangulo();
                    break;
                case 2:
                    PerimetroCuadrado();
                    break;
                case 3:
                    PerimetroPentagono();
                    break;
                case 4:
                    PerimetroHexagono();
                    break;
                case 5:
                    PerimetroHeptagono();
                    break;
                case 6:
                    PerimetroOctagono();
                    break;
                case 7:
                    PerimetroEneagono();
                    break;
                case 8:
                    PerimetroDecagono();
                    break;
                case 9:
                    PerimetroUndecagono();
                    break;
                case 10:
                    PerimetroDodecagono();
                    break;
                case 11:
                    default:
                    Console.WriteLine("ERROR...");
                    break;

            }
        }
        public static void PerimetroTriangulo()
        {
            double Lado1 = 0, Lado2 = 0, Lado3 = 0, Res = 0;

            Console.Write("Digite medida de un lado: ");
            Lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite medida de un lado: ");
            Lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite medida de un lado: ");
            Lado3 = Convert.ToDouble(Console.ReadLine());

            Res = Lado1 + Lado2 + Lado3;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Triangulo = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroCuadrado()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 4;
            Console.WriteLine("=================================");
            Console.WriteLine($"Perimetro del Cuadrado = {Res}cm");
            Console.WriteLine("=================================");
        }

        public static void PerimetroPentagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 5;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Pentagono = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroHexagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 6;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Hexagono = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroHeptagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 7;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Heptagono = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroOctagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 8;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Octagono = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroEneagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 9;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Eneagono = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroDecagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 10;
            Console.WriteLine("==================================");
            Console.WriteLine($"Perimetro del Decagono = {Res}cm");
            Console.WriteLine("==================================");
        }

        public static void PerimetroUndecagono()
        {
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 11;
            Console.WriteLine("====================================");
            Console.WriteLine($"Perimetro del Undecagono = {Res}cm");
            Console.WriteLine("====================================");
        }

        public static void PerimetroDodecagono() 
        { 
            double Lado = 0, Res = 0;
            Console.Write("Digite la medida de un lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Res = Lado * 12;
            Console.WriteLine("====================================");
            Console.WriteLine($"Perimetro del Dodecagono = {Res}cm");
            Console.WriteLine("====================================");
        }

        public static void Grados_A_Radianes()
        {
            double Grados = 0, Res = 0;
            double Pi = 3.1416;
            Console.WriteLine("==================================================");
            Console.Write("Digite la cantidad de grados que desea convertir: ");
           //Console.Write("==================================================");
           //Console.Write("Opcion: ");
            Grados = Convert.ToDouble(Console.ReadLine());
            Res = (Grados * Pi) / 180;
            Console.WriteLine("==================================================");
            Console.WriteLine($"{Grados} Grados = {Res} Radianes");
            Console.WriteLine("==================================================");
        }
        public static void Dollar_Y_Euro()
        {
            double Dollar = 0, Euro = 0, Res;
            int opc = 0;
            Console.WriteLine("============================");
            Console.Write("1-Convertir de Dollar a Euro\n2-Convertir de Euro A Dollar\n");
            Console.WriteLine("============================");
            Console.Write("Opcion: ");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("====================================");
                    Console.Write("Cuantos Dolares desea cambiar: ");
                    Dollar = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite el precio del Euro: ");
                    Euro = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("====================================");
                    Res = Dollar * Euro;
                    Console.WriteLine("==========================================");
                    Console.WriteLine($"{Dollar} Dolares = {Res} Euros");
                    Console.WriteLine("==========================================");
                    break;
                case 2:
                    Console.WriteLine("====================================");
                    Console.Write("Cuantos Euros desea cambiar: ");
                    Euro = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite el precio del Dollar: ");
                    Dollar = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("====================================");
                    Res = Euro * Dollar;
                    Console.WriteLine("==========================================");
                    Console.WriteLine($"{Euro} Euros = {Res} Dolares");
                    Console.WriteLine("==========================================");
                    break;
            }
        }
        //!!!!!!!Menu General!!!!!!
        public static void MenuGeneral()
        {
            int opcion = 0;
            Console.Write("-----------MENU------------\n");
            Console.WriteLine("===========================");
            Console.Write("1-Ejercicio del capitulo #1 \n2-Ejercicio del capitulo #2 \n3-Ejercicio del capitulo #3 \n");
            Console.WriteLine("===========================");
            Console.Write("\nOpcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());//Asi se le un entero.

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n==============================");
                    ImprimirDatos();
                    Console.WriteLine("==============================");
                    break;
                case 2:
                    MenuCapitulo2();
                    break;
                case 3:
                    MenuCapitulo3();
                    break;
            }
        }
        static void Main(string[] args)
        {
            MenuGeneral();
        }
    }
}
