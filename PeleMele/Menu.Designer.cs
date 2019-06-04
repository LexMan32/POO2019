namespace ExPeleMele
{
    partial class Menu
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
            this.btSelectFichier = new System.Windows.Forms.Button();
            this.lbSelectFichier = new System.Windows.Forms.Label();
            this.lbFichier = new System.Windows.Forms.Label();
            this.lbSelectNbreMot = new System.Windows.Forms.Label();
            this.nudNbreMot = new System.Windows.Forms.NumericUpDown();
            this.btJouerSequence = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btHistorique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbreMot)).BeginInit();
            this.SuspendLayout();
            // 
            // btSelectFichier
            // 
            this.btSelectFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectFichier.Location = new System.Drawing.Point(215, 35);
            this.btSelectFichier.Name = "btSelectFichier";
            this.btSelectFichier.Size = new System.Drawing.Size(81, 25);
            this.btSelectFichier.TabIndex = 0;
            this.btSelectFichier.Text = "Parcourir ...";
            this.btSelectFichier.UseVisualStyleBackColor = true;
            this.btSelectFichier.Click += new System.EventHandler(this.btSelectionFichier_Click);
            // 
            // lbSelectFichier
            // 
            this.lbSelectFichier.AutoSize = true;
            this.lbSelectFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectFichier.Location = new System.Drawing.Point(24, 40);
            this.lbSelectFichier.Name = "lbSelectFichier";
            this.lbSelectFichier.Size = new System.Drawing.Size(185, 18);
            this.lbSelectFichier.TabIndex = 1;
            this.lbSelectFichier.Text = "1.  Sélectionner un fichier : ";
            // 
            // lbFichier
            // 
            this.lbFichier.AutoSize = true;
            this.lbFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFichier.Location = new System.Drawing.Point(302, 40);
            this.lbFichier.Name = "lbFichier";
            this.lbFichier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFichier.Size = new System.Drawing.Size(149, 15);
            this.lbFichier.TabIndex = 2;
            this.lbFichier.Text = "Aucun fichier sélectionné !";
            this.lbFichier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSelectNbreMot
            // 
            this.lbSelectNbreMot.AutoSize = true;
            this.lbSelectNbreMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectNbreMot.Location = new System.Drawing.Point(24, 83);
            this.lbSelectNbreMot.Name = "lbSelectNbreMot";
            this.lbSelectNbreMot.Size = new System.Drawing.Size(331, 18);
            this.lbSelectNbreMot.TabIndex = 3;
            this.lbSelectNbreMot.Text = "2.  Sélectionner le nombre de mot pour la partie : ";
            // 
            // nudNbreMot
            // 
            this.nudNbreMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNbreMot.Location = new System.Drawing.Point(361, 83);
            this.nudNbreMot.Name = "nudNbreMot";
            this.nudNbreMot.Size = new System.Drawing.Size(46, 23);
            this.nudNbreMot.TabIndex = 4;
            // 
            // btJouerSequence
            // 
            this.btJouerSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJouerSequence.Location = new System.Drawing.Point(193, 127);
            this.btJouerSequence.Name = "btJouerSequence";
            this.btJouerSequence.Size = new System.Drawing.Size(126, 28);
            this.btJouerSequence.TabIndex = 5;
            this.btJouerSequence.Text = "3. Jouer";
            this.btJouerSequence.UseVisualStyleBackColor = true;
            this.btJouerSequence.Click += new System.EventHandler(this.btJouerSequence_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(408, 186);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(92, 30);
            this.btQuitter.TabIndex = 6;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btHistorique
            // 
            this.btHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorique.Location = new System.Drawing.Point(12, 188);
            this.btHistorique.Name = "btHistorique";
            this.btHistorique.Size = new System.Drawing.Size(98, 28);
            this.btHistorique.TabIndex = 7;
            this.btHistorique.Text = "Historique";
            this.btHistorique.UseVisualStyleBackColor = true;
            this.btHistorique.Click += new System.EventHandler(this.btHistorique_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 231);
            this.ControlBox = false;
            this.Controls.Add(this.btHistorique);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btJouerSequence);
            this.Controls.Add(this.nudNbreMot);
            this.Controls.Add(this.lbSelectNbreMot);
            this.Controls.Add(this.lbFichier);
            this.Controls.Add(this.lbSelectFichier);
            this.Controls.Add(this.btSelectFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nudNbreMot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelectFichier;
        private System.Windows.Forms.Label lbSelectFichier;
        private System.Windows.Forms.Label lbFichier;
        private System.Windows.Forms.Label lbSelectNbreMot;
        private System.Windows.Forms.NumericUpDown nudNbreMot;
        private System.Windows.Forms.Button btJouerSequence;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btHistorique;
    }
}