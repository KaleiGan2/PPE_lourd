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
    public partial class Programmer_une_intervention : Form
        
    {
        public static string statut_itvn;
        public static string date_itvn;
        public static string nom_itn;
        public static string materiel_itvn;
        public static string client_itvn;
        public static int id_itvn;
        public static int id_itv;
        public static string prenom_itn;
        public Programmer_une_intervention()
        {
            InitializeComponent();
            remplirMateriel();
            remplirClient();
            remplirlistView();
            listview_color();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        void remplirMateriel()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req = "SELECT Nom FROM Materiel";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader read = cmd.ExecuteReader();

            while(read.Read())
            {
                comboBox1.Items.Add(read[0].ToString());
            }
        }

        void remplirClient()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req = "SELECT Nom FROM Client";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                comboBox2.Items.Add(read[0].ToString());
            }
        }

       
       void remplirlistView()
        {
            listView1.Items.Clear(); 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req1 = "SELECT i.Statut, CONVERT(varchar,i.date_itv, 3) AS Date, m.Nom, c.Nom, i.ID_itv, n.Nom, n.Prenom FROM Intervention i, Materiel m, Client c, Intervenant n WHERE m.ID_mat = i.ID_mat AND i.ID_client = c.ID_client AND n.ID_intervenant = i.ID_intervenant AND i.validation = 0"; // Prend les informations de l'invtervention dans la base de données
            SqlCommand cmd = new SqlCommand(req1, con);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem cellule = new ListViewItem(read[0].ToString());
                for(int i=1; i <=read.FieldCount - 1; i++)
                {
                    cellule.SubItems.Add(read[i].ToString());
                }

                listView1.Items.Add(cellule);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string statut = comboBox3.Text;
            string materiel = comboBox1.Text;
            var client = comboBox2.Text;
            var date = dateTimePicker1.Value.ToString();

            if (statut =="")
            {
                MessageBox.Show("Il faut ajouter un statut !");
            }
            else
            {
                if (materiel =="")
                {
                    MessageBox.Show("Il faut ajouter un matériel !");
                }
                else
                {
                    if (date == "")
                    {
                        MessageBox.Show("Renseignez une date !");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                        con.Open();

                        string req1 = "SELECT id_mat FROM Materiel WHERE Nom = '" + materiel + "'";
                        SqlCommand cmd = new SqlCommand(req1, con);
                        SqlDataReader id_mat = cmd.ExecuteReader();
                        if (id_mat.Read())
                        {
                            int id_materiel;
                            id_materiel = Convert.ToInt32(id_mat[0]);

                            con.Close();
                            con.Open();

                            string req = "SELECT ID_client FROM Client WHERE Nom = '" + client + "'";
                            SqlCommand command = new SqlCommand(req, con);
                            SqlDataReader id_c = command.ExecuteReader();
                            if (id_c.Read())
                            {
                                int id_client;
                                id_client = Convert.ToInt32(id_c[0]);
                                id_c.Close();

                                string req2 = "INSERT INTO Intervention (Statut, date_itv, ID_intervenant, ID_mat, ID_client) VALUES ('" + statut + "','" + date + "','" + Page_de_connexion.id_int + "','" + id_materiel + "','" + id_client + "')";
                                SqlCommand cmd2 = new SqlCommand(req2, con);
                                cmd2.ExecuteNonQuery();

                                MessageBox.Show("L'intervention à bien été ajouté !");
                            }
                        }
                    }
                }
            }
            
        }
                private void button1_Click_1(object sender, EventArgs e) // Supprimer l'intervention
                {
                    
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                    con.Open();
                    if (listView1.CheckedItems.Count == 0)
                    {
                         MessageBox.Show("Vous devez d'abord selectionner une intervention !");
                    }
                    else
                    {
                        DialogResult reponse = MessageBox.Show("Voulez-vous vraiment supprimer les interventions selectionnés ?", "Supprimer l'intervention", MessageBoxButtons.YesNo);
                        foreach (ListViewItem li in listView1.CheckedItems)
                        {
                            if (reponse == DialogResult.Yes)
                            {
                                string id_itv;
                                id_itv = li.SubItems[4].Text;
                                string req = "DELETE FROM Intervention WHERE ID_itv = " + id_itv + "";
                                SqlCommand cmd = new SqlCommand(req, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("L'intervention " + id_itv + " à bien été supprimé");
                                li.Remove();
                            }
                        }
                    }
                }

        void listview_color()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

                foreach (ListViewItem li in listView1.Items)
                {
                        string id = li.SubItems[4].Text;
                        string statut = li.SubItems[0].Text;
                        string req = "SELECT CONVERT(varchar,date_itv, 3) AS Date FROM Intervention WHERE id_itv = " + id + "";
                        SqlCommand reader = new SqlCommand(req, con);
                        SqlDataReader read = reader.ExecuteReader();
                    
                        if (read.Read())
                        {
                            
                            for (int i2 = 0; i2 < listView1.Items.Count; i2++)
                            {
                                if(statut == "Urgente")
                                {
                                    li.SubItems[i2].BackColor = Color.DarkRed;
                                }
                                else
                                {
                                    string date = read[0].ToString();

                                    DateTime madate = DateTime.Parse(date);
                                    DateTime ladate = DateTime.Today.Date;
                                    if (madate < ladate)
                                    {
                                        li.SubItems[i2].BackColor = Color.Red;
                                    }
                                    else if (madate == ladate)
                                    {
                                        li.SubItems[i2].BackColor = Color.Yellow;
                                    }
                                    else if (madate > ladate)
                                    {
                                        li.SubItems[i2].BackColor = Color.LightGreen;
                                    }
                                }
                            }
                        read.Close();
                        }
                }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Programmer_une_intervention_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
 

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_principal();
            menu.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();
            
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord sélectionner une intervention !");
            }
            else if (listView1.CheckedItems.Count == 1)
                {
                    foreach (ListViewItem li in listView1.CheckedItems)
                    {
                    statut_itvn = li.SubItems[0].Text;
                    date_itvn = li.SubItems[1].Text;
                    materiel_itvn = li.SubItems[2].Text;
                    client_itvn = li.SubItems[3].Text;
                    id_itvn = Convert.ToInt32(li.SubItems[4].Text);
                    nom_itn = li.SubItems[5].Text;
                    prenom_itn = li.SubItems[6].Text;

                    Form modifier_intervention = new Modifier_intervention();
                    modifier_intervention.Show();
                    this.Close();
                }
                }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vous devez d'abord sélectionner une intervention !");
            }
            else if (listView1.CheckedItems.Count == 1)
            {
                DialogResult reponse = MessageBox.Show("L'intervention selectionné sera validé, voulez-vous continuer ?", "Valider l'intervention", MessageBoxButtons.YesNo);
                foreach (ListViewItem li in listView1.CheckedItems)
                {
                    if (reponse == DialogResult.Yes)
                    {
                        string id_itv;
                        id_itv = li.SubItems[4].Text;
                        string req = "UPDATE Intervention SET Validation = 1 WHERE ID_itv = " + id_itv + "";
                        SqlCommand cmd = new SqlCommand(req, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("L'intervention " + id_itv + " à bien été validé !");
                        li.Remove();
                    }
                }
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Les interventions selectionnés seront validés, voulez-vous continuer ?", "Valider les interventions", MessageBoxButtons.YesNo);
                foreach (ListViewItem li in listView1.CheckedItems)
                {
                    if (reponse == DialogResult.Yes)
                    {
                        string id_itv;
                        id_itv = li.SubItems[4].Text;
                        string req = "UPDATE Intervention SET Validation = 1 WHERE ID_itv = " + id_itv + "";
                        SqlCommand cmd = new SqlCommand(req, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("L'intervention " + id_itv + " à bien été validé !");
                        li.Remove();
                    }
                }
            }
        }
    }
}
