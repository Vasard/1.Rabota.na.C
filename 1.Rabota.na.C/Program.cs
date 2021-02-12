using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //указываем то, что мы будем использовать(аналогично-import в python vs)

namespace _1.Rabota.na.C //нельзя менять
{
    class Program //класс, запускающий весь проект
    {
        //static void Main(string[] args) //static void Main-основная функия. void-ничего не запоминает*public_void*static_void
        //{
            
        //    Console.BackgroundColor = ConsoleColor.Gray; //ключ-свойство, обязательно должно быть равно!!!!!
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.Clear(); //окрашивает всё
        //    Console.WriteLine("Hello world!"); //можно просто write. line-надо нажать на enter
        //    Random rnd = new Random(); //random-модуль. если выделен зелёным-значит программа знает этот модуль. конструктор всегда с круглыми скобками. красная линия-синтаксическая ошибка.
        //    Console.WriteLine("jah-random number, ei-ise sisestan");
        //    string soov = Console.ReadLine();//пользователь будет что-то вводить
        //    int num = 0;//говорю, что будет целое число
        //    if (soov == "jah")
        //    {
        //        num = rnd.Next(1, 7); //обращение к объекту. num-переменная. всегда ставить точку "." кубик-метод(Next-генерирует случайное число).()-задает аргумент

        //    }
        //    else
        //    {
        //        try
        //        {
        //            num = Convert.ToInt32(Console.ReadLine()); //буду использовать целое число
        //        }
        //        catch (SystemException)
        //        {
        //        }
        //    }
        //    Console.WriteLine("Päeva number: {0}", num.ToString()); //ToString()-рандомное число, как текст


        //    string nimetus = ""; //два раза использовать нельзя nimetus
        //    switch (num)
        //    {
        //        case 1: nimetus = "esmaspäev"; break;//если case=1
        //        case 2: nimetus = "teisipäev"; break;
        //        case 3: nimetus = "kolmapäev"; break;
        //        case 4: nimetus = "neljapäev"; break;
        //        case 5: nimetus = "reede"; break;
        //        case 6: nimetus = "laupäev"; break;
        //        case 7: nimetus = "pühapäev"; break;
        //        default:
        //            nimetus = "Viga!";
        //            break;
        //    } //"switch"+tab+tab, тогда откроется конструкция


        //    Console.WriteLine(nimetus); //выводит инфу на экран
        //    StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);//если програма не знает, тогда выбираем лампочку-подсказку true-режим до записи
        //    filesse.WriteLine("Number oli {0}, päev on {1}", num.ToString(), nimetus);//0-num, 1-nimetus
        //    filesse.Close();
        //    Console.WriteLine("Failis oli salvestatud: Number oli " + num.ToString() + " päev on " + nimetus);
        //    StreamReader filest = new StreamReader(@"..\..\andmed.txt");
        //    string a = filest.ReadToEnd();
        //    Console.WriteLine("Failis oli seda: \n" + a);
        //}

        //задание 1(10)
        //private static void Main(string[] args)
        //{
        //    Console.WriteLine("Sisesta a ");
        //    var a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Sisesta b ");
        //    var b = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Sisesta x ");
        //    var x = Convert.ToInt32(Console.ReadLine());
        //    var c = 12 * x - 18 * (b - a);
        //    Console.WriteLine("c = 12 * x - 18 * (b - a)\n"+ c +" = 12 * "+ x +" - 18 * ("+b+" - "+a+")");
        //    File.WriteAllText(@"..\..\andmed.txt", c.ToString());
        //    Console.ReadLine();

        //}
        static void Main(string[] args)
        {
            string[] sonad = new string[7] { "aaa", "bbb", "ccc", "ddd", "eee", "fff", "zzz" };
            foreach (string sona in sonad)
            {
                Console.WriteLine(sona);
            }
            for (int i = 0; i < sonad.Length; i++) //++ увеличить на 1 sonad.Length-длина массива
            {
                Console.WriteLine(sonad[i]);
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Escape");
                key = Console.ReadKey();
            } while (key.Key!=ConsoleKey.Escape);

            
        }



    }

}
    