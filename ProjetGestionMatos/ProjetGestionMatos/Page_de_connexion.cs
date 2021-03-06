using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------
using System.Data.SqlClient;

namespace ProjetGestionMatos
{
    public partial class Page_de_connexion : Form
    {
        public static string nom_int;
        public static string prenom_int;
        public static int admin_int;
        public static int id_int;
        public static string nom_statut;
        public Page_de_connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection();
           con.ConnectionString=@"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
           con.Open();

            string strLogin = Login.Text;
            string strMDP = MDP.Text;

            string req = "SELECT count(*) from Intervenant WHERE LOGIN = '" + strLogin + "' AND Password = '" + strMDP + "'";

            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();

            if((int) read[0]!= 0 )
            {
                read.Close();
                string req2 = "SELECT Verification FROM Intervenant WHERE LOGIN = '" + strLogin + "' AND Password = '" + strMDP + "'";
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader read2 = cmd2.ExecuteReader();

                if (read2.Read())
                {
                    int verification;
                    verification = Convert.ToInt32(read2[0]);
                    if (verification == 0)
                    {
                        label5.Visible = true;
                    }
                    else
                    {
                        read2.Close();
                        string req3 = "SELECT i.Nom, i.Prenom, i.Administrateur, i.ID_intervenant, s.Nom_statut FROM Intervenant i, Statut s WHERE i.Administrateur = s.ID_stats AND LOGIN = '" + strLogin + "' AND Password = '" + strMDP + "'";
                        SqlCommand cmd3 = new SqlCommand(req3, con);
                        SqlDataReader read3 = cmd3.ExecuteReader();
                        if (read3.Read())
                        {
                            nom_int = read3[0].ToString();
                            prenom_int = read3[1].ToString();
                            admin_int = Convert.ToInt32(read3[2]);
                            id_int = Convert.ToInt32(read3[3]);
                            nom_statut = read3[4].ToString();
                            // MessageBox.Show("Nom : " + nom_int + " :");
                            this.Hide();
                            Menu_principal menu;
                            menu = new Menu_principal();
                            menu.Show();
                        }
                    }
                }
            }
            else
            {
                label4.Visible = true;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MDP.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            Inscription form = new Inscription();
            form.Show();
            this.Hide();
        }
    }
}
