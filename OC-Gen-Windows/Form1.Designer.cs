
namespace OC_Gen_Windows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Hardware = new System.Windows.Forms.TabPage();
            this.Kext = new System.Windows.Forms.TabPage();
            this.EFIDriver = new System.Windows.Forms.TabPage();
            this.SMBios = new System.Windows.Forms.TabPage();
            this.Extra = new System.Windows.Forms.TabPage();
            this.generateEfiBtn = new System.Windows.Forms.Button();
            this.valdBtn = new System.Windows.Forms.Button();
            this.newEfiBtn = new System.Windows.Forms.Button();
            this.disclaimerLabel = new System.Windows.Forms.Label();
            this.sandyDesktop = new System.Windows.Forms.RadioButton();
            this.ivyDesktop = new System.Windows.Forms.RadioButton();
            this.skylakeDesktop = new System.Windows.Forms.RadioButton();
            this.haswellDesktop = new System.Windows.Forms.RadioButton();
            this.coffeDesktop = new System.Windows.Forms.RadioButton();
            this.kabylakeDesktop = new System.Windows.Forms.RadioButton();
            this.coffeeLaptop = new System.Windows.Forms.RadioButton();
            this.kabylakeLaptop = new System.Windows.Forms.RadioButton();
            this.skylakeLaptop = new System.Windows.Forms.RadioButton();
            this.haswellLaptop = new System.Windows.Forms.RadioButton();
            this.ivyLaptop = new System.Windows.Forms.RadioButton();
            this.sandyLaptop = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.icelakeLaptop = new System.Windows.Forms.RadioButton();
            this.kextDriverListbox = new System.Windows.Forms.CheckedListBox();
            this.efiDriverListbox = new System.Windows.Forms.CheckedListBox();
            this.bootArgs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.extraListbox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.smSerial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.smUUID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.smMlb = new System.Windows.Forms.TextBox();
            this.smGenbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Hardware.SuspendLayout();
            this.Kext.SuspendLayout();
            this.EFIDriver.SuspendLayout();
            this.SMBios.SuspendLayout();
            this.Extra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 10);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.lblTitle.Location = new System.Drawing.Point(307, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "OC Gen Windows 0.1";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.closeBtn.Location = new System.Drawing.Point(11, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 22);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.AutoSize = true;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.minimizeBtn.Location = new System.Drawing.Point(32, 5);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 22);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.Text = "__";
            this.minimizeBtn.Click += new System.EventHandler(this.label3_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(110, 47);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(612, 70);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 4;
            this.logoPicture.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Hardware);
            this.tabControl1.Controls.Add(this.Kext);
            this.tabControl1.Controls.Add(this.EFIDriver);
            this.tabControl1.Controls.Add(this.SMBios);
            this.tabControl1.Controls.Add(this.Extra);
            this.tabControl1.Location = new System.Drawing.Point(15, 148);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 206);
            this.tabControl1.TabIndex = 5;
            // 
            // Hardware
            // 
            this.Hardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.Hardware.Controls.Add(this.icelakeLaptop);
            this.Hardware.Controls.Add(this.label3);
            this.Hardware.Controls.Add(this.label2);
            this.Hardware.Controls.Add(this.coffeeLaptop);
            this.Hardware.Controls.Add(this.kabylakeLaptop);
            this.Hardware.Controls.Add(this.skylakeLaptop);
            this.Hardware.Controls.Add(this.haswellLaptop);
            this.Hardware.Controls.Add(this.ivyLaptop);
            this.Hardware.Controls.Add(this.sandyLaptop);
            this.Hardware.Controls.Add(this.coffeDesktop);
            this.Hardware.Controls.Add(this.kabylakeDesktop);
            this.Hardware.Controls.Add(this.skylakeDesktop);
            this.Hardware.Controls.Add(this.haswellDesktop);
            this.Hardware.Controls.Add(this.ivyDesktop);
            this.Hardware.Controls.Add(this.sandyDesktop);
            this.Hardware.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hardware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Hardware.Location = new System.Drawing.Point(4, 22);
            this.Hardware.Name = "Hardware";
            this.Hardware.Padding = new System.Windows.Forms.Padding(3);
            this.Hardware.Size = new System.Drawing.Size(765, 180);
            this.Hardware.TabIndex = 0;
            this.Hardware.Text = "Hardware";
            // 
            // Kext
            // 
            this.Kext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.Kext.Controls.Add(this.kextDriverListbox);
            this.Kext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Kext.Location = new System.Drawing.Point(4, 22);
            this.Kext.Name = "Kext";
            this.Kext.Size = new System.Drawing.Size(765, 180);
            this.Kext.TabIndex = 1;
            this.Kext.Text = "Kext";
            // 
            // EFIDriver
            // 
            this.EFIDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.EFIDriver.Controls.Add(this.efiDriverListbox);
            this.EFIDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EFIDriver.Location = new System.Drawing.Point(4, 22);
            this.EFIDriver.Name = "EFIDriver";
            this.EFIDriver.Size = new System.Drawing.Size(765, 180);
            this.EFIDriver.TabIndex = 2;
            this.EFIDriver.Text = "EFI Driver";
            // 
            // SMBios
            // 
            this.SMBios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.SMBios.Controls.Add(this.smGenbtn);
            this.SMBios.Controls.Add(this.label9);
            this.SMBios.Controls.Add(this.smMlb);
            this.SMBios.Controls.Add(this.label8);
            this.SMBios.Controls.Add(this.smUUID);
            this.SMBios.Controls.Add(this.label7);
            this.SMBios.Controls.Add(this.smSerial);
            this.SMBios.Controls.Add(this.label6);
            this.SMBios.Controls.Add(this.smModel);
            this.SMBios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SMBios.Location = new System.Drawing.Point(4, 22);
            this.SMBios.Name = "SMBios";
            this.SMBios.Size = new System.Drawing.Size(765, 180);
            this.SMBios.TabIndex = 3;
            this.SMBios.Text = "SMBIOS";
            // 
            // Extra
            // 
            this.Extra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.Extra.Controls.Add(this.label5);
            this.Extra.Controls.Add(this.extraListbox);
            this.Extra.Controls.Add(this.label4);
            this.Extra.Controls.Add(this.bootArgs);
            this.Extra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Extra.Location = new System.Drawing.Point(4, 22);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(765, 180);
            this.Extra.TabIndex = 4;
            this.Extra.Text = "Extra";
            // 
            // generateEfiBtn
            // 
            this.generateEfiBtn.Location = new System.Drawing.Point(323, 370);
            this.generateEfiBtn.Name = "generateEfiBtn";
            this.generateEfiBtn.Size = new System.Drawing.Size(153, 23);
            this.generateEfiBtn.TabIndex = 6;
            this.generateEfiBtn.Text = "Generate";
            this.generateEfiBtn.UseVisualStyleBackColor = true;
            // 
            // valdBtn
            // 
            this.valdBtn.Location = new System.Drawing.Point(482, 370);
            this.valdBtn.Name = "valdBtn";
            this.valdBtn.Size = new System.Drawing.Size(302, 23);
            this.valdBtn.TabIndex = 7;
            this.valdBtn.Text = "Validate Settings";
            this.valdBtn.UseVisualStyleBackColor = true;
            // 
            // newEfiBtn
            // 
            this.newEfiBtn.Location = new System.Drawing.Point(15, 370);
            this.newEfiBtn.Name = "newEfiBtn";
            this.newEfiBtn.Size = new System.Drawing.Size(302, 23);
            this.newEfiBtn.TabIndex = 8;
            this.newEfiBtn.Text = "New EFI";
            this.newEfiBtn.UseVisualStyleBackColor = true;
            // 
            // disclaimerLabel
            // 
            this.disclaimerLabel.AutoSize = true;
            this.disclaimerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.disclaimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.disclaimerLabel.Location = new System.Drawing.Point(308, 411);
            this.disclaimerLabel.Name = "disclaimerLabel";
            this.disclaimerLabel.Size = new System.Drawing.Size(188, 48);
            this.disclaimerLabel.TabIndex = 9;
            this.disclaimerLabel.Text = "OC Gen Windows  Is not\r\nassosiciated with any of Opencore\r\ncreators";
            this.disclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sandyDesktop
            // 
            this.sandyDesktop.AutoSize = true;
            this.sandyDesktop.Location = new System.Drawing.Point(17, 40);
            this.sandyDesktop.Name = "sandyDesktop";
            this.sandyDesktop.Size = new System.Drawing.Size(108, 23);
            this.sandyDesktop.TabIndex = 0;
            this.sandyDesktop.TabStop = true;
            this.sandyDesktop.Text = "Sandy Bridge";
            this.sandyDesktop.UseVisualStyleBackColor = true;
            // 
            // ivyDesktop
            // 
            this.ivyDesktop.AutoSize = true;
            this.ivyDesktop.Location = new System.Drawing.Point(151, 40);
            this.ivyDesktop.Name = "ivyDesktop";
            this.ivyDesktop.Size = new System.Drawing.Size(88, 23);
            this.ivyDesktop.TabIndex = 1;
            this.ivyDesktop.TabStop = true;
            this.ivyDesktop.Text = "Ivy Bridge";
            this.ivyDesktop.UseVisualStyleBackColor = true;
            // 
            // skylakeDesktop
            // 
            this.skylakeDesktop.AutoSize = true;
            this.skylakeDesktop.Location = new System.Drawing.Point(364, 40);
            this.skylakeDesktop.Name = "skylakeDesktop";
            this.skylakeDesktop.Size = new System.Drawing.Size(81, 23);
            this.skylakeDesktop.TabIndex = 3;
            this.skylakeDesktop.TabStop = true;
            this.skylakeDesktop.Text = "Sky Lake";
            this.skylakeDesktop.UseVisualStyleBackColor = true;
            // 
            // haswellDesktop
            // 
            this.haswellDesktop.AutoSize = true;
            this.haswellDesktop.Location = new System.Drawing.Point(265, 40);
            this.haswellDesktop.Name = "haswellDesktop";
            this.haswellDesktop.Size = new System.Drawing.Size(73, 23);
            this.haswellDesktop.TabIndex = 2;
            this.haswellDesktop.TabStop = true;
            this.haswellDesktop.Text = "Haswell";
            this.haswellDesktop.UseVisualStyleBackColor = true;
            // 
            // coffeDesktop
            // 
            this.coffeDesktop.AutoSize = true;
            this.coffeDesktop.Location = new System.Drawing.Point(586, 40);
            this.coffeDesktop.Name = "coffeDesktop";
            this.coffeDesktop.Size = new System.Drawing.Size(100, 23);
            this.coffeDesktop.TabIndex = 5;
            this.coffeDesktop.TabStop = true;
            this.coffeDesktop.Text = "Coffee Lake";
            this.coffeDesktop.UseVisualStyleBackColor = true;
            // 
            // kabylakeDesktop
            // 
            this.kabylakeDesktop.AutoSize = true;
            this.kabylakeDesktop.Location = new System.Drawing.Point(471, 40);
            this.kabylakeDesktop.Name = "kabylakeDesktop";
            this.kabylakeDesktop.Size = new System.Drawing.Size(89, 23);
            this.kabylakeDesktop.TabIndex = 4;
            this.kabylakeDesktop.TabStop = true;
            this.kabylakeDesktop.Text = "Kaby Lake";
            this.kabylakeDesktop.UseVisualStyleBackColor = true;
            // 
            // coffeeLaptop
            // 
            this.coffeeLaptop.AutoSize = true;
            this.coffeeLaptop.Location = new System.Drawing.Point(586, 105);
            this.coffeeLaptop.Name = "coffeeLaptop";
            this.coffeeLaptop.Size = new System.Drawing.Size(100, 23);
            this.coffeeLaptop.TabIndex = 11;
            this.coffeeLaptop.TabStop = true;
            this.coffeeLaptop.Text = "Coffee Lake";
            this.coffeeLaptop.UseVisualStyleBackColor = true;
            // 
            // kabylakeLaptop
            // 
            this.kabylakeLaptop.AutoSize = true;
            this.kabylakeLaptop.Location = new System.Drawing.Point(471, 105);
            this.kabylakeLaptop.Name = "kabylakeLaptop";
            this.kabylakeLaptop.Size = new System.Drawing.Size(89, 23);
            this.kabylakeLaptop.TabIndex = 10;
            this.kabylakeLaptop.TabStop = true;
            this.kabylakeLaptop.Text = "Kaby Lake";
            this.kabylakeLaptop.UseVisualStyleBackColor = true;
            // 
            // skylakeLaptop
            // 
            this.skylakeLaptop.AutoSize = true;
            this.skylakeLaptop.Location = new System.Drawing.Point(364, 105);
            this.skylakeLaptop.Name = "skylakeLaptop";
            this.skylakeLaptop.Size = new System.Drawing.Size(81, 23);
            this.skylakeLaptop.TabIndex = 9;
            this.skylakeLaptop.TabStop = true;
            this.skylakeLaptop.Text = "Sky Lake";
            this.skylakeLaptop.UseVisualStyleBackColor = true;
            // 
            // haswellLaptop
            // 
            this.haswellLaptop.AutoSize = true;
            this.haswellLaptop.Location = new System.Drawing.Point(265, 105);
            this.haswellLaptop.Name = "haswellLaptop";
            this.haswellLaptop.Size = new System.Drawing.Size(73, 23);
            this.haswellLaptop.TabIndex = 8;
            this.haswellLaptop.TabStop = true;
            this.haswellLaptop.Text = "Haswell";
            this.haswellLaptop.UseVisualStyleBackColor = true;
            // 
            // ivyLaptop
            // 
            this.ivyLaptop.AutoSize = true;
            this.ivyLaptop.Location = new System.Drawing.Point(151, 105);
            this.ivyLaptop.Name = "ivyLaptop";
            this.ivyLaptop.Size = new System.Drawing.Size(88, 23);
            this.ivyLaptop.TabIndex = 7;
            this.ivyLaptop.TabStop = true;
            this.ivyLaptop.Text = "Ivy Bridge";
            this.ivyLaptop.UseVisualStyleBackColor = true;
            // 
            // sandyLaptop
            // 
            this.sandyLaptop.AutoSize = true;
            this.sandyLaptop.Location = new System.Drawing.Point(17, 105);
            this.sandyLaptop.Name = "sandyLaptop";
            this.sandyLaptop.Size = new System.Drawing.Size(108, 23);
            this.sandyLaptop.TabIndex = 6;
            this.sandyLaptop.TabStop = true;
            this.sandyLaptop.Text = "Sandy Bridge";
            this.sandyLaptop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Intel Laptop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Intel Desktop:";
            // 
            // icelakeLaptop
            // 
            this.icelakeLaptop.AutoSize = true;
            this.icelakeLaptop.Location = new System.Drawing.Point(17, 134);
            this.icelakeLaptop.Name = "icelakeLaptop";
            this.icelakeLaptop.Size = new System.Drawing.Size(77, 23);
            this.icelakeLaptop.TabIndex = 13;
            this.icelakeLaptop.TabStop = true;
            this.icelakeLaptop.Text = "Ice Lake";
            this.icelakeLaptop.UseVisualStyleBackColor = true;
            // 
            // kextDriverListbox
            // 
            this.kextDriverListbox.FormattingEnabled = true;
            this.kextDriverListbox.HorizontalScrollbar = true;
            this.kextDriverListbox.Items.AddRange(new object[] {
            "VirtualSMC",
            "Lilu",
            "Whatevergreen",
            "<------------>",
            "AppleALC",
            "VooodooHDA",
            "<------------>",
            "Intel Mausi-Ethernet",
            "Atheros-Ethernet",
            "Realtek-Ethernet",
            "RTL-Ethernet",
            "<------------>",
            "USBInjectall",
            "<------------>",
            "Intel-Airport",
            "IntelBluetooth",
            "AirportBrcmFixup",
            "<------------>",
            "VooodooPS2",
            "OldVoodooPS2 ( Can cause kernel-panic )",
            "<------------>"});
            this.kextDriverListbox.Location = new System.Drawing.Point(17, 17);
            this.kextDriverListbox.MultiColumn = true;
            this.kextDriverListbox.Name = "kextDriverListbox";
            this.kextDriverListbox.Size = new System.Drawing.Size(720, 139);
            this.kextDriverListbox.TabIndex = 0;
            // 
            // efiDriverListbox
            // 
            this.efiDriverListbox.FormattingEnabled = true;
            this.efiDriverListbox.Items.AddRange(new object[] {
            "OpenRuntime.efi",
            "OpenPartitionDxe.efi",
            "HiiDatabase.efi",
            "AudioDxe.efi",
            "CrScreenshot.efi",
            "NvmExpressDxe.efi",
            "XhciDxe.efi",
            "Ps2Keyboard+Ps2Mouse.efi",
            "UsbMouseDxe.efi",
            "OpenUsbKb.efi",
            "OpenCanopy.efi",
            "HFSPlus.efi"});
            this.efiDriverListbox.Location = new System.Drawing.Point(14, 11);
            this.efiDriverListbox.Name = "efiDriverListbox";
            this.efiDriverListbox.Size = new System.Drawing.Size(737, 154);
            this.efiDriverListbox.TabIndex = 0;
            // 
            // bootArgs
            // 
            this.bootArgs.Location = new System.Drawing.Point(63, 10);
            this.bootArgs.Name = "bootArgs";
            this.bootArgs.Size = new System.Drawing.Size(680, 20);
            this.bootArgs.TabIndex = 0;
            this.bootArgs.Text = "-v debug=0x100 keepsysm=1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Args";
            // 
            // extraListbox
            // 
            this.extraListbox.FormattingEnabled = true;
            this.extraListbox.Items.AddRange(new object[] {
            "Generate debug log",
            "Apple Panic",
            "Disable Watchdog",
            "Disable Vault",
            "Audio Support"});
            this.extraListbox.Location = new System.Drawing.Point(17, 47);
            this.extraListbox.Name = "extraListbox";
            this.extraListbox.Size = new System.Drawing.Size(726, 94);
            this.extraListbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label5.Location = new System.Drawing.Point(289, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Please validate before generating";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model : ";
            // 
            // smModel
            // 
            this.smModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.smModel.Location = new System.Drawing.Point(81, 9);
            this.smModel.Multiline = true;
            this.smModel.Name = "smModel";
            this.smModel.Size = new System.Drawing.Size(621, 31);
            this.smModel.TabIndex = 11;
            this.smModel.Text = "Macbook Pro 6,1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Serial";
            // 
            // smSerial
            // 
            this.smSerial.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.smSerial.Location = new System.Drawing.Point(81, 90);
            this.smSerial.Multiline = true;
            this.smSerial.Name = "smSerial";
            this.smSerial.Size = new System.Drawing.Size(195, 31);
            this.smSerial.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label8.Location = new System.Drawing.Point(11, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "UUID";
            // 
            // smUUID
            // 
            this.smUUID.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.smUUID.Location = new System.Drawing.Point(81, 127);
            this.smUUID.Multiline = true;
            this.smUUID.Name = "smUUID";
            this.smUUID.Size = new System.Drawing.Size(664, 31);
            this.smUUID.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label9.Location = new System.Drawing.Point(290, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "MLB";
            // 
            // smMlb
            // 
            this.smMlb.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.smMlb.Location = new System.Drawing.Point(360, 90);
            this.smMlb.Multiline = true;
            this.smMlb.Name = "smMlb";
            this.smMlb.Size = new System.Drawing.Size(385, 31);
            this.smMlb.TabIndex = 17;
            // 
            // smGenbtn
            // 
            this.smGenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.smGenbtn.ForeColor = System.Drawing.Color.Black;
            this.smGenbtn.Location = new System.Drawing.Point(81, 46);
            this.smGenbtn.Name = "smGenbtn";
            this.smGenbtn.Size = new System.Drawing.Size(195, 38);
            this.smGenbtn.TabIndex = 10;
            this.smGenbtn.Text = "Generate SMBIOS";
            this.smGenbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.disclaimerLabel);
            this.Controls.Add(this.newEfiBtn);
            this.Controls.Add(this.valdBtn);
            this.Controls.Add(this.generateEfiBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OC-Gen Windows Edition 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Hardware.ResumeLayout(false);
            this.Hardware.PerformLayout();
            this.Kext.ResumeLayout(false);
            this.EFIDriver.ResumeLayout(false);
            this.SMBios.ResumeLayout(false);
            this.SMBios.PerformLayout();
            this.Extra.ResumeLayout(false);
            this.Extra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label minimizeBtn;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Hardware;
        private System.Windows.Forms.TabPage Kext;
        private System.Windows.Forms.TabPage EFIDriver;
        private System.Windows.Forms.TabPage SMBios;
        private System.Windows.Forms.TabPage Extra;
        private System.Windows.Forms.Button generateEfiBtn;
        private System.Windows.Forms.Button valdBtn;
        private System.Windows.Forms.Button newEfiBtn;
        private System.Windows.Forms.Label disclaimerLabel;
        private System.Windows.Forms.RadioButton icelakeLaptop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton coffeeLaptop;
        private System.Windows.Forms.RadioButton kabylakeLaptop;
        private System.Windows.Forms.RadioButton skylakeLaptop;
        private System.Windows.Forms.RadioButton haswellLaptop;
        private System.Windows.Forms.RadioButton ivyLaptop;
        private System.Windows.Forms.RadioButton sandyLaptop;
        private System.Windows.Forms.RadioButton coffeDesktop;
        private System.Windows.Forms.RadioButton kabylakeDesktop;
        private System.Windows.Forms.RadioButton skylakeDesktop;
        private System.Windows.Forms.RadioButton haswellDesktop;
        private System.Windows.Forms.RadioButton ivyDesktop;
        private System.Windows.Forms.RadioButton sandyDesktop;
        private System.Windows.Forms.CheckedListBox kextDriverListbox;
        private System.Windows.Forms.CheckedListBox efiDriverListbox;
        private System.Windows.Forms.CheckedListBox extraListbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bootArgs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button smGenbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox smMlb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox smUUID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox smSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox smModel;
    }
}

