namespace SQLiteEFCodeFirstDemo
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.LblKeyword = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblLocation = new System.Windows.Forms.Label();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(474, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(24, 299);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(50, 23);
            this.BtnCreate.TabIndex = 9;
            this.BtnCreate.Text = "创建";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(617, 22);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 12;
            this.BtnRefresh.Text = "刷新";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(83, 299);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(50, 23);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "更新";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(142, 299);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(50, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Location = new System.Drawing.Point(216, 327);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(0, 12);
            this.LblText.TabIndex = 0;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(49, 23);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(63, 21);
            this.TxtID.TabIndex = 1;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(22, 27);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 12);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID:";
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(118, 22);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnQuery.TabIndex = 2;
            this.BtnQuery.Text = "查找";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Location = new System.Drawing.Point(269, 23);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(100, 21);
            this.TxtKeyword.TabIndex = 3;
            // 
            // LblKeyword
            // 
            this.LblKeyword.AutoSize = true;
            this.LblKeyword.Location = new System.Drawing.Point(216, 27);
            this.LblKeyword.Name = "LblKeyword";
            this.LblKeyword.Size = new System.Drawing.Size(47, 12);
            this.LblKeyword.TabIndex = 0;
            this.LblKeyword.Text = "关键字:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(375, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "搜索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(21, 120);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 12);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "姓名:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(62, 117);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 21);
            this.TxtName.TabIndex = 5;
            // 
            // CmbGender
            // 
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CmbGender.Location = new System.Drawing.Point(62, 158);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(130, 20);
            this.CmbGender.TabIndex = 6;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(21, 160);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(35, 12);
            this.LblGender.TabIndex = 0;
            this.LblGender.Text = "性别:";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(21, 203);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(35, 12);
            this.LblAge.TabIndex = 0;
            this.LblAge.Text = "年龄:";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(62, 198);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(130, 21);
            this.TxtAge.TabIndex = 7;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(21, 244);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(35, 12);
            this.LblLocation.TabIndex = 0;
            this.LblLocation.Text = "地区:";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(62, 239);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(130, 21);
            this.TxtLocation.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 348);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.LblKeyword);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.TxtKeyword);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeFirst的SQLite EF示例程序";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.Label LblKeyword;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TxtLocation;
    }
}

