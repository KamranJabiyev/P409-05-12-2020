using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //["Anar","Famil","Ayshen"] - "Anar,Famil,Ayshen"
            //Console.WriteLine(JoinString(new string[] { "Anar", "Famil", "Ayten", "Ismayil" }));

            //[10,2,30,40] - min geriye qaytarin
            //Console.WriteLine(GetMin(new int[] { 10, 2, 30, 40,1 }));
            #endregion

            #region Ref,Out
            //int a = 1;
            //ChangeNumber(a);
            //Console.WriteLine("a="+a);

            //int[] arr = { 10, 20, 30 };
            //ChangeValue(arr);
            //Console.WriteLine("arr[0]="+arr[0]);

            #region Ref - initialize required
            //int n=1;
            //GetRefValue(ref n);
            //Console.WriteLine("n=" + n);
            #endregion
            #region Out - initialize custom
            //int a;
            //GetOutValue(out a);
            //Console.WriteLine("a=" + a);
            #endregion
            #endregion

            #region Array,String - methods
            //int[] arr = { 10, 2, 0, 45, 5 };
            //string[] arrStr = { "Ismayil", "Famil", "Elvin" };
            //int[] arr1 = new int[3] { 3, 4, 5 };
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Average());
            //Console.WriteLine(arr1.Length);
            //Console.WriteLine(arr[4]);
            //int[,] arrMulti = { { 1,2},{3,4 } };
            //Console.WriteLine(arrMulti[1,0]);
            //Array.Resize(ref arr1, 4);
            //Console.WriteLine(arr1.Length);
            //arr1[3] = 50;
            //Array.Reverse(arr);
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //Array.Clear(arrStr, 1, 2);
            //foreach (string num in arrStr)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(arrStr.Length);
            //string JoinArr = String.Join("-", arrStr);
            //Console.WriteLine(JoinArr);

            //STRING
            //string word = "Hello Hi Bye"; //'H','e','l','l','o'
            //string[] arr = word.Split(' ');
            //Console.WriteLine(arr[2]);
            //string removeStr = word.Remove(2,1);
            //Console.WriteLine(removeStr);
            //string repStr = word.Replace("lo", "l");
            //Console.WriteLine(word);
            //bool exist = word.ToLower().Contains("he".ToLower()); //he //hello
            //Console.WriteLine(exist);
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(word.ToLower());
            //string trim = word.Trim();
            //Console.WriteLine(trim);
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region StringBuilder
            // "Hello P409 Grup" - "olleH 904P purG" - Split()
            Console.WriteLine(ReverseWordInSent("Hello P409 Grup"));
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Salam");
            //stringBuilder.Append(" Necesiz");
            //stringBuilder.Clear();
            //stringBuilder.Insert(5, "P409");
            //Console.WriteLine(stringBuilder);
            #endregion
        }

        #region StringBuilder
        //static string ReverseWordInSent(string str)
        //{
        //    string result = String.Empty;
        //    string[] words = str.Split(' ');
        //    foreach (string word in words)
        //    {
        //        for (int i = word.Length-1; i >= 0; i--)
        //        {
        //            result+=word[i];
        //        }
        //        if(words[words.Length-1]!= word)
        //            result+=" ";
        //    }
        //    return result;
        //}

        static StringBuilder ReverseWordInSent(string str)
        {
            StringBuilder result = new StringBuilder();
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                }
                if (words[words.Length - 1] != word)
                    result.Append(" ");
            }
            return result;
        }
        #endregion

        #region Ref,Out
        #region Out
        static void GetOutValue(out int n)
        {
            n = 20;//-override required
            Console.WriteLine("method n=" + n);
        }
        #endregion
        #region Ref
        static void GetRefValue(ref int n)
        {
            n = 10; // -override custom
            Console.WriteLine("method n=" + n);
        }
        #endregion


        //static void ChangeValue(int[] arr)
        //{
        //    arr[0] = 101;
        //    Console.WriteLine("method arr[0]="+arr[0]);
        //}

        //static void ChangeNumber(int n)
        //{
        //    n = 10;
        //    Console.WriteLine("method n="+n);
        //}
        #endregion

        #region Homework
        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }


        static string JoinString(string[] arr)
        {
            //string result = "";
            //foreach (string item in arr)
            //{
            //    result += item;
            //    if(item!= arr[arr.Length-1]) 
            //        result += ",";
            //}
            //Console.WriteLine(result);

            string result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result += "," + arr[i];
            }
            return result;
        }
        #endregion
    }
}
