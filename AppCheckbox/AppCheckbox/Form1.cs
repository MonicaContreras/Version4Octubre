using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string texto = " ";
            if (chkingles.Checked == true)
            {
                texto = texto + "INGLÉS ";

            }
            if (chkfrances.Checked == true)
            {
                texto = texto + "FRANCÉS ";

            }
            if (chkAleman.Checked == true)
            {
                texto = texto + "ALEMÁN ";
            }
            Text = texto;

        }
        private void chkAleman_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
