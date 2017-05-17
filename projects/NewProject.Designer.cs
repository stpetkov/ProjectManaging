namespace projects
{
    partial class NewProject
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
            this.noTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hoursTxt = new System.Windows.Forms.TextBox();
            this.tasksBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.beginDtp = new System.Windows.Forms.DateTimePicker();
            this.endDtp = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.clientTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код на проект";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Начало";
            // 
            // noTxt
            // 
            this.noTxt.Location = new System.Drawing.Point(123, 31);
            this.noTxt.Name = "noTxt";
            this.noTxt.Size = new System.Drawing.Size(52, 20);
            this.noTxt.TabIndex = 5;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(123, 62);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(209, 20);
            this.nameTxt.TabIndex = 6;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(123, 93);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTxt.Size = new System.Drawing.Size(209, 65);
            this.descriptionTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Край";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Статус на проект";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Часова ставка";
            // 
            // hoursTxt
            // 
            this.hoursTxt.Location = new System.Drawing.Point(122, 308);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(52, 20);
            this.hoursTxt.TabIndex = 19;
            // 
            // tasksBtn
            // 
            this.tasksBtn.Location = new System.Drawing.Point(122, 344);
            this.tasksBtn.Name = "tasksBtn";
            this.tasksBtn.Size = new System.Drawing.Size(134, 23);
            this.tasksBtn.TabIndex = 23;
            this.tasksBtn.Text = "Задачи";
            this.tasksBtn.UseVisualStyleBackColor = true;
            this.tasksBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // beginDtp
            // 
            this.beginDtp.Location = new System.Drawing.Point(122, 209);
            this.beginDtp.Name = "beginDtp";
            this.beginDtp.Size = new System.Drawing.Size(210, 20);
            this.beginDtp.TabIndex = 25;
            // 
            // endDtp
            // 
            this.endDtp.Location = new System.Drawing.Point(122, 241);
            this.endDtp.Name = "endDtp";
            this.endDtp.Size = new System.Drawing.Size(210, 20);
            this.endDtp.TabIndex = 26;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(257, 383);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 27;
            this.saveBtn.Text = "Запази";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(124, 276);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(51, 20);
            this.statusTxt.TabIndex = 28;
            this.statusTxt.Text = "Нов";
            // 
            // clientTxt
            // 
            this.clientTxt.Location = new System.Drawing.Point(124, 175);
            this.clientTxt.Name = "clientTxt";
            this.clientTxt.Size = new System.Drawing.Size(208, 20);
            this.clientTxt.TabIndex = 29;
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(360, 433);
            this.Controls.Add(this.clientTxt);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.endDtp);
            this.Controls.Add(this.beginDtp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tasksBtn);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.noTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нов Проект";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hoursTxt;
        private System.Windows.Forms.Button tasksBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker beginDtp;
        private System.Windows.Forms.DateTimePicker endDtp;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.TextBox clientTxt;
    }
}