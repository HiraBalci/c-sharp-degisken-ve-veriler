using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte b = 5;//1 byte
            sbyte c = 5;//1 byte
            short d = 5;//2 byte yer kaplar.
            ushort us= 5;//2 byte yer kaplar.
            Int16 i16 = 2; //2 byte yer kaplar
            int i = 2;//4 byte yer kaplar
            Int32 i32 = 2;//4 byte yer kaplar
            Int64 i64 = 2;//8 byte yer kaplar
            uint ui = 2;//4byte
            long l = 4;//8byte
            ulong ul = 4;//8byte
            float f = 5;//4 byte
            double e = 5; //8 byte
            decimal de = 5; //16 byte
            char ch= 'c';//2 byte 
            string str = "Hira"; //sınırsızdır.
            bool b2 = true;
            bool c2 = false;
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 5.5;//üs tür olarak düşünülebilir
            //string ifadeler
            string str1 = string.Empty;
            str1 = "zikriye ürkmez";
            string ad = "zikriye";
            string soyad = "ürkmez";
            string tamİsim = ad + " " + soyad;
            //integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1*integer2;
            //boolean
            bool b1 = 10 < 2;
            //değişken  dönüşümleri
            string str11 = "20";
            int int20 = 20;
            string yeniDeger = str11 + int20.ToString();
            Console.WriteLine(yeniDeger);//çıktısı 2020
            int int56 = int20 + Convert.ToInt32(str11);
            Console.WriteLine(int56);//çıktısı 40
            int int22 = int20 + int.Parse(str11);//çıktısı 40
            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}
