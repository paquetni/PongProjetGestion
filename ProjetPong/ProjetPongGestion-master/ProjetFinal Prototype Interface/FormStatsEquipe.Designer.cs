namespace ProjetFinal_Prototype_Interface
{
    partial class FormStatsEquipe
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
            this.labelPointsTotaux = new System.Windows.Forms.Label();
            this.labelPointsTotauxResultat = new System.Windows.Forms.Label();
            this.labelScoreMax = new System.Windows.Forms.Label();
            this.labelScoreMaxResultat = new System.Windows.Forms.Label();
            this.labelScoreMin = new System.Windows.Forms.Label();
            this.labelScoreMinResultat = new System.Windows.Forms.Label();
            this.buttonQuitter = new System.Windows.Forms.Button();
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
            // labelPointsTotaux
            // 
            this.labelPointsTotaux.AutoSize = true;
            this.labelPointsTotaux.Location = new System.Drawing.Point(12, 63);
            this.labelPointsTotaux.Name = "labelPointsTotaux";
            this.labelPointsTotaux.Size = new System.Drawing.Size(151, 13);
            this.labelPointsTotaux.TabIndex = 6;
            this.labelPointsTotaux.Text = "Total des points pour l\'équipe: ";
            // 
            // labelPointsTotauxResultat
            // 
            this.labelPointsTotauxResultat.AutoSize = true;
            this.labelPointsTotauxResultat.Location = new System.Drawing.Point(169, 63);
            this.labelPointsTotauxResultat.Name = "labelPointsTotauxResultat";
            this.labelPointsTotauxResultat.Size = new System.Drawing.Size(64, 13);
            this.labelPointsTotauxResultat.TabIndex = 7;
            this.labelPointsTotauxResultat.Text = "Aucun point";
            // 
            // labelScoreMax
            // 
            this.labelScoreMax.AutoSize = true;
            this.labelScoreMax.Location = new System.Drawing.Point(12, 101);
            this.labelScoreMax.Name = "labelScoreMax";
            this.labelScoreMax.Size = new System.Drawing.Size(84, 13);
            this.labelScoreMax.TabIndex = 8;
            this.labelScoreMax.Text = "Score maximum:";
            // 
            // labelScoreMaxResultat
            // 
            this.labelScoreMaxResultat.AutoSize = true;
            this.labelScoreMaxResultat.Location = new System.Drawing.Point(169, 101);
            this.labelScoreMaxResultat.Name = "labelScoreMaxResultat";
            this.labelScoreMaxResultat.Size = new System.Drawing.Size(67, 13);
            this.labelScoreMaxResultat.TabIndex = 9;
            this.labelScoreMaxResultat.Text = "Aucun score";
            // 
            // labelScoreMin
            // 
            this.labelScoreMin.AutoSize = true;
            this.labelScoreMin.Location = new System.Drawing.Point(12, 135);
            this.labelScoreMin.Name = "labelScoreMin";
            this.labelScoreMin.Size = new System.Drawing.Size(81, 13);
            this.labelScoreMin.TabIndex = 10;
            this.labelScoreMin.Text = "Score minimum:";
            // 
            // labelScoreMinResultat
            // 
            this.labelScoreMinResultat.AutoSize = true;
            this.labelScoreMinResultat.Location = new System.Drawing.Point(169, 135);
            this.labelScoreMinResultat.Name = "labelScoreMinResultat";
            this.labelScoreMinResultat.Size = new System.Drawing.Size(67, 13);
            this.labelScoreMinResultat.TabIndex = 11;
            this.labelScoreMinResultat.Text = "Aucun score";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(15, 169);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(257, 23);
            this.buttonQuitter.TabIndex = 12;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FormStatsEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.labelScoreMinResultat);
            this.Controls.Add(this.labelScoreMin);
            this.Controls.Add(this.labelScoreMaxResultat);
            this.Controls.Add(this.labelScoreMax);
            this.Controls.Add(this.labelPointsTotauxResultat);
            this.Controls.Add(this.labelPointsTotaux);
            this.Controls.Add(this.labelPong);
            this.Name = "FormStatsEquipe";
            this.Text = "Stats de votre équipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Label labelPointsTotaux;
        private System.Windows.Forms.Label labelPointsTotauxResultat;
        private System.Windows.Forms.Label labelScoreMax;
        private System.Windows.Forms.Label labelScoreMaxResultat;
        private System.Windows.Forms.Label labelScoreMin;
        private System.Windows.Forms.Label labelScoreMinResultat;
        private System.Windows.Forms.Button buttonQuitter;
    }
}