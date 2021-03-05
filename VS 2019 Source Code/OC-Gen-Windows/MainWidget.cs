using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace OC_Gen_Windows
{
    public partial class MainWidget : Form
    {
        /*
         * 
         *  OC Gen X
         *  Coded by Gytch
         *  Credits: VisualStyler .NET for Theme
         *  License: MIT License
         * 
         */

        //
        // Variables
        public static List<string> selectedKexts = new List<string>();
        public static string bootargs;

        // Hardware list
        //
        //
        string[] intelHardware_laptop =
        {
            "Sandy Bridge",
            "Ivy Bridge",
            "Haswell",
            "Broadwell",
            "Skylake",
            "Kaby Lake",
            "Coffee Lake / Whiskey Lake",
            "Coffee Lake Plus / Comet Lake",
            "Ice Lake"
        };

        string[] intelHardware_desktop =
        {
            "Clarkdale",
            "Sandy Bridge",
            "Ivy Bridge",
            "Haswell",
            "Skylake",
            "Kaby Lake",
            "Coffee Lake",
            "Comet Lake"
        };

        string[] intelHardware_HEDT =
        {
            "Nehalem / Westmere",
            "Sandy/Ivy Bridge-E",
            "Haswell-E",
            "Broadwell-E",
            "Skylake-X/W",
            "Cascade Lake-X/W"
        };

        string[] amdHardware =
        {
            "Buildozer15h / Jaguar 16h",
            "Ryzen / Threadripper 17h/19h"
        };


        public MainWidget()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable Other tabs on load--
            tab_Kexts.Enabled = false;
            tab_Drivers.Enabled = false;
            tab_Quirks.Enabled = false;
            tab_SMBios.Enabled = false;
            tab_Generate.Enabled = false;

            // Hide Kext's tab
            KextsTab.ItemSize = new Size(0, 1);

            // Hide Kexts->Graphic->Intel Group box
            Graphics_Intel_group.Enabled = false;
        }

        //
        //<START> UI Movement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //
        // <End> UI Movement

      
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // SHOW INFORMATION ABOUT BUTTONS
        //
        private void tab_Hardware_MouseHover(object sender, EventArgs e)
        {
            hover_InformationTip.Show("Configure hardware module, Necessary for other steps", tab_Hardware);
        }

        private void tab_Kexts_MouseHover(object sender, EventArgs e)
        {
            hover_InformationTip.Show("Kexts are drivers, They Make unsupported parts working", tab_Kexts);
        }

        private void tab_Drivers_MouseHover(object sender, EventArgs e)
        {
            hover_InformationTip.Show("Drivers aren't kexts, Those are used in OpenCore bootloader", tab_Drivers);
        }

        private void tab_Quirks_MouseHover(object sender, EventArgs e)
        {
            hover_InformationTip.Show("Extra inputs For people who are familiar with Opencore", tab_Quirks);
        }

        private void tab_SMBios_MouseHover(object sender, EventArgs e)
        {
            hover_InformationTip.Show("Configure hardware module, Necessary for other steps", tab_SMBios);
        }

        private void tab_Generate_MouseHover(object sender, EventArgs e)
        {

        }
        //
        // START: Hardware
        //

     
        private void trigger_IntelHARDWARE_Click(object sender, EventArgs e)
        {
            hardware_comboBox.Items.Clear();
            hardware_comboBox.Enabled = true;
            hardware_comboBox.Items.Add("<-- DESKTOP -->");
            for (int i = 0; i < intelHardware_desktop.Length; i++)
            {
                hardware_comboBox.Items.Add(intelHardware_desktop[i]);
            }
            
            hardware_comboBox.Items.Add("<-- LAPTOPS -->");
            for (int i = 0; i < intelHardware_laptop.Length; i++)
            {
                hardware_comboBox.Items.Add(intelHardware_laptop[i]);
            }

            hardware_comboBox.SelectedIndex = 1;
            tab_Kexts.Enabled = true;
            tab_Drivers.Enabled = true;
            tab_Quirks.Enabled = true;
            tab_SMBios.Enabled = true;
            tab_Generate.Enabled = true;
            deg("Trigger Intel Hardware", 1);

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            hardware_comboBox.Items.Clear();
            hardware_comboBox.Enabled = true;
            hardware_comboBox.Items.Add("<-- INTEL HEDT SUPER -->");
            for (int i = 0; i < intelHardware_HEDT.Length; i++)
            {
                hardware_comboBox.Items.Add(intelHardware_HEDT[i]);
            }
            hardware_comboBox.SelectedIndex = 1;
            tab_Kexts.Enabled = true;
            tab_Drivers.Enabled = true;
            tab_Quirks.Enabled = true;
            tab_SMBios.Enabled = true;
            tab_Generate.Enabled = true;

            deg("Trigger Intel-HEDT Hardware", 1);

        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            hardware_comboBox.Items.Clear();
            hardware_comboBox.Enabled = true;
            hardware_comboBox.Items.Add("<-- AMD -->");
            for (int i = 0; i < amdHardware.Length; i++)
            {
                hardware_comboBox.Items.Add(amdHardware[i]);
            }
            hardware_comboBox.SelectedIndex = 1;
            tab_Kexts.Enabled = true;
            tab_Drivers.Enabled = true;
            tab_Quirks.Enabled = true;
            tab_SMBios.Enabled = true;
            tab_Generate.Enabled = true;

            deg("Trigger AMD Hardware", 1);
        }

        //
        // END: Hardware
        //
        private void tab_Hardware_Click(object sender, EventArgs e)
        {
            panel_Hardware.BringToFront();
            deg("Tab Hardware Menu", 1);
        }

        private void tab_Kexts_Click(object sender, EventArgs e)
        {
            panel_Kexts.BringToFront();
            deg("Tab Kexts Menu", 1);
        }
        private void tab_Generate_Click(object sender, EventArgs e)
        {
            panel_Generate.BringToFront();
        }

        //
        // START: Kexts- Tab
        //
        private void kextsPanel_btn_Essentials_Click(object sender, EventArgs e)
        {
            KextsTab.SelectedIndex = 0;
            deg("Kexts-> Essentials", 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KextsTab.SelectedIndex = 1;
            deg("Kexts-> Audio", 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            KextsTab.SelectedIndex = 2;
            deg("Kexts-> Graphics", 1);
        }
        private void kextsPanel_btn_Network_Click(object sender, EventArgs e)
        {
            KextsTab.SelectedIndex = 3;
            deg("Kexts-> Network", 1);
        }
        private void kextsPanel_btn_Laptop_Click(object sender, EventArgs e)
        {
            KextsTab.SelectedIndex = 4;
            deg("Kexts-> Laptop", 1);
        }
        //
        // END: Kexts- Tab
        //

        private void Audio_checkLlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Audio_checkLlist.GetItemCheckState(0) == CheckState.Checked && Audio_checkLlist.GetItemCheckState(1) == CheckState.Unchecked)
            {
                audio_textbox_Alcid.Enabled = true;
            }
            else
            {
                audio_textbox_Alcid.Enabled = false;
            }

            if (Audio_checkLlist.GetItemCheckState(0) == CheckState.Checked && Audio_checkLlist.GetItemCheckState(1) == CheckState.Checked)
            {
                MessageBox.Show("You can't choose both kexts, They'll cause conflict");
                Audio_checkLlist.SetItemChecked(1, false);
            }
        }

        private void Graphics_Intel_CheckedChanged(object sender, EventArgs e)
        {
            if (Graphics_Intel.Checked)
            {
                Graphics_Intel_group.Enabled = true;
            } else
            {
                Graphics_Intel_group.Enabled = false;
            }
        }

        private void Essentials_checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Essentials_checkList.GetItemCheckState(1) == CheckState.Checked && Essentials_checkList.GetItemCheckState(2) == CheckState.Unchecked)
            {
                audio_textbox_Alcid.Enabled = true;
            }
            else
            {
                audio_textbox_Alcid.Enabled = false;
            }

            if (Essentials_checkList.GetItemCheckState(1) == CheckState.Checked && Essentials_checkList.GetItemCheckState(2) == CheckState.Checked)
            {
                MessageBox.Show("You can't choose both kexts, They'll cause conflict");
                Essentials_checkList.SetItemChecked(2, false);
            }
        }

        private void Graphics_textbox_AAPL_TextChanged(object sender, EventArgs e)
        {
            if(Graphics_textbox_AAPL.TextLength < 8)
            {
                MessageBox.Show("Please enter valid  AAPL id");
            }
        }

        //
        // START: Functions
        //
        public void deg(string DebugSymbol, int Status)
        {
            Generate_debugWindow.Text += DebugSymbol + " :" + Status.ToString() + Environment.NewLine;
        }

        private void Generate_btn_ClearDebugs_Click(object sender, EventArgs e)
        {
            Generate_debugWindow.Text = "";
        }


        //
        // END: Functions
        //

    }
}
