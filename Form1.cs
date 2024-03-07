using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NachoAprende
{
    public partial class frmNachoAprende : Form
    {
        public frmNachoAprende()
        {
            InitializeComponent();
        }

        private void frmNachoAprende_Load(object sender, EventArgs e)
        {
            string videoPath = @"C:\Users\johan\source\repos\NachoAprende\bin\Debug\video.mp4";
            wmpMusica.URL = videoPath;
        }
    }
}
