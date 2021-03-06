using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System;

namespace OC_Gen_Windows
{
    class ConfigFiles
    {
        /*
         * Protected by MIT License
         * 
         * Used to Add kexts/drivers to config.plist provided by user!
         */

        public static string kexts = null;
        public static string efidrivers = null;
        static MainWidget MainWidget = Application.OpenForms.OfType<MainWidget>().FirstOrDefault();       
        //
        // Add kexts that is selected from MainWidget.cs to kexts list
        //
        public static void addKextsFromConfig()
        {
            try
            {
                //
                // Essentials 1
                //
                for (int i = 0; i < MainWidget.Essentials_checkList.Items.Count; i++)
                {
                    if (MainWidget.Essentials_checkList.GetItemCheckState(i) == CheckState.Checked)
                    {
                        kexts = kexts + MainWidget.Essentials_checkList.Items[i].ToString() + Environment.NewLine;
                    }
                }

                //
                // Essentials 2
                //
                for (int i = 0; i < MainWidget.Essentials_list2.Items.Count; i++)
                {
                    if (MainWidget.Essentials_list2.GetItemCheckState(i) == CheckState.Checked)
                    {
                        kexts = kexts + MainWidget.Essentials_list2.Items[i].ToString() + Environment.NewLine;

                    }
                }

                //
                // Audio
                //
                for (int i = 0; i < MainWidget.Audio_checkLlist.Items.Count; i++)
                {
                    if (MainWidget.Audio_checkLlist.GetItemCheckState(i) == CheckState.Checked)
                    {
                        kexts = kexts + MainWidget.Audio_checkLlist.Items[i].ToString() + Environment.NewLine;
                    }
                }

                //
                // Network
                //
                for (int i = 0; i < MainWidget.Network_ethernetList.Items.Count; i++)
                {
                    if (MainWidget.Network_ethernetList.GetItemCheckState(i) == CheckState.Checked)
                    {
                        kexts = kexts + MainWidget.Network_ethernetList.Items[i].ToString() + Environment.NewLine;
                    }
                }
                for (int i = 0; i < MainWidget.Network_wifiList.Items.Count; i++)
                {
                    if (MainWidget.Network_wifiList.GetItemCheckState(i) == CheckState.Checked)
                    {
                        kexts = kexts + MainWidget.Network_wifiList.Items[i].ToString() + Environment.NewLine;
                    }
                }

                //
                // Laptop
                //
                for (int i = 0; i < MainWidget.Laptops_listBox.Items.Count; i++)
                {
                    if (MainWidget.Laptops_listBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        kexts = kexts + MainWidget.Laptops_listBox.Items[i].ToString() + Environment.NewLine;
                    }
                }


            } catch(Exception ex)
            {
                MainWidget.Generate_debugWindow.Text += ex.ToString() + Environment.NewLine;
            }

           

        }

        public static void addDriversfromConfig()
        {
            for (int i = 0; i < MainWidget.Drivers_list.Items.Count; i++)
            {
                if (MainWidget.Drivers_list.GetItemCheckState(i) == CheckState.Checked)
                {
                    efidrivers = efidrivers + MainWidget.Drivers_list.Items[i].ToString() + Environment.NewLine;

                }
            }

        }


    }
}
