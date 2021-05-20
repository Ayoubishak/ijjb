
namespace Gestion_Bibliotheque
{
    partial class InsererEmprunt
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
            this.numero_RefLivreEmprunt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numero_RefClient = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.date_Emprunt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Retour = new System.Windows.Forms.DateTimePicker();
            this.button_retour = new System.Windows.Forms.Button();
            this.button_avancer = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.update_emprunt = new System.Windows.Forms.Button();
            this.delete_emprunt = new System.Windows.Forms.Button();
            this.insert_emprunt = new System.Windows.Forms.Button();
            this.select_emprunt = new System.Windows.Forms.Button();
            this.dataGridView_emprunt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefLivreEmprunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emprunt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Livre";
            // 
            // numero_RefLivreEmprunt
            // 
            this.numero_RefLivreEmprunt.Location = new System.Drawing.Point(91, 28);
            this.numero_RefLivreEmprunt.Name = "numero_RefLivreEmprunt";
            this.numero_RefLivreEmprunt.Size = new System.Drawing.Size(120, 20);
            this.numero_RefLivreEmprunt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Client";
            // 
            // numero_RefClient
            // 
            this.numero_RefClient.Location = new System.Drawing.Point(91, 67);
            this.numero_RefClient.Name = "numero_RefClient";
            this.numero_RefClient.Size = new System.Drawing.Size(120, 20);
            this.numero_RefClient.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Emprunt";
            // 
            // date_Emprunt
            // 
            this.date_Emprunt.CustomFormat = "yyyy-MM-dd";
            this.date_Emprunt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Emprunt.Location = new System.Drawing.Point(272, 28);
            this.date_Emprunt.Name = "date_Emprunt";
            this.date_Emprunt.Size = new System.Drawing.Size(200, 20);
            this.date_Emprunt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Retour";
            // 
            // date_Retour
            // 
            this.date_Retour.CustomFormat = "yyyy-MM-dd";
            this.date_Retour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Retour.Location = new System.Drawing.Point(272, 67);
            this.date_Retour.Name = "date_Retour";
            this.date_Retour.Size = new System.Drawing.Size(200, 20);
            this.date_Retour.TabIndex = 7;
            // 
            // button_retour
            // 
            this.button_retour.Location = new System.Drawing.Point(12, 506);
            this.button_retour.Name = "button_retour";
            this.button_retour.Size = new System.Drawing.Size(75, 37);
            this.button_retour.TabIndex = 11;
            this.button_retour.Text = "<";
            this.button_retour.UseVisualStyleBackColor = true;
            this.button_retour.Click += new System.EventHandler(this.button_retour_Click);
            // 
            // button_avancer
            // 
            this.button_avancer.Location = new System.Drawing.Point(904, 506);
            this.button_avancer.Name = "button_avancer";
            this.button_avancer.Size = new System.Drawing.Size(75, 41);
            this.button_avancer.TabIndex = 12;
            this.button_avancer.Text = ">";
            this.button_avancer.UseVisualStyleBackColor = true;
            this.button_avancer.Click += new System.EventHandler(this.button_avancer_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(904, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 42);
            this.button_close.TabIndex = 13;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // update_emprunt
            // 
            this.update_emprunt.BackColor = System.Drawing.Color.Yellow;
            this.update_emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_emprunt.Location = new System.Drawing.Point(786, 345);
            this.update_emprunt.Name = "update_emprunt";
            this.update_emprunt.Size = new System.Drawing.Size(170, 55);
            this.update_emprunt.TabIndex = 20;
            this.update_emprunt.Text = "UPDATE";
            this.update_emprunt.UseVisualStyleBackColor = false;
            this.update_emprunt.Click += new System.EventHandler(this.update_emprunt_Click);
            // 
            // delete_emprunt
            // 
            this.delete_emprunt.BackColor = System.Drawing.Color.Yellow;
            this.delete_emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_emprunt.Location = new System.Drawing.Point(786, 284);
            this.delete_emprunt.Name = "delete_emprunt";
            this.delete_emprunt.Size = new System.Drawing.Size(170, 55);
            this.delete_emprunt.TabIndex = 19;
            this.delete_emprunt.Text = "DELETE";
            this.delete_emprunt.UseVisualStyleBackColor = false;
            this.delete_emprunt.Click += new System.EventHandler(this.delete_emprunt_Click);
            // 
            // insert_emprunt
            // 
            this.insert_emprunt.BackColor = System.Drawing.Color.Yellow;
            this.insert_emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_emprunt.Location = new System.Drawing.Point(786, 215);
            this.insert_emprunt.Name = "insert_emprunt";
            this.insert_emprunt.Size = new System.Drawing.Size(170, 63);
            this.insert_emprunt.TabIndex = 18;
            this.insert_emprunt.Text = "INSERT";
            this.insert_emprunt.UseVisualStyleBackColor = false;
            this.insert_emprunt.Click += new System.EventHandler(this.insert_emprunt_Click);
            // 
            // select_emprunt
            // 
            this.select_emprunt.BackColor = System.Drawing.Color.Yellow;
            this.select_emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_emprunt.Location = new System.Drawing.Point(786, 151);
            this.select_emprunt.Name = "select_emprunt";
            this.select_emprunt.Size = new System.Drawing.Size(170, 58);
            this.select_emprunt.TabIndex = 17;
            this.select_emprunt.Text = "SELECT";
            this.select_emprunt.UseVisualStyleBackColor = false;
            this.select_emprunt.Click += new System.EventHandler(this.select_emprunt_Click);
            // 
            // dataGridView_emprunt
            // 
            this.dataGridView_emprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_emprunt.Location = new System.Drawing.Point(125, 127);
            this.dataGridView_emprunt.Name = "dataGridView_emprunt";
            this.dataGridView_emprunt.Size = new System.Drawing.Size(546, 383);
            this.dataGridView_emprunt.TabIndex = 21;
            // 
            // InsererEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(991, 555);
            this.Controls.Add(this.dataGridView_emprunt);
            this.Controls.Add(this.update_emprunt);
            this.Controls.Add(this.delete_emprunt);
            this.Controls.Add(this.insert_emprunt);
            this.Controls.Add(this.select_emprunt);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_avancer);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.date_Retour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_Emprunt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero_RefClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero_RefLivreEmprunt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsererEmprunt";
            this.Text = "InsererEmprunt";
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefLivreEmprunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_emprunt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numero_RefLivreEmprunt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numero_RefClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_Emprunt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_Retour;
        private System.Windows.Forms.Button button_retour;
        private System.Windows.Forms.Button button_avancer;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button update_emprunt;
        private System.Windows.Forms.Button delete_emprunt;
        private System.Windows.Forms.Button insert_emprunt;
        private System.Windows.Forms.Button select_emprunt;
        private System.Windows.Forms.DataGridView dataGridView_emprunt;
    }
}