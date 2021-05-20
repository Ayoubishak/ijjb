
namespace Gestion_Bibliotheque
{
    partial class InsererClient
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
            this.numero_client = new System.Windows.Forms.NumericUpDown();
            this.Prénom = new System.Windows.Forms.Label();
            this.nom_client = new System.Windows.Forms.TextBox();
            this.prenom_client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CIN_client = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateNaissance_client = new System.Windows.Forms.DateTimePicker();
            this.button_avancer = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_reculer = new System.Windows.Forms.Button();
            this.update_client = new System.Windows.Forms.Button();
            this.delete_client = new System.Windows.Forms.Button();
            this.insert_client = new System.Windows.Forms.Button();
            this.select_client = new System.Windows.Forms.Button();
            this.dataGridView_client = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numero_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // numero_client
            // 
            this.numero_client.Location = new System.Drawing.Point(79, 28);
            this.numero_client.Name = "numero_client";
            this.numero_client.Size = new System.Drawing.Size(87, 20);
            this.numero_client.TabIndex = 2;
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(76, 98);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(49, 13);
            this.Prénom.TabIndex = 4;
            this.Prénom.Text = "Prénom";
            // 
            // nom_client
            // 
            this.nom_client.Location = new System.Drawing.Point(79, 67);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(268, 20);
            this.nom_client.TabIndex = 5;
            // 
            // prenom_client
            // 
            this.prenom_client.Location = new System.Drawing.Point(79, 114);
            this.prenom_client.Name = "prenom_client";
            this.prenom_client.Size = new System.Drawing.Size(268, 20);
            this.prenom_client.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CIN";
            // 
            // CIN_client
            // 
            this.CIN_client.Location = new System.Drawing.Point(420, 28);
            this.CIN_client.Name = "CIN_client";
            this.CIN_client.Size = new System.Drawing.Size(196, 20);
            this.CIN_client.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date de Naissance";
            // 
            // DateNaissance_client
            // 
            this.DateNaissance_client.CustomFormat = "yyyy-MM-dd";
            this.DateNaissance_client.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNaissance_client.Location = new System.Drawing.Point(416, 67);
            this.DateNaissance_client.Name = "DateNaissance_client";
            this.DateNaissance_client.Size = new System.Drawing.Size(200, 20);
            this.DateNaissance_client.TabIndex = 10;
            // 
            // button_avancer
            // 
            this.button_avancer.Location = new System.Drawing.Point(906, 539);
            this.button_avancer.Name = "button_avancer";
            this.button_avancer.Size = new System.Drawing.Size(75, 34);
            this.button_avancer.TabIndex = 11;
            this.button_avancer.Text = ">";
            this.button_avancer.UseVisualStyleBackColor = true;
            this.button_avancer.Click += new System.EventHandler(this.button_avancer_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(906, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 41);
            this.button_close.TabIndex = 12;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_reculer
            // 
            this.button_reculer.Location = new System.Drawing.Point(12, 539);
            this.button_reculer.Name = "button_reculer";
            this.button_reculer.Size = new System.Drawing.Size(75, 34);
            this.button_reculer.TabIndex = 13;
            this.button_reculer.Text = "<";
            this.button_reculer.UseVisualStyleBackColor = true;
            this.button_reculer.Click += new System.EventHandler(this.button_reculer_Click);
            // 
            // update_client
            // 
            this.update_client.BackColor = System.Drawing.Color.Yellow;
            this.update_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_client.Location = new System.Drawing.Point(789, 382);
            this.update_client.Name = "update_client";
            this.update_client.Size = new System.Drawing.Size(157, 55);
            this.update_client.TabIndex = 26;
            this.update_client.Text = "UPDATE";
            this.update_client.UseVisualStyleBackColor = false;
            this.update_client.Click += new System.EventHandler(this.update_client_Click);
            // 
            // delete_client
            // 
            this.delete_client.BackColor = System.Drawing.Color.Yellow;
            this.delete_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_client.Location = new System.Drawing.Point(789, 321);
            this.delete_client.Name = "delete_client";
            this.delete_client.Size = new System.Drawing.Size(157, 55);
            this.delete_client.TabIndex = 25;
            this.delete_client.Text = "DELETE";
            this.delete_client.UseVisualStyleBackColor = false;
            this.delete_client.Click += new System.EventHandler(this.delete_client_Click);
            // 
            // insert_client
            // 
            this.insert_client.BackColor = System.Drawing.Color.Yellow;
            this.insert_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_client.Location = new System.Drawing.Point(789, 252);
            this.insert_client.Name = "insert_client";
            this.insert_client.Size = new System.Drawing.Size(157, 63);
            this.insert_client.TabIndex = 24;
            this.insert_client.Text = "INSERT";
            this.insert_client.UseVisualStyleBackColor = false;
            this.insert_client.Click += new System.EventHandler(this.insert_client_Click);
            // 
            // select_client
            // 
            this.select_client.BackColor = System.Drawing.Color.Yellow;
            this.select_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_client.Location = new System.Drawing.Point(789, 188);
            this.select_client.Name = "select_client";
            this.select_client.Size = new System.Drawing.Size(157, 58);
            this.select_client.TabIndex = 23;
            this.select_client.Text = "SELECT";
            this.select_client.UseVisualStyleBackColor = false;
            this.select_client.Click += new System.EventHandler(this.select_client_Click);
            // 
            // dataGridView_client
            // 
            this.dataGridView_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_client.Location = new System.Drawing.Point(143, 156);
            this.dataGridView_client.Name = "dataGridView_client";
            this.dataGridView_client.Size = new System.Drawing.Size(562, 379);
            this.dataGridView_client.TabIndex = 27;
            // 
            // InsererClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(993, 585);
            this.Controls.Add(this.dataGridView_client);
            this.Controls.Add(this.update_client);
            this.Controls.Add(this.delete_client);
            this.Controls.Add(this.insert_client);
            this.Controls.Add(this.select_client);
            this.Controls.Add(this.button_reculer);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_avancer);
            this.Controls.Add(this.DateNaissance_client);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CIN_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenom_client);
            this.Controls.Add(this.nom_client);
            this.Controls.Add(this.Prénom);
            this.Controls.Add(this.numero_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsererClient";
            this.Text = "InsererClient";
            ((System.ComponentModel.ISupportInitialize)(this.numero_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numero_client;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.TextBox nom_client;
        private System.Windows.Forms.TextBox prenom_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CIN_client;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateNaissance_client;
        private System.Windows.Forms.Button button_avancer;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_reculer;
        private System.Windows.Forms.Button update_client;
        private System.Windows.Forms.Button delete_client;
        private System.Windows.Forms.Button insert_client;
        private System.Windows.Forms.Button select_client;
        private System.Windows.Forms.DataGridView dataGridView_client;
    }
}