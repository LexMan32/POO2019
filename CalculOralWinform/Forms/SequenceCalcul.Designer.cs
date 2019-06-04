namespace ExCalculOral
{
    partial class SequenceCalcul
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
            this.btRetour = new System.Windows.Forms.Button();
            this.btVerifier = new System.Windows.Forms.Button();
            this.lbCalcul = new System.Windows.Forms.Label();
            this.tbReponse = new System.Windows.Forms.TextBox();
            this.dgvCalculs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculs)).BeginInit();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(25, 320);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(500, 23);
            this.btRetour.TabIndex = 1;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btVerifier
            // 
            this.btVerifier.Location = new System.Drawing.Point(312, 23);
            this.btVerifier.Name = "btVerifier";
            this.btVerifier.Size = new System.Drawing.Size(75, 23);
            this.btVerifier.TabIndex = 2;
            this.btVerifier.Text = "Vérifier";
            this.btVerifier.UseVisualStyleBackColor = true;
            this.btVerifier.Click += new System.EventHandler(this.btVerifier_Click);
            // 
            // lbCalcul
            // 
            this.lbCalcul.AutoSize = true;
            this.lbCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalcul.Location = new System.Drawing.Point(168, 26);
            this.lbCalcul.Name = "lbCalcul";
            this.lbCalcul.Size = new System.Drawing.Size(46, 17);
            this.lbCalcul.TabIndex = 3;
            this.lbCalcul.Text = "label1";
            // 
            // tbReponse
            // 
            this.tbReponse.Location = new System.Drawing.Point(254, 25);
            this.tbReponse.Name = "tbReponse";
            this.tbReponse.Size = new System.Drawing.Size(52, 20);
            this.tbReponse.TabIndex = 4;
            // 
            // dgvCalculs
            // 
            this.dgvCalculs.AllowUserToAddRows = false;
            this.dgvCalculs.AllowUserToDeleteRows = false;
            this.dgvCalculs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculs.Location = new System.Drawing.Point(25, 64);
            this.dgvCalculs.Name = "dgvCalculs";
            this.dgvCalculs.ReadOnly = true;
            this.dgvCalculs.Size = new System.Drawing.Size(500, 234);
            this.dgvCalculs.TabIndex = 5;
            this.dgvCalculs.DataSource = calculs;
            // 
            // SequenceCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 355);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCalculs);
            this.Controls.Add(this.tbReponse);
            this.Controls.Add(this.lbCalcul);
            this.Controls.Add(this.btVerifier);
            this.Controls.Add(this.btRetour);
            this.Name = "SequenceCalcul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séquence de calcul";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btVerifier;
        private System.Windows.Forms.Label lbCalcul;
        private System.Windows.Forms.TextBox tbReponse;
        private System.Windows.Forms.DataGridView dgvCalculs;
    }
}