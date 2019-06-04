namespace ExPeleMele
{
    partial class JouerSequence
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
            this.lbConsigne = new System.Windows.Forms.Label();
            this.lbLettres = new System.Windows.Forms.Label();
            this.btVerifier = new System.Windows.Forms.Button();
            this.reponse = new System.Windows.Forms.TextBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConsigne
            // 
            this.lbConsigne.AutoSize = true;
            this.lbConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsigne.Location = new System.Drawing.Point(12, 19);
            this.lbConsigne.Name = "lbConsigne";
            this.lbConsigne.Size = new System.Drawing.Size(282, 15);
            this.lbConsigne.TabIndex = 0;
            this.lbConsigne.Text = "Retrouvez le mot dont les lettres ont été mélangés.";
            // 
            // lbLettres
            // 
            this.lbLettres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLettres.Location = new System.Drawing.Point(73, 58);
            this.lbLettres.Name = "lbLettres";
            this.lbLettres.Size = new System.Drawing.Size(155, 25);
            this.lbLettres.TabIndex = 1;
            this.lbLettres.Text = "TEST_TEST";
            this.lbLettres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btVerifier
            // 
            this.btVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerifier.Location = new System.Drawing.Point(114, 156);
            this.btVerifier.Name = "btVerifier";
            this.btVerifier.Size = new System.Drawing.Size(68, 35);
            this.btVerifier.TabIndex = 2;
            this.btVerifier.Text = "Vérifier";
            this.btVerifier.UseVisualStyleBackColor = true;
            this.btVerifier.Click += new System.EventHandler(this.btVerifier_Click);
            // 
            // reponse
            // 
            this.reponse.Location = new System.Drawing.Point(74, 106);
            this.reponse.Name = "reponse";
            this.reponse.Size = new System.Drawing.Size(150, 20);
            this.reponse.TabIndex = 3;
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(98, 156);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(98, 35);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Visible = false;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // JouerSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 208);
            this.ControlBox = false;
            this.Controls.Add(this.btVerifier);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.reponse);
            this.Controls.Add(this.lbLettres);
            this.Controls.Add(this.lbConsigne);
            this.Name = "JouerSequence";
            this.Text = "Jeux : Rechercher le mot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsigne;
        private System.Windows.Forms.Label lbLettres;
        private System.Windows.Forms.Button btVerifier;
        private System.Windows.Forms.TextBox reponse;
        private System.Windows.Forms.Button btRetour;
    }
}