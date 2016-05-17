namespace ProjetFinal_Prototype_Interface
{
    partial class FormRejoindreMatch
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
            this.buttonRejoindreMatch = new System.Windows.Forms.Button();
            this.labelNbJoueursConnecte = new System.Windows.Forms.Label();
            this.labelNbJoueursConnecteResultat = new System.Windows.Forms.Label();
            this.labelNombreMatchsRestants = new System.Windows.Forms.Label();
            this.labelNombreMatchsRestantsResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-1, -1);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 3;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRejoindreMatch
            // 
            this.buttonRejoindreMatch.Location = new System.Drawing.Point(45, 97);
            this.buttonRejoindreMatch.Name = "buttonRejoindreMatch";
            this.buttonRejoindreMatch.Size = new System.Drawing.Size(188, 71);
            this.buttonRejoindreMatch.TabIndex = 4;
            this.buttonRejoindreMatch.Text = "Rejoindre un match";
            this.buttonRejoindreMatch.UseVisualStyleBackColor = true;
            // 
            // labelNbJoueursConnecte
            // 
            this.labelNbJoueursConnecte.AutoSize = true;
            this.labelNbJoueursConnecte.Location = new System.Drawing.Point(12, 239);
            this.labelNbJoueursConnecte.Name = "labelNbJoueursConnecte";
            this.labelNbJoueursConnecte.Size = new System.Drawing.Size(142, 13);
            this.labelNbJoueursConnecte.TabIndex = 5;
            this.labelNbJoueursConnecte.Text = "Nombre de joueurs en ligne: ";
            // 
            // labelNbJoueursConnecteResultat
            // 
            this.labelNbJoueursConnecteResultat.AutoSize = true;
            this.labelNbJoueursConnecteResultat.Location = new System.Drawing.Point(160, 239);
            this.labelNbJoueursConnecteResultat.Name = "labelNbJoueursConnecteResultat";
            this.labelNbJoueursConnecteResultat.Size = new System.Drawing.Size(118, 13);
            this.labelNbJoueursConnecteResultat.TabIndex = 6;
            this.labelNbJoueursConnecteResultat.Text = "Aucun joueur connecté";
            // 
            // labelNombreMatchsRestants
            // 
            this.labelNombreMatchsRestants.AutoSize = true;
            this.labelNombreMatchsRestants.Location = new System.Drawing.Point(12, 217);
            this.labelNombreMatchsRestants.Name = "labelNombreMatchsRestants";
            this.labelNombreMatchsRestants.Size = new System.Drawing.Size(139, 13);
            this.labelNombreMatchsRestants.TabIndex = 7;
            this.labelNombreMatchsRestants.Text = "Nombre de matchs restants:";
            // 
            // labelNombreMatchsRestantsResultat
            // 
            this.labelNombreMatchsRestantsResultat.AutoSize = true;
            this.labelNombreMatchsRestantsResultat.Location = new System.Drawing.Point(160, 217);
            this.labelNombreMatchsRestantsResultat.Name = "labelNombreMatchsRestantsResultat";
            this.labelNombreMatchsRestantsResultat.Size = new System.Drawing.Size(105, 13);
            this.labelNombreMatchsRestantsResultat.TabIndex = 8;
            this.labelNombreMatchsRestantsResultat.Text = "Aucun match restant";
            // 
            // FormRejoindreMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelNombreMatchsRestantsResultat);
            this.Controls.Add(this.labelNombreMatchsRestants);
            this.Controls.Add(this.labelNbJoueursConnecteResultat);
            this.Controls.Add(this.labelNbJoueursConnecte);
            this.Controls.Add(this.buttonRejoindreMatch);
            this.Controls.Add(this.labelPong);
            this.Name = "FormRejoindreMatch";
            this.Text = "Jouer un match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Button buttonRejoindreMatch;
        private System.Windows.Forms.Label labelNbJoueursConnecte;
        private System.Windows.Forms.Label labelNbJoueursConnecteResultat;
        private System.Windows.Forms.Label labelNombreMatchsRestants;
        private System.Windows.Forms.Label labelNombreMatchsRestantsResultat;
    }
}