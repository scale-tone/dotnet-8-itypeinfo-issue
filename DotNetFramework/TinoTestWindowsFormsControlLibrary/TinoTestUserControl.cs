using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace TinoTestWindowsFormsControlLibrary
{
    [Guid("8EC1F0DA-5FB7-384B-AC18-6B7EE6CCD1C6")]
    [ProgId("TinoTestWindowsFormsControlLibrary.TinoTestUserControl")]
    public partial class TinoTestUserControl: UserControl
    {
        public TinoTestUserControl()
        {
            MessageBox.Show(".Net Framework control created!");

            InitializeComponent();
        }

        private void TinoTestUserControl_Load(object sender, EventArgs e)
        {
        }

        [ComRegisterFunction()]
        public static void RegisterClass(string key)
        {
            using (var clsidKey = Registry.ClassesRoot.OpenSubKey(key.Replace(@"HKEY_CLASSES_ROOT\", ""), true))
            {
                // Marking as "Control", so that VBA can see it
                using (clsidKey.CreateSubKey("Control")) { }
            }
        }
    }
}
