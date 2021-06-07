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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Programmer_une_intervention form = new Programmer_une_intervention();
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page_de_connexion f = new Page_de_connexion();
            this.Close(); // deconnexion du programme
            f.Show();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
           // Page_de_connexion f = new Page_de_connexion();
            label2.Text = Page_de_connexion.nom_int;
            label5.Text = Page_de_connexion.prenom_int;

            if (Page_de_connexion.admin_int == 0)
            {
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajout_matériel f = new Ajout_matériel();
            f.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();
            
            Liste_des_clients f = new Liste_des_clients();
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Liste_intervenants f = new Liste_intervenants();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
