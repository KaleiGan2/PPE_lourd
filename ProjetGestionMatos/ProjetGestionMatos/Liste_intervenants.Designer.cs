namespace ProjetGestionMatos
{
    partial class Liste_intervenants
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_anciennete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vérifié = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_intervenant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Ville,
            this.Date_anciennete,
            this.Vérifié,
            this.Admin,
            this.ID_intervenant});
            this.listView1.HideSelection = false;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.Location = new System.Drawing.Point(107, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 85;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 81;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 95;
            // 
            // Date_anciennete
            // 
            this.Date_anciennete.Text = "Date_anciennete";
            this.Date_anciennete.Width = 140;
            // 
            // Vérifié
            // 
            this.Vérifié.Text = "Vérifié";
            // 
            // Admin
            // 
            this.Admin.Text = "Administrateur";
            this.Admin.Width = 83;
            // 
            // ID_intervenant
            // 
            this.ID_intervenant.Text = "ID_intervenant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des intervenants";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voir les informations de l\'intervenant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Supprimer l\'intervenant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(303, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Accepter l\'inscription";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(506, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Donner le statut administrateur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(554, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Quitter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 406);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "Donner le statut intervenant";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Liste_intervenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Liste_intervenants";
            this.Text = "Liste_intervenants";
            this.Load += new System.EventHandler(this.Liste_intervenants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader Date_anciennete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Vérifié;
        private System.Windows.Forms.ColumnHeader Admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader ID_intervenant;
    }
}