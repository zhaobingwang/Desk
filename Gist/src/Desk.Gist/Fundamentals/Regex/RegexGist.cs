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

        public static void Group()
        {
            var datetimeString = "2021-03-05 15:00:00";

            // 分组与编号
            Console.WriteLine("分组与编号：");
            var pattern = @"(\d{4}-\d{2}-\d{2}) (\d{2}:\d{2}:\d{2})";
            var groups = Regex.Match(datetimeString, pattern).Groups;   // 共2组，但是groups里多一个记录（完整匹配的值）
            Console.WriteLine(groups.Count);    // 3
            Console.WriteLine(groups[0]);   // 2021-03-05 15:00:00
            Console.WriteLine(groups[1]);   // 2021-03-05
            Console.WriteLine(groups[2]);   // 15:00:00
            Console.WriteLine(Regex.Match(datetimeString, pattern));    // 2021-03-05 15:00:00
            Console.WriteLine(Regex.IsMatch(datetimeString, pattern));  // True

            // 不保存子组?:
            //pattern = @"(\d{4}-\d{2}-\d{2}) (?:\d{2}:\d{2}:\d{2})"; // 此模式返回的groups只剩下前两个了
            // 括号嵌套
            Console.WriteLine("括号嵌套：");
            pattern = @"((\d{4})-(\d{2})-(\d{2})) ((\d{2}):(\d{2}):(\d{2}))";
            groups = Regex.Match(datetimeString, pattern).Groups;   // 共8组，但是groups里多一个记录（完整匹配的值）
            Console.WriteLine(groups.Count);    // 9
            Console.WriteLine(groups[0]);   // 2021-03-05 15:00:00
            Console.WriteLine(groups[1]);   // 2021-03-05
            Console.WriteLine(groups[2]);   // 2021
            Console.WriteLine(groups[3]);   // 03
            Console.WriteLine(groups[4]);   // 05
            Console.WriteLine(groups[5]);   // 15:00:00
            Console.WriteLine(groups[6]);   // 15
            Console.WriteLine(groups[7]);   // 00
            Console.WriteLine(groups[8]);   // 00

            // 命名分组
            Console.WriteLine("命名分组：");
            pattern = @"(?<p1>\d{4}-\d{2}-\d{2}) (?<p2>\d{2}:\d{2}:\d{2})";
            groups = Regex.Match(datetimeString, pattern).Groups;
            Console.WriteLine(groups[0]);   // 2021-03-05 15:00:00
            Console.WriteLine(groups["p1"]);   // 2021-03-05
            Console.WriteLine(groups["p2"]);   // 15:00:00

            // 分组引用(反向引用)
            Console.WriteLine("分组引用：");
            var repeatString = "ABAB CDCD";
            pattern = @"(\w{2})\1";
            var matchs = Regex.Matches(repeatString, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x)); // ABAB\nCDCD

            // 替换
            Console.WriteLine("替换：");
            pattern = @"((\d{4})-(\d{2})-(\d{2})) ((\d{2}):(\d{2}):(\d{2}))";

            // 分组编号替换
            // 有些语言或工具可能使用："\2年\3月\4日 \6时\7分\8秒" 进行替换
            var replaced = Regex.Replace(datetimeString, pattern, @"$2年$3月$4日 $6时$7分$8秒");  // 2021年03月05日 15时00分00秒
            Console.WriteLine(replaced);

            // 分组命名替换
            pattern = @"((?<year>\d{4})-(?<month>\d{2})-(?<day>\d{2})) ((?<hour>\d{2}):(?<min>\d{2}):(?<sec>\d{2}))";
            replaced = Regex.Replace(datetimeString, pattern, @"${year}年${month}月${day}日 ${hour}时${min}分${sec}秒");  // 2021年03月05日 15时00分00秒
            Console.WriteLine(replaced);
        }

        public static void MatchMode()
        {
            Console.WriteLine("不区分大小写模式：");
            // 不区分大小写 ?i
            var pattern = @"(?i)cat";
            var str = "catCATCat";
            var matchs = Regex.Matches(str, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat
            // CAT
            // Cat

            // 连续出现两个cat
            Console.WriteLine("连续出现两个cat");
            str = "cat cat CAT cat";
            pattern = @"(?i)(cat) \1";
            matchs = Regex.Matches(str, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat cat
            // CAT cat

            // 连续出现两个cat && 大小写一致
            Console.WriteLine("连续出现两个cat && 大小写一致");
            str = "cat cat CAT cat CAT CAT";
            pattern = @"((?i)cat) \1";
            matchs = Regex.Matches(str, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat cat
            // CAT CAT

            // 部分区分大小写
            Console.WriteLine("部分区分大小写");
            str = "the cat The cat THE cat the Cat the CAT";
            pattern = @"((?i)THE) cat";
            matchs = Regex.Matches(str, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // the cat
            // The cat
            // THE cat

            // 直接使用编程语言中的预定义常量接口区分大小写
            Console.WriteLine("直接使用编程语言中的预定义常量接口区分大小写");
            pattern = @"(?i)cat";
            str = "catCATCat";
            matchs = Regex.Matches(str, pattern, RegexOptions.IgnoreCase);
            matchs.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat
            // CAT
            // Cat
            Console.WriteLine("\n\n");


            // 点号通配模式(单行匹配模式)
            Console.WriteLine("点号通配模式(单行匹配模式)：");
            str = "the little cat\nthe small cat";
            pattern = @"(?s)^the|cat$";
            matchs = Regex.Matches(str, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x));

            // 多行匹配
            Console.WriteLine("多行匹配：");
            str = "the little cat\nthe small cat";
            pattern = @"(?m)^the|cat$";
            matchs = Regex.Matches(str, pattern);
            matchs.ToList().ForEach(x => Console.WriteLine(x));

            // 注释模式 (?#comment)
            Console.WriteLine("注释模式 (?#comment)");
            pattern = @"(?i)cat(?#这是一个注释)";
            str = "catCATCat";
            matchs = Regex.Matches(str, pattern, RegexOptions.IgnoreCase);
            matchs.ToList().ForEach(x => Console.WriteLine(x));
        }

        public static void WriteLine(string title = null)
        {
            Console.WriteLine();
            Console.WriteLine(title.PadLeft(15, '*').PadRight(30, '*'));
        }
    }
}
