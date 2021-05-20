
namespace Gestion_Bibliotheque
{
    partial class InsererExemplaire
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
            this.numero_examplaire = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numero_RefLivre = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_exemplaire = new System.Windows.Forms.NumericUpDown();
            this.button_avancer = new System.Windows.Forms.Button();
            this.button_reculer = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.update_exemplaire = new System.Windows.Forms.Button();
            this.delete_exemplaire = new System.Windows.Forms.Button();
            this.insert_exemplaire = new System.Windows.Forms.Button();
            this.select_exemplaire = new System.Windows.Forms.Button();
            this.dataGridView_exemplaire = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numero_examplaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefLivre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombre_exemplaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_exemplaire)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Examplaire";
            // 
            // numero_examplaire
            // 
            this.numero_examplaire.Location = new System.Drawing.Point(67, 42);
            this.numero_examplaire.Name = "numero_examplaire";
            this.numero_examplaire.Size = new System.Drawing.Size(84, 20);
            this.numero_examplaire.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Livre";
            // 
            // numero_RefLivre
            // 
            this.numero_RefLivre.Location = new System.Drawing.Point(209, 42);
            this.numero_RefLivre.Name = "numero_RefLivre";
            this.numero_RefLivre.Size = new System.Drawing.Size(84, 20);
            this.numero_RefLivre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NombreExamplaire";
            // 
            // nombre_exemplaire
            // 
            this.nombre_exemplaire.Location = new System.Drawing.Point(334, 42);
            this.nombre_exemplaire.Name = "nombre_exemplaire";
            this.nombre_exemplaire.Size = new System.Drawing.Size(84, 20);
            this.nombre_exemplaire.TabIndex = 5;
            // 
            // button_avancer
            // 
            this.button_avancer.Location = new System.Drawing.Point(846, 461);
            this.button_avancer.Name = "button_avancer";
            this.button_avancer.Size = new System.Drawing.Size(75, 47);
            this.button_avancer.TabIndex = 9;
            this.button_avancer.Text = ">";
            this.button_avancer.UseVisualStyleBackColor = true;
            this.button_avancer.Click += new System.EventHandler(this.button_avancer_Click);
            // 
            // button_reculer
            // 
            this.button_reculer.Location = new System.Drawing.Point(12, 464);
            this.button_reculer.Name = "button_reculer";
            this.button_reculer.Size = new System.Drawing.Size(75, 44);
            this.button_reculer.TabIndex = 10;
            this.button_reculer.Text = "<";
            this.button_reculer.UseVisualStyleBackColor = true;
            this.button_reculer.Click += new System.EventHandler(this.button_reculer_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(846, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 40);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // update_exemplaire
            // 
            this.update_exemplaire.BackColor = System.Drawing.Color.Yellow;
            this.update_exemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_exemplaire.Location = new System.Drawing.Point(717, 318);
            this.update_exemplaire.Name = "update_exemplaire";
            this.update_exemplaire.Size = new System.Drawing.Size(204, 55);
            this.update_exemplaire.TabIndex = 16;
            this.update_exemplaire.Text = "UPDATE";
            this.update_exemplaire.UseVisualStyleBackColor = false;
            this.update_exemplaire.Click += new System.EventHandler(this.update_exemplaire_Click);
            // 
            // delete_exemplaire
            // 
            this.delete_exemplaire.BackColor = System.Drawing.Color.Yellow;
            this.delete_exemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_exemplaire.Location = new System.Drawing.Point(717, 257);
            this.delete_exemplaire.Name = "delete_exemplaire";
            this.delete_exemplaire.Size = new System.Drawing.Size(204, 55);
            this.delete_exemplaire.TabIndex = 15;
            this.delete_exemplaire.Text = "DELETE";
            this.delete_exemplaire.UseVisualStyleBackColor = false;
            this.delete_exemplaire.Click += new System.EventHandler(this.delete_exemplaire_Click);
            // 
            // insert_exemplaire
            // 
            this.insert_exemplaire.BackColor = System.Drawing.Color.Yellow;
            this.insert_exemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_exemplaire.Location = new System.Drawing.Point(717, 188);
            this.insert_exemplaire.Name = "insert_exemplaire";
            this.insert_exemplaire.Size = new System.Drawing.Size(204, 63);
            this.insert_exemplaire.TabIndex = 14;
            this.insert_exemplaire.Text = "INSERT";
            this.insert_exemplaire.UseVisualStyleBackColor = false;
            this.insert_exemplaire.Click += new System.EventHandler(this.insert_exemplaire_Click);
            // 
            // select_exemplaire
            // 
            this.select_exemplaire.BackColor = System.Drawing.Color.Yellow;
            this.select_exemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_exemplaire.Location = new System.Drawing.Point(717, 124);
            this.select_exemplaire.Name = "select_exemplaire";
            this.select_exemplaire.Size = new System.Drawing.Size(204, 58);
            this.select_exemplaire.TabIndex = 13;
            this.select_exemplaire.Text = "SELECT";
            this.select_exemplaire.UseVisualStyleBackColor = false;
            this.select_exemplaire.Click += new System.EventHandler(this.select_exemplaire_Click);
            // 
            // dataGridView_exemplaire
            // 
            this.dataGridView_exemplaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_exemplaire.Location = new System.Drawing.Point(137, 124);
            this.dataGridView_exemplaire.Name = "dataGridView_exemplaire";
            this.dataGridView_exemplaire.Size = new System.Drawing.Size(314, 249);
            this.dataGridView_exemplaire.TabIndex = 17;
            // 
            // InsererExemplaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(944, 520);
            this.Controls.Add(this.dataGridView_exemplaire);
            this.Controls.Add(this.update_exemplaire);
            this.Controls.Add(this.delete_exemplaire);
            this.Controls.Add(this.insert_exemplaire);
            this.Controls.Add(this.select_exemplaire);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_reculer);
            this.Controls.Add(this.button_avancer);
            this.Controls.Add(this.nombre_exemplaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero_RefLivre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero_examplaire);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsererExemplaire";
            this.Text = "InsererExemplaire";
            ((System.ComponentModel.ISupportInitialize)(this.numero_examplaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_RefLivre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombre_exemplaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_exemplaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numero_examplaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numero_RefLivre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nombre_exemplaire;
        private System.Windows.Forms.Button button_avancer;
        private System.Windows.Forms.Button button_reculer;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button update_exemplaire;
        private System.Windows.Forms.Button delete_exemplaire;
        private System.Windows.Forms.Button insert_exemplaire;
        private System.Windows.Forms.Button select_exemplaire;
        private System.Windows.Forms.DataGridView dataGridView_exemplaire;
    }
}