using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Desk.Gist.Fundamentals
{
    public static class RegexGist
    {
        public const string Common_Character = "abcdefghijklmnopqrstuvwxyz" +
            "0123456789" +
            "~`!@#$%^&*()_+-=" +
            "{}|[]\\;':\",./<>?" +
            "\n" +
            "\n";

        /// <summary>
        /// 元字符
        /// </summary>
        public static void Metacharacter()
        {
            // \d 任意数字
            WriteLine(@"\d");
            Regex.Matches(Common_Character, @"\d").ToList().ForEach(x => Console.Write(x)); // 0123456789

            // \D 任意非数字
            WriteLine(@"\D");
            Regex.Matches(Common_Character, @"\D").ToList().ForEach(x => Console.Write(x)); // abcdefghijklmnopqrstuvwxyz~`!@#$%^&*()_+-={}|[]\;':",./<>?\n\n


            // \w 任意字母数字下划线
            WriteLine(@"\w");
            Regex.Matches(Common_Character, @"\w").ToList().ForEach(x => Console.Write(x)); // abcdefghijklmnopqrstuvwxyz0123456789_

            // \W 任意非字母数字下划线
            WriteLine(@"\W");
            Regex.Matches(Common_Character, @"\W").ToList().ForEach(x => Console.Write(x)); // ~`!@#$%^&*()+-={}|[]\;':",./<>?\n\n

            // \s 任意空白符
            WriteLine(@"\s");
            Regex.Matches(Common_Character, @"\s").ToList().ForEach(x => Console.Write(x)); // \n\n

            // \s 任意非空白符
            WriteLine(@"\S");
            Regex.Matches(Common_Character, @"\S").ToList().ForEach(x => Console.Write(x)); // abcdefghijklmnopqrstuvwxyz0123456789~`!@#$%^&*()_+-={}|[]\;':",./<>?

        }

        public static void WriteLine(string title = null)
        {
            Console.WriteLine();
            Console.WriteLine(title.PadLeft(15, '*').PadRight(30, '*'));
        }
    }
}
