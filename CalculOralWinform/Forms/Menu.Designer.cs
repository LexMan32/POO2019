using ExCalculOral.Enums;
using System;

namespace ExCalculOral
{
    partial class mMenu
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
            this.lMenuOperandes = new System.Windows.Forms.Label();
            this.lMenuOperation = new System.Windows.Forms.Label();
            this.lMenuCalculs = new System.Windows.Forms.Label();
            this.btMenuQuitter = new System.Windows.Forms.Button();
            this.btLancement = new System.Windows.Forms.Button();
            this.btAffichageHistorique = new System.Windows.Forms.Button();
            this.nudOperande = new System.Windows.Forms.NumericUpDown();
            this.nudCalculs = new System.Windows.Forms.NumericUpDown();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalculs)).BeginInit();
            this.SuspendLayout();
            // 
            // lMenuOperandes
            // 
            this.lMenuOperandes.AutoSize = true;
            this.lMenuOperandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenuOperandes.Location = new System.Drawing.Point(32, 24);
            this.lMenuOperandes.Name = "lMenuOperandes";
            this.lMenuOperandes.Size = new System.Drawing.Size(256, 15);
            this.lMenuOperandes.TabIndex = 8;
            this.lMenuOperandes.Text = "Quantité maximum de chiffres des opérandes";
            // 
            // lMenuOperation
            // 
            this.lMenuOperation.AutoSize = true;
            this.lMenuOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenuOperation.Location = new System.Drawing.Point(32, 52);
            this.lMenuOperation.Name = "lMenuOperation";
            this.lMenuOperation.Size = new System.Drawing.Size(215, 15);
            this.lMenuOperation.TabIndex = 9;
            this.lMenuOperation.Text = "Genre d\'opérations désirées (+,-,*,/,m)";
            // 
            // lMenuCalculs
            // 
            this.lMenuCalculs.AutoSize = true;
            this.lMenuCalculs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenuCalculs.Location = new System.Drawing.Point(32, 79);
            this.lMenuCalculs.Name = "lMenuCalculs";
            this.lMenuCalculs.Size = new System.Drawing.Size(144, 15);
            this.lMenuCalculs.TabIndex = 10;
            this.lMenuCalculs.Text = "Quantité de calculs suivis";
            // 
            // btMenuQuitter
            // 
            this.btMenuQuitter.Location = new System.Drawing.Point(159, 197);
            this.btMenuQuitter.Name = "btMenuQuitter";
            this.btMenuQuitter.Size = new System.Drawing.Size(97, 32);
            this.btMenuQuitter.TabIndex = 13;
            this.btMenuQuitter.Text = "Quitter";
            this.btMenuQuitter.UseVisualStyleBackColor = true;
            this.btMenuQuitter.Click += new System.EventHandler(this.btMenuQuitter_Click);
            // 
            // btLancement
            // 
            this.btLancement.Location = new System.Drawing.Point(35, 112);
            this.btLancement.Name = "btLancement";
            this.btLancement.Size = new System.Drawing.Size(344, 28);
            this.btLancement.TabIndex = 14;
            this.btLancement.Text = "Lancement d\'une séquence de calcul";
            this.btLancement.UseVisualStyleBackColor = true;
            this.btLancement.Click += new System.EventHandler(this.btLancement_Click);
            // 
            // btAffichageHistorique
            // 
            this.btAffichageHistorique.Location = new System.Drawing.Point(35, 146);
            this.btAffichageHistorique.Name = "btAffichageHistorique";
            this.btAffichageHistorique.Size = new System.Drawing.Size(344, 28);
            this.btAffichageHistorique.TabIndex = 15;
            this.btAffichageHistorique.Text = "Affichage de l\'ancienne séquence de calcul";
            this.btAffichageHistorique.UseVisualStyleBackColor = true;
            this.btAffichageHistorique.Click += new System.EventHandler(this.btAffichageHistorique_Click);
            // 
            // nudOperande
            // 
            this.nudOperande.Location = new System.Drawing.Point(333, 24);
            this.nudOperande.Name = "nudOperande";
            this.nudOperande.Size = new System.Drawing.Size(46, 20);
            this.nudOperande.TabIndex = 17;
            this.nudOperande.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudCalculs
            // 
            this.nudCalculs.Location = new System.Drawing.Point(333, 80);
            this.nudCalculs.Name = "nudCalculs";
            this.nudCalculs.Size = new System.Drawing.Size(46, 20);
            this.nudCalculs.TabIndex = 18;
            this.nudCalculs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbOperations
            // 
            this.cbOperations.DataSource = Enum.GetValues(typeof(TypeOperation));
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Location = new System.Drawing.Point(269, 52);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(110, 21);
            this.cbOperations.TabIndex = 16;
            // 
            // mMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 246);
            this.ControlBox = false;
            this.Controls.Add(this.nudCalculs);
            this.Controls.Add(this.nudOperande);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.btAffichageHistorique);
            this.Controls.Add(this.btLancement);
            this.Controls.Add(this.btMenuQuitter);
            this.Controls.Add(this.lMenuCalculs);
            this.Controls.Add(this.lMenuOperation);
            this.Controls.Add(this.lMenuOperandes);
            this.Name = "mMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nudOperande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalculs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lMenuOperandes;
        private System.Windows.Forms.Label lMenuOperation;
        private System.Windows.Forms.Label lMenuCalculs;
        private System.Windows.Forms.Button btMenuQuitter;
        private System.Windows.Forms.Button btLancement;
        private System.Windows.Forms.Button btAffichageHistorique;
        private System.Windows.Forms.NumericUpDown nudOperande;
        private System.Windows.Forms.NumericUpDown nudCalculs;
        private System.Windows.Forms.ComboBox cbOperations;
    }
}

