
namespace Gestion_Bibliotheque
{
    partial class ChercherLivre
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
            this.Recherche_Livre = new System.Windows.Forms.TextBox();
            this.button_recherche = new System.Windows.Forms.Button();
            this.reculez_button = new System.Windows.Forms.Button();
            this.avancer_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.dataGridView_DetLivre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // Recherche_Livre
            // 
            this.Recherche_Livre.Location = new System.Drawing.Point(113, 48);
            this.Recherche_Livre.Name = "Recherche_Livre";
            this.Recherche_Livre.Size = new System.Drawing.Size(583, 20);
            this.Recherche_Livre.TabIndex = 0;
            this.Recherche_Livre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_recherche
            // 
            this.button_recherche.Location = new System.Drawing.Point(703, 46);
            this.button_recherche.Name = "button_recherche";
            this.button_recherche.Size = new System.Drawing.Size(49, 23);
            this.button_recherche.TabIndex = 1;
            this.button_recherche.Text = "->";
            this.button_recherche.UseVisualStyleBackColor = true;
            this.button_recherche.Click += new System.EventHandler(this.button_recherche_Click);
            // 
            // reculez_button
            // 
            this.reculez_button.Location = new System.Drawing.Point(12, 12);
            this.reculez_button.Name = "reculez_button";
            this.reculez_button.Size = new System.Drawing.Size(75, 32);
            this.reculez_button.TabIndex = 2;
            this.reculez_button.Text = "<";
            this.reculez_button.UseVisualStyleBackColor = true;
            this.reculez_button.Click += new System.EventHandler(this.reculez_button_Click);
            // 
            // avancer_button
            // 
            this.avancer_button.Location = new System.Drawing.Point(900, 476);
            this.avancer_button.Name = "avancer_button";
            this.avancer_button.Size = new System.Drawing.Size(75, 32);
            this.avancer_button.TabIndex = 3;
            this.avancer_button.Text = ">";
            this.avancer_button.UseVisualStyleBackColor = true;
            this.avancer_button.Click += new System.EventHandler(this.avancer_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(900, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 32);
            this.close_button.TabIndex = 4;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dataGridView_DetLivre
            // 
            this.dataGridView_DetLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetLivre.Location = new System.Drawing.Point(100, 124);
            this.dataGridView_DetLivre.Name = "dataGridView_DetLivre";
            this.dataGridView_DetLivre.Size = new System.Drawing.Size(782, 372);
            this.dataGridView_DetLivre.TabIndex = 5;
            // 
            // ChercherLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 532);
            this.Controls.Add(this.dataGridView_DetLivre);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.avancer_button);
            this.Controls.Add(this.reculez_button);
            this.Controls.Add(this.button_recherche);
            this.Controls.Add(this.Recherche_Livre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChercherLivre";
            this.Text = "ChercherLivre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetLivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Recherche_Livre;
        private System.Windows.Forms.Button button_recherche;
        private System.Windows.Forms.Button reculez_button;
        private System.Windows.Forms.Button avancer_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.DataGridView dataGridView_DetLivre;
    }
}