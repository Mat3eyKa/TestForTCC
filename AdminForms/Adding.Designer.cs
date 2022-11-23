namespace AdminForms
{
    partial class Adding
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
            this.texAddName = new System.Windows.Forms.TextBox();
            this.texAddCity = new System.Windows.Forms.TextBox();
            this.texAddPatronymic = new System.Windows.Forms.TextBox();
            this.texAddSurname = new System.Windows.Forms.TextBox();
            this.texAddHouse = new System.Windows.Forms.TextBox();
            this.texAddStreet = new System.Windows.Forms.TextBox();
            this.texAddRoom = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texAddDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.texAddPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // texAddName
            // 
            this.texAddName.Location = new System.Drawing.Point(47, 58);
            this.texAddName.Name = "texAddName";
            this.texAddName.PlaceholderText = "Имя ";
            this.texAddName.Size = new System.Drawing.Size(186, 31);
            this.texAddName.TabIndex = 0;
            this.texAddName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texAddCity
            // 
            this.texAddCity.Location = new System.Drawing.Point(277, 82);
            this.texAddCity.Name = "texAddCity";
            this.texAddCity.PlaceholderText = "Город ";
            this.texAddCity.Size = new System.Drawing.Size(187, 31);
            this.texAddCity.TabIndex = 1;
            this.texAddCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texAddPatronymic
            // 
            this.texAddPatronymic.Location = new System.Drawing.Point(47, 162);
            this.texAddPatronymic.Name = "texAddPatronymic";
            this.texAddPatronymic.PlaceholderText = "Отчество";
            this.texAddPatronymic.Size = new System.Drawing.Size(186, 31);
            this.texAddPatronymic.TabIndex = 4;
            this.texAddPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texAddSurname
            // 
            this.texAddSurname.Location = new System.Drawing.Point(47, 110);
            this.texAddSurname.Name = "texAddSurname";
            this.texAddSurname.PlaceholderText = "Фамилия";
            this.texAddSurname.Size = new System.Drawing.Size(186, 31);
            this.texAddSurname.TabIndex = 5;
            this.texAddSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texAddHouse
            // 
            this.texAddHouse.Location = new System.Drawing.Point(277, 197);
            this.texAddHouse.Name = "texAddHouse";
            this.texAddHouse.PlaceholderText = "Дом";
            this.texAddHouse.Size = new System.Drawing.Size(187, 31);
            this.texAddHouse.TabIndex = 6;
            this.texAddHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsDigit);
            // 
            // texAddStreet
            // 
            this.texAddStreet.Location = new System.Drawing.Point(277, 138);
            this.texAddStreet.Name = "texAddStreet";
            this.texAddStreet.PlaceholderText = "Улица";
            this.texAddStreet.Size = new System.Drawing.Size(187, 31);
            this.texAddStreet.TabIndex = 7;
            this.texAddStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texAddRoom
            // 
            this.texAddRoom.Location = new System.Drawing.Point(277, 247);
            this.texAddRoom.Name = "texAddRoom";
            this.texAddRoom.PlaceholderText = "Квартира";
            this.texAddRoom.Size = new System.Drawing.Size(187, 31);
            this.texAddRoom.TabIndex = 8;
            this.texAddRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsDigit);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(200, 328);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 34);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Добавление записи";
            // 
            // texAddDateOfBirth
            // 
            this.texAddDateOfBirth.Location = new System.Drawing.Point(47, 218);
            this.texAddDateOfBirth.Mask = "00/00/0000";
            this.texAddDateOfBirth.Name = "texAddDateOfBirth";
            this.texAddDateOfBirth.Size = new System.Drawing.Size(186, 31);
            this.texAddDateOfBirth.TabIndex = 11;
            this.texAddDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // texAddPhone
            // 
            this.texAddPhone.Location = new System.Drawing.Point(46, 270);
            this.texAddPhone.Name = "texAddPhone";
            this.texAddPhone.PlaceholderText = "Телефон";
            this.texAddPhone.Size = new System.Drawing.Size(187, 31);
            this.texAddPhone.TabIndex = 12;
            this.texAddPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsDigit);
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 392);
            this.Controls.Add(this.texAddPhone);
            this.Controls.Add(this.texAddDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.texAddRoom);
            this.Controls.Add(this.texAddStreet);
            this.Controls.Add(this.texAddHouse);
            this.Controls.Add(this.texAddSurname);
            this.Controls.Add(this.texAddPatronymic);
            this.Controls.Add(this.texAddCity);
            this.Controls.Add(this.texAddName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adding";
            this.Text = "Adding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texAddName;
        private System.Windows.Forms.TextBox texAddCity;
        private System.Windows.Forms.TextBox texAddPatronymic;
        private System.Windows.Forms.TextBox texAddSurname;
        private System.Windows.Forms.TextBox texAddHouse;
        private System.Windows.Forms.TextBox texAddStreet;
        private System.Windows.Forms.TextBox texAddRoom;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox texAddDateOfBirth;
        private System.Windows.Forms.TextBox texAddPhone;
    }
}