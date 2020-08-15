using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace SQLiteEFCodeFirstDemo
{
    public class Configuration : DbMigrationsConfiguration<MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(MyDatabase context)
        {
            context.Users.AddOrUpdate(
                    new Models.User { ID = 1, Name = "张三", Age = 22, Gender = "男", Location = "北京"},
                    new Models.User { ID = 2, Name = "李四", Age = 23, Gender = "男", Location = "上海"},
                    new Models.User { ID = 3, Name = "王五", Age = 30, Gender = "男", Location = "广州"},
                    new Models.User { ID = 4, Name = "赵六", Age = 27, Gender = "男", Location = "安徽"},
                    new Models.User { ID = 5, Name = "张丽", Age = 19, Gender = "女", Location = "深圳"}
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}