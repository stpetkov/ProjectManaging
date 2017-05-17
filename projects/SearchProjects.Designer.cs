namespace projects
{
    partial class SearchProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.clientTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.beginDtp = new System.Windows.Forms.DateTimePicker();
            this.endDtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.detailBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.statusCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код на проект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Начало";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Край";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // noTxt
            // 
            this.noTxt.Location = new System.Drawing.Point(122, 20);
            this.noTxt.Name = "noTxt";
            this.noTxt.Size = new System.Drawing.Size(42, 20);
            this.noTxt.TabIndex = 6;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(122, 53);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(242, 20);
            this.nameTxt.TabIndex = 7;
            // 
            // clientTxt
            // 
            this.clientTxt.Location = new System.Drawing.Point(122, 86);
            this.clientTxt.Name = "clientTxt";
            this.clientTxt.Size = new System.Drawing.Size(242, 20);
            this.clientTxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // beginDtp
            // 
            this.beginDtp.Location = new System.Drawing.Point(122, 121);
            this.beginDtp.Name = "beginDtp";
            this.beginDtp.Size = new System.Drawing.Size(153, 20);
            this.beginDtp.TabIndex = 13;
            // 
            // endDtp
            // 
            this.endDtp.Location = new System.Drawing.Point(122, 155);
            this.endDtp.Name = "endDtp";
            this.endDtp.Size = new System.Drawing.Size(153, 20);
            this.endDtp.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 203);
            this.dataGridView1.TabIndex = 15;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(148, 229);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Търсене";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // detailBtn
            // 
            this.detailBtn.Location = new System.Drawing.Point(386, 306);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(136, 23);
            this.detailBtn.TabIndex = 17;
            this.detailBtn.Text = "Детайлна информация";
            this.detailBtn.UseVisualStyleBackColor = true;
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(386, 268);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(136, 23);
            this.summaryBtn.TabIndex = 18;
            this.summaryBtn.Text = "Обобщена информация";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(386, 346);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 23);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "Редактиране";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // statusCmb
            // 
            this.statusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCmb.FormattingEnabled = true;
            this.statusCmb.Items.AddRange(new object[] {
            "Нов",
            "В изпълнение",
            "Прекратен",
            "Замразен",
            "Приключил",
            "Без значение"});
            this.statusCmb.Location = new System.Drawing.Point(122, 192);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(153, 21);
            this.statusCmb.TabIndex = 20;
            this.statusCmb.SelectedIndexChanged += new System.EventHandler(this.statusCmb_SelectedIndexChanged);
            // 
            // SearchProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 497);
            this.Controls.Add(this.statusCmb);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.detailBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.endDtp);
            this.Controls.Add(this.beginDtp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.noTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Търсене по проекти";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox noTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox clientTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker beginDtp;
        private System.Windows.Forms.DateTimePicker endDtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button detailBtn;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox statusCmb;
    }
}