
using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Core.Extension;
using Magicodes.ExporterAndImporter.Core.Filters;
using Magicodes.ExporterAndImporter.Core.Models;
using Magicodes.ExporterAndImporter.Excel;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// Here is Magicodes.IE demo.
/// The project of Magicodes.IE is located in: https://github.com/dotnetcore/Magicodes.IE
/// </summary>
namespace Desk.Demo.MagicodesIEGist
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                await Export2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("end");
        }


        public static async Task ExportHeader()
        {
            var exporter = new ExcelExporter();

            var filePath = "test.xlsx";
            var arr = new[] { "Name1", "Name2", "Name3", "Name4", "Name5", "Name6" };
            var sheetName = "Test";
            var result = await exporter.ExportHeaderAsByteArray(arr, sheetName);
            result.ToExcelExportFileInfo(filePath);
        }

        public static async Task ExportHeader2()
        {
            var exporter = new ExcelExporter();

            var filePath = "test.xlsx";
            var result = await exporter.ExportHeaderAsByteArray(new Student());
            result.ToExcelExportFileInfo(filePath);
        }

        public static async Task Export()
        {
            var exporter = new ExcelExporter();
            var result = await exporter.Export("test.xlsx", new List<Student>() {
                new Student
                {
                    Name = "MR.A",
                    Age = 18
                },
                new Student
                {
                    Name = "MR.B",
                    Age = 19
                },
                new Student
                {
                    Name = "MR.B",
                    Age = 20
                }
            });
        }

        public static async Task Export2()
        {
            IExporter exporter = new ExcelExporter();
            var result = await exporter.Export("test.xlsx", new List<Student2>()
            {
                new Student2
                {
                    Name = "MR.A",
                    Age = 17,
                    Remarks = "我叫MR.A,今年17岁",
                    Birthday=DateTime.Now,
                    Adult="no",
                },
                new Student2
                {
                    Name = "MR.A",
                    Age = 18,
                    Remarks = "我叫MR.A,今年18岁",
                    Birthday=DateTime.Now,
                    Adult="yes"
                },
                new Student2
                {
                    Name = "MR.B",
                    Age = 19,
                    Remarks = "我叫MR.B,今年19岁",
                    Birthday=DateTime.Now,
                },
                new Student2
                {
                    Name = "MR.C",
                    Age = 20,
                    Remarks = "我叫MR.C,今年20岁",
                    Birthday=DateTime.Now,
                }
            });
        }
    }

    public class Student
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
    }

    /// <summary>
    /// 学生信息
    /// </summary>
    [ExcelExporter(Name = "学生信息", TableStyle = TableStyles.Light10, AutoFitAllColumn = true, MaxRowNumberOnASheet = 21,
        ExporterHeaderFilter = typeof(ExporterStudentHeaderFilter))]
    public class Student2
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [ExporterHeader(DisplayName = "姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [ExporterHeader(DisplayName = "年龄")]
        public int Age { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [ExporterHeader(DisplayName = "出生日期", Format = "yyyy-MM-dd")]
        public DateTime Birthday { get; set; }

        [ExporterHeader(DisplayName = "是否成年")]
        [ValueMapping("yes", true)]
        [ValueMapping("no", false)]
        public string Adult { get; set; }
    }

    public class ExporterStudentHeaderFilter : IExporterHeaderFilter
    {
        /// <summary>
        /// 表头筛选器（修改名称）
        /// </summary>
        /// <param name="exporterHeaderInfo"></param>
        /// <returns></returns>
        public ExporterHeaderInfo Filter(ExporterHeaderInfo exporterHeaderInfo)
        {
            if (exporterHeaderInfo.DisplayName.Equals("姓名"))
            {
                exporterHeaderInfo.DisplayName = "name";
            }
            return exporterHeaderInfo;
        }
    }
}
