using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public MainWidget()
        {
            InitializeComponent();
        }

        //
        // Ability to draw Windows Form
        //
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
        // End

        //
        // UI Functions
        //

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            // Disable Other Tabs if Hardware is not selected
            //
            if (hardwareCombobox.Text == "")
            {
                EnableTab(Kext, false);
                EnableTab(EFIDriver, false);
                EnableTab(SMBios, false);
                EnableTab(Extra, false);
            }
        }

        // If hardware is selected, Enable other tabs
        private void hardwareCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getHardwareComboboxText = hardwareCombobox.Text;
            // Validate Selection
            if( getHardwareComboboxText.Contains("<----"))
            {
                // Invalid selection
                MessageBox.Show("Invalid Selection", "Error");

            } else
            {
                //
                // Valid Selection
                //
                EnableTab(Kext, true);
                EnableTab(EFIDriver, true);
                EnableTab(SMBios, true);
                EnableTab(Extra, true);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (audioListbox.GetItemCheckState(0) == CheckState.Checked)
            {
                codecEditbox.Enabled = true;
            } else
            {
                codecEditbox.Enabled = false;
            }
        }
        // END

        //
        // Coded-Functions
        //

        // Enable/Disable Tab
        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

       
    }
}
