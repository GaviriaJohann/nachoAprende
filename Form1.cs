using AxWMPLib;
using SHDocVw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void RealizarBusquedaEnLinea(string busqueda)
        {
            string urlBusqueda = "https://www.google.com/search?q=" + Uri.EscapeUriString(busqueda);

            wbNavegador.Navigate(urlBusqueda);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                search = search.Replace(" ", "+");

                RealizarBusquedaEnLinea(search);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un término de búsqueda.");
            }
        }
    }
}
