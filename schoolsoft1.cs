using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_program2
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void cr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("school soft 2019: Andres, Daniel, Mauricio");

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
