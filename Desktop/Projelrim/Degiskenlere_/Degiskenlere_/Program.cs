using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenlere_
{
    class Program
    {
        static void Main(string[] args)
        {
            //tam sayı veri tipleri
            // byte min-0 max-255
            byte s1 = 255;  // unsigned varsa 0 dan başlar- değer olmaz
            s1 = 12;
            // sbyte
            //min -128 max 128
            sbyte s2 = 123;

            //short
            // MaxValue = 32767;
        //MinValue = -32768;
        short b1 = 10;

            //ushort
            // MaxValue = 65535;
        // MinValue = 0;
        ushort c1 = 15;
            //int
            //MaxValue = 2147483647;
        // MinValue = -2147483648;
        int h1 = 8;

            //uint
            //MaxValue = 4294967295;
        // MinValue = 0;

        uint r1 = 10;
            //long
            long s7 = 125;
            //ulong
            ulong s8 = 200;


            //ondalıklı veri tipleri
            //float
            float o1 = 1.1F;
            //double
            double o2 = 2.2;
            //decimal
            decimal o3 = 3.3M;
            //metinsel veri tipleri
            //char
            char karakter = 'A';
            //sttring
            string metin = 'B';
            //mantıklsal veri tipi
            //bool
            bool result = 10 > 1. //true;
        }
    }
}
