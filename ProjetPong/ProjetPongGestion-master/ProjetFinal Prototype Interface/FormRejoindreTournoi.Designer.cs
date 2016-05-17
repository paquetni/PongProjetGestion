namespace ProjetFinal_Prototype_Interface
{
    partial class FormRejoindreTournoi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPong = new System.Windows.Forms.Label();
            this.labelChoixTournoi = new System.Windows.Forms.Label();
            this.buttonRejoindre = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-2, -1);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 3;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoixTournoi
            // 
            this.labelChoixTournoi.AutoSize = true;
            this.labelChoixTournoi.Location = new System.Drawing.Point(6, 66);
            this.labelChoixTournoi.Name = "labelChoixTournoi";
            this.labelChoixTournoi.Size = new System.Drawing.Size(91, 13);
            this.labelChoixTournoi.TabIndex = 4;
            this.labelChoixTournoi.Text = "Choisir un tournoi:";
            // 
            // buttonRejoindre
            // 
            this.buttonRejoindre.Location = new System.Drawing.Point(12, 91);
            this.buttonRejoindre.Name = "buttonRejoindre";
            this.buttonRejoindre.Size = new System.Drawing.Size(260, 23);
            this.buttonRejoindre.TabIndex = 5;
            this.buttonRejoindre.Text = "Rejoindre le tournoi";
            this.buttonRejoindre.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(12, 120);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(260, 23);
            this.buttonAnnuler.TabIndex = 6;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // FormRejoindreTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonRejoindre);
            this.Controls.Add(this.labelChoixTournoi);
            this.Controls.Add(this.labelPong);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormRejoindreTournoi";
            this.Text = "Rejoindre un tournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Label labelChoixTournoi;
        private System.Windows.Forms.Button buttonRejoindre;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}