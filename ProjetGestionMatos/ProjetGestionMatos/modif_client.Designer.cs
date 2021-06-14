
namespace ProjetGestionMatos
{
    partial class modif_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_ville = new System.Windows.Forms.Label();
            this.label_cp = new System.Windows.Forms.Label();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code Postal :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(129, 55);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(64, 13);
            this.label_nom.TabIndex = 5;
            this.label_nom.Text = "label_nom";
            this.label_nom.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse.Location = new System.Drawing.Point(129, 108);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(85, 13);
            this.label_adresse.TabIndex = 6;
            this.label_adresse.Text = "label_adresse";
            this.label_adresse.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tel.Location = new System.Drawing.Point(408, 55);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(55, 13);
            this.label_tel.TabIndex = 7;
            this.label_tel.Text = "label_tel";
            this.label_tel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label_ville
            // 
            this.label_ville.AutoSize = true;
            this.label_ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ville.Location = new System.Drawing.Point(408, 108);
            this.label_ville.Name = "label_ville";
            this.label_ville.Size = new System.Drawing.Size(64, 13);
            this.label_ville.TabIndex = 8;
            this.label_ville.Text = "label_ville";
            // 
            // label_cp
            // 
            this.label_cp.AutoSize = true;
            this.label_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cp.Location = new System.Drawing.Point(446, 130);
            this.label_cp.Name = "label_cp";
            this.label_cp.Size = new System.Drawing.Size(55, 13);
            this.label_cp.TabIndex = 9;
            this.label_cp.Text = "label_cp";
            this.label_cp.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(446, 130);
            this.textBox_cp.MaxLength = 5;
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.Size = new System.Drawing.Size(100, 20);
            this.textBox_cp.TabIndex = 10;
            this.textBox_cp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(408, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // modif_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 232);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_cp);
            this.Controls.Add(this.label_cp);
            this.Controls.Add(this.label_ville);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modif_client";
            this.Text = "modif_client";
            this.Load += new System.EventHandler(this.modif_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_ville;
        private System.Windows.Forms.Label label_cp;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.TextBox textBox2;
    }
}