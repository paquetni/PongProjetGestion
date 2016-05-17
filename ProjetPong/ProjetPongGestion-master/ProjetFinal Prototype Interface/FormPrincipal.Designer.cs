namespace ProjetFinal_Prototype_Interface
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.buttonJoueur = new System.Windows.Forms.Button();
            this.labelPong = new System.Windows.Forms.Label();
            this.buttonTournois = new System.Windows.Forms.Button();
            this.buttonJouer = new System.Windows.Forms.Button();
            this.buttonAcheter = new System.Windows.Forms.Button();
            this.buttonTableauBord = new System.Windows.Forms.Button();
            this.buttonEquipe = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // buttonJoueur
            // 
            this.buttonJoueur.Location = new System.Drawing.Point(12, 41);
            this.buttonJoueur.Name = "buttonJoueur";
            this.buttonJoueur.Size = new System.Drawing.Size(117, 54);
            this.buttonJoueur.TabIndex = 0;
            this.buttonJoueur.Text = "Joueur";
            this.buttonJoueur.UseVisualStyleBackColor = true;
            this.buttonJoueur.Click += new System.EventHandler(this.buttonJoueur_Click);
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-3, -1);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 1;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTournois
            // 
            this.buttonTournois.Location = new System.Drawing.Point(155, 41);
            this.buttonTournois.Name = "buttonTournois";
            this.buttonTournois.Size = new System.Drawing.Size(117, 54);
            this.buttonTournois.TabIndex = 2;
            this.buttonTournois.Text = "Tournois";
            this.buttonTournois.UseVisualStyleBackColor = true;
            this.buttonTournois.Click += new System.EventHandler(this.buttonTournois_Click);
            // 
            // buttonJouer
            // 
            this.buttonJouer.Location = new System.Drawing.Point(155, 101);
            this.buttonJouer.Name = "buttonJouer";
            this.buttonJouer.Size = new System.Drawing.Size(117, 54);
            this.buttonJouer.TabIndex = 3;
            this.buttonJouer.Text = "Jouer un match";
            this.buttonJouer.UseVisualStyleBackColor = true;
            this.buttonJouer.Click += new System.EventHandler(this.buttonJouer_Click);
            // 
            // buttonAcheter
            // 
            this.buttonAcheter.Location = new System.Drawing.Point(155, 161);
            this.buttonAcheter.Name = "buttonAcheter";
            this.buttonAcheter.Size = new System.Drawing.Size(117, 54);
            this.buttonAcheter.TabIndex = 4;
            this.buttonAcheter.Text = "Acheter des forfaits";
            this.buttonAcheter.UseVisualStyleBackColor = true;
            this.buttonAcheter.Click += new System.EventHandler(this.buttonAcheter_Click);
            // 
            // buttonTableauBord
            // 
            this.buttonTableauBord.Location = new System.Drawing.Point(12, 161);
            this.buttonTableauBord.Name = "buttonTableauBord";
            this.buttonTableauBord.Size = new System.Drawing.Size(117, 54);
            this.buttonTableauBord.TabIndex = 5;
            this.buttonTableauBord.Text = "Tableau de bord";
            this.buttonTableauBord.UseVisualStyleBackColor = true;
            this.buttonTableauBord.Click += new System.EventHandler(this.buttonTableauBord_Click);
            // 
            // buttonEquipe
            // 
            this.buttonEquipe.Location = new System.Drawing.Point(12, 101);
            this.buttonEquipe.Name = "buttonEquipe";
            this.buttonEquipe.Size = new System.Drawing.Size(117, 54);
            this.buttonEquipe.TabIndex = 6;
            this.buttonEquipe.Text = "Équipe";
            this.buttonEquipe.UseVisualStyleBackColor = true;
            this.buttonEquipe.Click += new System.EventHandler(this.buttonEquipe_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.buttonEquipe);
            this.Controls.Add(this.buttonTableauBord);
            this.Controls.Add(this.buttonAcheter);
            this.Controls.Add(this.buttonJouer);
            this.Controls.Add(this.buttonTournois);
            this.Controls.Add(this.labelPong);
            this.Controls.Add(this.buttonJoueur);
            this.Name = "FormPrincipal";
            this.Text = "PONG!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonJoueur;
        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Button buttonTournois;
        private System.Windows.Forms.Button buttonJouer;
        private System.Windows.Forms.Button buttonAcheter;
        private System.Windows.Forms.Button buttonTableauBord;
        private System.Windows.Forms.Button buttonEquipe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

