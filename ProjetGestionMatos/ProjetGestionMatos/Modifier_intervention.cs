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
    public partial class Modifier_intervention : Form
    {
        public int id_intervenant;
        public Modifier_intervention()
        {
            InitializeComponent();
            combo_materiel();
            combo_client();
            remplir_checklist();
        }

        private void Modifier_intervention_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox4.Visible = false;
            listView1.Visible = false;

            label6.Text = Programmer_une_intervention.statut_itvn;
            label7.Text = Programmer_une_intervention.client_itvn;
            label8.Text = Programmer_une_intervention.date_itvn;
            label9.Text = Programmer_une_intervention.materiel_itvn;
            label10.Text = "" + Programmer_une_intervention.nom_itn + " " + Programmer_une_intervention.prenom_itn + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            dateTimePicker1.Visible = true;
            comboBox4.Visible = true;
            listView1.Visible = true;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        void combo_materiel()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req = "SELECT Nom FROM Materiel";
            SqlCommand cmd = new SqlCommand(req, con);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                comboBox4.Items.Add(read[0].ToString());
            }
        }

        void combo_client()
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string statut = comboBox1.Text;
            if (statut == "")
            {
                MessageBox.Show("Il faut renseigner un statut pour pouvoir le modifier !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req = "UPDATE Intervention SET Statut ='" + statut + "' WHERE ID_itv =" + Programmer_une_intervention.id_itvn + "";
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le statut de l'intervention a bien été modifié !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string client = comboBox2.Text;
            if (client == "")
            {
                MessageBox.Show("Il faut renseigner un client pour pouvoir le modifier !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req_id = "SELECT ID_client FROM Client WHERE Nom = '" + client + "'";
                SqlCommand cmd_id = new SqlCommand(req_id, con);
                SqlDataReader read = cmd_id.ExecuteReader();

                if (read.Read())
                {
                    int id_client = Convert.ToInt32(read[0].ToString());
                    read.Close();
                    string req = "UPDATE Intervention SET ID_client ='" + id_client + "' WHERE ID_itv =" + Programmer_une_intervention.id_itvn + "";
                    SqlCommand cmd = new SqlCommand(req, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le client de l'intervention a bien été modifié !");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string materiel = comboBox4.Text;
            if (materiel == "")
            {
                MessageBox.Show("Il faut renseigner un client pour pouvoir le modifier !");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req_id = "SELECT ID_mat FROM Materiel WHERE Nom = '" + materiel + "'";
                SqlCommand cmd_id = new SqlCommand(req_id, con);
                SqlDataReader read = cmd_id.ExecuteReader();

                if (read.Read())
                {
                    int id_mat = Convert.ToInt32(read[0].ToString());
                    read.Close();
                    string req = "UPDATE Intervention SET ID_mat ='" + id_mat + "' WHERE ID_itv =" + Programmer_une_intervention.id_itvn + "";
                    SqlCommand cmd = new SqlCommand(req, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le matériel de l'intervention a bien été modifié !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value.ToString();
            DateTime date_time = DateTime.Parse(date);
            DateTime date_du_jour = DateTime.Today.Date;

            if (date_time < date_du_jour)
            {
                MessageBox.Show("Vous ne pouvez pas mettre une date antérieur à celle d'aujourd'hui");
            }
            else if (date_time == date_du_jour)
            {
                DialogResult reponse = MessageBox.Show("Vous avez mis la date du jour, voulez-vous continuer ?", "Changement de date", MessageBoxButtons.YesNo);
                if (reponse == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                    con.Open();

                    string req_date = "UPDATE Intervention SET date_itv ='" + date + "' WHERE ID_itv =" + Programmer_une_intervention.id_itvn + "";
                    SqlCommand cmd_date = new SqlCommand(req_date, con);
                    cmd_date.ExecuteNonQuery();
                    MessageBox.Show("La date à bien été modifié !");
                }
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                string req_date = "UPDATE Intervention SET Date_itv ='" + date + "' WHERE ID_itv =" + Programmer_une_intervention.id_itvn + "";
                SqlCommand cmd_date = new SqlCommand(req_date, con);
                cmd_date.ExecuteNonQuery();
                MessageBox.Show("La date à bien été modifié !");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Programmer_une_intervention f = new Programmer_une_intervention();
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 1)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
                con.Open();

                foreach (ListViewItem li in listView1.CheckedItems)
                {
                    string id_intv = li.SubItems[4].Text;
                    string req_itv = "UPDATE Intervention SET ID_intervenant =" + id_intv + " WHERE ID_itv = " + Programmer_une_intervention.id_itvn + "";
                    SqlCommand cmd_itv = new SqlCommand(req_itv, con);
                    cmd_itv.ExecuteNonQuery();

                    MessageBox.Show("L'intervenant de l'intervention à bien été changé !");
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas choisir plusieurs intervenants");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void remplir_checklist()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=PC-IBRAHIMA\SQLEXPRESS; database=PPE; integrated security=true";
            con.Open();

            string req_list = "SELECT Nom, Prenom, Ville, ID_intervenant FROM Intervenant";
            SqlCommand cmd_list = new SqlCommand(req_list, con);
            SqlDataReader read = cmd_list.ExecuteReader();

            while (read.Read())
            {
                ListViewItem cellule = new ListViewItem(read[0].ToString());
                for (int i = 0; i <= read.FieldCount - 1; i++)
                {
                    cellule.SubItems.Add(read[i].ToString());
                }

                listView1.Items.Add(cellule);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
