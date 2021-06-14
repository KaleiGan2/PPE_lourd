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
    public partial class Liste_intervenants : Form
    {
        public static int id_itvn;
        public Liste_intervenants()
        {
            InitializeComponent();
            Liste_view_intervenant();
        }

        private void Liste_intervenants_Load(object sender, EventArgs e)
        {

        }
        void Liste_view_intervenant()
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req1 = "SELECT Nom, Prenom, Ville, CONVERT(varchar, Date_anciennete, 3), Verification, Administrateur, ID_intervenant FROM Intervenant";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_principal m = new Menu_principal();
            m.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord selectionner un intervenant !");
            }
            else
            {
                if (listView1.CheckedItems.Count == 1)
                {
                    DialogResult reponse1 = MessageBox.Show("Voulez-vous vraiment supprimer l'intervenant selectionné ? Cette action est irréversible", "Supprimer l'intervenant", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        if (reponse1 == DialogResult.Yes)
                        {
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;
                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (id_intervenant == Page_de_connexion.id_int)
                            {
                                MessageBox.Show("Vous ne pouvez pas vous supprimez vous-même !");
                            }
                            else
                            {
                                string req2 = "SELECT COUNT(*) FROM Intervention WHERE ID_intervenant = " + id_intervenant + "";
                                SqlCommand cmd2 = new SqlCommand(req2, con);
                                SqlDataReader read2 = cmd2.ExecuteReader();
                                read2.Read();
                                if ((int)read2[0] != 0)
                                {
                                    MessageBox.Show("Cet intervenant à une intervention programmé, supprimez-la avant de supprimer l'intervenant !");
                                }
                                else
                                {
                                    read2.Close();
                                    string req = "DELETE FROM Intervenant WHERE ID_intervenant = " + id_intervenant + "";
                                    SqlCommand cmd = new SqlCommand(req, con);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " à bien été supprimé !");
                                    li.Remove();
                                }
                            }
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
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;
                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (id_intervenant == Page_de_connexion.id_int)
                            {
                                MessageBox.Show("Vous ne pouvez pas vous supprimez vous-même !");
                            }
                            else
                            {
                                string req2 = "SELECT COUNT(*) FROM Intervention WHERE ID_intervenant = " + id_intervenant + "";
                                SqlCommand cmd2 = new SqlCommand(req2, con);
                                SqlDataReader read2 = cmd2.ExecuteReader();
                                read2.Read();
                                if ((int)read2[0] != 0)
                                {
                                    read2.Close();
                                    MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " a une intervention programmé, supprimez-la avant de supprimer l'intervenant !");
                                }
                                else
                                {
                                    read2.Close();
                                    string req = "DELETE FROM Intervenant WHERE ID_intervenant = " + id_intervenant + "";
                                    SqlCommand cmd = new SqlCommand(req, con);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " à bien été supprimé !");
                                    li.Remove();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord selectionner un intervenant !");
            }
            else
            {
                if (listView1.CheckedItems.Count == 1)
                {
                    DialogResult reponse1 = MessageBox.Show("Voulez-vous inscrire définitivement cet intervenant ?", "Accepter l'intervenant", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        if (reponse1 == DialogResult.Yes)
                        {
                            int verif_intervenant;
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;

                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            verif_intervenant = Convert.ToInt32(li.SubItems[4].Text);
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (verif_intervenant == 1)
                            {
                                MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " est déjà vérifié !");
                            }
                            else
                            {
                                string req2 = "UPDATE Intervenant SET Verification = 1 WHERE ID_intervenant = " + id_intervenant + "";
                                SqlCommand cmd2 = new SqlCommand(req2, con);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " est désormais vérifié ! Il peut se connecter a l'application");
                            }
                        }
                    }
                }
                else
                {
                    DialogResult reponse = MessageBox.Show("Voulez-vous inscrire définitivement les intervenants sélectionnées ?", "Accepter les nouveaux intervenants", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        {
                            int verif_intervenant;
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;

                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            verif_intervenant = Convert.ToInt32(li.SubItems[4].Text);
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (verif_intervenant == 1)
                            {
                                MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " est déjà vérifié !");
                            }
                            else
                            {
                                string req2 = "UPDATE Intervenant SET Verification = 1 WHERE ID_intervenant = " + id_intervenant + "";
                                SqlCommand cmd2 = new SqlCommand(req2, con);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " est désormais vérifié ! Il peut se connecter a l'application");
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord selectionner un intervenant !");
            }
            else
            {
                if (listView1.CheckedItems.Count == 1)
                {
                    DialogResult reponse1 = MessageBox.Show("Vous allez faire passer cet intervenant en administrateur, voulez-vous continuer ?", "Donner le statut administrateur", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        if (reponse1 == DialogResult.Yes)
                        {
                            int admin_intervenant;
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;

                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            admin_intervenant = Convert.ToInt32(li.SubItems[5].Text);
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (Page_de_connexion.admin_int != 2)
                            {
                                MessageBox.Show("Vous n'avez pas les autorisations pour faire cette action !");
                            }
                            else
                            {
                                if(admin_intervenant == 1)
                                {
                                    MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " est déjà administrateur de l'application !");
                                }
                                else
                                {
                                    string req2 = "UPDATE Intervenant SET Administrateur = 1 WHERE ID_intervenant = " + id_intervenant + "";
                                    SqlCommand cmd2 = new SqlCommand(req2, con);
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " est désormais administrateur !");
                                }
                            }
                        }
                    }
                }
                else
                {
                    DialogResult reponse = MessageBox.Show("Vous allez faire passer ces intervenant en administrateur, voulez - vous continuer ? ", "Donner le statut administrateur", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        if (reponse == DialogResult.Yes)
                        {
                            int admin_intervenant;
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;

                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            admin_intervenant = Convert.ToInt32(li.SubItems[5].Text);
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (Page_de_connexion.admin_int != 2)
                            {
                                MessageBox.Show("Vous n'avez pas les autorisations pour faire cette action !");
                            }
                            else
                            {
                                if (admin_intervenant == 1)
                                {
                                    MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " est déjà administrateur de l'application !");
                                }
                                else
                                {
                                    string req2 = "UPDATE Intervenant SET Administrateur = 1 WHERE ID_intervenant = " + id_intervenant + "";
                                    SqlCommand cmd2 = new SqlCommand(req2, con);
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " est désormais administrateur !");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord selectionner un intervenant !");
            }
            else
            {
                if (listView1.CheckedItems.Count == 1)
                {
                    DialogResult reponse1 = MessageBox.Show("Vous allez faire passer cet intervenant en statut 'intervenant', voulez-vous continuer ?", "Donner le statut intervenant", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        if (reponse1 == DialogResult.Yes)
                        {
                            int admin_intervenant;
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;

                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            admin_intervenant = Convert.ToInt32(li.SubItems[5].Text);
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (id_intervenant == Page_de_connexion.id_int)
                            {
                                MessageBox.Show("Vous ne pouvez pas modifier votre rôle vous-même !");
                            }
                            else
                            {
                                if (Page_de_connexion.admin_int == 0)
                                {
                                    MessageBox.Show("Vous n'avez pas les autorisations pour faire cette action !");
                                }
                                else
                                {
                                    if (Page_de_connexion.admin_int <= admin_intervenant)
                                    {
                                        MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " à un role supérieur ou égale au vôtre !");
                                    }
                                    else
                                    {
                                        string req2 = "UPDATE Intervenant SET Administrateur = 0 WHERE ID_intervenant = " + id_intervenant + "";
                                        SqlCommand cmd2 = new SqlCommand(req2, con);
                                        cmd2.ExecuteNonQuery();
                                        MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " est désormais simple intervenant !");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    DialogResult reponse = MessageBox.Show("Vous allez faire passer ces intervenants en 'intervenant', voulez - vous continuer ? ", "Donner le statut intervenant", MessageBoxButtons.YesNo);
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                        if (reponse == DialogResult.Yes)
                        {
                            int admin_intervenant;
                            int id_intervenant;
                            string nom_intervenant;
                            string prenom_intervenant;

                            nom_intervenant = li.SubItems[0].Text;
                            prenom_intervenant = li.SubItems[1].Text;
                            admin_intervenant = Convert.ToInt32(li.SubItems[5].Text);
                            id_intervenant = Convert.ToInt32(li.SubItems[6].Text);
                            if (id_intervenant == Page_de_connexion.id_int)
                            {
                                MessageBox.Show("Vous ne pouvez pas modfiier votre rôle vous-même !");
                            }
                            else
                            {
                                if (Page_de_connexion.admin_int == 0)
                                {
                                    MessageBox.Show("Vous n'avez pas les autorisations pour faire cette action !");
                                }
                                else
                                {
                                    if (Page_de_connexion.admin_int <= admin_intervenant)
                                    {
                                        MessageBox.Show("" + nom_intervenant + " " + prenom_intervenant + " à un role supérieur ou égale au vôtre !");
                                    }
                                    else
                                    {
                                        string req2 = "UPDATE Intervenant SET Administrateur = 0 WHERE ID_intervenant = " + id_intervenant + "";
                                        SqlCommand cmd2 = new SqlCommand(req2, con);
                                        cmd2.ExecuteNonQuery();
                                        MessageBox.Show("L'intervenant " + nom_intervenant + " " + prenom_intervenant + " est désormais simple intervenant !");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
