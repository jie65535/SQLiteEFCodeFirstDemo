using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using SQLiteEFCodeFirstDemo.Models;

namespace SQLiteEFCodeFirstDemo
{
    /*********************************
     * CodeFirst模式下EF SQLite示例程序
     * 
     * 参考链接：
     *
     * C#/.NET VS2017+ EF+SQLite.CodeFirst——真正实现CodeFirst
     * https://blog.csdn.net/qq_34202873/article/details/85068877
     * 
     * Sqlite：Code First模式
     * https://blog.csdn.net/wucdsg/article/details/78895366
     * 
     * SQLite 的 CodeFirst 模式
     * https://www.cnblogs.com/hippieZhou/archive/2018/08/04/9420432.html
     * 
     * 以SQLite作为数据库的CodeFirst模式开发及踩的坑
     * https://blog.csdn.net/kindmb/article/details/102293986
     * 
     * SQLite在XP下出现no such table异常与找不到SQLite.Interop.dll故障
     * https://blog.csdn.net/kindmb/article/details/102328189
     * 
     * Sqlite && EF Code FIRST 终极解决方案 2019.5.17#
     * https://www.cnblogs.com/swobble/p/10881756.html
     * 
     * SQLite CodeFirst、Migration 的趟坑过程
     * https://blog.csdn.net/myinc/article/details/61953193
     * 
     * 感谢以上文章原作者
     * 
     ********************************/
    public partial class FormMain : Form
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 创建按钮事件
        /// </summary>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            using (var db = new MyDatabase())
            {
                db.Users.Add(GetInputUserInfo());
                int count = db.SaveChanges();
                LblText.Text = $"{DateTime.Now}，插入{count}条记录";
                RefreshData();
            }
        }


        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new MyDatabase())
            {
                var user = db.Users.FirstOrDefault(x => x.ID == int.Parse(TxtID.Text));
                if (user != null)
                {
                    var result = db.Users.Remove(user);
                    int count = db.SaveChanges();
                    LblText.Text = $"{DateTime.Now}, 删除{count}条记录";
                    SetInputUserInfo(null);
                    RefreshData();
                }
            }
        }


        /// <summary>
        /// 查找按钮事件
        /// </summary>
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            using (var db = new MyDatabase())
            {
                var user = db.Users.Find(int.Parse(TxtID.Text));
                if (user == null)
                    LblText.Text = $"{DateTime.Now}, 未找到指定用户";
                else
                    SetInputUserInfo(user);
            }
        }

        /// <summary>
        /// 刷新按钮事件
        /// </summary>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// 搜索按钮事件
        /// </summary>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtKeyword.Text))
                return;
            using (var db = new MyDatabase())
            {
                var users = db.Users.Where(x => x.Name.Contains(TxtKeyword.Text)).ToList();
                LblText.Text = $"{DateTime.Now}, 查到{users.Count}条记录";
                dataGridView1.DataSource = users;
            }
        }

        /// <summary>
        /// 更新按钮事件
        /// </summary>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new MyDatabase())
            {
                var user = GetInputUserInfo();
                user.ID = int.Parse(TxtID.Text);
                db.Users.Attach(user);
                int count = db.SaveChanges();
                LblText.Text = $"{DateTime.Now}, 修改{count}条记录";
                RefreshData();
            }
        }

        /// <summary>
        /// 行选中时触发
        /// </summary>
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 更新左侧输入框
                if (dataGridView1.DataSource is List<User> users)
                    SetInputUserInfo(users[e.RowIndex]);
            }
        }

        /// <summary>
        /// 获取输入框用户信息
        /// </summary>
        /// <returns></returns>
        private User GetInputUserInfo()
        {
            return new User
            {
                Name     = TxtName.Text,
                Gender   = CmbGender.Text,
                Age      = int.Parse(TxtAge.Text),
                Location = TxtLocation.Text
            };
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        private void RefreshData()
        {
            using (var db = new MyDatabase())
            {
                var users = db.Users.ToList();
                dataGridView1.DataSource = users;
            }
        }

        /// <summary>
        /// 设置输入框用户信息
        /// </summary>
        /// <param name="user"></param>
        private void SetInputUserInfo(User user)
        {
            if (user != null)
            {
                TxtID.Text       = user.ID.ToString();
                TxtName.Text     = user.Name;
                CmbGender.Text   = user.Gender;
                TxtAge.Text      = user.Age.ToString();
                TxtLocation.Text = user.Location;
            }
            else
            {
                TxtID.Text              = string.Empty;
                TxtName.Text            = string.Empty;
                CmbGender.SelectedIndex = 0;
                TxtAge.Text             = string.Empty;
                TxtLocation.Text        = string.Empty;
            }
        }

        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}