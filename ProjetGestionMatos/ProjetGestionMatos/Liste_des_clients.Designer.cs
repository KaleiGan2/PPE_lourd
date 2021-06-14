namespace ProjetGestionMatos
{
    partial class Liste_des_clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VilleTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TelTextBox = new System.Windows.Forms.TextBox();
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code_Postal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Téléphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CPTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VilleTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TelTextBox);
            this.groupBox1.Controls.Add(this.AdresseTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NomTextBox);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations clients";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Code Postal :";
            // 
            // CPTextBox
            // 
            this.CPTextBox.Location = new System.Drawing.Point(148, 152);
            this.CPTextBox.Name = "CPTextBox";
            this.CPTextBox.Size = new System.Drawing.Size(176, 20);
            this.CPTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ville :";
            // 
            // VilleTextBox
            // 
            this.VilleTextBox.Location = new System.Drawing.Point(148, 114);
            this.VilleTextBox.Name = "VilleTextBox";
            this.VilleTextBox.Size = new System.Drawing.Size(176, 20);
            this.VilleTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ajouter le client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone :";
            // 
            // TelTextBox
            // 
            this.TelTextBox.Location = new System.Drawing.Point(148, 193);
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.Size = new System.Drawing.Size(176, 20);
            this.TelTextBox.TabIndex = 4;
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(148, 66);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(176, 20);
            this.AdresseTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse du client :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du client à ajouter :";
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(148, 23);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(176, 20);
            this.NomTextBox.TabIndex = 0;
            this.NomTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Adresse,
            this.Ville,
            this.Code_Postal,
            this.Téléphone,
            this.id_client});
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(499, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 253);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 79;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 116;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 68;
            // 
            // Code_Postal
            // 
            this.Code_Postal.Text = "Code Postal";
            this.Code_Postal.Width = 75;
            // 
            // Téléphone
            // 
            this.Téléphone.Text = "Téléphone";
            this.Téléphone.Width = 131;
            // 
            // id_client
            // 
            this.id_client.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer un client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modifier un client";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(616, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Liste_des_clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Liste_des_clients";
            this.Text = "Liste_des_clients";
            this.Load += new System.EventHandler(this.Liste_des_clients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VilleTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelTextBox;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader Code_Postal;
        private System.Windows.Forms.ColumnHeader Téléphone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader id_client;
    }
}