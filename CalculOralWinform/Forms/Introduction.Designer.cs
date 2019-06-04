namespace ExCalculOral
{
    partial class mIntroduction
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
            this.laIntroduction = new System.Windows.Forms.Label();
            this.btIntroduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laIntroduction
            // 
            this.laIntroduction.AutoSize = true;
            this.laIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIntroduction.Location = new System.Drawing.Point(12, 9);
            this.laIntroduction.Name = "laIntroduction";
            this.laIntroduction.Size = new System.Drawing.Size(298, 68);
            this.laIntroduction.TabIndex = 0;
            this.laIntroduction.Text = "Bienvenue !\r\n\r\nCe programme permet d\'exercer le calcul oral.\r\nIl propose les quat" +
    "tres opérations de base.";
            this.laIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btIntroduction
            // 
            this.btIntroduction.Location = new System.Drawing.Point(121, 115);
            this.btIntroduction.Name = "btIntroduction";
            this.btIntroduction.Size = new System.Drawing.Size(75, 23);
            this.btIntroduction.TabIndex = 1;
            this.btIntroduction.Text = "Continuer";
            this.btIntroduction.UseVisualStyleBackColor = true;
            this.btIntroduction.Click += new System.EventHandler(this.btIntroduction_Click);
            // 
            // mIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btIntroduction);
            this.Controls.Add(this.laIntroduction);
            this.DoubleBuffered = true;
            this.Name = "mIntroduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laIntroduction;
        private System.Windows.Forms.Button btIntroduction;
    }
}