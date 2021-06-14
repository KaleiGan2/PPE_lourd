using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetGestionMatos
{
    public partial class modif_client : Form
    {
        public modif_client()
        {
            InitializeComponent();
          
        }

        private void modif_client_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        void textbox(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // Set l'evenement comme etant completement fini
                return;
            }
        }

        void chiffre(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiffre(e);
        }
    }
}
