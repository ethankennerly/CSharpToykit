using System;
using System.Collections;
using System.Collections.Generic;

namespace FineGameDesign.Utils
{
    public sealed class DataUtils
    {
        public static void Clear<T>(T[] items, int startIndex = 0)
        {
            Array.Clear(items, startIndex, items.Length);
        }

        public static void Clear(ArrayList items, int startIndex = 0)
        {
            if (0 == startIndex)
            {
                items.Clear();
            }
            else
            {
                items.RemoveRange(startIndex, items.Count - startIndex);
            }
        }

        public static void Clear<T>(List<T> items, int startIndex = 0)
        {
            if (0 == startIndex)
            {
                items.Clear();
            }
            else
            {
                items.RemoveRange(startIndex, items.Count - startIndex);
            }
        }

         /**
          * Is integer or single floating point.
          */
        public static bool IsNumber(string text)
        {
            float n;
            return float.TryParse(text, out n);
        }

         /**
          * Is data type flat or a class or collection?
          */
         public static bool IsFlat(object value)
         {
             return (bool)((value is string) || (value is float) 
                || (value is int) || (null == value));
         }

        public static ArrayList SplitToArrayList(string text, string delimiter)
        {
            return new ArrayList(Split(text, delimiter));
        }

        //
        // I wish C# API were as simple as JavaScript and Python:
        // http://stackoverflow.com/questions/1126915/how-do-i-split-a-string-by-a-multi-character-delimiter-in-c
        // 
        public static List<string> Split(string text, string delimiter)
        {
            if ("" == delimiter) {
                return SplitString(text);
            }
            else {
                string[] delimiters = new string[] {delimiter};
                string[] parts = text.Split(delimiters, StringSplitOptions.None);
                List<string> list = new List<string>(parts);
                return list;
            }
        }

        //
        // This was the most concise way I found to split a string without depending on a library.
        // In ActionScript splitting a string is concise:  s.split("");
    // C# has characters, which would be more efficient, though less portable.
        // 
        public static List<string> SplitString(string text)
        {
            List<string> letters = new List<string>();
            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++) {
                letters.Add(characters[i].ToString());
            }
            return letters;
        }

        // Without depending on LINQ or that each item is already a string.
        public static string Join(ArrayList items, string delimiter)
        {
            string[] parts = new string[items.Count];
            for (int index = 0; index < items.Count; index++) {
                parts[index] = items[index].ToString();
            }
            string joined = string.Join(delimiter, parts);
            return joined;
        }

        public static string Join<T>(T[] items, string delimiter)
        {
            int length = items.Length;
            string[] parts = new string[length];
            for (int index = 0; index < length; ++index) {
                parts[index] = items[index].ToString();
            }
            string joined = string.Join(delimiter, parts);
            return joined;
        }

        public static string Join(List<string> texts, string delimiter)
        {
            string[] parts = (string[]) texts.ToArray();
            string joined = string.Join(delimiter, parts);
            return joined;
        }

        public static string Join(List<int> numbers, string delimiter)
        {
            int length = numbers.Count;
            string[] parts = new string[length];
            for (int index = 0; index < length; index++)
            {
                parts[index] = numbers[index].ToString();
            }
            string joined = string.Join(delimiter, parts);
            return joined;
        }

        /// <remarks>
        /// For medium-length or longer arrays, string builder is faster.
        /// </remarks>
        public static string ToString<T>(T[] items, string delimiter = ", ")
        {
            return "[" + Join(items, delimiter) + "]";
        }

        public static string Trim(string text)
        {
            return text.Trim();
        }

        public static string Replace(string text, string from, string to)
        {
            return Join(Split(text, from), to);
        }

        public static string Join<T>(List<T> items, string delimiter)
        {
            string[] parts = new string[items.Count];
            for (int i = 0; i < items.Count; i++) {
                parts[i] = items[i].ToString();
            }
            string joined = string.Join(delimiter, parts);
            return joined;
        }

        public static T Pop<T>(List<T> items)
        {
            T item = (T)items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public static object Pop(ArrayList items)
        {
            object item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public static List<T> Slice<T>(List<T> items, int start, int end)
        {
            List<T> sliced = new List<T>();
            for (int index = start; index < end; index++) {
                sliced.Add(items[index]);
            }
            return sliced;
        }

        public static ArrayList Slice(ArrayList items, int start, int end)
        {
            ArrayList sliced = new ArrayList();
            for (int index = start; index < end; index++) {
                sliced.Add(items[index]);
            }
            return sliced;
        }
    }
}
