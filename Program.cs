using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static System.Console;

/*<summary>
 *Bu script çerezlik console application sorularından ve string manipülasyon notlarından oluşmaktadır.
 *Ara ara Coderbyte gibi platformlarda gördüğüm soruları burada derlemeye karar verdim. 
 *Bu sorulara benim yaklaşımımı inceleyebilirsiniz.
 *</summary>
 */
namespace Snacks {
    class Program {
        private static void Main() {

            Test(); void Test() {





            }


            IntArrayExamples();
            void IntArrayExamples() {

                //IA_1();
                void IA_1() {

                    //SORU-1
                    WriteLine(Codebyte_Example02_Factorial(9));

                    static int Codebyte_Example02_Factorial(int v) {
                        int sonuc = 1;
                        for (int i = sonuc; i > 1; i--) {
                            sonuc *= i;
                        }
                        return sonuc;
                    }
                }

                //IA_2();
                void IA_2() {

                    //SORU
                    WriteLine(ReturnLargestNumber(new int[] { 1, 2, 3, 4, 5 }));

                    static int ReturnLargestNumber(int[] nums) {
                        int maxNumaber = 0;
                        for (int i = 0; i < nums.Length; i++) {
                            if (maxNumaber < nums[i]) {
                                maxNumaber = nums[i];
                            }
                        }
                        return maxNumaber;

                        // return nums.Prepend(0).Max();
                    }

                }

                //IA_3();
                void IA_3() {

                    //SORU
                    WriteLine(RemoveLastAndReturnNewList(new int[] { 1, 2, 3, 4, 5 }));

                    static int[] RemoveLastAndReturnNewList(int[] nums) {
                        //int arrayLength = nums.Length - 1;
                        int[] dizi2 = new int[nums.Length - 1];

                        for (int i = 0; i < nums.Length - 1; i++) {
                            dizi2[i] = nums[i];
                        }

                        return dizi2;

                    }
                }

                //IA_4();
                void IA_4() {

                    /*Dizideki 2 sayının toplamı girilen sayı ise indislerini döndüren program*/
                    WriteLine(Leetcode_TwoSum(new int[] { 7, 6, 3, 4, 5 }, 13));

                    static int[] Leetcode_TwoSum(int[] nums, int target) {
                        int[] finalIndices = new int[2];

                        for (int i = 0; i < nums.Length; i++) {
                            for (int j = 0; j < nums.Length; j++) {
                                if (nums[i] + nums[j] == target && i != j) {
                                    finalIndices[0] = i;
                                    finalIndices[1] = j;
                                }
                                else continue;
                            }
                        }
                        if (finalIndices != null) {
                            return finalIndices;

                        }

                        else return null;
                    }
                }

                //IA_6();
                void IA_6() {

                    // Odd numbers should be number first, then evens. Return last list.
                    WriteLine(Flutter_ArrangeNumbersInTheArray(new int[] { 8, 77, 56, 1, 2, 3, 4, 6 }));
                    static int[] Flutter_ArrangeNumbersInTheArray(int[] nums) {

                        //SOLUTION-1

                        int[] result = nums.Where(o => o % 2 == 1).OrderBy(o => o)
                            .Concat(nums.Where(o => o % 2 == 0).OrderBy(o => o)).ToArray();

                        //SOLUTION-2

                        //int i = 0;
                        //foreach (var st in nums.Where(o => o % 2 == 1).OrderByDescending(o => o).Reverse()) {
                        //    result[i] = st;
                        //    i++;
                        //}
                        //foreach (var st in nums.Where(o => o % 2 == 0).OrderByDescending(o => o).Reverse()) {
                        //    result[i] = st;
                        //    i++;
                        //}


                        foreach (var st in result) {
                            WriteLine(st);
                        }
                        return result;
                    }
                }

                //IA_7();
                void IA_7() {

                    //SORU
                    WriteLine(Flutter_FindLargestThenSubstractFromOthers(new int[] { 1, 3, 5, 6, 9 }));

                    static int[] Flutter_FindLargestThenSubstractFromOthers(int[] nums) {

                        int maxNumber = nums.Max();
                        int[] result = new int[nums.Length];

                        for (int i = 0; i < result.Length; i++) {
                            result[i] = maxNumber - nums[i];
                        }
                        foreach (var st in result) {
                            WriteLine(st);
                        }
                        return result;
                    }

                }

            }

            StringManipulationExamples();
            void StringManipulationExamples() {
                //SM_1();
                void SM_1() {

                    // Ekrandan girilen cümleyi tersten yazdır
                    Console.WriteLine(Codebyte_Example01_FirstReverse(Console.ReadLine()));
                    static string Codebyte_Example01_FirstReverse(string str) {
                        string bos = string.Empty;

                        for (int i = str.Length - 1; i >= 0; i--) {
                            bos += str[i];
                        }

                        str = bos;
                        return str;
                    }

                }

                //SM_2();
                void SM_2() {

                    //SORU
                    Console.WriteLine(Codebyte_Example01_FirstReverse2(Console.ReadLine()));
                    static string Codebyte_Example01_FirstReverse2(string v) {
                        char[] harfler = v.ToCharArray();
                        string bos = "";

                        for (int i = harfler.Length; i > 0; i--) {
                            bos += harfler[i - 1];
                        }
                        return bos;
                    }

                }

                //SM_3();
                void SM_3() {

                    // Ekrandan girilen cümledeki en uzun kelimeyi bul
                    Console.WriteLine(Codebyte_Example03_LongestWord(Console.ReadLine()));
                    static string Codebyte_Example03_LongestWord(string sen) {
                        string bosString = string.Empty;
                        string[] kelimeler = sen.Split(' ');
                        int harfSayisi = 0;

                        foreach (string kelime in kelimeler) {
                            if (harfSayisi < kelime.Length) {
                                harfSayisi = kelime.Length;
                                bosString = kelime;
                            }
                        }
                        sen = bosString;
                        return sen;

                    }

                }

                //SM_4();
                void SM_4() {

                    Console.WriteLine(Codebyte_Example03_LongestWord2(Console.ReadLine()));
                    static string Codebyte_Example03_LongestWord2(string v) {
                        string[] kelimeler = v.Split(' ');
                        int maxNumber = 0;
                        int currentNumber;
                        int removeIndis = -1;
                        string longestWord = "";

                        foreach (string kelime in kelimeler) {
                            currentNumber = 0;

                            for (int i = 0; i < kelime.Length; i++) {
                                char[] c = kelime.ToCharArray();

                                if (char.IsLetter(c[i])) {
                                    currentNumber++;
                                }
                                else {
                                    removeIndis = i;
                                    maxNumber = currentNumber;
                                    longestWord = kelime;
                                    break;
                                }
                            }
                        }
                        if (removeIndis != -1) longestWord = longestWord.Remove(removeIndis);

                        return longestWord;
                    }
                }

                //SM_5();
                void SM_5() {

                    /// Girilen cümlede bir sayı girildiğinde, bir sonraki sayı görünene kadar
                    /// 3 tane "Soru işareti" bulunmalıdır. Herhangi biri sağlanmazsa false döner.
                    /// Bu koşul sağlanırsa aynı cümle içerisinde birden fazla gerçekleşebilir.

                    Console.WriteLine(Codebyte_Example04_QuestionsMarks(Console.ReadLine()));

                    static string Codebyte_Example04_QuestionsMarks(string str) {
                        char[] harf = str.ToCharArray();
                        bool isCounterStarted = false;
                        int soruIsaretiCounter = 0;

                        for (int i = 0; i < str.Length; i++) {
                            if (!isCounterStarted && char.IsDigit(harf[i])) {
                                isCounterStarted = true;
                            }
                            else if (isCounterStarted && char.IsDigit(harf[i])) {
                                if (soruIsaretiCounter != 3) return "false";
                                else {
                                    isCounterStarted = false;
                                    soruIsaretiCounter = 0;
                                    continue;
                                }
                            }
                            if (harf[i] == '?' && isCounterStarted) {
                                soruIsaretiCounter++;
                                if (soruIsaretiCounter > 3) { return "false"; }
                                else { continue; }
                            }

                        }
                        return "true\n" + str;
                    }

                }

                //SM_6();
                void SM_6() {

                    // 2 dizi gir. Kesişen sayıları yazdır
                    Console.WriteLine(Codebyte_Example05_FindIntersection(new string[] { "1, 3, 4, 7, 13, 15", "1, 2, 4, 13, 15" }));
                    static bool Codebyte_Example05_FindIntersection(string[] strArr) {
                        string result = string.Empty;
                        string[] strArray1 = strArr[0].Split(',');
                        string[] strArray2 = strArr[1].Split(',');

                        foreach (string str in strArray1) {

                            foreach (string str2 in strArray2) {
                                if (str == str2) {
                                    result += str + ", ";
                                }
                            }
                        }

                        return false;
                    }

                }

                //SM_7();
                void SM_7() {

                    ///  Codebyte_Example06_CodelandUsernameValidation(str) take the str parameter being passed and determine if the 
                    ///  string is a valid username according to the following rules:
                    ///   1.The username is between 4 and 25 characters.
                    ///   2.It must start with a letter.
                    ///   3.It can only contain letters, numbers, and the underscore character.
                    ///   4.It cannot end with an underscore character.
                    ///   If the username is valid then your program should return the string true, otherwise return the string false.
                    /// 
                    WriteLine(Codebyte_Example06_CodelandUsernameValidation(Console.ReadLine()));

                    static string Codebyte_Example06_CodelandUsernameValidation(string str) {
                        int strLength = str.Length;
                        char firstLetter = str[0];
                        string sonDurum = string.Empty;

                        foreach (char c in str) {
                            if (char.IsDigit(c) || char.IsLetter(c) || c == '_') {
                                continue;
                            }
                            else {
                                sonDurum = "false";
                                break;
                            }

                        }

                        if (strLength < 4 || strLength > 25 ||
                            !char.IsLetter(firstLetter) || str[strLength - 1] == '_') {
                            sonDurum = "false";
                        }
                        else { sonDurum = "true"; }

                        WriteLine(sonDurum);
                        return str;
                    }

                }

                //SM_8();
                void SM_8() {

                    // Açtığın parantez kadar kapadığın parantez olsun. False dönsün yoksa

                    WriteLine(Codebyte_Example07_BracketMatcher(Console.ReadLine()));
                    static string Codebyte_Example07_BracketMatcher(string str) {
                        int openBracketCounter = 0;
                        int closedBracketCounter = 0;

                        for (int i = 0; i < str.Length; i++) {
                            if (str[i] == '(') {
                                openBracketCounter++;
                            }

                            if (str[i] == ')') {
                                closedBracketCounter++;
                            }
                        }
                        if (openBracketCounter == closedBracketCounter) Console.Write("1");
                        else Console.Write("0");

                        return str;
                    }

                }

                //SM_9();
                void SM_9() {

                    WriteLine(Codebyte_Example08_TreeConstructor(new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(19,5)" }));
                    static string Codebyte_Example08_TreeConstructor(string[] strArr) {

                        string[] bosListe;

                        for (int i = 0; i < strArr.Length; i++) {
                            bosListe = strArr[i].Split(')', ',', '(');
                            Write(bosListe);
                        }




                        return "";
                    }

                }

                //SM_10();
                void SM_10() {

                    //SORU
                    Console.WriteLine(Rollic1("cats AND do*gs-are Awesome"));

                    static string Rollic1(string str) {
                        string result = string.Empty;
                        char[] charArray = str.ToCharArray();
                        bool isUpper = false;
                        for (int i = 0; i < str.Length; i++) {
                            if (!char.IsLetter(charArray[i])) {
                                isUpper = true;
                                continue;
                            }
                            result += isUpper ? char.ToUpper(charArray[i]) : char.ToLower(charArray[i]);
                            isUpper = false;
                        }
                        return result;
                    }

                }

                //SM_11();
                void SM_11() {

                    //SORU
                    Console.WriteLine(Rollic3("10110001"));
                    static string Rollic3(string str) {
                        char[] charArray = str.ToCharArray();
                        float result = 0, multiplier = 2;
                        for (int i = charArray.Length - 1; i >= 0; i--) {
                            result += charArray[i] == '1' ? MathF.Pow(multiplier, charArray.Length - 1 - i) : 0;
                        }
                        return result.ToString();
                    }
                }
            }


            //Template();
            void Template() {

                //SORU

            }

            //ManipulationNotes(); 
            static void ManipulationNotes() {
                char c;
                c = char.ToUpper('c');

                string str = "abcdefgh";
                str.ToUpper();
                int index = str.IndexOf('e'); // index = 4

                int a1 = str[1];     // a1 = 98
                string a2 = str[1] + "t";  // a2 = bt
                                           //çıkarma
                string lastPart = str.Substring(str.IndexOf(str[2])); // dizinin 3. elemanı çıkarılmaz => cdefgh olur


                lastPart.IndexOf('1'); //içi char olmalı
                lastPart.Substring(1); //2. dizi elemanı dahil sonrasını yazdırır
                lastPart.ToUpper(); //hepsi büyük
                lastPart.ToLower(); //hepsi küçük

                lastPart.Split('a', StringSplitOptions.RemoveEmptyEntries);             //Char.IsDigit() is a subset of Char.IsNumber().
                char.IsDigit('a');               //Some of the characters that are 'numeric' but not digits include 0x00b2 and 0x00b3 which are 
                char.IsNumber('a');              //superscripted 2 and 3('²' and '³') and the glyphs that are fractions such as '¼', '½', and '¾'.

                string hello = "***hellooo beatifulll * * whatsupp***";
                hello = hello.Trim('*', 'e');       //* ve e'den arındırır string'i
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
                WriteLine(a.Remove(5, 2)); //5. iindexten başlayıp 2 tane sil
                WriteLine(a.Substring(5, 2));//5. indexten başla sonrasını getir
                WriteLine(a.Replace("a", "b")); //tüm a'ları b yap

                string ay = "asdfg";
                Write(ay.Remove(ay.Length - 1)); //returns "asdf"
                Write(ay.Remove(1)); //returns "a"

            }

            //CulturalInfo();
            void CulturalInfo() {
                string[] cultureNames =
                {
                    "en-US", "en-GB", "fr-FR",
                    "hr-HR", "ja-JP"
                };
                CultureInfo ci = new CultureInfo(cultureNames[^1]);

                double number = MathF.PI;
                int number2 = 176;

                WriteLine(number.ToString("C4", ci)); // para birime ekler. Virgülden sonra 4 basamak ekler.Yoksa 0 atar.
                WriteLine(number2.ToString("X")); // hexe çevirir | büyük X => B0 | küçük x => b0 döndürür
                WriteLine(number.ToString("P1")); // yüzde işareti atar başa. virgülden sonra 1 basamak gösterir
                // ve onu da yuvarlar. => %314,2 döndürür
                WriteLine(number.ToString("F4")); // virgülden sonra 4 basamak gösterir
                WriteLine(number.ToString("G3")); // Virgülden sonraki 3. basamağı toplamda virgülden sonra
                // 2 basamak olcak şekilde yuvarlar
                WriteLine(number.ToString("N5")); // her 3 basamakta nokta atar kolay okunması için.
                // virgülden sonra 5 basamak gösterir

                var s = 4.ToString($"4 to string: {0:C2} ");
                WriteLine(s);

                //append => sonuna ekliyor | appendLine => sonuna ekleyip alt satıra geçiyor
                StringBuilder amountMsg = new StringBuilder("Your total amount is ");

                amountMsg.AppendFormat("{0:C2}", 25);
                amountMsg.AppendFormat(25.ToString("C2", ci));
                Console.WriteLine(amountMsg);
            }

            //Dictionaries(); 
            void Dictionaries() {
                //dic'in aynısı ama sıralı | neyi istersen sıralayıp veriyor, key'i de value'yu da
                SortedList<int, string> sorted = new SortedList<int, string>();
                sorted.Add(2, "iki");
                sorted.Add(4, "dört");
                sorted.Add(3, "üç");
                sorted.Add(1, "bir");
                //foreach (var st in sorted) {
                //    WriteLine(st.Value);
                //}

                //generic değil. sıra karışık // Hashset generic olanı
                Hashtable numberNames = new Hashtable();
                numberNames.Add(1, "One");
                numberNames.Add("asd", 1);
                numberNames.Add(3, "üç");
                numberNames.Add("dört", 4);
                //foreach (DictionaryEntry dictionaryEntry in numberNames) {
                //    WriteLine(dictionaryEntry.Key);
                //}

                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(1, "bir");
                dic.Add(2, "iki");
                dic.Add(3, "üç");
                dic.Add(4, "dört");
                //foreach (var dictionaryEntry in dic) {
                //    WriteLine(dictionaryEntry.Key);
                //}
            }

            //Takkeler();
            void Takkeler() {
                int[] arrayList = { 1, 2, 3, 4, 5 };
                var sa = arrayList[^2..];

                WriteLine(sa.Length); // return 2 value

                foreach (int value in sa) { // returns 4,5
                    Write(value + " ");
                }
                string asdd = "123456789";
                asdd = asdd[^2..]; //3. dizi elemanı ve sonrasını döndürür
                WriteLine(asdd);

                int[] arrayListt = new int[] { 1, 2 };
                var ssa = arrayListt[..^2]; //Sondan 3. ve önceki elemanları döndürür

            }



            #region INTO THE MIDDLE EXAMPLES
            //HackerRank_Example01_ToplaCikarYaz();
            static void HackerRank_Example01_ToplaCikarYaz() {
                int i = 4;
                double d = 4.0;
                string s = "HackerRank ";

                int i2 = Convert.ToInt32(ReadLine());
                double d2 = Convert.ToDouble(ReadLine());
                string s2 = ReadLine();

                Console.WriteLine(i + i2);
                Console.WriteLine("{0:.0 }" + d + d2); //en önemli kısmı burası
                Console.Write(s + s2);
            }

            //LongLINQ();
            static void LongLINQ() {
                string[] employees = { "Joe", "Bob", "Carol", "Alice", "Will" };

                IEnumerable<string> employeeQuery =
                    from person in employees
                    orderby person
                    select person;

                foreach (string employee in employeeQuery) {
                    Console.WriteLine(employee);
                }
            }
            #endregion


        }
    }
}
