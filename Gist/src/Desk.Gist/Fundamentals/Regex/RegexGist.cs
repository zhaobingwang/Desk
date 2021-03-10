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

        /// <summary>
        /// 分组
        /// </summary>
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
            var matches = Regex.Matches(repeatString, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x)); // ABAB\nCDCD

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

        /// <summary>
        /// 匹配模式
        /// </summary>
        public static void MatchMode()
        {
            Console.WriteLine("不区分大小写模式：");
            // 不区分大小写 ?i
            var pattern = @"(?i)cat";
            var str = "catCATCat";
            var matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat
            // CAT
            // Cat

            // 连续出现两个cat
            Console.WriteLine("连续出现两个cat");
            str = "cat cat CAT cat";
            pattern = @"(?i)(cat) \1";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat cat
            // CAT cat

            // 连续出现两个cat && 大小写一致
            Console.WriteLine("连续出现两个cat && 大小写一致");
            str = "cat cat CAT cat CAT CAT";
            pattern = @"((?i)cat) \1";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat cat
            // CAT CAT

            // 部分区分大小写
            Console.WriteLine("部分区分大小写");
            str = "the cat The cat THE cat the Cat the CAT";
            pattern = @"((?i)THE) cat";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // the cat
            // The cat
            // THE cat

            // 直接使用编程语言中的预定义常量接口区分大小写
            Console.WriteLine("直接使用编程语言中的预定义常量接口区分大小写");
            pattern = @"(?i)cat";
            str = "catCATCat";
            matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat
            // CAT
            // Cat
            Console.WriteLine("\n\n");


            // 点号通配模式(单行匹配模式)
            Console.WriteLine("点号通配模式(单行匹配模式)：");
            str = "the little cat\nthe small cat";
            pattern = @"(?s)^the|cat$";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));

            // 多行匹配
            Console.WriteLine("多行匹配：");
            str = "the little cat\nthe small cat";
            pattern = @"(?m)^the|cat$";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));

            // 注释模式 (?#comment)
            Console.WriteLine("注释模式 (?#comment)");
            pattern = @"(?i)cat(?#这是一个注释)";
            str = "catCATCat";
            matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase);
            matches.ToList().ForEach(x => Console.WriteLine(x));
        }

        /// <summary>
        /// 断言
        /// </summary>
        public static void Assertion()
        {
            // 1. 单词边界 \b
            Console.WriteLine("1. 单词边界");
            var str = "tom asked me if I would go fishing with him tomorrow";
            var pattern = @"\btom\b";
            var matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // tom

            // 2. 行的开始或结束 ^ $
            Console.WriteLine("2. 行的开始或结束 ^ $");
            // Windows换行符： \r\n
            // Linux/macOS换行符： \n

            // 3. 环视 
            // (?<=Y)   左边是Y
            // (?<!Y)   左边不是Y
            // (?=Y)    右边是Y
            // (?!Y)    右边不是Y
            Console.WriteLine("3. 环视");
            // 邮编：第一位是1-9，一共6位数字
            Console.WriteLine("错误匹配");
            str = "012345\n";
            str += "123456\n";
            str += "1234567\n";
            str += "123456654321\n";
            pattern = @"[1-9]\d{5}";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // 123456
            // 123456
            // 123456
            // 654321
            Console.WriteLine("正确匹配");
            pattern = @"(?<!\d)[1-9]\d{5}(?!\d)";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // 123456


            Console.WriteLine("------找相同字符串-------");

            Console.WriteLine("无匹配");
            str = "the little cat cat2 is in the hat hat2,we like it";
            pattern = @"(\w+)(\s+\b\1\b)";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));

            // output:
            // 

            Console.WriteLine("匹配到重复字符串");
            str = "the little cat cat is in the hat hat,we like it";
            pattern = @"(\w+)(\s+\b\1\b)";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // cat cat
            // hat hat
        }

        /// <summary>
        /// 转义
        /// </summary>
        public static void EscapeCharacter()
        {
            Console.WriteLine("----------------------");
            var str = @"abc\d";
            var pattern = @"\\d";   // 匹配 \d
            var matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // \d
            Console.WriteLine("----------------------");
            str = @"abc\d111d\";
            pattern = @"\\|d";   // 匹配 \ || d
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // \
            // d
            // d
            // \
            Console.WriteLine("元字符转义");
            str = "+";
            pattern = @"\+";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // +

            Console.WriteLine("括号转义");
            // 方括号[]和花括号{}只需要转义开括号，圆括号()两个都需要转义
            str = "()[]{}";
            pattern = @"\(\)\[]\{}";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // ()[]{}

            str = "()[]{}";
            pattern = @"\(\)\[\]\{\}";
            matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // ()[]{}
        }

        public static void Unicode()
        {
            Console.WriteLine(char.GetUnicodeCategory('中'));
            Console.WriteLine("查找所有标点字符");
            // 参见：https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/character-classes-in-regular-expressions#SupportedNamedBlocks
            var str = "123正则表达式abc990()asd-=+.,a，";
            var pattern = @"\p{P}+";
            var matches = Regex.Matches(str, pattern);
            matches.ToList().ForEach(x => Console.WriteLine(x));
            // output:
            // ()
            // -
            // .,
            // ，
        }

        public static void WriteLine(string title = null)
        {
            Console.WriteLine();
            Console.WriteLine(title.PadLeft(15, '*').PadRight(30, '*'));
        }
    }
}
