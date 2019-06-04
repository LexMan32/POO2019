namespace ExPeleMele
{
    partial class Introduction
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbIntroduction = new System.Windows.Forms.Label();
            this.btContinuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIntroduction
            // 
            this.lbIntroduction.AutoSize = true;
            this.lbIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntroduction.Location = new System.Drawing.Point(12, 18);
            this.lbIntroduction.Name = "lbIntroduction";
            this.lbIntroduction.Size = new System.Drawing.Size(361, 72);
            this.lbIntroduction.TabIndex = 0;
            this.lbIntroduction.Text = "Bienvenue !\r\n\r\nCe programme est un mini-jeu. Le but est de retrouvé \r\nle mot dont" +
    " les lettres ont été mélangés.";
            this.lbIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btContinuer
            // 
            this.btContinuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinuer.Location = new System.Drawing.Point(151, 111);
            this.btContinuer.Name = "btContinuer";
            this.btContinuer.Size = new System.Drawing.Size(77, 29);
            this.btContinuer.TabIndex = 1;
            this.btContinuer.Text = "Continuer";
            this.btContinuer.UseVisualStyleBackColor = true;
            this.btContinuer.Click += new System.EventHandler(this.btContinuer_Click);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btContinuer);
            this.Controls.Add(this.lbIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIntroduction;
        private System.Windows.Forms.Button btContinuer;
    }
}

