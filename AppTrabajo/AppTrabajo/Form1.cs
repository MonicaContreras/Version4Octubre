using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "Su Navegador es: ";
            if (chkExplorer.Checked == true)
            {
                texto = texto + "EXPLORER ";

            }
            if (chkMozilla.Checked == true)
            {
                texto = texto + "MOZILLA FIREFOX ";

            }
            if (chkChrome.Checked == true)
            {
                texto = texto + "CHROME ";
            }
            lbltexto.Text = texto;
        }

        private void lbltexto_Click(object sender, EventArgs e)
        {

        }
    }
}
