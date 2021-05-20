
namespace Gestion_Bibliotheque
{
    partial class InsererDomaine
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
            this.numero_domaine = new System.Windows.Forms.NumericUpDown();
            this.button_arriere = new System.Windows.Forms.Button();
            this.select_domaine = new System.Windows.Forms.Button();
            this.insert_domaine = new System.Windows.Forms.Button();
            this.delete_domaine = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_avant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.libelle_domaine = new System.Windows.Forms.TextBox();
            this.update_domaine = new System.Windows.Forms.Button();
            this.dataGridView_domaine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numero_domaine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_domaine)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_domaine
            // 
            this.numero_domaine.Location = new System.Drawing.Point(196, 37);
            this.numero_domaine.Name = "numero_domaine";
            this.numero_domaine.Size = new System.Drawing.Size(77, 20);
            this.numero_domaine.TabIndex = 1;
            // 
            // button_arriere
            // 
            this.button_arriere.Location = new System.Drawing.Point(2, 483);
            this.button_arriere.Name = "button_arriere";
            this.button_arriere.Size = new System.Drawing.Size(73, 43);
            this.button_arriere.TabIndex = 3;
            this.button_arriere.Text = "<";
            this.button_arriere.UseVisualStyleBackColor = true;
            this.button_arriere.Click += new System.EventHandler(this.button_arriere_Click);
            // 
            // select_domaine
            // 
            this.select_domaine.BackColor = System.Drawing.Color.Yellow;
            this.select_domaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_domaine.Location = new System.Drawing.Point(777, 123);
            this.select_domaine.Name = "select_domaine";
            this.select_domaine.Size = new System.Drawing.Size(204, 58);
            this.select_domaine.TabIndex = 4;
            this.select_domaine.Text = "SELECT";
            this.select_domaine.UseVisualStyleBackColor = false;
            this.select_domaine.Click += new System.EventHandler(this.ajouter_domaine_Click);
            // 
            // insert_domaine
            // 
            this.insert_domaine.BackColor = System.Drawing.Color.Yellow;
            this.insert_domaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_domaine.Location = new System.Drawing.Point(777, 187);
            this.insert_domaine.Name = "insert_domaine";
            this.insert_domaine.Size = new System.Drawing.Size(204, 63);
            this.insert_domaine.TabIndex = 5;
            this.insert_domaine.Text = "INSERT";
            this.insert_domaine.UseVisualStyleBackColor = false;
            this.insert_domaine.Click += new System.EventHandler(this.modifier_domaine_Click);
            // 
            // delete_domaine
            // 
            this.delete_domaine.BackColor = System.Drawing.Color.Yellow;
            this.delete_domaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_domaine.Location = new System.Drawing.Point(777, 256);
            this.delete_domaine.Name = "delete_domaine";
            this.delete_domaine.Size = new System.Drawing.Size(204, 55);
            this.delete_domaine.TabIndex = 6;
            this.delete_domaine.Text = "DELETE";
            this.delete_domaine.UseVisualStyleBackColor = false;
            this.delete_domaine.Click += new System.EventHandler(this.supprimer_domaine_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(944, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 45);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_avant
            // 
            this.button_avant.Location = new System.Drawing.Point(944, 483);
            this.button_avant.Name = "button_avant";
            this.button_avant.Size = new System.Drawing.Size(75, 43);
            this.button_avant.TabIndex = 8;
            this.button_avant.Text = ">";
            this.button_avant.UseVisualStyleBackColor = true;
            this.button_avant.Click += new System.EventHandler(this.button_avant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Libelle";
            // 
            // libelle_domaine
            // 
            this.libelle_domaine.Location = new System.Drawing.Point(387, 44);
            this.libelle_domaine.Name = "libelle_domaine";
            this.libelle_domaine.Size = new System.Drawing.Size(268, 20);
            this.libelle_domaine.TabIndex = 11;
            // 
            // update_domaine
            // 
            this.update_domaine.BackColor = System.Drawing.Color.Yellow;
            this.update_domaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_domaine.Location = new System.Drawing.Point(777, 317);
            this.update_domaine.Name = "update_domaine";
            this.update_domaine.Size = new System.Drawing.Size(204, 55);
            this.update_domaine.TabIndex = 12;
            this.update_domaine.Text = "UPDATE";
            this.update_domaine.UseVisualStyleBackColor = false;
            this.update_domaine.Click += new System.EventHandler(this.update_domaine_Click);
            // 
            // dataGridView_domaine
            // 
            this.dataGridView_domaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_domaine.Location = new System.Drawing.Point(196, 123);
            this.dataGridView_domaine.Name = "dataGridView_domaine";
            this.dataGridView_domaine.Size = new System.Drawing.Size(459, 353);
            this.dataGridView_domaine.TabIndex = 13;
            // 
            // InsererDomaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1031, 538);
            this.Controls.Add(this.dataGridView_domaine);
            this.Controls.Add(this.update_domaine);
            this.Controls.Add(this.libelle_domaine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_avant);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.delete_domaine);
            this.Controls.Add(this.insert_domaine);
            this.Controls.Add(this.select_domaine);
            this.Controls.Add(this.button_arriere);
            this.Controls.Add(this.numero_domaine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsererDomaine";
            this.Text = "InsererDomaine";
            ((System.ComponentModel.ISupportInitialize)(this.numero_domaine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_domaine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numero_domaine;
        private System.Windows.Forms.Button button_arriere;
        private System.Windows.Forms.Button select_domaine;
        private System.Windows.Forms.Button insert_domaine;
        private System.Windows.Forms.Button delete_domaine;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_avant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox libelle_domaine;
        private System.Windows.Forms.Button update_domaine;
        private System.Windows.Forms.DataGridView dataGridView_domaine;
    }
}