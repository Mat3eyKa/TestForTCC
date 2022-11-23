using System.Windows.Forms;

namespace UserForms
{
    partial class lbMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbMain));
            this.tbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFamel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.MaintoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SurnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatronymicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CityAddressToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetAddressToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HouseAddressToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomAddressToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateofbirthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texPhone = new System.Windows.Forms.TextBox();
            this.texPatronymic = new System.Windows.Forms.TextBox();
            this.texSurname = new System.Windows.Forms.TextBox();
            this.texName = new System.Windows.Forms.TextBox();
            this.CountOfRows = new System.Windows.Forms.Label();
            this.lbHelp = new System.Windows.Forms.Label();
            this.texCity = new System.Windows.Forms.TextBox();
            this.texStreet = new System.Windows.Forms.TextBox();
            this.texHouse = new System.Windows.Forms.TextBox();
            this.texRoom = new System.Windows.Forms.TextBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сlPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btSerch = new System.Windows.Forms.Button();
            this.texDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.HeaderText = "Имя";
            this.tbName.MinimumWidth = 8;
            this.tbName.Name = "tbName";
            this.tbName.Width = 150;
            // 
            // tbFamel
            // 
            this.tbFamel.HeaderText = "Фамилия";
            this.tbFamel.MinimumWidth = 8;
            this.tbFamel.Name = "tbFamel";
            this.tbFamel.Width = 150;
            // 
            // tbSurname
            // 
            this.tbSurname.HeaderText = "Отчество";
            this.tbSurname.MinimumWidth = 8;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Width = 150;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaintoolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1166, 34);
            this.toolStrip.TabIndex = 23;
            this.toolStrip.Text = "toolStrip";
            // 
            // MaintoolStripDropDownButton
            // 
            this.MaintoolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MaintoolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameToolStripMenuItem,
            this.SurnameToolStripMenuItem,
            this.PatronymicToolStripMenuItem,
            this.AddressToolStripMenuItem,
            this.PhoneToolStripMenuItem,
            this.DateofbirthToolStripMenuItem});
            this.MaintoolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("MaintoolStripDropDownButton.Image")));
            this.MaintoolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaintoolStripDropDownButton.Name = "MaintoolStripDropDownButton";
            this.MaintoolStripDropDownButton.Size = new System.Drawing.Size(187, 29);
            this.MaintoolStripDropDownButton.Text = "Параметры поиска";
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.Checked = true;
            this.NameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.NameToolStripMenuItem.Text = "Имя";
            this.NameToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // SurnameToolStripMenuItem
            // 
            this.SurnameToolStripMenuItem.Checked = true;
            this.SurnameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SurnameToolStripMenuItem.Name = "SurnameToolStripMenuItem";
            this.SurnameToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.SurnameToolStripMenuItem.Text = "Фамлия";
            this.SurnameToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // PatronymicToolStripMenuItem
            // 
            this.PatronymicToolStripMenuItem.Checked = true;
            this.PatronymicToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PatronymicToolStripMenuItem.Name = "PatronymicToolStripMenuItem";
            this.PatronymicToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.PatronymicToolStripMenuItem.Text = "Отчество";
            this.PatronymicToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // AddressToolStripMenuItem
            // 
            this.AddressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CityAddressToolStrip,
            this.StreetAddressToolStrip,
            this.HouseAddressToolStrip,
            this.RoomAddressToolStrip});
            this.AddressToolStripMenuItem.Name = "AddressToolStripMenuItem";
            this.AddressToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.AddressToolStripMenuItem.Text = "Адресс";
            // 
            // CityAddressToolStrip
            // 
            this.CityAddressToolStrip.Name = "CityAddressToolStrip";
            this.CityAddressToolStrip.Size = new System.Drawing.Size(191, 34);
            this.CityAddressToolStrip.Text = "Город";
            this.CityAddressToolStrip.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // StreetAddressToolStrip
            // 
            this.StreetAddressToolStrip.Name = "StreetAddressToolStrip";
            this.StreetAddressToolStrip.Size = new System.Drawing.Size(191, 34);
            this.StreetAddressToolStrip.Text = "Улица";
            this.StreetAddressToolStrip.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // HouseAddressToolStrip
            // 
            this.HouseAddressToolStrip.Name = "HouseAddressToolStrip";
            this.HouseAddressToolStrip.Size = new System.Drawing.Size(191, 34);
            this.HouseAddressToolStrip.Text = "Дом";
            this.HouseAddressToolStrip.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // RoomAddressToolStrip
            // 
            this.RoomAddressToolStrip.Name = "RoomAddressToolStrip";
            this.RoomAddressToolStrip.Size = new System.Drawing.Size(191, 34);
            this.RoomAddressToolStrip.Text = "Квартира";
            this.RoomAddressToolStrip.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // PhoneToolStripMenuItem
            // 
            this.PhoneToolStripMenuItem.Name = "PhoneToolStripMenuItem";
            this.PhoneToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.PhoneToolStripMenuItem.Text = "№ телефона";
            this.PhoneToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // DateofbirthToolStripMenuItem
            // 
            this.DateofbirthToolStripMenuItem.Name = "DateofbirthToolStripMenuItem";
            this.DateofbirthToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.DateofbirthToolStripMenuItem.Text = "Дата рождения";
            this.DateofbirthToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // texPhone
            // 
            this.texPhone.Location = new System.Drawing.Point(664, 67);
            this.texPhone.MaxLength = 12;
            this.texPhone.Name = "texPhone";
            this.texPhone.PlaceholderText = "Телефон для поиска";
            this.texPhone.Size = new System.Drawing.Size(146, 31);
            this.texPhone.TabIndex = 22;
            this.toolTip.SetToolTip(this.texPhone, "Для поска через это поле достаточно ввести одну цифру");
            this.texPhone.Visible = false;
            this.texPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsDigit);
            // 
            // texPatronymic
            // 
            this.texPatronymic.Location = new System.Drawing.Point(365, 67);
            this.texPatronymic.MaxLength = 15;
            this.texPatronymic.Name = "texPatronymic";
            this.texPatronymic.PlaceholderText = "Отчество для поиска";
            this.texPatronymic.Size = new System.Drawing.Size(146, 31);
            this.texPatronymic.TabIndex = 21;
            this.toolTip.SetToolTip(this.texPatronymic, "Для поска через это поле достаточно ввести одну букву");
            this.texPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texSurname
            // 
            this.texSurname.Location = new System.Drawing.Point(218, 67);
            this.texSurname.MaxLength = 15;
            this.texSurname.Name = "texSurname";
            this.texSurname.PlaceholderText = "Фамилия для поиска";
            this.texSurname.Size = new System.Drawing.Size(141, 31);
            this.texSurname.TabIndex = 20;
            this.toolTip.SetToolTip(this.texSurname, "Для поска через это поле достаточно ввести одну букву");
            this.texSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texName
            // 
            this.texName.Location = new System.Drawing.Point(65, 67);
            this.texName.MaxLength = 15;
            this.texName.Name = "texName";
            this.texName.PlaceholderText = "Имя для поиска";
            this.texName.Size = new System.Drawing.Size(147, 31);
            this.texName.TabIndex = 19;
            this.toolTip.SetToolTip(this.texName, "Для поска через это поле достаточно ввести одну букву");
            this.texName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // CountOfRows
            // 
            this.CountOfRows.AutoSize = true;
            this.CountOfRows.Location = new System.Drawing.Point(4, 22);
            this.CountOfRows.Name = "CountOfRows";
            this.CountOfRows.Size = new System.Drawing.Size(0, 25);
            this.CountOfRows.TabIndex = 18;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(198, 529);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(795, 25);
            this.lbHelp.TabIndex = 16;
            this.lbHelp.Text = "При обнаружении ошибки или отсутствия данных напишите на почту MatBeyKa004@gmail." +
    "com";
            // 
            // texCity
            // 
            this.texCity.Location = new System.Drawing.Point(816, 67);
            this.texCity.MaxLength = 12;
            this.texCity.Name = "texCity";
            this.texCity.PlaceholderText = "Город для поиска";
            this.texCity.Size = new System.Drawing.Size(136, 31);
            this.texCity.TabIndex = 25;
            this.toolTip.SetToolTip(this.texCity, "Для поска через это поле достаточно ввести одну букву");
            this.texCity.Visible = false;
            this.texCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texStreet
            // 
            this.texStreet.Location = new System.Drawing.Point(948, 67);
            this.texStreet.MaxLength = 12;
            this.texStreet.Name = "texStreet";
            this.texStreet.PlaceholderText = "Улица для поиска ";
            this.texStreet.Size = new System.Drawing.Size(131, 31);
            this.texStreet.TabIndex = 27;
            this.toolTip.SetToolTip(this.texStreet, "Для поска через это поле достаточно ввести одну букву");
            this.texStreet.Visible = false;
            this.texStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texHouse
            // 
            this.texHouse.Location = new System.Drawing.Point(1075, 67);
            this.texHouse.MaxLength = 12;
            this.texHouse.Name = "texHouse";
            this.texHouse.PlaceholderText = "Дом";
            this.texHouse.Size = new System.Drawing.Size(47, 31);
            this.texHouse.TabIndex = 28;
            this.toolTip.SetToolTip(this.texHouse, "Для поска через это поле достаточно ввести одну цифру");
            this.texHouse.Visible = false;
            this.texHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsDigit);
            // 
            // texRoom
            // 
            this.texRoom.Location = new System.Drawing.Point(1119, 67);
            this.texRoom.MaxLength = 12;
            this.texRoom.Name = "texRoom";
            this.texRoom.PlaceholderText = "Квартира";
            this.texRoom.Size = new System.Drawing.Size(46, 31);
            this.texRoom.TabIndex = 29;
            this.toolTip.SetToolTip(this.texRoom, "Для поска через это поле достаточно ввести одну цифру\r\n");
            this.texRoom.Visible = false;
            this.texRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsDigit);
            // 
            // dgvMain
            // 
            this.dgvMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clName,
            this.clSurname,
            this.сlPatronymic,
            this.clDateOfBirth,
            this.clPhone,
            this.clAddress});
            this.dgvMain.Location = new System.Drawing.Point(1, 104);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 33;
            this.dgvMain.Size = new System.Drawing.Size(1164, 422);
            this.dgvMain.TabIndex = 33;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "id";
            this.clID.HeaderText = "ID";
            this.clID.MinimumWidth = 8;
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Visible = false;
            this.clID.Width = 150;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Имя";
            this.clName.MinimumWidth = 8;
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 150;
            // 
            // clSurname
            // 
            this.clSurname.DataPropertyName = "Surname";
            this.clSurname.HeaderText = "Фамилия";
            this.clSurname.MinimumWidth = 8;
            this.clSurname.Name = "clSurname";
            this.clSurname.ReadOnly = true;
            this.clSurname.Width = 150;
            // 
            // сlPatronymic
            // 
            this.сlPatronymic.DataPropertyName = "Patronymic";
            this.сlPatronymic.HeaderText = "Отчестов";
            this.сlPatronymic.MinimumWidth = 8;
            this.сlPatronymic.Name = "сlPatronymic";
            this.сlPatronymic.ReadOnly = true;
            this.сlPatronymic.Width = 150;
            // 
            // clDateOfBirth
            // 
            this.clDateOfBirth.DataPropertyName = "DateOfBirth";
            this.clDateOfBirth.HeaderText = "Дата рождения";
            this.clDateOfBirth.MinimumWidth = 8;
            this.clDateOfBirth.Name = "clDateOfBirth";
            this.clDateOfBirth.ReadOnly = true;
            this.clDateOfBirth.Width = 150;
            // 
            // clPhone
            // 
            this.clPhone.DataPropertyName = "Phone";
            this.clPhone.HeaderText = "Телефон";
            this.clPhone.MinimumWidth = 8;
            this.clPhone.Name = "clPhone";
            this.clPhone.ReadOnly = true;
            this.clPhone.Width = 150;
            // 
            // clAddress
            // 
            this.clAddress.DataPropertyName = "Address";
            this.clAddress.HeaderText = "Адресс проживания";
            this.clAddress.MinimumWidth = 8;
            this.clAddress.Name = "clAddress";
            this.clAddress.ReadOnly = true;
            this.clAddress.Width = 350;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // btSerch
            // 
            this.btSerch.Location = new System.Drawing.Point(1053, 17);
            this.btSerch.Name = "btSerch";
            this.btSerch.Size = new System.Drawing.Size(112, 34);
            this.btSerch.TabIndex = 34;
            this.btSerch.Text = "Поиск";
            this.btSerch.UseVisualStyleBackColor = true;
            this.btSerch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // texDateofbirth
            // 
            this.texDateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.texDateofbirth.Location = new System.Drawing.Point(517, 67);
            this.texDateofbirth.Name = "texDateofbirth";
            this.texDateofbirth.Size = new System.Drawing.Size(141, 31);
            this.texDateofbirth.TabIndex = 35;
            // 
            // lbMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 554);
            this.Controls.Add(this.texDateofbirth);
            this.Controls.Add(this.btSerch);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.texRoom);
            this.Controls.Add(this.texHouse);
            this.Controls.Add(this.texStreet);
            this.Controls.Add(this.texCity);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texPatronymic);
            this.Controls.Add(this.texSurname);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.CountOfRows);
            this.Controls.Add(this.lbHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "lbMain";
            this.Text = "Main";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn tbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbFamel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbSurname;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton MaintoolStripDropDownButton;
        private ToolStripMenuItem NameToolStripMenuItem;
        private ToolStripMenuItem SurnameToolStripMenuItem;
        private ToolStripMenuItem PatronymicToolStripMenuItem;
        private ToolStripMenuItem AddressToolStripMenuItem;
        private ToolStripMenuItem CityAddressToolStrip;
        private ToolStripMenuItem StreetAddressToolStrip;
        private ToolStripMenuItem HouseAddressToolStrip;
        private ToolStripMenuItem RoomAddressToolStrip;
        private ToolStripMenuItem PhoneToolStripMenuItem;
        private ToolStripMenuItem DateofbirthToolStripMenuItem;
        private TextBox texPhone;
        private TextBox texPatronymic;
        private TextBox texSurname;
        private TextBox texName;
        private Label CountOfRows;
        private Label lbHelp;
        private TextBox texCity;
        private TextBox texStreet;
        private TextBox texHouse;
        private TextBox texRoom;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn clPatronymic;
        private ToolTip toolTip;
        private Button btSerch;
        private DataGridViewTextBoxColumn clID;
        private DataGridViewTextBoxColumn clName;
        private DataGridViewTextBoxColumn clSurname;
        private DataGridViewTextBoxColumn сlPatronymic;
        private DataGridViewTextBoxColumn clDateOfBirth;
        private DataGridViewTextBoxColumn clPhone;
        private DataGridViewTextBoxColumn clAddress;
        private DateTimePicker texDateofbirth;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
