using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Gist.Fundamentals.Format
{
    /// <summary>
    /// 标准数字格式字符串
    /// https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/standard-numeric-format-strings
    /// </summary>
    public static class NumericFormatGist
    {
        public static void Currency()
        {
            double source = 123.456;

            Console.WriteLine(source.ToString("C"));    // ￥123.46
            Console.WriteLine(source.ToString("C2"));   // ￥123.46
            Console.WriteLine(source.ToString("C3"));   // ￥123.456

            Console.WriteLine(source.ToString("C", CultureInfo.GetCultureInfo("en-US")));   // $123.46
            Console.WriteLine(source.ToString("C", CultureInfo.GetCultureInfo("zh-CN")));    // ￥123.46
        }
    }
}
