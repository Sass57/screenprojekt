using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScreen.Models
{
    static public class Screen
    {
        /// <summary>
        /// Téglalap rajzolása a képernyőn a megadott koordináták és méretek alapján. 
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="width">A téglalap szélessége</param>
        /// <param name="height">A téglalap magassága</param>
        /// <param name="sign">A téglalap rajzolásához használt karakter</param>
        static public void DrawRectangle(byte x, byte y, byte width, byte height, char sign = '*')
        {
            // TODO : (Bihari) DONE Téglalap rajzolásának implementációja a képernyőn

        }

        /// <summary>
        /// Kitöltött téglalap rajzolása a képernyőn a megadott koordináták és méretek alapján.
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="width">A kitöltött téglalap szélessége</param>
        /// <param name="height">A kitöltött téglalap magassága</param>
        /// <param name="sign">A kitöltéshez használt karakter</param>
        static public void FillRectangle(byte x, byte y, byte width, byte height, char sign = '■')
        {
            // TODO : (Tas) DONE Kitöltött téglalap rajzolásának implementációja a képernyőn
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x,y+i);

                for (int j = 0; j < width; j++)
                {
                    Console.Write(sign);
                }
            }
        }

        /// <summary>
        /// Vonal rajzolása a képernyőn a megadott kezdő és végpontok alapján.
        /// </summary>
        /// <param name="x1">X koordináta a kezdőpontban</param>
        /// <param name="y1">Y koordináta a kezdőpontban</param>
        /// <param name="x2">X koordináta a végpontban</param>
        /// <param name="y2">Y koordináta a végpontban</param>
        /// <param name="sign">A vonal rajzolásához használt karakter</param>
        static public void DrawLine(byte x1, byte y1, byte x2, byte y2, char sign = '*')
        {
            // TODO : (Tas) Vonal rajzolásának implementációja a képernyőn
            // TODO : Függőleges megoldás
            while (x1 < x2 || y1 < y2)
            {
                if (x1 < x2)
                {
                    Console.Write(sign);
                    x1++;
                }
            }
        }

        /// <summary>
        /// Adott szélességre középre igazítja a szöveget
        /// </summary>
        /// <param name="text">A középre igazítandó szöveg</param>
        /// <param name="width">A szélesség, amire igazítani kell</param>
        /// <returns>A szöveg középre igazított változata</returns>
        static public string AlignTextCenter(string text, int width)
        {
            // TODO : (Bihari) DONE Szöveg középre igazításának implementációja
            return text;
        }

        /// <summary>
        /// Keverve adja vissza a két szöveg karaktereit.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
        /// <returns>A két szöveg karaktereinek keverésével elkészített szöveg</returns>
        public static string MixedStrings(string textA, string textB)
        {
            // TODO : (Tas) DONE Két szöveg keverésének implementációja
            // 1. példa:
            // textA = "Hello"
            // textB = "World"
            // Kimenet: HWeolrllod

            // 2. példa:
            // textA = "abcd"
            // textB = "12345"
            // Kimenet: a1b2c3d45

                StringBuilder sb = new StringBuilder();
                int maxHossz =  Math.Max(textA.Length, textB.Length);
                for (int i = 0;i < maxHossz;i++)
                {
                if (i < textA.Length)
                    sb.Append(textA[i]);
                if (i < textB.Length)
                    sb.Append(textB[i]);
                }
                return sb.ToString();
        }


        /// <summary>
        /// Egymás után váltakozva szereplő szövegeket fűz egybe.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
        /// <param name="iteration">A fűzések ismétlési száma.</param>
        /// <returns>A két szöveg ismételt váltakozásával elkészített szöveg</returns>
        public static string RepeatedStrings(string textA, string textB, int iteration)
        {
            // TODO : (Bihari) DONE Két szöveg ismételt váltakozásának implementációja
            // példa:
            // textA = "Hi"
            // textB = "There"
            // iteration = 3
            // Kimenet: HiThereHiThereHiThere

            throw new NotImplementedException();
        }
    }
}
