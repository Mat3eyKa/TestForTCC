namespace ClientForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.texPhone = new System.Windows.Forms.TextBox();
            this.texPatronymic = new System.Windows.Forms.TextBox();
            this.texSurname = new System.Windows.Forms.TextBox();
            this.texName = new System.Windows.Forms.TextBox();
            this.lbHelp = new System.Windows.Forms.Label();
            this.CountOfRows = new System.Windows.Forms.Label();
            this.Serch = new System.Windows.Forms.Button();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmName});
            this.dgvMain.Location = new System.Drawing.Point(61, 214);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 33;
            this.dgvMain.Size = new System.Drawing.Size(360, 225);
            this.dgvMain.TabIndex = 16;
            // 
            // texPhone
            // 
            this.texPhone.Location = new System.Drawing.Point(489, 97);
            this.texPhone.MaxLength = 12;
            this.texPhone.Name = "texPhone";
            this.texPhone.PlaceholderText = "Телефон для поиска";
            this.texPhone.Size = new System.Drawing.Size(150, 31);
            this.texPhone.TabIndex = 15;
            // 
            // texPatronymic
            // 
            this.texPatronymic.Location = new System.Drawing.Point(333, 97);
            this.texPatronymic.MaxLength = 15;
            this.texPatronymic.Name = "texPatronymic";
            this.texPatronymic.PlaceholderText = "Отчество для поиска";
            this.texPatronymic.Size = new System.Drawing.Size(150, 31);
            this.texPatronymic.TabIndex = 14;
            // 
            // texSurname
            // 
            this.texSurname.Location = new System.Drawing.Point(177, 97);
            this.texSurname.MaxLength = 15;
            this.texSurname.Name = "texSurname";
            this.texSurname.PlaceholderText = "Фамилия для поиска";
            this.texSurname.Size = new System.Drawing.Size(150, 31);
            this.texSurname.TabIndex = 13;
            // 
            // texName
            // 
            this.texName.Location = new System.Drawing.Point(21, 97);
            this.texName.MaxLength = 15;
            this.texName.Name = "texName";
            this.texName.PlaceholderText = "Имя для поиска";
            this.texName.Size = new System.Drawing.Size(150, 31);
            this.texName.TabIndex = 12;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(104, 561);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(795, 25);
            this.lbHelp.TabIndex = 11;
            this.lbHelp.Text = "При обнаружении ошибки или отсутствия данных напишите на почту MatBeyKa004@gmail." +
    "com";
            // 
            // CountOfRows
            // 
            this.CountOfRows.AutoSize = true;
            this.CountOfRows.Location = new System.Drawing.Point(21, 4);
            this.CountOfRows.Name = "CountOfRows";
            this.CountOfRows.Size = new System.Drawing.Size(270, 25);
            this.CountOfRows.TabIndex = 10;
            this.CountOfRows.Text = "Общее колличество записей: 0 ";
            // 
            // Serch
            // 
            this.Serch.Location = new System.Drawing.Point(861, 97);
            this.Serch.Name = "Serch";
            this.Serch.Size = new System.Drawing.Size(112, 34);
            this.Serch.TabIndex = 9;
            this.Serch.Text = "Поиск";
            this.Serch.UseVisualStyleBackColor = true;
            this.Serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // cmName
            // 
            this.cmName.HeaderText = "Имя";
            this.cmName.MinimumWidth = 8;
            this.cmName.Name = "cmName";
            this.cmName.Width = 150;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 588);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texPatronymic);
            this.Controls.Add(this.texSurname);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.CountOfRows);
            this.Controls.Add(this.Serch);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox texPhone;
        private System.Windows.Forms.TextBox texPatronymic;
        private System.Windows.Forms.TextBox texSurname;
        private System.Windows.Forms.TextBox texName;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label CountOfRows;
        private System.Windows.Forms.Button Serch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
    }
}
