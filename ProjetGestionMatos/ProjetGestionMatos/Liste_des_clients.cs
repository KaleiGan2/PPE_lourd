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
    public partial class Liste_des_clients : Form
    {
        public static string nom_client;
        public static string adresse_client;
        public static string telephone_client;
        public static string ville_client;
        public static string cp_client;
        public static int id_du_client;
        public Liste_des_clients()
        {
            InitializeComponent();
            remplirlalistview();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Page_de_connexion.admin_int < 1)
            {
                MessageBox.Show("Vous n'avez pas les autorisations pour faire cette action !");
            }
            else
            {
                string nom = NomTextBox.Text;
                string adresse = AdresseTextBox.Text;
                string ville = Ville.Text;
                string CP = CPTextBox.Text;
                string telephone = TelTextBox.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "INSERT INTO Client (Nom, Adresse, Ville, Code_Postal, Telephone) VALUES ('" + nom + "','" + adresse + "','" + ville + "','" + CP + "', '" + telephone + "')";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Le client à bien été ajouté à la liste !");
            }
        }

        void remplirlalistview()
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req1 = "SELECT Nom, Adresse, Ville, Code_Postal, Telephone, ID_client FROM Client"; 
            SqlCommand cmd = new SqlCommand(req1, con);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem cellule = new ListViewItem(read[0].ToString());
                for (int i = 1; i <= read.FieldCount - 1; i++)
                {
                    cellule.SubItems.Add(read[i].ToString());
                }

                listView1.Items.Add(cellule);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Page_de_connexion.admin_int < 1)
            {
                MessageBox.Show("Vous n'avez pas les autorisations pour faire cette action !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();
                if (listView1.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vous devez d'abord selectionner un client !");
                }
                else
                {
                    if (listView1.CheckedItems.Count == 1)
                    {
                        DialogResult reponse1 = MessageBox.Show("Voulez-vous vraiment supprimer le client selectionné ?", "Supprimer le client", MessageBoxButtons.YesNo);
                        foreach (ListViewItem li in listView1.CheckedItems)
                        {
                            if (reponse1 == DialogResult.Yes)
                            {
                                string id_client;
                                string nom_client;
                                nom_client = li.SubItems[0].Text;
                                id_client = li.SubItems[5].Text;
                                string req = "DELETE FROM Client WHERE ID_client = " + id_client + "";
                                SqlCommand cmd = new SqlCommand(req, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Le client " + nom_client + " à bien été supprimé");
                                li.Remove();
                            }
                        }
                    }
                    else
                    {
                        DialogResult reponse = MessageBox.Show("Voulez-vous vraiment supprimer les clients selectionnés ?", "Supprimer le client", MessageBoxButtons.YesNo);
                        foreach (ListViewItem li in listView1.CheckedItems)
                        {
                            if (reponse == DialogResult.Yes)
                            {
                                string id_client;
                                string nom_client;
                                nom_client = li.SubItems[0].Text;
                                id_client = li.SubItems[5].Text;
                                string req = "DELETE FROM Client WHERE ID_client = " + id_client + "";
                                SqlCommand cmd = new SqlCommand(req, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Le client " + nom_client + " à bien été supprimé");
                                li.Remove();
                            }
                        }
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Close();
        }

        private void Liste_des_clients_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord sélectionner un client !");
            }
            else if (listView1.CheckedItems.Count == 1)
            {
                foreach (ListViewItem li in listView1.CheckedItems)
                {
                    nom_client = li.SubItems[0].Text;
                    adresse_client = li.SubItems[1].Text;
                    ville_client = li.SubItems[2].Text;
                    cp_client = li.SubItems[3].Text;
                    telephone_client = li.SubItems[4].Text;
                    id_du_client = Convert.ToInt32(li.SubItems[5].Text);

                    modif_client modif = new modif_client();
                    modif.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas modifier plusieurs clients en même temps !");
            }
        }
    }
}
