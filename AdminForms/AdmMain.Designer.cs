using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace AdminForms
{
    partial class AdmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.texRoom = new System.Windows.Forms.TextBox();
            this.texHouse = new System.Windows.Forms.TextBox();
            this.texStreet = new System.Windows.Forms.TextBox();
            this.texCity = new System.Windows.Forms.TextBox();
            this.texPatronymic = new System.Windows.Forms.TextBox();
            this.texSurname = new System.Windows.Forms.TextBox();
            this.texName = new System.Windows.Forms.TextBox();
            this.texPhone = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.MaintoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SurnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatronymicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CityAddressToolStripCity = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetAddressToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HouseAddressToolStripHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomAddressToolStripRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateofbirthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripUpdate = new System.Windows.Forms.ToolStripButton();
            this.lbHelp = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btSerch = new System.Windows.Forms.Button();
            this.texDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // texRoom
            // 
            this.texRoom.Location = new System.Drawing.Point(1321, 70);
            this.texRoom.MaxLength = 12;
            this.texRoom.Name = "texRoom";
            this.texRoom.PlaceholderText = "Квартира";
            this.texRoom.Size = new System.Drawing.Size(145, 31);
            this.texRoom.TabIndex = 66;
            this.toolTip.SetToolTip(this.texRoom, "Для поска через это поле достаточно ввести одну цифру");
            this.texRoom.Visible = false;
            // 
            // texHouse
            // 
            this.texHouse.Location = new System.Drawing.Point(1173, 69);
            this.texHouse.MaxLength = 12;
            this.texHouse.Name = "texHouse";
            this.texHouse.PlaceholderText = "Дом";
            this.texHouse.Size = new System.Drawing.Size(142, 31);
            this.texHouse.TabIndex = 65;
            this.toolTip.SetToolTip(this.texHouse, "Для поска через это поле достаточно ввести одну цифру");
            this.texHouse.Visible = false;
            // 
            // texStreet
            // 
            this.texStreet.Location = new System.Drawing.Point(1022, 69);
            this.texStreet.MaxLength = 12;
            this.texStreet.Name = "texStreet";
            this.texStreet.PlaceholderText = "Улица для поиска ";
            this.texStreet.Size = new System.Drawing.Size(145, 31);
            this.texStreet.TabIndex = 64;
            this.toolTip.SetToolTip(this.texStreet, "Для поска через это поле достаточно ввести одну букву");
            this.texStreet.Visible = false;
            // 
            // texCity
            // 
            this.texCity.Location = new System.Drawing.Point(873, 71);
            this.texCity.MaxLength = 12;
            this.texCity.Name = "texCity";
            this.texCity.PlaceholderText = "Город для поиска";
            this.texCity.Size = new System.Drawing.Size(143, 31);
            this.texCity.TabIndex = 63;
            this.toolTip.SetToolTip(this.texCity, "Для поска через это поле достаточно ввести одну букву");
            this.texCity.Visible = false;
            // 
            // texPatronymic
            // 
            this.texPatronymic.Location = new System.Drawing.Point(421, 71);
            this.texPatronymic.MaxLength = 15;
            this.texPatronymic.Name = "texPatronymic";
            this.texPatronymic.PlaceholderText = "Отчество для поиска";
            this.texPatronymic.Size = new System.Drawing.Size(146, 31);
            this.texPatronymic.TabIndex = 61;
            this.toolTip.SetToolTip(this.texPatronymic, "Для поска через это поле достаточно ввести одну букву");
            this.texPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texSurname
            // 
            this.texSurname.Location = new System.Drawing.Point(274, 71);
            this.texSurname.MaxLength = 15;
            this.texSurname.Name = "texSurname";
            this.texSurname.PlaceholderText = "Фамилия для поиска";
            this.texSurname.Size = new System.Drawing.Size(141, 31);
            this.texSurname.TabIndex = 60;
            this.toolTip.SetToolTip(this.texSurname, "Для поска через это поле достаточно ввести одну букву");
            this.texSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texName
            // 
            this.texName.AcceptsReturn = true;
            this.texName.AllowDrop = true;
            this.texName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texName.Location = new System.Drawing.Point(121, 71);
            this.texName.MaxLength = 15;
            this.texName.Name = "texName";
            this.texName.PlaceholderText = "Имя для поиска";
            this.texName.Size = new System.Drawing.Size(147, 31);
            this.texName.TabIndex = 59;
            this.toolTip.SetToolTip(this.texName, "Для поска через это поле достаточно ввести одну букву");
            this.texName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetters);
            // 
            // texPhone
            // 
            this.texPhone.Location = new System.Drawing.Point(729, 71);
            this.texPhone.MaxLength = 12;
            this.texPhone.Name = "texPhone";
            this.texPhone.PlaceholderText = "Город для поиска";
            this.texPhone.Size = new System.Drawing.Size(138, 31);
            this.texPhone.TabIndex = 68;
            this.toolTip.SetToolTip(this.texPhone, "Телефон поска через это поле достаточно ввести одну букву");
            this.texPhone.Visible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaintoolStripDropDownButton,
            this.toolStripButton1,
            this.toolStripUpdate});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1620, 34);
            this.toolStrip.TabIndex = 58;
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
            this.CityAddressToolStripCity,
            this.StreetAddressToolStrip,
            this.HouseAddressToolStripHouse,
            this.RoomAddressToolStripRoom});
            this.AddressToolStripMenuItem.Name = "AddressToolStripMenuItem";
            this.AddressToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.AddressToolStripMenuItem.Text = "Адресс";
            // 
            // CityAddressToolStripCity
            // 
            this.CityAddressToolStripCity.Name = "CityAddressToolStripCity";
            this.CityAddressToolStripCity.Size = new System.Drawing.Size(191, 34);
            this.CityAddressToolStripCity.Text = "Город";
            this.CityAddressToolStripCity.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // StreetAddressToolStrip
            // 
            this.StreetAddressToolStrip.Name = "StreetAddressToolStrip";
            this.StreetAddressToolStrip.Size = new System.Drawing.Size(191, 34);
            this.StreetAddressToolStrip.Text = "Улица";
            this.StreetAddressToolStrip.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // HouseAddressToolStripHouse
            // 
            this.HouseAddressToolStripHouse.Name = "HouseAddressToolStripHouse";
            this.HouseAddressToolStripHouse.Size = new System.Drawing.Size(191, 34);
            this.HouseAddressToolStripHouse.Text = "Дом";
            this.HouseAddressToolStripHouse.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
            // 
            // RoomAddressToolStripRoom
            // 
            this.RoomAddressToolStripRoom.Name = "RoomAddressToolStripRoom";
            this.RoomAddressToolStripRoom.Size = new System.Drawing.Size(191, 34);
            this.RoomAddressToolStripRoom.Text = "Квартира";
            this.RoomAddressToolStripRoom.Click += new System.EventHandler(this.ToolStripMenuItemSettings);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(213, 29);
            this.toolStripButton1.Text = "Добавить новую запись";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripUpdate
            // 
            this.toolStripUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUpdate.Image")));
            this.toolStripUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUpdate.Name = "toolStripUpdate";
            this.toolStripUpdate.Size = new System.Drawing.Size(97, 29);
            this.toolStripUpdate.Text = "Обновить";
            this.toolStripUpdate.Click += new System.EventHandler(this.toolStripUpdate_Click);
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(262, 646);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(795, 25);
            this.lbHelp.TabIndex = 56;
            this.lbHelp.Text = "При обнаружении ошибки или отсутствия данных напишите на почту MatBeyKa004@gmail." +
    "com";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMain.ColumnHeadersHeight = 34;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clName,
            this.clSurname,
            this.clPatronymic,
            this.clDateOfBirth,
            this.clPhone,
            this.clCity,
            this.clStreet,
            this.clHouse,
            this.clRoom,
            this.clCommand});
            this.dgvMain.Location = new System.Drawing.Point(0, 108);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 33;
            this.dgvMain.Size = new System.Drawing.Size(1618, 535);
            this.dgvMain.TabIndex = 55;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            this.dgvMain.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMain_CellValidating);
            this.dgvMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellValueChanged);
            // 
            // clID
            // 
            this.clID.DataPropertyName = "Id";
            this.clID.Frozen = true;
            this.clID.HeaderText = "ID";
            this.clID.MinimumWidth = 8;
            this.clID.Name = "clID";
            this.clID.Width = 60;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.Frozen = true;
            this.clName.HeaderText = "Имя";
            this.clName.MinimumWidth = 8;
            this.clName.Name = "clName";
            this.clName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clName.Width = 150;
            // 
            // clSurname
            // 
            this.clSurname.DataPropertyName = "Surname";
            this.clSurname.Frozen = true;
            this.clSurname.HeaderText = "Фамилия";
            this.clSurname.MinimumWidth = 8;
            this.clSurname.Name = "clSurname";
            this.clSurname.Width = 150;
            // 
            // clPatronymic
            // 
            this.clPatronymic.DataPropertyName = "Patronymic";
            this.clPatronymic.Frozen = true;
            this.clPatronymic.HeaderText = "Отчество";
            this.clPatronymic.MinimumWidth = 8;
            this.clPatronymic.Name = "clPatronymic";
            this.clPatronymic.Width = 150;
            // 
            // clDateOfBirth
            // 
            this.clDateOfBirth.DataPropertyName = "DateOfBirth";
            this.clDateOfBirth.Frozen = true;
            this.clDateOfBirth.HeaderText = "Дата рождения";
            this.clDateOfBirth.MinimumWidth = 8;
            this.clDateOfBirth.Name = "clDateOfBirth";
            this.clDateOfBirth.Width = 150;
            // 
            // clPhone
            // 
            this.clPhone.DataPropertyName = "Phone";
            this.clPhone.Frozen = true;
            this.clPhone.HeaderText = "Телефон";
            this.clPhone.MinimumWidth = 8;
            this.clPhone.Name = "clPhone";
            this.clPhone.Width = 150;
            // 
            // clCity
            // 
            this.clCity.DataPropertyName = "City";
            this.clCity.Frozen = true;
            this.clCity.HeaderText = "Город ";
            this.clCity.MinimumWidth = 8;
            this.clCity.Name = "clCity";
            this.clCity.Width = 150;
            // 
            // clStreet
            // 
            this.clStreet.DataPropertyName = "Street";
            this.clStreet.Frozen = true;
            this.clStreet.HeaderText = "Улица";
            this.clStreet.MinimumWidth = 8;
            this.clStreet.Name = "clStreet";
            this.clStreet.Width = 150;
            // 
            // clHouse
            // 
            this.clHouse.DataPropertyName = "House";
            this.clHouse.Frozen = true;
            this.clHouse.HeaderText = "Дом";
            this.clHouse.MinimumWidth = 8;
            this.clHouse.Name = "clHouse";
            this.clHouse.Width = 150;
            // 
            // clRoom
            // 
            this.clRoom.DataPropertyName = "Room";
            this.clRoom.Frozen = true;
            this.clRoom.HeaderText = "Квартира";
            this.clRoom.MinimumWidth = 8;
            this.clRoom.Name = "clRoom";
            this.clRoom.Width = 150;
            // 
            // clCommand
            // 
            this.clCommand.Frozen = true;
            this.clCommand.HeaderText = "Комманды";
            this.clCommand.MinimumWidth = 8;
            this.clCommand.Name = "clCommand";
            this.clCommand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clCommand.Text = "Удалить";
            this.clCommand.UseColumnTextForButtonValue = true;
            this.clCommand.Width = 150;
            // 
            // btSerch
            // 
            this.btSerch.Location = new System.Drawing.Point(1484, 68);
            this.btSerch.Name = "btSerch";
            this.btSerch.Size = new System.Drawing.Size(112, 34);
            this.btSerch.TabIndex = 69;
            this.btSerch.Text = "Поиск";
            this.btSerch.UseVisualStyleBackColor = true;
            this.btSerch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // texDateofbirth
            // 
            this.texDateofbirth.CalendarForeColor = System.Drawing.Color.Gray;
            this.texDateofbirth.CalendarMonthBackground = System.Drawing.Color.White;
            this.texDateofbirth.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.texDateofbirth.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.texDateofbirth.CustomFormat = "";
            this.texDateofbirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texDateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.texDateofbirth.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.texDateofbirth.Location = new System.Drawing.Point(573, 71);
            this.texDateofbirth.MaxDate = new System.DateTime(2022, 11, 23, 0, 0, 0, 0);
            this.texDateofbirth.MinDate = new System.DateTime(1910, 12, 25, 0, 0, 0, 0);
            this.texDateofbirth.Name = "texDateofbirth";
            this.texDateofbirth.Size = new System.Drawing.Size(150, 31);
            this.texDateofbirth.TabIndex = 70;
            this.texDateofbirth.Value = new System.DateTime(2002, 5, 26, 0, 0, 0, 0);
            this.texDateofbirth.Visible = false;
            // 
            // AdmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 691);
            this.Controls.Add(this.texDateofbirth);
            this.Controls.Add(this.btSerch);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texRoom);
            this.Controls.Add(this.texHouse);
            this.Controls.Add(this.texStreet);
            this.Controls.Add(this.texCity);
            this.Controls.Add(this.texPatronymic);
            this.Controls.Add(this.texSurname);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.dgvMain);
            this.MaximizeBox = false;
            this.Name = "AdmMain";
            this.Text = "AdmMain";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolTip toolTip;
        private TextBox texRoom;
        private TextBox texHouse;
        private TextBox texStreet;
        private TextBox texCity;
        private TextBox texPatronymic;
        private TextBox texSurname;
        private TextBox texName;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton MaintoolStripDropDownButton;
        private ToolStripMenuItem NameToolStripMenuItem;
        private ToolStripMenuItem SurnameToolStripMenuItem;
        private ToolStripMenuItem PatronymicToolStripMenuItem;
        private ToolStripMenuItem AddressToolStripMenuItem;
        private ToolStripMenuItem CityAddressToolStripCity;
        private ToolStripMenuItem StreetAddressToolStrip;
        private ToolStripMenuItem HouseAddressToolStripHouse;
        private ToolStripMenuItem RoomAddressToolStripRoom;
        private ToolStripMenuItem PhoneToolStripMenuItem;
        private ToolStripMenuItem DateofbirthToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private Label lbHelp;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn clID;
        private DataGridViewTextBoxColumn clName;
        private DataGridViewTextBoxColumn clSurname;
        private DataGridViewTextBoxColumn clPatronymic;
        private DataGridViewTextBoxColumn clDateOfBirth;
        private DataGridViewTextBoxColumn clPhone;
        private DataGridViewTextBoxColumn clCity;
        private DataGridViewTextBoxColumn clStreet;
        private DataGridViewTextBoxColumn clHouse;
        private DataGridViewTextBoxColumn clRoom;
        private DataGridViewButtonColumn clCommand;
        private TextBox texPhone;
        private Button btSerch;
        private ToolStripButton toolStripUpdate;
        private DateTimePicker texDateofbirth;
    }
}
