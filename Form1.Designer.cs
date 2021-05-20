
namespace Gestion_Bibliotheque
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Identifiant = new System.Windows.Forms.TextBox();
            this.MotDePasse = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.Label();
            this.entrez_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entrez_button);
            this.groupBox1.Controls.Add(this.MotDePasse);
            this.groupBox1.Controls.Add(this.mdp);
            this.groupBox1.Controls.Add(this.Identifiant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(393, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentification";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // Identifiant
            // 
            this.Identifiant.Location = new System.Drawing.Point(33, 53);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(300, 20);
            this.Identifiant.TabIndex = 1;
            // 
            // MotDePasse
            // 
            this.MotDePasse.Location = new System.Drawing.Point(33, 116);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(300, 20);
            this.MotDePasse.TabIndex = 2;
            this.MotDePasse.UseSystemPasswordChar = true;
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(30, 86);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(117, 27);
            this.mdp.TabIndex = 2;
            this.mdp.Text = "Mot de passe";
            // 
            // entrez_button
            // 
            this.entrez_button.BackColor = System.Drawing.Color.Yellow;
            this.entrez_button.Location = new System.Drawing.Point(33, 160);
            this.entrez_button.Name = "entrez_button";
            this.entrez_button.Size = new System.Drawing.Size(300, 48);
            this.entrez_button.TabIndex = 3;
            this.entrez_button.Text = "Entrez";
            this.entrez_button.UseVisualStyleBackColor = false;
            this.entrez_button.Click += new System.EventHandler(this.entrez_button_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button entrez_button;
        private System.Windows.Forms.TextBox MotDePasse;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox Identifiant;
        private System.Windows.Forms.Label label1;
    }
}

