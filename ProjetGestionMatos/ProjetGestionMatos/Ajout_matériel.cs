using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetGestionMatos
{
    public partial class Ajout_matériel : Form
    {
        public Ajout_matériel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string materiel = textBox1.Text;

            if (materiel =="")
            {
                MessageBox.Show("Remplissez la zone de texte pour ajouter un matériel !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "INSERT INTO Materiel (Nom) VALUES('" + materiel + "')";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Le matériel à bien été ajouté à la liste !");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textMateriel = textBox1.Text;

            if (textMateriel =="")
            {
                label2.Visible = true;
            }
            else
            {
                label2.Text = textMateriel;
                label2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_principal();
            menu.Show();
            this.Close();
        }
    }
}
