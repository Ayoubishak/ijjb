
namespace Gestion_Bibliotheque
{
    partial class ChercherClient
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
            this.recherche_client = new System.Windows.Forms.TextBox();
            this.recherche_button = new System.Windows.Forms.Button();
            this.reculer_button = new System.Windows.Forms.Button();
            this.avancer_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.dataGridView_client = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).BeginInit();
            this.SuspendLayout();
            // 
            // recherche_client
            // 
            this.recherche_client.AccessibleDescription = "cherchez un client";
            this.recherche_client.Location = new System.Drawing.Point(111, 60);
            this.recherche_client.Name = "recherche_client";
            this.recherche_client.Size = new System.Drawing.Size(458, 20);
            this.recherche_client.TabIndex = 0;
            // 
            // recherche_button
            // 
            this.recherche_button.Location = new System.Drawing.Point(575, 57);
            this.recherche_button.Name = "recherche_button";
            this.recherche_button.Size = new System.Drawing.Size(43, 23);
            this.recherche_button.TabIndex = 1;
            this.recherche_button.Text = "->";
            this.recherche_button.UseVisualStyleBackColor = true;
            this.recherche_button.Click += new System.EventHandler(this.recherche_button_Click);
            // 
            // reculer_button
            // 
            this.reculer_button.Location = new System.Drawing.Point(12, 12);
            this.reculer_button.Name = "reculer_button";
            this.reculer_button.Size = new System.Drawing.Size(65, 32);
            this.reculer_button.TabIndex = 2;
            this.reculer_button.Text = "<";
            this.reculer_button.UseVisualStyleBackColor = true;
            this.reculer_button.Click += new System.EventHandler(this.reculer_button_Click);
            // 
            // avancer_button
            // 
            this.avancer_button.Location = new System.Drawing.Point(862, 463);
            this.avancer_button.Name = "avancer_button";
            this.avancer_button.Size = new System.Drawing.Size(76, 36);
            this.avancer_button.TabIndex = 3;
            this.avancer_button.Text = ">";
            this.avancer_button.UseVisualStyleBackColor = true;
            this.avancer_button.Click += new System.EventHandler(this.avancer_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(862, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(76, 32);
            this.close_button.TabIndex = 4;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dataGridView_client
            // 
            this.dataGridView_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_client.Location = new System.Drawing.Point(111, 113);
            this.dataGridView_client.Name = "dataGridView_client";
            this.dataGridView_client.Size = new System.Drawing.Size(638, 386);
            this.dataGridView_client.TabIndex = 5;
            // 
            // ChercherClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(968, 528);
            this.Controls.Add(this.dataGridView_client);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.avancer_button);
            this.Controls.Add(this.reculer_button);
            this.Controls.Add(this.recherche_button);
            this.Controls.Add(this.recherche_client);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChercherClient";
            this.Text = "ChercherClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recherche_client;
        private System.Windows.Forms.Button recherche_button;
        private System.Windows.Forms.Button reculer_button;
        private System.Windows.Forms.Button avancer_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.DataGridView dataGridView_client;
    }
}