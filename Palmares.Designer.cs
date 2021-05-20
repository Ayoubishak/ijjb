
namespace Gestion_Bibliotheque
{
    partial class Palmares
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
            this.LivreEmprunté_button = new System.Windows.Forms.Button();
            this.NombreDomaine_button = new System.Windows.Forms.Button();
            this.ClientLivreEmprunt_button = new System.Windows.Forms.Button();
            this.dataGridView_Palmares = new System.Windows.Forms.DataGridView();
            this.reculez_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Palmares)).BeginInit();
            this.SuspendLayout();
            // 
            // LivreEmprunté_button
            // 
            this.LivreEmprunté_button.Location = new System.Drawing.Point(25, 61);
            this.LivreEmprunté_button.Name = "LivreEmprunté_button";
            this.LivreEmprunté_button.Size = new System.Drawing.Size(211, 78);
            this.LivreEmprunté_button.TabIndex = 0;
            this.LivreEmprunté_button.Text = "Livre le plus emprunté";
            this.LivreEmprunté_button.UseVisualStyleBackColor = true;
            this.LivreEmprunté_button.Click += new System.EventHandler(this.LivreEmprunté_button_Click);
            // 
            // NombreDomaine_button
            // 
            this.NombreDomaine_button.Location = new System.Drawing.Point(25, 160);
            this.NombreDomaine_button.Name = "NombreDomaine_button";
            this.NombreDomaine_button.Size = new System.Drawing.Size(211, 78);
            this.NombreDomaine_button.TabIndex = 1;
            this.NombreDomaine_button.Text = "Nombre des domaines";
            this.NombreDomaine_button.UseVisualStyleBackColor = true;
            this.NombreDomaine_button.Click += new System.EventHandler(this.NombreDomaine_button_Click);
            // 
            // ClientLivreEmprunt_button
            // 
            this.ClientLivreEmprunt_button.Location = new System.Drawing.Point(25, 257);
            this.ClientLivreEmprunt_button.Name = "ClientLivreEmprunt_button";
            this.ClientLivreEmprunt_button.Size = new System.Drawing.Size(211, 68);
            this.ClientLivreEmprunt_button.TabIndex = 2;
            this.ClientLivreEmprunt_button.Text = "Clients et ses emprunts";
            this.ClientLivreEmprunt_button.UseVisualStyleBackColor = true;
            this.ClientLivreEmprunt_button.Click += new System.EventHandler(this.ClientLivreEmprunt_button_Click);
            // 
            // dataGridView_Palmares
            // 
            this.dataGridView_Palmares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Palmares.Location = new System.Drawing.Point(318, 61);
            this.dataGridView_Palmares.Name = "dataGridView_Palmares";
            this.dataGridView_Palmares.Size = new System.Drawing.Size(456, 264);
            this.dataGridView_Palmares.TabIndex = 3;
            // 
            // reculez_button
            // 
            this.reculez_button.Location = new System.Drawing.Point(12, 481);
            this.reculez_button.Name = "reculez_button";
            this.reculez_button.Size = new System.Drawing.Size(75, 35);
            this.reculez_button.TabIndex = 5;
            this.reculez_button.Text = "<";
            this.reculez_button.UseVisualStyleBackColor = true;
            this.reculez_button.Click += new System.EventHandler(this.reculez_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(813, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 33);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Palmares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.reculez_button);
            this.Controls.Add(this.dataGridView_Palmares);
            this.Controls.Add(this.ClientLivreEmprunt_button);
            this.Controls.Add(this.NombreDomaine_button);
            this.Controls.Add(this.LivreEmprunté_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Palmares";
            this.Text = "Palmares";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Palmares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LivreEmprunté_button;
        private System.Windows.Forms.Button NombreDomaine_button;
        private System.Windows.Forms.Button ClientLivreEmprunt_button;
        private System.Windows.Forms.DataGridView dataGridView_Palmares;
        private System.Windows.Forms.Button reculez_button;
        private System.Windows.Forms.Button close_button;
    }
}