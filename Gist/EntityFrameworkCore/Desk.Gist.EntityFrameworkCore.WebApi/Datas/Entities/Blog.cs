using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Gist.EntityFrameworkCore.WebApi.Datas.Entities
{
    [Table("blogs", Schema = Const.SCHEMA_DEFAULT)]
    public class Blog
    {
        public int Id { get; set; }

        // 可将特性（称为数据注释）应用于类和属性。 数据注释会替代约定，但会被 Fluent API 配置替代。
        [Required]
        public string Url { get; set; }
    }
}
