using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20040815
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola mundo!!";
        }
    }
}
