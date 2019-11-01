using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingProject
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void opacityTrack_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)opacityTrack.Value / 100.0);
            
        }
    }
}
