using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Gen_Windows
{
    class ConfigACPI
    {
        /*
         * 
         * Protected by MIT License
         * 
         * Values for hardware, To generate EFI
         * Don't modify unless you are sure
         * 
         * The point of this is, The actual config.plist is going to have major areas such as ACPI
         * removed and replaced with one letter or a word intially, Then we replace it
         * by using the Arrays that contain keys..etc the actual-format
         * 
         * For example:
         * <dict>ACPI</dict>
         * - ACPI Patching keys and text
         * 
         * is going to be instead
         * ACPIHere
         * 
         * Array Index item are sorted by how Dortania's guide sort the config setup
         * example:
         * Intel Laptop
         *       - Arrandale
         *       - Sandy
         *       
         */

        // ACPI Section
        String[] ACPI_intelDesktop = { };
        String[] ACPI_intelLaptop = { };
        String[] ACPI_intelHEDT = { };
        String[] ACPI_AMD = { };

        //
        // Functions for generating is here....
        //


	}
}
