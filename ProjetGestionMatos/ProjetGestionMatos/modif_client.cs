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
    public partial class modif_client : Form
    {
        public modif_client()
        {
            InitializeComponent();
          
        }

        private void modif_client_Load(object sender, EventArgs e)
        {
            label_nom.Text = Liste_des_clients.nom_client;
            label_adresse.Text = Liste_des_clients.adresse_client;
            label_tel.Text = Liste_des_clients.telephone_client;
            label_cp.Text = Liste_des_clients.cp_client;
            label_ville.Text = Liste_des_clients.ville_client;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox_cp.Visible = false;

            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        public void verif_int(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
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
            verif_int(e);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_int(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox_cp.Visible = true;

            label_adresse.Visible = false;
            label_cp.Visible = false;
            label_tel.Visible = false;
            label_nom.Visible = false;
            label_ville.Visible = false;

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength == 0)
            {
                MessageBox.Show("Vous devez renter un nom de client !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "UPDATE Client SET Nom ='" + textBox1.Text + "' WHERE ID_client =" + Liste_des_clients.id_du_client + "";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le nom du client a bien été modifié !");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.TextLength == 0)
            {
                MessageBox.Show("Vous devez renter un numéro de téléphone !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "UPDATE Client SET Telephone ='" + textBox4.Text + "' WHERE ID_client =" + Liste_des_clients.id_du_client + "";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le numéro de téléphone du client a bien été modifié !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Vous devez renter l'adresse à modifier !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "UPDATE Client SET Adresse ='" + textBox3.Text + "' WHERE ID_client =" + Liste_des_clients.id_du_client + "";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'adresse du client a bien été modifié !");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0 || textBox_cp.TextLength == 0)
            {
                MessageBox.Show("Vous devez renter une ville à modifier et également son code postal!");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "UPDATE Client SET Ville ='" + textBox2.Text + "' WHERE ID_client =" + Liste_des_clients.id_du_client + "";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();

                string req2 = "UPDATE Client SET Code_Postal ='" + textBox_cp.Text + "' WHERE ID_client =" + Liste_des_clients.id_du_client + "";
                SqlCommand cmd2 = new SqlCommand(req2, con);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("La ville et le code postal du client ont bien été modifiés !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Liste_des_clients liste = new Liste_des_clients();
            liste.Show();
            this.Close();
        }
    }
}
