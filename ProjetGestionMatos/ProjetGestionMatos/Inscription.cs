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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string Login = textBox1.Text;
            string MDP = textBox2.Text;
            string Confirm_MDP = textBox3.Text;
            string Nom = textBox4.Text;
            string Prenom = textBox5.Text;
            string Adresse = textBox6.Text;
            string Ville = textBox7.Text;
            DateTime date = DateTime.Today;

            if (MDP != Confirm_MDP)
            {
                erreur.Text = "Les mots de passes ne correspondent pas !";
                erreur.Visible = true;
            }
            else
            {
                string req = "SELECT COUNT(*) FROM Intervenant WHERE LOGIN = '" + Login + "';";
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();

                if ((int) read[0] == 1)
                {
                    erreur.Text = "Ce login est déjà utilisé par un autre intervenant !";
                    erreur.Visible = true;
                }
                else
                {
                    read.Close();
                    string req2 = "INSERT INTO Intervenant (Nom, Prenom, Adresse, Ville, Date_anciennete, LOGIN, Password) VALUES ('" + Nom + "','" + Prenom + "','" + Adresse + "','" + Ville + "','" + date + "','" + Login + "','" + MDP + "')";
                    SqlCommand cmd2 = new SqlCommand(req2, con);
                    cmd2.ExecuteNonQuery();

                    erreur.Text = "Votre demande d'inscription à bien été effectué !";
                    erreur.Visible = true;
                    MessageBox.Show("Votre inscription à bien été transmise, vous devez maintenant attendre sa validation par un administrateur !");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Page_de_connexion page = new Page_de_connexion();
            page.Show();
        }
    }
}
