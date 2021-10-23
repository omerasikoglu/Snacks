using System;
using System.Text;
using static System.Console;

/*<summary>
 *Bu script çerezlik console application sorularından ve string manipülasyon notlarından oluşmaktadır.
 *Ara ara Codebyte gibi platformlarda gördüğüm soruları burada derlemeye karar verdim. 
 *Bu sorulara benim algoritmik yaklaşımımı inceleyebilirsiniz.
 *Umarım kodlamayı öğrenme maceranızla yardımı dokunur.
 *</summary>
 */
namespace Snacks
{
    class Program
    {
        static void Main()
        {
            /// <summary>
            /// Ekrandan girilen cümleyi tersten yazdır
            /// </summary>
            #region Soru-1
            //Console.WriteLine(FirstReverse(Console.ReadLine())); 
            #endregion

            /// <summary>
            /// Ekrandan girilen cümledeki en uzun kelimeyi bul
            /// </summary>
            #region Soru-2
            //Console.WriteLine(LongestWord(Console.ReadLine())); 
            #endregion

            /// <summary>
            /// Girilen cümlede bir sayı girildiğinde, bir sonraki sayı görünene kadar
            /// 3 tane "Soru işareti" bulunmalıdır. Herhangi biri sağlanmazsa false döner.
            /// Bu koşul sağlanırsa aynı cümle içerisinde birden fazla gerçekleşebilir.
            /// </summary>
            #region Soru-3
            //Console.WriteLine(QuestionsMarks(Console.ReadLine())); 
            #endregion

            ///< summary >2 dizi gir. Kesişen sayıları yazdır
            ///< /summary >
            #region Soru-4
            //Console.WriteLine(FindIntersection(new string[] { "1, 3, 4, 7, 13, 15", "1, 2, 4, 13, 15" })); 
            #endregion

            ///  <summary>
            ///  CodelandUsernameValidation(str) take the str parameter being passed and determine if the 
            ///  string is a valid username according to the following rules:
            ///   1.The username is between 4 and 25 characters.
            ///   2.It must start with a letter.
            ///   3.It can only contain letters, numbers, and the underscore character.
            ///   4.It cannot end with an underscore character.
            ///   If the username is valid then your program should return the string true, otherwise return the string false.
            ///   </summary>
            #region Soru-5
            //WriteLine(CodelandUsernameValidation(Console.ReadLine()));
            #endregion

            ///< /summary > Açtığın parantez kadar kapadığın parantez olsun. False dönsün yoksa
            ///< /summary >
            #region Soru-6
            //WriteLine(BracketMatcher(Console.ReadLine())); 
            #endregion

            #region Soru-7
            WriteLine(TreeConstructor(new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(19,5)" })); 
            #endregion



            //DecoratorPattern();
            //ManipulationNotlar();

        }



        public static string FirstReverse(string str)
        {
            string bos = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                bos += str[i];
            }

            str = bos;
            return str;

        }
        public static string LongestWord(string sen)
        {

            string bosString = string.Empty;
            string[] kelimeler = sen.Split(' ');
            int harfSayisi = 0;

            foreach (string kelime in kelimeler)
            {
                if (harfSayisi < kelime.Length)
                {
                    harfSayisi = kelime.Length;
                    bosString = kelime;
                }
            }
            sen = bosString;
            return sen;

        }
        public static string QuestionsMarks(string str)
        {
            char[] harf = str.ToCharArray();

            bool isCounterStarted = false;
            int soruIsaretiCounter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!isCounterStarted && char.IsDigit(harf[i]))
                {
                    isCounterStarted = true;
                }
                else if (isCounterStarted && char.IsDigit(harf[i]))
                {
                    if (soruIsaretiCounter != 3) return "false";
                    else
                    {
                        isCounterStarted = false;
                        soruIsaretiCounter = 0;
                        continue;
                    }
                }
                if (harf[i] == '?' && isCounterStarted)
                {
                    soruIsaretiCounter++;
                    if (soruIsaretiCounter > 3) { return "false"; }
                    else { continue; }
                }

            }
            return "true\n" + str;
        }

