namespace ProjetFinal_Prototype_Interface
{
    partial class FormCreerTournoi
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
            this.labelPong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNomTournoi = new System.Windows.Forms.Label();
            this.buttonCreerTournoi = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.checkBoxTournoiPremium = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-1, 0);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 5;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 6;
            // 
            // labelNomTournoi
            // 
            this.labelNomTournoi.AutoSize = true;
            this.labelNomTournoi.Location = new System.Drawing.Point(21, 55);
            this.labelNomTournoi.Name = "labelNomTournoi";
            this.labelNomTournoi.Size = new System.Drawing.Size(82, 13);
            this.labelNomTournoi.TabIndex = 7;
            this.labelNomTournoi.Text = "Nom du tournoi:";
            // 
            // buttonCreerTournoi
            // 
            this.buttonCreerTournoi.Location = new System.Drawing.Point(12, 114);
            this.buttonCreerTournoi.Name = "buttonCreerTournoi";
            this.buttonCreerTournoi.Size = new System.Drawing.Size(260, 23);
            this.buttonCreerTournoi.TabIndex = 8;
            this.buttonCreerTournoi.Text = "Créer le tournoi";
            this.buttonCreerTournoi.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(12, 143);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(260, 23);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // checkBoxTournoiPremium
            // 
            this.checkBoxTournoiPremium.AutoSize = true;
            this.checkBoxTournoiPremium.Location = new System.Drawing.Point(167, 78);
            this.checkBoxTournoiPremium.Name = "checkBoxTournoiPremium";
            this.checkBoxTournoiPremium.Size = new System.Drawing.Size(105, 17);
            this.checkBoxTournoiPremium.TabIndex = 10;
            this.checkBoxTournoiPremium.Text = "Tournoi Premium";
            this.checkBoxTournoiPremium.UseVisualStyleBackColor = true;
            // 
            // FormCreerTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.checkBoxTournoiPremium);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonCreerTournoi);
            this.Controls.Add(this.labelNomTournoi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPong);
            this.Name = "FormCreerTournoi";
            this.Text = "Créer un tournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNomTournoi;
        private System.Windows.Forms.Button buttonCreerTournoi;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.CheckBox checkBoxTournoiPremium;
    }
}