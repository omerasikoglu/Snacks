using System;

/*<summary>
 *Bu script çerezlik console application sorularından oluşmaktadır.
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
    }
}
