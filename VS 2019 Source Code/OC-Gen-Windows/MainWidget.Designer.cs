
namespace OC_Gen_Windows
{
    partial class MainWidget
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWidget));
            this.panel_MainWidget = new System.Windows.Forms.Panel();
            this.tab_Generate = new System.Windows.Forms.Button();
            this.tab_SMBios = new System.Windows.Forms.Button();
            this.tab_Quirks = new System.Windows.Forms.Button();
            this.tab_Drivers = new System.Windows.Forms.Button();
            this.tab_Kexts = new System.Windows.Forms.Button();
            this.tab_Hardware = new System.Windows.Forms.Button();
            this.panel_Hardware = new System.Windows.Forms.Panel();
            this.hardware_comboBox = new System.Windows.Forms.ComboBox();
            this.trigger_AMDHardware = new XanderUI.XUIButton();
            this.trigger_HEDTHardware = new XanderUI.XUIButton();
            this.trigger_IntelHARDWARE = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Kexts = new System.Windows.Forms.Panel();
            this.KextsTab = new System.Windows.Forms.TabControl();
            this.kext_Essentials = new System.Windows.Forms.TabPage();
            this.Essentials_checkList = new System.Windows.Forms.CheckedListBox();
            this.Kext_Audio = new System.Windows.Forms.TabPage();
            this.audio_textbox_Alcid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Audio_checkLlist = new System.Windows.Forms.CheckedListBox();
            this.Kext_Graphics = new System.Windows.Forms.TabPage();
            this.Graphics_Intel_group = new XanderUI.XUICustomGroupbox();
            this.Graphics_textbox_AAPL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Graphics_AMD = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Graphics_Intel = new System.Windows.Forms.RadioButton();
            this.Kext_Network = new System.Windows.Forms.TabPage();
            this.Network_wifiList = new System.Windows.Forms.CheckedListBox();
            this.Network_ethernetList = new System.Windows.Forms.CheckedListBox();
            this.Kext_Laptop = new System.Windows.Forms.TabPage();
            this.Laptops_listBox = new System.Windows.Forms.CheckedListBox();
            this.kextsPanel_btn_Laptop = new System.Windows.Forms.Button();
            this.kextsPanel_btn_Network = new System.Windows.Forms.Button();
            this.kextsPanel_btn_Graphics = new System.Windows.Forms.Button();
            this.kextsPanel_btn_Audio = new System.Windows.Forms.Button();
            this.kextsPanel_btn_Essentials = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Generate = new System.Windows.Forms.Panel();
            this.Generate_btn_Gen = new System.Windows.Forms.Button();
            this.Generate_btn_ClearDebugs = new XanderUI.XUISuperButton();
            this.Generate_debugWindow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Quirks = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_SMBios = new System.Windows.Forms.Panel();
            this.SMBios_model = new System.Windows.Forms.TextBox();
            this.SMbios_group_List = new XanderUI.XUICustomGroupbox();
            this.SMBios_UUID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SMBios_MLB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SMBios_serial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_windowTitle = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label_Stripo = new System.Windows.Forms.Label();
            this.hover_InformationTip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Essentials_list2 = new System.Windows.Forms.CheckedListBox();
            this.panel_EFIDrivers = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Drivers_list = new System.Windows.Forms.CheckedListBox();
            this.panel_MainWidget.SuspendLayout();
            this.panel_Hardware.SuspendLayout();
            this.panel_Kexts.SuspendLayout();
            this.KextsTab.SuspendLayout();
            this.kext_Essentials.SuspendLayout();
            this.Kext_Audio.SuspendLayout();
            this.Kext_Graphics.SuspendLayout();
            this.Graphics_Intel_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Kext_Network.SuspendLayout();
            this.Kext_Laptop.SuspendLayout();
            this.panel_Generate.SuspendLayout();
            this.panel_Quirks.SuspendLayout();
            this.panel_SMBios.SuspendLayout();
            this.SMbios_group_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel_EFIDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MainWidget
            // 
            this.panel_MainWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.panel_MainWidget.Controls.Add(this.tab_Generate);
            this.panel_MainWidget.Controls.Add(this.tab_SMBios);
            this.panel_MainWidget.Controls.Add(this.tab_Quirks);
            this.panel_MainWidget.Controls.Add(this.tab_Drivers);
            this.panel_MainWidget.Controls.Add(this.tab_Kexts);
            this.panel_MainWidget.Controls.Add(this.tab_Hardware);
            this.panel_MainWidget.Controls.Add(this.panel_SMBios);
            this.panel_MainWidget.Controls.Add(this.panel_Hardware);
            this.panel_MainWidget.Controls.Add(this.panel_Kexts);
            this.panel_MainWidget.Controls.Add(this.panel_Generate);
            this.panel_MainWidget.Controls.Add(this.panel_EFIDrivers);
            this.panel_MainWidget.Controls.Add(this.panel_Quirks);
            this.panel_MainWidget.Location = new System.Drawing.Point(2, 42);
            this.panel_MainWidget.Name = "panel_MainWidget";
            this.panel_MainWidget.Size = new System.Drawing.Size(925, 319);
            this.panel_MainWidget.TabIndex = 2;
            // 
            // tab_Generate
            // 
            this.tab_Generate.AutoSize = true;
            this.tab_Generate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.tab_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_Generate.Image = ((System.Drawing.Image)(resources.GetObject("tab_Generate.Image")));
            this.tab_Generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_Generate.Location = new System.Drawing.Point(0, 226);
            this.tab_Generate.Name = "tab_Generate";
            this.tab_Generate.Size = new System.Drawing.Size(174, 46);
            this.tab_Generate.TabIndex = 4;
            this.tab_Generate.Text = "Generate";
            this.tab_Generate.UseVisualStyleBackColor = true;
            this.tab_Generate.Click += new System.EventHandler(this.tab_Generate_Click);
            this.tab_Generate.MouseHover += new System.EventHandler(this.tab_Generate_MouseHover);
            // 
            // tab_SMBios
            // 
            this.tab_SMBios.AutoSize = true;
            this.tab_SMBios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.tab_SMBios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_SMBios.Image = ((System.Drawing.Image)(resources.GetObject("tab_SMBios.Image")));
            this.tab_SMBios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_SMBios.Location = new System.Drawing.Point(0, 181);
            this.tab_SMBios.Name = "tab_SMBios";
            this.tab_SMBios.Size = new System.Drawing.Size(174, 46);
            this.tab_SMBios.TabIndex = 4;
            this.tab_SMBios.Text = "SMBios";
            this.tab_SMBios.UseVisualStyleBackColor = true;
            this.tab_SMBios.Click += new System.EventHandler(this.tab_SMBios_Click);
            this.tab_SMBios.MouseHover += new System.EventHandler(this.tab_SMBios_MouseHover);
            // 
            // tab_Quirks
            // 
            this.tab_Quirks.AutoSize = true;
            this.tab_Quirks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.tab_Quirks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_Quirks.Image = ((System.Drawing.Image)(resources.GetObject("tab_Quirks.Image")));
            this.tab_Quirks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_Quirks.Location = new System.Drawing.Point(0, 140);
            this.tab_Quirks.Name = "tab_Quirks";
            this.tab_Quirks.Size = new System.Drawing.Size(174, 46);
            this.tab_Quirks.TabIndex = 4;
            this.tab_Quirks.Text = "Quirks";
            this.tab_Quirks.UseVisualStyleBackColor = true;
            this.tab_Quirks.Click += new System.EventHandler(this.tab_Quirks_Click);
            this.tab_Quirks.MouseHover += new System.EventHandler(this.tab_Quirks_MouseHover);
            // 
            // tab_Drivers
            // 
            this.tab_Drivers.AutoSize = true;
            this.tab_Drivers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.tab_Drivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_Drivers.Image = ((System.Drawing.Image)(resources.GetObject("tab_Drivers.Image")));
            this.tab_Drivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_Drivers.Location = new System.Drawing.Point(0, 94);
            this.tab_Drivers.Name = "tab_Drivers";
            this.tab_Drivers.Size = new System.Drawing.Size(174, 46);
            this.tab_Drivers.TabIndex = 2;
            this.tab_Drivers.Text = "Drivers";
            this.tab_Drivers.UseVisualStyleBackColor = true;
            this.tab_Drivers.Click += new System.EventHandler(this.tab_Drivers_Click);
            this.tab_Drivers.MouseHover += new System.EventHandler(this.tab_Drivers_MouseHover);
            // 
            // tab_Kexts
            // 
            this.tab_Kexts.AutoSize = true;
            this.tab_Kexts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.tab_Kexts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_Kexts.Image = ((System.Drawing.Image)(resources.GetObject("tab_Kexts.Image")));
            this.tab_Kexts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_Kexts.Location = new System.Drawing.Point(0, 48);
            this.tab_Kexts.Name = "tab_Kexts";
            this.tab_Kexts.Size = new System.Drawing.Size(174, 46);
            this.tab_Kexts.TabIndex = 1;
            this.tab_Kexts.Text = "Kexts";
            this.tab_Kexts.UseVisualStyleBackColor = true;
            this.tab_Kexts.Click += new System.EventHandler(this.tab_Kexts_Click);
            this.tab_Kexts.MouseHover += new System.EventHandler(this.tab_Kexts_MouseHover);
            // 
            // tab_Hardware
            // 
            this.tab_Hardware.AutoSize = true;
            this.tab_Hardware.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.tab_Hardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_Hardware.Image = ((System.Drawing.Image)(resources.GetObject("tab_Hardware.Image")));
            this.tab_Hardware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_Hardware.Location = new System.Drawing.Point(0, 2);
            this.tab_Hardware.Name = "tab_Hardware";
            this.tab_Hardware.Size = new System.Drawing.Size(174, 46);
            this.tab_Hardware.TabIndex = 0;
            this.tab_Hardware.Text = "Hardware";
            this.tab_Hardware.UseVisualStyleBackColor = true;
            this.tab_Hardware.Click += new System.EventHandler(this.tab_Hardware_Click);
            this.tab_Hardware.MouseHover += new System.EventHandler(this.tab_Hardware_MouseHover);
            // 
            // panel_Hardware
            // 
            this.panel_Hardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel_Hardware.Controls.Add(this.hardware_comboBox);
            this.panel_Hardware.Controls.Add(this.trigger_AMDHardware);
            this.panel_Hardware.Controls.Add(this.trigger_HEDTHardware);
            this.panel_Hardware.Controls.Add(this.trigger_IntelHARDWARE);
            this.panel_Hardware.Controls.Add(this.label1);
            this.panel_Hardware.Location = new System.Drawing.Point(180, 3);
            this.panel_Hardware.Name = "panel_Hardware";
            this.panel_Hardware.Size = new System.Drawing.Size(727, 301);
            this.panel_Hardware.TabIndex = 5;
            // 
            // hardware_comboBox
            // 
            this.hardware_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardware_comboBox.Enabled = false;
            this.hardware_comboBox.FormattingEnabled = true;
            this.hardware_comboBox.Location = new System.Drawing.Point(24, 240);
            this.hardware_comboBox.Name = "hardware_comboBox";
            this.hardware_comboBox.Size = new System.Drawing.Size(677, 29);
            this.hardware_comboBox.TabIndex = 6;
            this.hardware_comboBox.SelectedIndexChanged += new System.EventHandler(this.hardware_comboBox_SelectedIndexChanged);
            // 
            // trigger_AMDHardware
            // 
            this.trigger_AMDHardware.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trigger_AMDHardware.ButtonImage = ((System.Drawing.Image)(resources.GetObject("trigger_AMDHardware.ButtonImage")));
            this.trigger_AMDHardware.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.trigger_AMDHardware.ButtonText = "AMD Hardware";
            this.trigger_AMDHardware.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.trigger_AMDHardware.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_AMDHardware.CornerRadius = 5;
            this.trigger_AMDHardware.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.trigger_AMDHardware.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.trigger_AMDHardware.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_AMDHardware.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.trigger_AMDHardware.Location = new System.Drawing.Point(19, 101);
            this.trigger_AMDHardware.Name = "trigger_AMDHardware";
            this.trigger_AMDHardware.Size = new System.Drawing.Size(663, 50);
            this.trigger_AMDHardware.TabIndex = 5;
            this.trigger_AMDHardware.TextColor = System.Drawing.Color.Black;
            this.trigger_AMDHardware.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.trigger_AMDHardware.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // trigger_HEDTHardware
            // 
            this.trigger_HEDTHardware.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trigger_HEDTHardware.ButtonImage = ((System.Drawing.Image)(resources.GetObject("trigger_HEDTHardware.ButtonImage")));
            this.trigger_HEDTHardware.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.trigger_HEDTHardware.ButtonText = "Intel-HEDT Hardware";
            this.trigger_HEDTHardware.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.trigger_HEDTHardware.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_HEDTHardware.CornerRadius = 5;
            this.trigger_HEDTHardware.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.trigger_HEDTHardware.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.trigger_HEDTHardware.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_HEDTHardware.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.trigger_HEDTHardware.Location = new System.Drawing.Point(340, 45);
            this.trigger_HEDTHardware.Name = "trigger_HEDTHardware";
            this.trigger_HEDTHardware.Size = new System.Drawing.Size(342, 50);
            this.trigger_HEDTHardware.TabIndex = 4;
            this.trigger_HEDTHardware.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.trigger_HEDTHardware.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.trigger_HEDTHardware.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // trigger_IntelHARDWARE
            // 
            this.trigger_IntelHARDWARE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trigger_IntelHARDWARE.ButtonImage = ((System.Drawing.Image)(resources.GetObject("trigger_IntelHARDWARE.ButtonImage")));
            this.trigger_IntelHARDWARE.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.trigger_IntelHARDWARE.ButtonText = "Intel Hardware";
            this.trigger_IntelHARDWARE.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.trigger_IntelHARDWARE.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_IntelHARDWARE.CornerRadius = 5;
            this.trigger_IntelHARDWARE.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.trigger_IntelHARDWARE.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.trigger_IntelHARDWARE.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_IntelHARDWARE.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.trigger_IntelHARDWARE.Location = new System.Drawing.Point(24, 45);
            this.trigger_IntelHARDWARE.Name = "trigger_IntelHARDWARE";
            this.trigger_IntelHARDWARE.Size = new System.Drawing.Size(302, 50);
            this.trigger_IntelHARDWARE.TabIndex = 3;
            this.trigger_IntelHARDWARE.TextColor = System.Drawing.Color.DodgerBlue;
            this.trigger_IntelHARDWARE.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.trigger_IntelHARDWARE.Click += new System.EventHandler(this.trigger_IntelHARDWARE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hardware Configuration";
            // 
            // panel_Kexts
            // 
            this.panel_Kexts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel_Kexts.Controls.Add(this.KextsTab);
            this.panel_Kexts.Controls.Add(this.kextsPanel_btn_Laptop);
            this.panel_Kexts.Controls.Add(this.kextsPanel_btn_Network);
            this.panel_Kexts.Controls.Add(this.kextsPanel_btn_Graphics);
            this.panel_Kexts.Controls.Add(this.kextsPanel_btn_Audio);
            this.panel_Kexts.Controls.Add(this.kextsPanel_btn_Essentials);
            this.panel_Kexts.Controls.Add(this.label2);
            this.panel_Kexts.Location = new System.Drawing.Point(180, 3);
            this.panel_Kexts.Name = "panel_Kexts";
            this.panel_Kexts.Size = new System.Drawing.Size(727, 301);
            this.panel_Kexts.TabIndex = 7;
            // 
            // KextsTab
            // 
            this.KextsTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.KextsTab.Controls.Add(this.kext_Essentials);
            this.KextsTab.Controls.Add(this.Kext_Audio);
            this.KextsTab.Controls.Add(this.Kext_Graphics);
            this.KextsTab.Controls.Add(this.Kext_Network);
            this.KextsTab.Controls.Add(this.Kext_Laptop);
            this.KextsTab.ItemSize = new System.Drawing.Size(76, 26);
            this.KextsTab.Location = new System.Drawing.Point(24, 118);
            this.KextsTab.Name = "KextsTab";
            this.KextsTab.SelectedIndex = 0;
            this.KextsTab.Size = new System.Drawing.Size(691, 162);
            this.KextsTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.KextsTab.TabIndex = 28;
            // 
            // kext_Essentials
            // 
            this.kext_Essentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.kext_Essentials.Controls.Add(this.Essentials_list2);
            this.kext_Essentials.Controls.Add(this.Essentials_checkList);
            this.kext_Essentials.Location = new System.Drawing.Point(4, 30);
            this.kext_Essentials.Name = "kext_Essentials";
            this.kext_Essentials.Padding = new System.Windows.Forms.Padding(3);
            this.kext_Essentials.Size = new System.Drawing.Size(683, 128);
            this.kext_Essentials.TabIndex = 0;
            this.kext_Essentials.Text = "Essential";
            // 
            // Essentials_checkList
            // 
            this.Essentials_checkList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Essentials_checkList.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Essentials_checkList.ForeColor = System.Drawing.Color.White;
            this.Essentials_checkList.FormattingEnabled = true;
            this.Essentials_checkList.Items.AddRange(new object[] {
            "Lilu.kext",
            "VirtualSMC.kext",
            "FakeSMC.kext"});
            this.Essentials_checkList.Location = new System.Drawing.Point(12, 11);
            this.Essentials_checkList.Name = "Essentials_checkList";
            this.Essentials_checkList.Size = new System.Drawing.Size(250, 104);
            this.Essentials_checkList.TabIndex = 24;
            this.Essentials_checkList.SelectedIndexChanged += new System.EventHandler(this.Essentials_checkList_SelectedIndexChanged);
            // 
            // Kext_Audio
            // 
            this.Kext_Audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Kext_Audio.Controls.Add(this.audio_textbox_Alcid);
            this.Kext_Audio.Controls.Add(this.label3);
            this.Kext_Audio.Controls.Add(this.Audio_checkLlist);
            this.Kext_Audio.Location = new System.Drawing.Point(4, 30);
            this.Kext_Audio.Name = "Kext_Audio";
            this.Kext_Audio.Padding = new System.Windows.Forms.Padding(3);
            this.Kext_Audio.Size = new System.Drawing.Size(683, 128);
            this.Kext_Audio.TabIndex = 1;
            this.Kext_Audio.Text = "Audio";
            this.Kext_Audio.Click += new System.EventHandler(this.Kext_Audio_Click);
            // 
            // audio_textbox_Alcid
            // 
            this.audio_textbox_Alcid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.audio_textbox_Alcid.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.audio_textbox_Alcid.ForeColor = System.Drawing.Color.White;
            this.audio_textbox_Alcid.Location = new System.Drawing.Point(324, 15);
            this.audio_textbox_Alcid.MaxLength = 2;
            this.audio_textbox_Alcid.Name = "audio_textbox_Alcid";
            this.audio_textbox_Alcid.Size = new System.Drawing.Size(127, 30);
            this.audio_textbox_Alcid.TabIndex = 26;
            this.audio_textbox_Alcid.Text = "13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "ALCID";
            // 
            // Audio_checkLlist
            // 
            this.Audio_checkLlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Audio_checkLlist.CheckOnClick = true;
            this.Audio_checkLlist.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Audio_checkLlist.ForeColor = System.Drawing.Color.White;
            this.Audio_checkLlist.FormattingEnabled = true;
            this.Audio_checkLlist.Items.AddRange(new object[] {
            "AppleALC.kext",
            "VoodooHDA.kext"});
            this.Audio_checkLlist.Location = new System.Drawing.Point(12, 11);
            this.Audio_checkLlist.Name = "Audio_checkLlist";
            this.Audio_checkLlist.Size = new System.Drawing.Size(250, 104);
            this.Audio_checkLlist.TabIndex = 25;
            this.Audio_checkLlist.SelectedIndexChanged += new System.EventHandler(this.Audio_checkLlist_SelectedIndexChanged_1);
            // 
            // Kext_Graphics
            // 
            this.Kext_Graphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Kext_Graphics.Controls.Add(this.Graphics_Intel_group);
            this.Kext_Graphics.Controls.Add(this.pictureBox2);
            this.Kext_Graphics.Controls.Add(this.Graphics_AMD);
            this.Kext_Graphics.Controls.Add(this.pictureBox1);
            this.Kext_Graphics.Controls.Add(this.Graphics_Intel);
            this.Kext_Graphics.Location = new System.Drawing.Point(4, 30);
            this.Kext_Graphics.Name = "Kext_Graphics";
            this.Kext_Graphics.Padding = new System.Windows.Forms.Padding(3);
            this.Kext_Graphics.Size = new System.Drawing.Size(683, 128);
            this.Kext_Graphics.TabIndex = 2;
            this.Kext_Graphics.Text = "Graphics";
            // 
            // Graphics_Intel_group
            // 
            this.Graphics_Intel_group.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Graphics_Intel_group.BorderWidth = 1;
            this.Graphics_Intel_group.Controls.Add(this.Graphics_textbox_AAPL);
            this.Graphics_Intel_group.Controls.Add(this.label4);
            this.Graphics_Intel_group.Location = new System.Drawing.Point(114, 10);
            this.Graphics_Intel_group.Name = "Graphics_Intel_group";
            this.Graphics_Intel_group.ShowText = true;
            this.Graphics_Intel_group.Size = new System.Drawing.Size(558, 100);
            this.Graphics_Intel_group.TabIndex = 4;
            this.Graphics_Intel_group.TabStop = false;
            this.Graphics_Intel_group.Text = "Intel";
            this.Graphics_Intel_group.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // Graphics_textbox_AAPL
            // 
            this.Graphics_textbox_AAPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Graphics_textbox_AAPL.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Graphics_textbox_AAPL.ForeColor = System.Drawing.Color.White;
            this.Graphics_textbox_AAPL.Location = new System.Drawing.Point(187, 32);
            this.Graphics_textbox_AAPL.MaxLength = 8;
            this.Graphics_textbox_AAPL.Name = "Graphics_textbox_AAPL";
            this.Graphics_textbox_AAPL.Size = new System.Drawing.Size(127, 30);
            this.Graphics_textbox_AAPL.TabIndex = 29;
            this.Graphics_textbox_AAPL.Text = "00000100";
            this.Graphics_textbox_AAPL.TextChanged += new System.EventHandler(this.Graphics_textbox_AAPL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = " AAPL,snb-platform-id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Graphics_AMD
            // 
            this.Graphics_AMD.AutoSize = true;
            this.Graphics_AMD.Checked = true;
            this.Graphics_AMD.Location = new System.Drawing.Point(16, 83);
            this.Graphics_AMD.Name = "Graphics_AMD";
            this.Graphics_AMD.Size = new System.Drawing.Size(14, 13);
            this.Graphics_AMD.TabIndex = 2;
            this.Graphics_AMD.TabStop = true;
            this.Graphics_AMD.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Graphics_Intel
            // 
            this.Graphics_Intel.AutoSize = true;
            this.Graphics_Intel.Location = new System.Drawing.Point(16, 25);
            this.Graphics_Intel.Name = "Graphics_Intel";
            this.Graphics_Intel.Size = new System.Drawing.Size(14, 13);
            this.Graphics_Intel.TabIndex = 0;
            this.Graphics_Intel.UseVisualStyleBackColor = true;
            this.Graphics_Intel.CheckedChanged += new System.EventHandler(this.Graphics_Intel_CheckedChanged);
            // 
            // Kext_Network
            // 
            this.Kext_Network.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Kext_Network.Controls.Add(this.Network_wifiList);
            this.Kext_Network.Controls.Add(this.Network_ethernetList);
            this.Kext_Network.Location = new System.Drawing.Point(4, 30);
            this.Kext_Network.Name = "Kext_Network";
            this.Kext_Network.Padding = new System.Windows.Forms.Padding(3);
            this.Kext_Network.Size = new System.Drawing.Size(683, 128);
            this.Kext_Network.TabIndex = 3;
            this.Kext_Network.Text = "Network";
            // 
            // Network_wifiList
            // 
            this.Network_wifiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Network_wifiList.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Network_wifiList.ForeColor = System.Drawing.Color.White;
            this.Network_wifiList.FormattingEnabled = true;
            this.Network_wifiList.Items.AddRange(new object[] {
            "AirportItlwm.kext",
            "AirportBrcmFixup.kext"});
            this.Network_wifiList.Location = new System.Drawing.Point(280, 10);
            this.Network_wifiList.Name = "Network_wifiList";
            this.Network_wifiList.Size = new System.Drawing.Size(252, 54);
            this.Network_wifiList.TabIndex = 30;
            // 
            // Network_ethernetList
            // 
            this.Network_ethernetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Network_ethernetList.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Network_ethernetList.ForeColor = System.Drawing.Color.White;
            this.Network_ethernetList.FormattingEnabled = true;
            this.Network_ethernetList.Items.AddRange(new object[] {
            "IntelMausi.kext",
            "SmallTree82576.kext",
            "AtherosE2200.kext",
            "RealtekRTL8111.kext",
            "LucyRTL8125.kext"});
            this.Network_ethernetList.Location = new System.Drawing.Point(24, 10);
            this.Network_ethernetList.Name = "Network_ethernetList";
            this.Network_ethernetList.Size = new System.Drawing.Size(250, 104);
            this.Network_ethernetList.TabIndex = 29;
            // 
            // Kext_Laptop
            // 
            this.Kext_Laptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Kext_Laptop.Controls.Add(this.Laptops_listBox);
            this.Kext_Laptop.Location = new System.Drawing.Point(4, 30);
            this.Kext_Laptop.Name = "Kext_Laptop";
            this.Kext_Laptop.Padding = new System.Windows.Forms.Padding(3);
            this.Kext_Laptop.Size = new System.Drawing.Size(683, 128);
            this.Kext_Laptop.TabIndex = 4;
            this.Kext_Laptop.Text = "Laptops";
            // 
            // Laptops_listBox
            // 
            this.Laptops_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Laptops_listBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Laptops_listBox.ForeColor = System.Drawing.Color.White;
            this.Laptops_listBox.FormattingEnabled = true;
            this.Laptops_listBox.Items.AddRange(new object[] {
            "VoodooPS2.kext"});
            this.Laptops_listBox.Location = new System.Drawing.Point(24, 10);
            this.Laptops_listBox.Name = "Laptops_listBox";
            this.Laptops_listBox.Size = new System.Drawing.Size(250, 104);
            this.Laptops_listBox.TabIndex = 29;
            // 
            // kextsPanel_btn_Laptop
            // 
            this.kextsPanel_btn_Laptop.AutoSize = true;
            this.kextsPanel_btn_Laptop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.kextsPanel_btn_Laptop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kextsPanel_btn_Laptop.Image = ((System.Drawing.Image)(resources.GetObject("kextsPanel_btn_Laptop.Image")));
            this.kextsPanel_btn_Laptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kextsPanel_btn_Laptop.Location = new System.Drawing.Point(538, 59);
            this.kextsPanel_btn_Laptop.Name = "kextsPanel_btn_Laptop";
            this.kextsPanel_btn_Laptop.Size = new System.Drawing.Size(147, 46);
            this.kextsPanel_btn_Laptop.TabIndex = 12;
            this.kextsPanel_btn_Laptop.Text = "Laptops";
            this.kextsPanel_btn_Laptop.UseVisualStyleBackColor = true;
            this.kextsPanel_btn_Laptop.Click += new System.EventHandler(this.kextsPanel_btn_Laptop_Click);
            // 
            // kextsPanel_btn_Network
            // 
            this.kextsPanel_btn_Network.AutoSize = true;
            this.kextsPanel_btn_Network.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.kextsPanel_btn_Network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kextsPanel_btn_Network.Image = ((System.Drawing.Image)(resources.GetObject("kextsPanel_btn_Network.Image")));
            this.kextsPanel_btn_Network.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kextsPanel_btn_Network.Location = new System.Drawing.Point(406, 59);
            this.kextsPanel_btn_Network.Name = "kextsPanel_btn_Network";
            this.kextsPanel_btn_Network.Size = new System.Drawing.Size(147, 46);
            this.kextsPanel_btn_Network.TabIndex = 11;
            this.kextsPanel_btn_Network.Text = "Network";
            this.kextsPanel_btn_Network.UseVisualStyleBackColor = true;
            this.kextsPanel_btn_Network.Click += new System.EventHandler(this.kextsPanel_btn_Network_Click);
            // 
            // kextsPanel_btn_Graphics
            // 
            this.kextsPanel_btn_Graphics.AutoSize = true;
            this.kextsPanel_btn_Graphics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.kextsPanel_btn_Graphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kextsPanel_btn_Graphics.Image = ((System.Drawing.Image)(resources.GetObject("kextsPanel_btn_Graphics.Image")));
            this.kextsPanel_btn_Graphics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kextsPanel_btn_Graphics.Location = new System.Drawing.Point(273, 59);
            this.kextsPanel_btn_Graphics.Name = "kextsPanel_btn_Graphics";
            this.kextsPanel_btn_Graphics.Size = new System.Drawing.Size(147, 46);
            this.kextsPanel_btn_Graphics.TabIndex = 10;
            this.kextsPanel_btn_Graphics.Text = "Graphics";
            this.kextsPanel_btn_Graphics.UseVisualStyleBackColor = true;
            this.kextsPanel_btn_Graphics.Click += new System.EventHandler(this.button2_Click);
            // 
            // kextsPanel_btn_Audio
            // 
            this.kextsPanel_btn_Audio.AutoSize = true;
            this.kextsPanel_btn_Audio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.kextsPanel_btn_Audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kextsPanel_btn_Audio.Image = ((System.Drawing.Image)(resources.GetObject("kextsPanel_btn_Audio.Image")));
            this.kextsPanel_btn_Audio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kextsPanel_btn_Audio.Location = new System.Drawing.Point(171, 59);
            this.kextsPanel_btn_Audio.Name = "kextsPanel_btn_Audio";
            this.kextsPanel_btn_Audio.Size = new System.Drawing.Size(131, 46);
            this.kextsPanel_btn_Audio.TabIndex = 9;
            this.kextsPanel_btn_Audio.Text = "Audio";
            this.kextsPanel_btn_Audio.UseVisualStyleBackColor = true;
            this.kextsPanel_btn_Audio.Click += new System.EventHandler(this.button1_Click);
            // 
            // kextsPanel_btn_Essentials
            // 
            this.kextsPanel_btn_Essentials.AutoSize = true;
            this.kextsPanel_btn_Essentials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.kextsPanel_btn_Essentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kextsPanel_btn_Essentials.Image = ((System.Drawing.Image)(resources.GetObject("kextsPanel_btn_Essentials.Image")));
            this.kextsPanel_btn_Essentials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kextsPanel_btn_Essentials.Location = new System.Drawing.Point(24, 59);
            this.kextsPanel_btn_Essentials.Name = "kextsPanel_btn_Essentials";
            this.kextsPanel_btn_Essentials.Size = new System.Drawing.Size(169, 46);
            this.kextsPanel_btn_Essentials.TabIndex = 8;
            this.kextsPanel_btn_Essentials.Text = "Essentials";
            this.kextsPanel_btn_Essentials.UseVisualStyleBackColor = true;
            this.kextsPanel_btn_Essentials.Click += new System.EventHandler(this.kextsPanel_btn_Essentials_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kexts Configuration";
            // 
            // panel_Generate
            // 
            this.panel_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel_Generate.Controls.Add(this.Generate_btn_Gen);
            this.panel_Generate.Controls.Add(this.Generate_btn_ClearDebugs);
            this.panel_Generate.Controls.Add(this.Generate_debugWindow);
            this.panel_Generate.Controls.Add(this.label6);
            this.panel_Generate.Location = new System.Drawing.Point(180, 6);
            this.panel_Generate.Name = "panel_Generate";
            this.panel_Generate.Size = new System.Drawing.Size(727, 301);
            this.panel_Generate.TabIndex = 8;
            // 
            // Generate_btn_Gen
            // 
            this.Generate_btn_Gen.AutoSize = true;
            this.Generate_btn_Gen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.Generate_btn_Gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_btn_Gen.Image = ((System.Drawing.Image)(resources.GetObject("Generate_btn_Gen.Image")));
            this.Generate_btn_Gen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Generate_btn_Gen.Location = new System.Drawing.Point(19, 221);
            this.Generate_btn_Gen.Name = "Generate_btn_Gen";
            this.Generate_btn_Gen.Size = new System.Drawing.Size(689, 46);
            this.Generate_btn_Gen.TabIndex = 9;
            this.Generate_btn_Gen.Text = "Build EFI Files";
            this.Generate_btn_Gen.UseVisualStyleBackColor = true;
            this.Generate_btn_Gen.Click += new System.EventHandler(this.Generate_btn_Gen_Click);
            // 
            // Generate_btn_ClearDebugs
            // 
            this.Generate_btn_ClearDebugs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Generate_btn_ClearDebugs.ButtonImage = ((System.Drawing.Image)(resources.GetObject("Generate_btn_ClearDebugs.ButtonImage")));
            this.Generate_btn_ClearDebugs.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.Generate_btn_ClearDebugs.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.Generate_btn_ClearDebugs.ButtonText = "Clear";
            this.Generate_btn_ClearDebugs.CornerRadius = 6;
            this.Generate_btn_ClearDebugs.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Generate_btn_ClearDebugs.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.Generate_btn_ClearDebugs.HoverTextColor = System.Drawing.Color.White;
            this.Generate_btn_ClearDebugs.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.Generate_btn_ClearDebugs.Location = new System.Drawing.Point(577, 175);
            this.Generate_btn_ClearDebugs.Name = "Generate_btn_ClearDebugs";
            this.Generate_btn_ClearDebugs.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Generate_btn_ClearDebugs.SelectedTextColor = System.Drawing.Color.White;
            this.Generate_btn_ClearDebugs.Size = new System.Drawing.Size(138, 21);
            this.Generate_btn_ClearDebugs.SuperSelected = false;
            this.Generate_btn_ClearDebugs.TabIndex = 2;
            this.Generate_btn_ClearDebugs.TextColor = System.Drawing.Color.White;
            this.Generate_btn_ClearDebugs.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Generate_btn_ClearDebugs.Click += new System.EventHandler(this.Generate_btn_ClearDebugs_Click);
            // 
            // Generate_debugWindow
            // 
            this.Generate_debugWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Generate_debugWindow.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_debugWindow.ForeColor = System.Drawing.Color.White;
            this.Generate_debugWindow.Location = new System.Drawing.Point(12, 42);
            this.Generate_debugWindow.Multiline = true;
            this.Generate_debugWindow.Name = "Generate_debugWindow";
            this.Generate_debugWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Generate_debugWindow.Size = new System.Drawing.Size(703, 153);
            this.Generate_debugWindow.TabIndex = 1;
            this.Generate_debugWindow.Text = "LAUNCHED -> DEBUG WINDOW\r\n";
            this.Generate_debugWindow.TextChanged += new System.EventHandler(this.Generate_debugWindow_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Generate";
            // 
            // panel_Quirks
            // 
            this.panel_Quirks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel_Quirks.Controls.Add(this.label9);
            this.panel_Quirks.Controls.Add(this.label8);
            this.panel_Quirks.Controls.Add(this.textBox1);
            this.panel_Quirks.Controls.Add(this.label7);
            this.panel_Quirks.Location = new System.Drawing.Point(180, 4);
            this.panel_Quirks.Name = "panel_Quirks";
            this.panel_Quirks.Size = new System.Drawing.Size(727, 297);
            this.panel_Quirks.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.label9.Location = new System.Drawing.Point(25, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Please do not use alcid=\r\nIt is already included in the Kexts/Audio Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Boot Args";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(609, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "-v keepsyms=1 debug=0x100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quirks";
            // 
            // panel_SMBios
            // 
            this.panel_SMBios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel_SMBios.Controls.Add(this.SMBios_model);
            this.panel_SMBios.Controls.Add(this.SMbios_group_List);
            this.panel_SMBios.Controls.Add(this.label11);
            this.panel_SMBios.Controls.Add(this.label12);
            this.panel_SMBios.Location = new System.Drawing.Point(177, 2);
            this.panel_SMBios.Name = "panel_SMBios";
            this.panel_SMBios.Size = new System.Drawing.Size(727, 297);
            this.panel_SMBios.TabIndex = 8;
            // 
            // SMBios_model
            // 
            this.SMBios_model.Location = new System.Drawing.Point(114, 55);
            this.SMBios_model.MaxLength = 16;
            this.SMBios_model.Name = "SMBios_model";
            this.SMBios_model.Size = new System.Drawing.Size(213, 26);
            this.SMBios_model.TabIndex = 15;
            // 
            // SMbios_group_List
            // 
            this.SMbios_group_List.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.SMbios_group_List.BorderWidth = 3;
            this.SMbios_group_List.Controls.Add(this.SMBios_UUID);
            this.SMbios_group_List.Controls.Add(this.label14);
            this.SMbios_group_List.Controls.Add(this.SMBios_MLB);
            this.SMbios_group_List.Controls.Add(this.label13);
            this.SMbios_group_List.Controls.Add(this.SMBios_serial);
            this.SMbios_group_List.Controls.Add(this.label10);
            this.SMbios_group_List.Location = new System.Drawing.Point(31, 89);
            this.SMbios_group_List.Name = "SMbios_group_List";
            this.SMbios_group_List.ShowText = true;
            this.SMbios_group_List.Size = new System.Drawing.Size(582, 137);
            this.SMbios_group_List.TabIndex = 7;
            this.SMbios_group_List.TabStop = false;
            this.SMbios_group_List.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.SMbios_group_List.Enter += new System.EventHandler(this.SMbios_group_List_Enter);
            // 
            // SMBios_UUID
            // 
            this.SMBios_UUID.Location = new System.Drawing.Point(65, 92);
            this.SMBios_UUID.MaxLength = 36;
            this.SMBios_UUID.Name = "SMBios_UUID";
            this.SMBios_UUID.Size = new System.Drawing.Size(470, 26);
            this.SMBios_UUID.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "UUID";
            // 
            // SMBios_MLB
            // 
            this.SMBios_MLB.Location = new System.Drawing.Point(66, 55);
            this.SMBios_MLB.MaxLength = 17;
            this.SMBios_MLB.Name = "SMBios_MLB";
            this.SMBios_MLB.Size = new System.Drawing.Size(292, 26);
            this.SMBios_MLB.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "MLB";
            // 
            // SMBios_serial
            // 
            this.SMBios_serial.Location = new System.Drawing.Point(65, 19);
            this.SMBios_serial.MaxLength = 12;
            this.SMBios_serial.Name = "SMBios_serial";
            this.SMBios_serial.Size = new System.Drawing.Size(213, 26);
            this.SMBios_serial.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Serial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Mac Model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "SMBios";
            // 
            // label_windowTitle
            // 
            this.label_windowTitle.AutoSize = true;
            this.label_windowTitle.Location = new System.Drawing.Point(349, 10);
            this.label_windowTitle.Name = "label_windowTitle";
            this.label_windowTitle.Size = new System.Drawing.Size(159, 21);
            this.label_windowTitle.TabIndex = 3;
            this.label_windowTitle.Text = "OC Gen Windows - 0.1";
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::OC_Gen_Windows.Properties.Resources.close_button;
            this.btn_Close.Location = new System.Drawing.Point(887, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(22, 24);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label_Stripo
            // 
            this.label_Stripo.AutoSize = true;
            this.label_Stripo.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label_Stripo.Location = new System.Drawing.Point(8, 366);
            this.label_Stripo.Name = "label_Stripo";
            this.label_Stripo.Size = new System.Drawing.Size(101, 18);
            this.label_Stripo.TabIndex = 4;
            this.label_Stripo.Text = "Opencore 0.6.7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label5.Location = new System.Drawing.Point(831, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Build: 007b";
            // 
            // Essentials_list2
            // 
            this.Essentials_list2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Essentials_list2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Essentials_list2.ForeColor = System.Drawing.Color.White;
            this.Essentials_list2.FormattingEnabled = true;
            this.Essentials_list2.Items.AddRange(new object[] {
            "USBInjectall.kext",
            "SATA-unsupported.kext",
            "XHCI-unsupported.kext",
            "CtlnaAHCIPort.kext"});
            this.Essentials_list2.Location = new System.Drawing.Point(275, 10);
            this.Essentials_list2.Name = "Essentials_list2";
            this.Essentials_list2.Size = new System.Drawing.Size(250, 104);
            this.Essentials_list2.TabIndex = 25;
            // 
            // panel_EFIDrivers
            // 
            this.panel_EFIDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel_EFIDrivers.Controls.Add(this.Drivers_list);
            this.panel_EFIDrivers.Controls.Add(this.label15);
            this.panel_EFIDrivers.Controls.Add(this.label17);
            this.panel_EFIDrivers.Location = new System.Drawing.Point(177, 3);
            this.panel_EFIDrivers.Name = "panel_EFIDrivers";
            this.panel_EFIDrivers.Size = new System.Drawing.Size(727, 297);
            this.panel_EFIDrivers.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.label15.Location = new System.Drawing.Point(290, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 32);
            this.label15.TabIndex = 4;
            this.label15.Text = "EFI Drivers are used only in loader\r\n\"Openruntime is already included \"";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(339, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "EFI Drivers";
            // 
            // Drivers_list
            // 
            this.Drivers_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Drivers_list.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.Drivers_list.ForeColor = System.Drawing.Color.White;
            this.Drivers_list.FormattingEnabled = true;
            this.Drivers_list.Items.AddRange(new object[] {
            "HfsPlus.efi",
            "HfsPlusLegacy.efi",
            "OpenPartitionDxe.efi",
            "OpenUsbKbDxe.efi",
            "NvmExpressDxe.efi",
            "Ps2KeyboardDxe.efi",
            "Ps2MouseDxe.efi",
            "UsbMouseDxe.efi",
            "XhciDxe.efi"});
            this.Drivers_list.Location = new System.Drawing.Point(275, 71);
            this.Drivers_list.Name = "Drivers_list";
            this.Drivers_list.Size = new System.Drawing.Size(250, 211);
            this.Drivers_list.TabIndex = 25;
            // 
            // MainWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(921, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Stripo);
            this.Controls.Add(this.label_windowTitle);
            this.Controls.Add(this.panel_MainWidget);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWidget";
            this.Text = "OC-Gen Windows Edition 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel_MainWidget.ResumeLayout(false);
            this.panel_MainWidget.PerformLayout();
            this.panel_Hardware.ResumeLayout(false);
            this.panel_Hardware.PerformLayout();
            this.panel_Kexts.ResumeLayout(false);
            this.panel_Kexts.PerformLayout();
            this.KextsTab.ResumeLayout(false);
            this.kext_Essentials.ResumeLayout(false);
            this.Kext_Audio.ResumeLayout(false);
            this.Kext_Audio.PerformLayout();
            this.Kext_Graphics.ResumeLayout(false);
            this.Kext_Graphics.PerformLayout();
            this.Graphics_Intel_group.ResumeLayout(false);
            this.Graphics_Intel_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Kext_Network.ResumeLayout(false);
            this.Kext_Laptop.ResumeLayout(false);
            this.panel_Generate.ResumeLayout(false);
            this.panel_Generate.PerformLayout();
            this.panel_Quirks.ResumeLayout(false);
            this.panel_Quirks.PerformLayout();
            this.panel_SMBios.ResumeLayout(false);
            this.panel_SMBios.PerformLayout();
            this.SMbios_group_List.ResumeLayout(false);
            this.SMbios_group_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel_EFIDrivers.ResumeLayout(false);
            this.panel_EFIDrivers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox btn_Close;
        public System.Windows.Forms.Panel panel_MainWidget;
        public System.Windows.Forms.Label label_windowTitle;
        public System.Windows.Forms.Button tab_Hardware;
        public System.Windows.Forms.Button tab_Kexts;
        public System.Windows.Forms.Button tab_Drivers;
        public System.Windows.Forms.Button tab_Generate;
        public System.Windows.Forms.Button tab_SMBios;
        public System.Windows.Forms.Button tab_Quirks;
        public System.Windows.Forms.Label label_Stripo;
        public System.Windows.Forms.ToolTip hover_InformationTip;
        public System.Windows.Forms.Panel panel_Hardware;
        public System.Windows.Forms.Label label1;
        public XanderUI.XUIButton trigger_AMDHardware;
        public XanderUI.XUIButton trigger_HEDTHardware;
        public XanderUI.XUIButton trigger_IntelHARDWARE;
        public System.Windows.Forms.ComboBox hardware_comboBox;
        public System.Windows.Forms.Panel panel_Kexts;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button kextsPanel_btn_Graphics;
        public System.Windows.Forms.Button kextsPanel_btn_Audio;
        public System.Windows.Forms.Button kextsPanel_btn_Essentials;
        public System.Windows.Forms.Button kextsPanel_btn_Network;
        public System.Windows.Forms.Button kextsPanel_btn_Laptop;
        public System.Windows.Forms.TabControl KextsTab;
        public System.Windows.Forms.TabPage kext_Essentials;
        public System.Windows.Forms.TabPage Kext_Audio;
        public System.Windows.Forms.CheckedListBox Essentials_checkList;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckedListBox Audio_checkLlist;
        public System.Windows.Forms.TextBox audio_textbox_Alcid;
        public System.Windows.Forms.TabPage Kext_Graphics;
        public System.Windows.Forms.TabPage Kext_Network;
        public System.Windows.Forms.TabPage Kext_Laptop;
        public System.Windows.Forms.RadioButton Graphics_Intel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.RadioButton Graphics_AMD;
        public XanderUI.XUICustomGroupbox Graphics_Intel_group;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Graphics_textbox_AAPL;
        public System.Windows.Forms.CheckedListBox Network_ethernetList;
        public System.Windows.Forms.CheckedListBox Network_wifiList;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel_Generate;
        public System.Windows.Forms.TextBox Generate_debugWindow;
        public System.Windows.Forms.Label label6;
        public XanderUI.XUISuperButton Generate_btn_ClearDebugs;
        public System.Windows.Forms.Button Generate_btn_Gen;
        public System.Windows.Forms.CheckedListBox Laptops_listBox;
        public System.Windows.Forms.Panel panel_Quirks;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel panel_SMBios;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public XanderUI.XUICustomGroupbox SMbios_group_List;
        public System.Windows.Forms.TextBox SMBios_UUID;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox SMBios_MLB;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox SMBios_serial;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox SMBios_model;
        public System.Windows.Forms.CheckedListBox Essentials_list2;
        public System.Windows.Forms.Panel panel_EFIDrivers;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.CheckedListBox Drivers_list;
    }
}

