namespace ProjetFinal_Prototype_Interface
{
    partial class FormRejoindreEquipe
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
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.labelPong = new System.Windows.Forms.Label();
            this.textBoxNomEquipe = new System.Windows.Forms.TextBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonCreerEquipe = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomEquipe
            // 
            this.labelNomEquipe.AutoSize = true;
            this.labelNomEquipe.Location = new System.Drawing.Point(12, 73);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(86, 13);
            this.labelNomEquipe.TabIndex = 0;
            this.labelNomEquipe.Text = "Nom de l\'équipe:";
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-3, 0);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 6;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNomEquipe
            // 
            this.textBoxNomEquipe.Location = new System.Drawing.Point(104, 70);
            this.textBoxNomEquipe.Name = "textBoxNomEquipe";
            this.textBoxNomEquipe.Size = new System.Drawing.Size(168, 20);
            this.textBoxNomEquipe.TabIndex = 7;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(12, 113);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(260, 23);
            this.buttonRechercher.TabIndex = 8;
            this.buttonRechercher.Text = "Rechercher l\'équipe";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonCreerEquipe
            // 
            this.buttonCreerEquipe.Location = new System.Drawing.Point(12, 142);
            this.buttonCreerEquipe.Name = "buttonCreerEquipe";
            this.buttonCreerEquipe.Size = new System.Drawing.Size(260, 23);
            this.buttonCreerEquipe.TabIndex = 9;
            this.buttonCreerEquipe.Text = "Créer une équipe";
            this.buttonCreerEquipe.UseVisualStyleBackColor = true;
            this.buttonCreerEquipe.Click += new System.EventHandler(this.buttonCreerEquipe_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(12, 171);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(260, 23);
            this.buttonAnnuler.TabIndex = 10;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // FormRejoindreEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonCreerEquipe);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.textBoxNomEquipe);
            this.Controls.Add(this.labelPong);
            this.Controls.Add(this.labelNomEquipe);
            this.Name = "FormRejoindreEquipe";
            this.Text = "FormRejoindreEquipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.TextBox textBoxNomEquipe;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonCreerEquipe;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}