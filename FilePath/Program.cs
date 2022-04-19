using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilePath
{
    class Program
    {
        // string
        //Строка, содержащая полный путь к файлу -> Массив строк из названий папок
        static String[] ArrStr(String way)
        {
            List<String> rez = new List<String>();


            String folder = "";
            Char slash = '\\';

            for (int i = 0; i < way.Count(); i++)
            {
                if (way[i] != slash)
                    folder += way[i];

                if ((way[i] == slash) || (i == way.Count() - 1))
                {
                    rez.Add(folder);
                    folder = "";
                }
            }

            Console.WriteLine("Путь состоит из папок: ");
            for (int i = 0; i < rez.Count(); i++)
            {

                Console.Write(i);
                Console.Write("   ");
                Console.WriteLine(rez[i]);
            }

            String[] Arr = new String[rez.Count()];
            for (int i = 0; i < rez.Count(); i++)
            {
                Arr[i] = rez[i];
            }

            Console.WriteLine("");

            return Arr;
        }

        //Массив строк из названий папок -> Полный путь к файлу
        static void WayStr(String[] Arr)
        {
            String way = Path.Combine(Arr);

            Console.WriteLine("Путь к файлу: ");
            Console.WriteLine(way);
            Console.WriteLine("");
            Console.WriteLine("");
        }



        // char[]
        //Строка, содержащая полный путь к файлу -> Массив строк из названий папок
        static Char[][] ArrChr(Char[] way)
        {
            List<List<Char>> rez = new List<List<Char>>();

            List<char> folder = new List<Char>(); 

            for (int i = 0; i < way.Count(); i++)
            {
                if (way[i] != '\\')
                {
                    folder.Add(way[i]);   
                }

                if ((way[i] == '\\') || (i == way.Count() - 1))
                {
                    rez.Add(folder);
                    List<Char> tmp = new List<Char>();
                    folder = tmp;
                }
            }

            Console.WriteLine("Путь состоит из папок: ");
            for (int i = 0; i < rez.Count(); i++)
            {

                Console.Write(i);
                Console.Write("   ");
                for (int j = 0; j < rez[i].Count(); j ++ )
                    Console.Write(rez[i][j]);
                Console.WriteLine("");
            }

            Char[][] Arr = new Char[rez.Count()][];
            for (int i = 0; i < rez.Count(); i++)
            {
                Arr[i] = new Char[rez[i].Count()];
                for (int j = 0; j < rez[i].Count(); j++)
                {
                    Arr[i][j] = rez[i][j];
                }
            }
            Console.WriteLine(""); 
            
            return Arr;
        }

        //Массив строк из названий папок -> Полный путь к файлу
        static void WayChr(Char[][] Arr)
        {
            List<Char> way = new List<Char>();

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    way.Add(Arr[i][j]);
                }
                way.Add('\\');
            }

            Console.WriteLine("Путь к файлу: ");
            for (int i = 0; i < way.Count(); i++)
            {
                Console.Write(way[i]);
            }
            Console.WriteLine("");
        }



        static void Main(string[] args)
        {
            // Для String
            Console.WriteLine(" Для String");
            Console.WriteLine("");

            //Строка пути
            String way = Path.Combine(Directory.GetCurrentDirectory(), "Text456");

            /*
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            String way = Path.Combine(desktopPath, "File456.txt");
           */

            //Из строки пути получаем массив папок
            String[] Arr = ArrStr(way); 

            //из массива папок получаем строку пути 
            WayStr(Arr);

            // для Char
            Console.WriteLine(" Для Char");
            Console.WriteLine("");

            //Строка пути
            Char[] wayCh = way.ToCharArray();

            //Из строки пути получаем массив папок
            Char[][] ArrCh = ArrChr(wayCh);

            //из массива папок получаем строку пути 
            WayChr(ArrCh);

            Console.ReadKey();
        }
    }
}
