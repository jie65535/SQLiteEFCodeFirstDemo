using System;
using System.Data.Entity;

using SQLiteEFCodeFirstDemo.Models;

namespace SQLiteEFCodeFirstDemo
{
    public class MyDatabase : DbContext
    {
        public MyDatabase()
            : base("name=MyDatabase")
        {
            // 解决参数中使用相对路径导致无法创建数据库问题
            // https://blog.csdn.net/kindmb/article/details/102328189
            Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // 设定初始化器为自动迁移数据库到最新版本
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDatabase, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 自动发现
            //modelBuilder.Configurations.AddFromAssembly(typeof(MyDatabase).Assembly);
        }

        public virtual DbSet<User> Users { get; set; }
    }
}