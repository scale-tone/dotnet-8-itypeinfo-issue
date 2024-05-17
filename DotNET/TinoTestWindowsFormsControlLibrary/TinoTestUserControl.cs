using System.Runtime.InteropServices;

namespace TinoTestWindowsFormsControlLibrary
{
    [ComVisible(true)]
    [Guid("8EC1F0DA-5FB7-384B-AC18-6B7EE6CCD1C6")]
    [ProgId("TinoTestWindowsFormsControlLibrary.TinoTestUserControl")]
    public partial class TinoTestUserControl : UserControl
    {
        public TinoTestUserControl()
        {
            MessageBox.Show(".NET control created!");

            InitializeComponent();
        }
    }
}