        private static bool FindIntersection(string[] strArr)
        {
            string result = string.Empty;
            string[] strArray1 = strArr[0].Split(',');
            string[] strArray2 = strArr[1].Split(',');

            foreach (string str in strArray1)
            {

                foreach (string str2 in strArray2)
                {
                    if (str == str2)
                    {
                        result += str + ", ";
                    }
                }
            }

            return false;
        }

        private static string CodelandUsernameValidation(string str)
        {
            int strLength = str.Length;
            char firstLetter = str[0];
            string sonDurum = string.Empty;

            foreach (char c in str)
            {
                if (char.IsDigit(c) || char.IsLetter(c) || c == '_')
                {
                    continue;
                }
                else
                {
                    sonDurum = "false";
                    break;
                }

            }

            if (strLength < 4 || strLength > 25 ||
            !char.IsLetter(firstLetter) || str[strLength - 1] == '_')
            {
                sonDurum = "false";
            }
            else { sonDurum = "true"; }

            WriteLine(sonDurum);
            return str;
        }

        private static string BracketMatcher(string str)
        {
            int openBracketCounter = 0;
            int closedBracketCounter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    openBracketCounter++;
                }

                if (str[i] == ')')
                {
                    closedBracketCounter++;
                }
            }
            if (openBracketCounter == closedBracketCounter) Console.Write("1");
            else Console.Write("0");

            return str;
        }

        private static string TreeConstructor(string[] strArr)
        {

            string[] bosListe;

            for (int i = 0; i < strArr.Length; i++)
            {
                bosListe = strArr[i].Split(')', ',', '(');
                Write(bosListe);
            }




            return "";
        }




        private static void ManipulationNotlar()
        {
            string str = "abcdefgh";
            int index = str.IndexOf('e'); // index = 4

            int a1 = str[1];     // a1 = 98
            string a2 = str[1] + "t";  // a2 = bt

            string lastPart = str.Substring(str.IndexOf(str[2])); // dizinin 3. elemanaı dahildir => cdefgh olur

            lastPart.IndexOf('1'); //içi char olmalı
            lastPart.Substring(1); //2. dizi elemanı dahil sonrasını yazdırır
            lastPart.ToUpper(); //hepsi büyük
            lastPart.ToLower(); //hepsi küçük

            lastPart.Split('a');
            char.IsDigit('a');

            string hello = "***hellooo beatifulll * * whatsupp***";
            hello = hello.Trim('*', 'e');
            WriteLine(hello);

            string a = "a";
            string b = "b";
            WriteLine(string.Concat(a, b)); //birleştirir output: ab

            WriteLine(a.CompareTo(b)); // string length'i a'nın büyükse 1; eşitse 0; azsa -1 döndürür
            WriteLine(string.Compare(a, b, false)); //3rd parameter is büyük/küçük harf duyarlılığı
            WriteLine(a.Contains(b)); // a'nın içinde b varsa true dönderir
            WriteLine(a.EndsWith(b));
            WriteLine(a.StartsWith(b)); //b ile başlayıp bitiyorsa true/false döndürür
            WriteLine(a.Insert(0, "asd")); // girilen indise string ekler
            WriteLine(a.LastIndexOf('a')); // a'yı son gördüğü indexi döndürür yoksa -1 döner
            WriteLine(a.Remove(2)); //2.indexten başlayarak sonuna kadar siler. Öncesini döndürür
            WriteLine(a.Remove(5,2)); //5. iindexten başlayıp 2 tane sil
            WriteLine(a.Substring(5,2));//5. indexten başla sonrasını getir
            WriteLine(a.Replace("a","b")); //tüm a'ları b yap


        }
        private static void DecoratorPattern()
        {
            var x = "Hello";
            x += "World";
            Console.WriteLine(x);

            //StringBuilder
        }



    }
}
