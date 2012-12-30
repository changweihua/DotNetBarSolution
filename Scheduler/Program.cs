using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NLite.Data;

namespace Scheduler
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DbConfiguration cfg = DbConfiguration
               .Configure("Scheduler")//通过connectionStringName对象创建DbConfiguration对象（可以用于配置文件中有多个数据库连接字符串配置）
                //.AddClass<MonoBookEntity.Index>()//注册实体到数据表的映射关系
                //.AddClass<MonoBookEntity.Index>(p =>
                //{
                //    p.TableName("tbIndex");
                //    p.Id(q => q.Id).DbGenerated().ColumnName("i_id");
                //    p.Column(q => q.Guid).ColumnName("i_guid");
                //    p.Column(q => q.TypeId).ColumnName("i_type_id");
                //})
               .AddClass<Appointment>()
               .AddClass<AppointmentLabel>()
               .AddClass<AppointmentDisplay>();

            Application.Run(new MainForm());
        }
    }
}
