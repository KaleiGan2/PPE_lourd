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

            string req1 = "SELECT Nom, Prenom, Ville, CONVERT(varchar, Date_anciennete, 3), Verification, Administrateur FROM Intervenant";
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
    }
}
