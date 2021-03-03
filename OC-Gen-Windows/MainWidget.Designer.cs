
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Hardware = new System.Windows.Forms.TabPage();
            this.Kext = new System.Windows.Forms.TabPage();
            this.EFIDriver = new System.Windows.Forms.TabPage();
            this.efiDriverListbox = new System.Windows.Forms.CheckedListBox();
            this.SMBios = new System.Windows.Forms.TabPage();
            this.smGenbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.smMlb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.smUUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.smSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.smModel = new System.Windows.Forms.TextBox();
            this.Extra = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.extraListbox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bootArgs = new System.Windows.Forms.TextBox();
            this.generateEfiBtn = new System.Windows.Forms.Button();
            this.valdBtn = new System.Windows.Forms.Button();
            this.newEfiBtn = new System.Windows.Forms.Button();
            this.disclaimerLabel = new System.Windows.Forms.Label();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kextPanel = new System.Windows.Forms.TabControl();
            this.mustTab = new System.Windows.Forms.TabPage();
            this.audioTab = new System.Windows.Forms.TabPage();
            this.ethernetTab = new System.Windows.Forms.TabPage();
            this.usbTab = new System.Windows.Forms.TabPage();
            this.ExtraTab = new System.Windows.Forms.TabPage();
            this.mustListbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.audioListbox = new System.Windows.Forms.CheckedListBox();
            this.codecEditbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.intelEthernetListbox = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.atherosEthernetlistbox = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.realtekEthernetlistbox = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.otherEthernetListbox = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.unsupportedListbox = new System.Windows.Forms.CheckedListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.usbInjectListbox = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hardwareCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Hardware.SuspendLayout();
            this.Kext.SuspendLayout();
            this.EFIDriver.SuspendLayout();
            this.SMBios.SuspendLayout();
            this.Extra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.kextPanel.SuspendLayout();
            this.mustTab.SuspendLayout();
            this.audioTab.SuspendLayout();
            this.ethernetTab.SuspendLayout();
            this.usbTab.SuspendLayout();
            this.ExtraTab.SuspendLayout();
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
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.lblTitle.Location = new System.Drawing.Point(319, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 18);
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
            this.logoPicture.Location = new System.Drawing.Point(93, 56);
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
            this.Hardware.Controls.Add(this.hardwareCombobox);
            this.Hardware.Controls.Add(this.label2);
            this.Hardware.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Kext.Controls.Add(this.kextPanel);
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
            // SMBios
            // 
            this.SMBios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.SMBios.Controls.Add(this.comboBox1);
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
            // bootArgs
            // 
            this.bootArgs.Location = new System.Drawing.Point(63, 10);
            this.bootArgs.Name = "bootArgs";
            this.bootArgs.Size = new System.Drawing.Size(680, 20);
            this.bootArgs.TabIndex = 0;
            this.bootArgs.Text = "-v debug=0x100 keepsysm=1";
            // 
            // generateEfiBtn
            // 
            this.generateEfiBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateEfiBtn.Location = new System.Drawing.Point(323, 370);
            this.generateEfiBtn.Name = "generateEfiBtn";
            this.generateEfiBtn.Size = new System.Drawing.Size(153, 42);
            this.generateEfiBtn.TabIndex = 6;
            this.generateEfiBtn.Text = "Generate";
            this.generateEfiBtn.UseVisualStyleBackColor = true;
            // 
            // valdBtn
            // 
            this.valdBtn.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.valdBtn.Location = new System.Drawing.Point(482, 370);
            this.valdBtn.Name = "valdBtn";
            this.valdBtn.Size = new System.Drawing.Size(302, 42);
            this.valdBtn.TabIndex = 7;
            this.valdBtn.Text = "Validate Settings";
            this.valdBtn.UseVisualStyleBackColor = true;
            // 
            // newEfiBtn
            // 
            this.newEfiBtn.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.newEfiBtn.Location = new System.Drawing.Point(15, 370);
            this.newEfiBtn.Name = "newEfiBtn";
            this.newEfiBtn.Size = new System.Drawing.Size(302, 42);
            this.newEfiBtn.TabIndex = 8;
            this.newEfiBtn.Text = "New EFI";
            this.newEfiBtn.UseVisualStyleBackColor = true;
            // 
            // disclaimerLabel
            // 
            this.disclaimerLabel.AutoSize = true;
            this.disclaimerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.disclaimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.disclaimerLabel.Location = new System.Drawing.Point(308, 435);
            this.disclaimerLabel.Name = "disclaimerLabel";
            this.disclaimerLabel.Size = new System.Drawing.Size(188, 48);
            this.disclaimerLabel.TabIndex = 9;
            this.disclaimerLabel.Text = "OC Gen Windows  Is not\r\nassosiciated with any of Opencore\r\ncreators";
            this.disclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "CORE (BLACK2).vssf");
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Macbook",
            "Macbook Pro",
            "Macbook Mini",
            "Mac Mini",
            "iMac",
            "iMac Pro",
            "Mac Pro"});
            this.comboBox1.Location = new System.Drawing.Point(282, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 26);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Macbook Air";
            // 
            // kextPanel
            // 
            this.kextPanel.Controls.Add(this.mustTab);
            this.kextPanel.Controls.Add(this.audioTab);
            this.kextPanel.Controls.Add(this.ethernetTab);
            this.kextPanel.Controls.Add(this.usbTab);
            this.kextPanel.Controls.Add(this.ExtraTab);
            this.kextPanel.Location = new System.Drawing.Point(17, 12);
            this.kextPanel.Name = "kextPanel";
            this.kextPanel.SelectedIndex = 0;
            this.kextPanel.Size = new System.Drawing.Size(729, 158);
            this.kextPanel.TabIndex = 0;
            // 
            // mustTab
            // 
            this.mustTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.mustTab.Controls.Add(this.label1);
            this.mustTab.Controls.Add(this.mustListbox);
            this.mustTab.Location = new System.Drawing.Point(4, 22);
            this.mustTab.Name = "mustTab";
            this.mustTab.Padding = new System.Windows.Forms.Padding(3);
            this.mustTab.Size = new System.Drawing.Size(721, 132);
            this.mustTab.TabIndex = 0;
            this.mustTab.Text = "Must";
            // 
            // audioTab
            // 
            this.audioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.audioTab.Controls.Add(this.label10);
            this.audioTab.Controls.Add(this.codecEditbox);
            this.audioTab.Controls.Add(this.audioListbox);
            this.audioTab.Location = new System.Drawing.Point(4, 22);
            this.audioTab.Name = "audioTab";
            this.audioTab.Padding = new System.Windows.Forms.Padding(3);
            this.audioTab.Size = new System.Drawing.Size(721, 132);
            this.audioTab.TabIndex = 1;
            this.audioTab.Text = "Audio";
            // 
            // ethernetTab
            // 
            this.ethernetTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.ethernetTab.Controls.Add(this.label14);
            this.ethernetTab.Controls.Add(this.otherEthernetListbox);
            this.ethernetTab.Controls.Add(this.label13);
            this.ethernetTab.Controls.Add(this.realtekEthernetlistbox);
            this.ethernetTab.Controls.Add(this.label12);
            this.ethernetTab.Controls.Add(this.atherosEthernetlistbox);
            this.ethernetTab.Controls.Add(this.label11);
            this.ethernetTab.Controls.Add(this.intelEthernetListbox);
            this.ethernetTab.Location = new System.Drawing.Point(4, 22);
            this.ethernetTab.Name = "ethernetTab";
            this.ethernetTab.Size = new System.Drawing.Size(721, 132);
            this.ethernetTab.TabIndex = 2;
            this.ethernetTab.Text = "Ethernet & WiFi";
            // 
            // usbTab
            // 
            this.usbTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.usbTab.Controls.Add(this.label16);
            this.usbTab.Controls.Add(this.usbInjectListbox);
            this.usbTab.Controls.Add(this.label15);
            this.usbTab.Controls.Add(this.unsupportedListbox);
            this.usbTab.Location = new System.Drawing.Point(4, 22);
            this.usbTab.Name = "usbTab";
            this.usbTab.Size = new System.Drawing.Size(721, 132);
            this.usbTab.TabIndex = 3;
            this.usbTab.Text = "USB";
            // 
            // ExtraTab
            // 
            this.ExtraTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.ExtraTab.Controls.Add(this.label18);
            this.ExtraTab.Controls.Add(this.checkedListBox2);
            this.ExtraTab.Controls.Add(this.label17);
            this.ExtraTab.Controls.Add(this.checkedListBox1);
            this.ExtraTab.Location = new System.Drawing.Point(4, 22);
            this.ExtraTab.Name = "ExtraTab";
            this.ExtraTab.Size = new System.Drawing.Size(721, 132);
            this.ExtraTab.TabIndex = 5;
            this.ExtraTab.Text = "Extra";
            // 
            // mustListbox
            // 
            this.mustListbox.CheckOnClick = true;
            this.mustListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mustListbox.FormattingEnabled = true;
            this.mustListbox.Items.AddRange(new object[] {
            "Lilu",
            "VirtualSMC",
            "FakeSMC",
            "Whatevergreen"});
            this.mustListbox.Location = new System.Drawing.Point(6, 6);
            this.mustListbox.Name = "mustListbox";
            this.mustListbox.Size = new System.Drawing.Size(178, 109);
            this.mustListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(190, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 80);
            this.label1.TabIndex = 10;
            this.label1.Text = "Instructions:\r\nLilu ( HEAVLIY REQUIRED )\r\nVirtualSMC ( Emulate Chip, For New Hard" +
    "ware )\r\nFakeSMC ( Also Emulate chip, For legacy hardware )\r\nWhatevergreen ( for " +
    "Patching Graphic )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // audioListbox
            // 
            this.audioListbox.CheckOnClick = true;
            this.audioListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.audioListbox.FormattingEnabled = true;
            this.audioListbox.Items.AddRange(new object[] {
            "AppleALC",
            "VoodooHDA"});
            this.audioListbox.Location = new System.Drawing.Point(6, 6);
            this.audioListbox.Name = "audioListbox";
            this.audioListbox.Size = new System.Drawing.Size(178, 109);
            this.audioListbox.TabIndex = 10;
            this.audioListbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // codecEditbox
            // 
            this.codecEditbox.Enabled = false;
            this.codecEditbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.codecEditbox.Location = new System.Drawing.Point(351, 7);
            this.codecEditbox.Name = "codecEditbox";
            this.codecEditbox.Size = new System.Drawing.Size(280, 24);
            this.codecEditbox.TabIndex = 10;
            this.codecEditbox.Text = "CX8050";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label10.Location = new System.Drawing.Point(190, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Codec ( for AppleALC Only )";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intelEthernetListbox
            // 
            this.intelEthernetListbox.CheckOnClick = true;
            this.intelEthernetListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.intelEthernetListbox.FormattingEnabled = true;
            this.intelEthernetListbox.Items.AddRange(new object[] {
            "IntelMausi [ Ethernet ]",
            "SmallTree [ Ethernet ]",
            "Intel WiFi",
            "Intel Bluetooth"});
            this.intelEthernetListbox.Location = new System.Drawing.Point(11, 25);
            this.intelEthernetListbox.Name = "intelEthernetListbox";
            this.intelEthernetListbox.Size = new System.Drawing.Size(188, 88);
            this.intelEthernetListbox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label11.Location = new System.Drawing.Point(81, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Intel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label12.Location = new System.Drawing.Point(215, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Atheros";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atherosEthernetlistbox
            // 
            this.atherosEthernetlistbox.CheckOnClick = true;
            this.atherosEthernetlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.atherosEthernetlistbox.FormattingEnabled = true;
            this.atherosEthernetlistbox.Items.AddRange(new object[] {
            "Atheros E2200 [ Ethernet ]"});
            this.atherosEthernetlistbox.Location = new System.Drawing.Point(218, 25);
            this.atherosEthernetlistbox.Name = "atherosEthernetlistbox";
            this.atherosEthernetlistbox.Size = new System.Drawing.Size(238, 25);
            this.atherosEthernetlistbox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label13.Location = new System.Drawing.Point(215, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Realtek";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realtekEthernetlistbox
            // 
            this.realtekEthernetlistbox.CheckOnClick = true;
            this.realtekEthernetlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.realtekEthernetlistbox.FormattingEnabled = true;
            this.realtekEthernetlistbox.Items.AddRange(new object[] {
            "RTL8111"});
            this.realtekEthernetlistbox.Location = new System.Drawing.Point(218, 79);
            this.realtekEthernetlistbox.Name = "realtekEthernetlistbox";
            this.realtekEthernetlistbox.Size = new System.Drawing.Size(117, 25);
            this.realtekEthernetlistbox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label14.Location = new System.Drawing.Point(481, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Other";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otherEthernetListbox
            // 
            this.otherEthernetListbox.CheckOnClick = true;
            this.otherEthernetListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.otherEthernetListbox.FormattingEnabled = true;
            this.otherEthernetListbox.Items.AddRange(new object[] {
            "Lucy RTL",
            "Realtek RTL 8100",
            "BCM5722D",
            "Broadcom Airport"});
            this.otherEthernetListbox.Location = new System.Drawing.Point(484, 25);
            this.otherEthernetListbox.Name = "otherEthernetListbox";
            this.otherEthernetListbox.Size = new System.Drawing.Size(214, 88);
            this.otherEthernetListbox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label15.Location = new System.Drawing.Point(76, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Unsupported";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unsupportedListbox
            // 
            this.unsupportedListbox.CheckOnClick = true;
            this.unsupportedListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unsupportedListbox.FormattingEnabled = true;
            this.unsupportedListbox.Items.AddRange(new object[] {
            "SATA-unsupported",
            "XHCI-unsupported",
            "CtlnaAHCIPort ( For big sur )"});
            this.unsupportedListbox.Location = new System.Drawing.Point(17, 30);
            this.unsupportedListbox.Name = "unsupportedListbox";
            this.unsupportedListbox.Size = new System.Drawing.Size(235, 88);
            this.unsupportedListbox.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label16.Location = new System.Drawing.Point(355, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "USB";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usbInjectListbox
            // 
            this.usbInjectListbox.CheckOnClick = true;
            this.usbInjectListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usbInjectListbox.FormattingEnabled = true;
            this.usbInjectListbox.Items.AddRange(new object[] {
            "USBInjectAll",
            "XLNCUSBFIX ( AMD )"});
            this.usbInjectListbox.Location = new System.Drawing.Point(258, 30);
            this.usbInjectListbox.Name = "usbInjectListbox";
            this.usbInjectListbox.Size = new System.Drawing.Size(235, 46);
            this.usbInjectListbox.TabIndex = 15;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "AppleMCEReporterDisabler",
            "CPUTysnc",
            "NVMeFix"});
            this.checkedListBox1.Location = new System.Drawing.Point(14, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(233, 88);
            this.checkedListBox1.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label17.Location = new System.Drawing.Point(92, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Fixes";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label18.Location = new System.Drawing.Point(349, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Laptops:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "VoodooPS2",
            "RehabMan-VoodooPS2",
            "VoodooI2C",
            "VoodooSMBus"});
            this.checkedListBox2.Location = new System.Drawing.Point(271, 28);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(233, 88);
            this.checkedListBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(232, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "Please choose Proper hardware configuration\r\nThis will judge how EFI folder will " +
    "be created\r\nDon\'t put anything you don\'t know";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardwareCombobox
            // 
            this.hardwareCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardwareCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardwareCombobox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareCombobox.FormattingEnabled = true;
            this.hardwareCombobox.Items.AddRange(new object[] {
            "<---- DESKTOP ------>",
            "Intel  - Clarkdale",
            "Intel - Sandy Bridge",
            "Intel - Ivy Bridge",
            "Intel - Haswell",
            "Intel - Skylake",
            "Intel - Kaby Lake",
            "Intel - Coffee Lake",
            "Intel - Comet lake",
            "<---- LAPTOP ------>",
            "Intel - Arrandale",
            "Intel - Sandy Bridge",
            "Intel - Ivy Bridge",
            "Intel - Haswell",
            "Intel - Broadwell",
            "Intel - Skylake",
            "Intel - Kaby Lake",
            "Intel - Coffee/Whiskey Lake",
            "Intel - Coffee Lake Plus/ Comet Lake",
            "Intel - Ice  Lake",
            "<---- INTEL HEDT ------>",
            "Nehalem / Westmere",
            "Sandy and Ivy-Bridge E",
            "Haswell-E",
            "Broadwell-E",
            "Skylake-X",
            "<---- AMD ------>",
            "AMD - Buildozer and Jaguar 15h/16h",
            "AMD - Ryzen and Threadripper 17h/19h"});
            this.hardwareCombobox.Location = new System.Drawing.Point(134, 84);
            this.hardwareCombobox.Name = "hardwareCombobox";
            this.hardwareCombobox.Size = new System.Drawing.Size(517, 28);
            this.hardwareCombobox.TabIndex = 11;
            this.hardwareCombobox.SelectedIndexChanged += new System.EventHandler(this.hardwareCombobox_SelectedIndexChanged);
            // 
            // MainWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
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
            this.Name = "MainWidget";
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
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.kextPanel.ResumeLayout(false);
            this.mustTab.ResumeLayout(false);
            this.mustTab.PerformLayout();
            this.audioTab.ResumeLayout(false);
            this.audioTab.PerformLayout();
            this.ethernetTab.ResumeLayout(false);
            this.ethernetTab.PerformLayout();
            this.usbTab.ResumeLayout(false);
            this.usbTab.PerformLayout();
            this.ExtraTab.ResumeLayout(false);
            this.ExtraTab.PerformLayout();
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
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl kextPanel;
        private System.Windows.Forms.TabPage mustTab;
        private System.Windows.Forms.TabPage audioTab;
        private System.Windows.Forms.TabPage ethernetTab;
        private System.Windows.Forms.TabPage usbTab;
        private System.Windows.Forms.TabPage ExtraTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox mustListbox;
        private System.Windows.Forms.CheckedListBox audioListbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox codecEditbox;
        private System.Windows.Forms.CheckedListBox intelEthernetListbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox realtekEthernetlistbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox atherosEthernetlistbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox otherEthernetListbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox unsupportedListbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox usbInjectListbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hardwareCombobox;
    }
}

