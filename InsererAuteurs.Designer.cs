
namespace Gestion_Bibliotheque
{
    partial class InsererAuteurs
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
            this.nom_auteur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prenom_auteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nationalite_auteur = new System.Windows.Forms.TextBox();
            this.dateNaissance_auteur = new System.Windows.Forms.DateTimePicker();
            this.button_arret = new System.Windows.Forms.Button();
            this.button_passage = new System.Windows.Forms.Button();
            this.select_auteur = new System.Windows.Forms.Button();
            this.insert_auteur = new System.Windows.Forms.Button();
            this.delete_auteur = new System.Windows.Forms.Button();
            this.num_auteur = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.update_auteur = new System.Windows.Forms.Button();
            this.dataGridView_auteur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.num_auteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_auteur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // nom_auteur
            // 
            this.nom_auteur.Location = new System.Drawing.Point(115, 76);
            this.nom_auteur.Name = "nom_auteur";
            this.nom_auteur.Size = new System.Drawing.Size(251, 20);
            this.nom_auteur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom";
            // 
            // prenom_auteur
            // 
            this.prenom_auteur.Location = new System.Drawing.Point(115, 124);
            this.prenom_auteur.Name = "prenom_auteur";
            this.prenom_auteur.Size = new System.Drawing.Size(251, 20);
            this.prenom_auteur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nationalité";
            // 
            // nationalite_auteur
            // 
            this.nationalite_auteur.Location = new System.Drawing.Point(449, 28);
            this.nationalite_auteur.Name = "nationalite_auteur";
            this.nationalite_auteur.Size = new System.Drawing.Size(251, 20);
            this.nationalite_auteur.TabIndex = 7;
            // 
            // dateNaissance_auteur
            // 
            this.dateNaissance_auteur.CustomFormat = "yyyy-MM-dd";
            this.dateNaissance_auteur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNaissance_auteur.Location = new System.Drawing.Point(449, 76);
            this.dateNaissance_auteur.Name = "dateNaissance_auteur";
            this.dateNaissance_auteur.Size = new System.Drawing.Size(200, 20);
            this.dateNaissance_auteur.TabIndex = 9;
            // 
            // button_arret
            // 
            this.button_arret.Location = new System.Drawing.Point(874, 12);
            this.button_arret.Name = "button_arret";
            this.button_arret.Size = new System.Drawing.Size(75, 46);
            this.button_arret.TabIndex = 11;
            this.button_arret.Text = "X";
            this.button_arret.UseVisualStyleBackColor = true;
            this.button_arret.Click += new System.EventHandler(this.button_arret_Click);
            // 
            // button_passage
            // 
            this.button_passage.Location = new System.Drawing.Point(874, 478);
            this.button_passage.Name = "button_passage";
            this.button_passage.Size = new System.Drawing.Size(75, 48);
            this.button_passage.TabIndex = 12;
            this.button_passage.Text = ">";
            this.button_passage.UseVisualStyleBackColor = true;
            this.button_passage.Click += new System.EventHandler(this.button_passage_Click);
            // 
            // select_auteur
            // 
            this.select_auteur.BackColor = System.Drawing.Color.Yellow;
            this.select_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_auteur.Location = new System.Drawing.Point(747, 202);
            this.select_auteur.Name = "select_auteur";
            this.select_auteur.Size = new System.Drawing.Size(189, 36);
            this.select_auteur.TabIndex = 13;
            this.select_auteur.Text = "SELECT";
            this.select_auteur.UseVisualStyleBackColor = false;
            this.select_auteur.Click += new System.EventHandler(this.ajouter_auteur_Click);
            // 
            // insert_auteur
            // 
            this.insert_auteur.BackColor = System.Drawing.Color.Yellow;
            this.insert_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_auteur.Location = new System.Drawing.Point(747, 244);
            this.insert_auteur.Name = "insert_auteur";
            this.insert_auteur.Size = new System.Drawing.Size(189, 36);
            this.insert_auteur.TabIndex = 14;
            this.insert_auteur.Text = "INSERT";
            this.insert_auteur.UseVisualStyleBackColor = false;
            this.insert_auteur.Click += new System.EventHandler(this.modifier_auteur_Click);
            // 
            // delete_auteur
            // 
            this.delete_auteur.BackColor = System.Drawing.Color.Yellow;
            this.delete_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_auteur.Location = new System.Drawing.Point(747, 286);
            this.delete_auteur.Name = "delete_auteur";
            this.delete_auteur.Size = new System.Drawing.Size(189, 36);
            this.delete_auteur.TabIndex = 15;
            this.delete_auteur.Text = "DELETE";
            this.delete_auteur.UseVisualStyleBackColor = false;
            this.delete_auteur.Click += new System.EventHandler(this.supprimer_auteur_Click);
            // 
            // num_auteur
            // 
            this.num_auteur.Location = new System.Drawing.Point(115, 28);
            this.num_auteur.Name = "num_auteur";
            this.num_auteur.Size = new System.Drawing.Size(65, 20);
            this.num_auteur.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date de Naissance";
            // 
            // update_auteur
            // 
            this.update_auteur.BackColor = System.Drawing.Color.Yellow;
            this.update_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_auteur.Location = new System.Drawing.Point(747, 328);
            this.update_auteur.Name = "update_auteur";
            this.update_auteur.Size = new System.Drawing.Size(189, 36);
            this.update_auteur.TabIndex = 18;
            this.update_auteur.Text = "UPDATE";
            this.update_auteur.UseVisualStyleBackColor = false;
            this.update_auteur.Click += new System.EventHandler(this.update_auteur_Click);
            // 
            // dataGridView_auteur
            // 
            this.dataGridView_auteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_auteur.Location = new System.Drawing.Point(25, 166);
            this.dataGridView_auteur.Name = "dataGridView_auteur";
            this.dataGridView_auteur.Size = new System.Drawing.Size(691, 360);
            this.dataGridView_auteur.TabIndex = 19;
            // 
            // InsererAuteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(961, 538);
            this.Controls.Add(this.dataGridView_auteur);
            this.Controls.Add(this.update_auteur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_auteur);
            this.Controls.Add(this.delete_auteur);
            this.Controls.Add(this.insert_auteur);
            this.Controls.Add(this.select_auteur);
            this.Controls.Add(this.button_passage);
            this.Controls.Add(this.button_arret);
            this.Controls.Add(this.dateNaissance_auteur);
            this.Controls.Add(this.nationalite_auteur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenom_auteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nom_auteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsererAuteurs";
            this.Text = "InsererAuteurs";
            this.Load += new System.EventHandler(this.InsererAuteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_auteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_auteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom_auteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenom_auteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nationalite_auteur;
        private System.Windows.Forms.DateTimePicker dateNaissance_auteur;
        private System.Windows.Forms.Button button_arret;
        private System.Windows.Forms.Button button_passage;
        private System.Windows.Forms.Button select_auteur;
        private System.Windows.Forms.Button insert_auteur;
        private System.Windows.Forms.Button delete_auteur;
        private System.Windows.Forms.NumericUpDown num_auteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_auteur;
        private System.Windows.Forms.DataGridView dataGridView_auteur;
    }
}