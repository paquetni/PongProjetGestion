namespace ProjetFinal_Prototype_Interface
{
    partial class FormJoueur
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
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonInscription = new System.Windows.Forms.Button();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.labelMotPasse = new System.Windows.Forms.Label();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-2, 0);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 4;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(12, 162);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(260, 24);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonInscription
            // 
            this.buttonInscription.Location = new System.Drawing.Point(12, 214);
            this.buttonInscription.Name = "buttonInscription";
            this.buttonInscription.Size = new System.Drawing.Size(260, 25);
            this.buttonInscription.TabIndex = 6;
            this.buttonInscription.Text = "S\'inscrire";
            this.buttonInscription.UseVisualStyleBackColor = true;
            this.buttonInscription.Click += new System.EventHandler(this.buttonInscription_Click);
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Location = new System.Drawing.Point(100, 108);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.Size = new System.Drawing.Size(172, 20);
            this.textBoxMotDePasse.TabIndex = 7;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(100, 63);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(172, 20);
            this.textBoxPseudo.TabIndex = 8;
            // 
            // labelMotPasse
            // 
            this.labelMotPasse.AutoSize = true;
            this.labelMotPasse.Location = new System.Drawing.Point(17, 111);
            this.labelMotPasse.Name = "labelMotPasse";
            this.labelMotPasse.Size = new System.Drawing.Size(77, 13);
            this.labelMotPasse.TabIndex = 9;
            this.labelMotPasse.Text = "Mot de passe: ";
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Location = new System.Drawing.Point(48, 66);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(46, 13);
            this.labelPseudo.TabIndex = 10;
            this.labelPseudo.Text = "Pseudo:";
            // 
            // FormJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelPseudo);
            this.Controls.Add(this.labelMotPasse);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.textBoxMotDePasse);
            this.Controls.Add(this.buttonInscription);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelPong);
            this.Name = "FormJoueur";
            this.Text = "Bienvenue sur PONG!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonInscription;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label labelMotPasse;
        private System.Windows.Forms.Label labelPseudo;
    }
}