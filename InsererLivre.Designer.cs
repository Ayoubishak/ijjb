
namespace Gestion_Bibliotheque
{
    partial class InsererLivre
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
            this.numero_livre = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numero_RefAuteur = new System.Windows.Forms.NumericUpDown();
            this.titre_livre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.langue_livre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_edition_livre = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.numero_RefDomaine = new System.Windows.Forms.NumericUpDown();
            this.button_avancer = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_reculer = new System.Windows.Forms.Button();
            this.update_livre = new System.Windows.Forms.Button();
            this.delete_livre = new System.Windows.Forms.Button();
            this.insert_livre = new System.Windows.Forms.Button();
            this.select_livre = new System.Windows.Forms.Button();
            this.dataGridView_livre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numero_livre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefAuteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefDomaine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_livre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°";
            // 
            // numero_livre
            // 
            this.numero_livre.Location = new System.Drawing.Point(135, 28);
            this.numero_livre.Name = "numero_livre";
            this.numero_livre.Size = new System.Drawing.Size(75, 20);
            this.numero_livre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Auteur";
            // 
            // numero_RefAuteur
            // 
            this.numero_RefAuteur.Location = new System.Drawing.Point(135, 78);
            this.numero_RefAuteur.Name = "numero_RefAuteur";
            this.numero_RefAuteur.Size = new System.Drawing.Size(75, 20);
            this.numero_RefAuteur.TabIndex = 3;
            // 
            // titre_livre
            // 
            this.titre_livre.Location = new System.Drawing.Point(334, 28);
            this.titre_livre.Name = "titre_livre";
            this.titre_livre.Size = new System.Drawing.Size(343, 20);
            this.titre_livre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Langue";
            // 
            // langue_livre
            // 
            this.langue_livre.Location = new System.Drawing.Point(334, 78);
            this.langue_livre.Name = "langue_livre";
            this.langue_livre.Size = new System.Drawing.Size(226, 20);
            this.langue_livre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date d\'edition";
            // 
            // date_edition_livre
            // 
            this.date_edition_livre.CustomFormat = "yyyy-MM-dd";
            this.date_edition_livre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_edition_livre.Location = new System.Drawing.Point(334, 126);
            this.date_edition_livre.Name = "date_edition_livre";
            this.date_edition_livre.Size = new System.Drawing.Size(226, 20);
            this.date_edition_livre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "N° Domaine";
            // 
            // numero_RefDomaine
            // 
            this.numero_RefDomaine.Location = new System.Drawing.Point(131, 126);
            this.numero_RefDomaine.Name = "numero_RefDomaine";
            this.numero_RefDomaine.Size = new System.Drawing.Size(75, 20);
            this.numero_RefDomaine.TabIndex = 11;
            // 
            // button_avancer
            // 
            this.button_avancer.Location = new System.Drawing.Point(944, 519);
            this.button_avancer.Name = "button_avancer";
            this.button_avancer.Size = new System.Drawing.Size(75, 42);
            this.button_avancer.TabIndex = 13;
            this.button_avancer.Text = ">";
            this.button_avancer.UseVisualStyleBackColor = true;
            this.button_avancer.Click += new System.EventHandler(this.button_avancer_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(944, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 36);
            this.button_close.TabIndex = 14;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_reculer
            // 
            this.button_reculer.Location = new System.Drawing.Point(12, 525);
            this.button_reculer.Name = "button_reculer";
            this.button_reculer.Size = new System.Drawing.Size(75, 36);
            this.button_reculer.TabIndex = 18;
            this.button_reculer.Text = "<";
            this.button_reculer.UseVisualStyleBackColor = true;
            this.button_reculer.Click += new System.EventHandler(this.button_reculer_Click);
            // 
            // update_livre
            // 
            this.update_livre.BackColor = System.Drawing.Color.Yellow;
            this.update_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_livre.Location = new System.Drawing.Point(815, 320);
            this.update_livre.Name = "update_livre";
            this.update_livre.Size = new System.Drawing.Size(204, 55);
            this.update_livre.TabIndex = 22;
            this.update_livre.Text = "UPDATE";
            this.update_livre.UseVisualStyleBackColor = false;
            this.update_livre.Click += new System.EventHandler(this.update_livre_Click);
            // 
            // delete_livre
            // 
            this.delete_livre.BackColor = System.Drawing.Color.Yellow;
            this.delete_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_livre.Location = new System.Drawing.Point(815, 259);
            this.delete_livre.Name = "delete_livre";
            this.delete_livre.Size = new System.Drawing.Size(204, 55);
            this.delete_livre.TabIndex = 21;
            this.delete_livre.Text = "DELETE";
            this.delete_livre.UseVisualStyleBackColor = false;
            this.delete_livre.Click += new System.EventHandler(this.delete_livre_Click);
            // 
            // insert_livre
            // 
            this.insert_livre.BackColor = System.Drawing.Color.Yellow;
            this.insert_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_livre.Location = new System.Drawing.Point(815, 190);
            this.insert_livre.Name = "insert_livre";
            this.insert_livre.Size = new System.Drawing.Size(204, 63);
            this.insert_livre.TabIndex = 20;
            this.insert_livre.Text = "INSERT";
            this.insert_livre.UseVisualStyleBackColor = false;
            this.insert_livre.Click += new System.EventHandler(this.insert_livre_Click);
            // 
            // select_livre
            // 
            this.select_livre.BackColor = System.Drawing.Color.Yellow;
            this.select_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_livre.Location = new System.Drawing.Point(815, 126);
            this.select_livre.Name = "select_livre";
            this.select_livre.Size = new System.Drawing.Size(204, 58);
            this.select_livre.TabIndex = 19;
            this.select_livre.Text = "SELECT";
            this.select_livre.UseVisualStyleBackColor = false;
            this.select_livre.Click += new System.EventHandler(this.select_livre_Click);
            // 
            // dataGridView_livre
            // 
            this.dataGridView_livre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_livre.Location = new System.Drawing.Point(108, 173);
            this.dataGridView_livre.Name = "dataGridView_livre";
            this.dataGridView_livre.Size = new System.Drawing.Size(587, 388);
            this.dataGridView_livre.TabIndex = 23;
            // 
            // InsererLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1031, 573);
            this.Controls.Add(this.dataGridView_livre);
            this.Controls.Add(this.update_livre);
            this.Controls.Add(this.delete_livre);
            this.Controls.Add(this.insert_livre);
            this.Controls.Add(this.select_livre);
            this.Controls.Add(this.button_reculer);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_avancer);
            this.Controls.Add(this.numero_RefDomaine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_edition_livre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.langue_livre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titre_livre);
            this.Controls.Add(this.numero_RefAuteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero_livre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsererLivre";
            this.Text = "InsererLivre";
            ((System.ComponentModel.ISupportInitialize)(this.numero_livre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefAuteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefDomaine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_livre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numero_livre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numero_RefAuteur;
        private System.Windows.Forms.TextBox titre_livre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox langue_livre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_edition_livre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numero_RefDomaine;
        private System.Windows.Forms.Button button_avancer;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_reculer;
        private System.Windows.Forms.Button update_livre;
        private System.Windows.Forms.Button delete_livre;
        private System.Windows.Forms.Button insert_livre;
        private System.Windows.Forms.Button select_livre;
        private System.Windows.Forms.DataGridView dataGridView_livre;
    }
}