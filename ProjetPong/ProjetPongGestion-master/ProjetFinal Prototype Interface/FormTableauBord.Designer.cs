namespace ProjetFinal_Prototype_Interface
{
    partial class FormTableauBord
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
            this.labelActif = new System.Windows.Forms.Label();
            this.labelActuellement = new System.Windows.Forms.Label();
            this.labelMois = new System.Windows.Forms.Label();
            this.label7j = new System.Windows.Forms.Label();
            this.label24h = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.labelVie = new System.Windows.Forms.Label();
            this.labelNbEquipesActives = new System.Windows.Forms.Label();
            this.labelNbPartiesJouées = new System.Windows.Forms.Label();
            this.dataGridViewPerformances = new System.Windows.Forms.DataGridView();
            this.labelPerformances = new System.Windows.Forms.Label();
            this.labelActuellementResultat = new System.Windows.Forms.Label();
            this.labelNbPartiesTotalesResultat = new System.Windows.Forms.Label();
            this.labelNbEquipesActivesResultat = new System.Windows.Forms.Label();
            this.labelVieResultat = new System.Windows.Forms.Label();
            this.labelAnneeResultat = new System.Windows.Forms.Label();
            this.labelMoisResultat = new System.Windows.Forms.Label();
            this.label7jResultat = new System.Windows.Forms.Label();
            this.label24hResultat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformances)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-2, 0);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(595, 39);
            this.labelPong.TabIndex = 5;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActif
            // 
            this.labelActif.AutoSize = true;
            this.labelActif.Location = new System.Drawing.Point(12, 49);
            this.labelActif.Name = "labelActif";
            this.labelActif.Size = new System.Drawing.Size(75, 13);
            this.labelActif.TabIndex = 6;
            this.labelActif.Text = "Joueurs actifs:";
            // 
            // labelActuellement
            // 
            this.labelActuellement.AutoSize = true;
            this.labelActuellement.Location = new System.Drawing.Point(12, 81);
            this.labelActuellement.Name = "labelActuellement";
            this.labelActuellement.Size = new System.Drawing.Size(71, 13);
            this.labelActuellement.TabIndex = 7;
            this.labelActuellement.Text = "Actuellement:";
            // 
            // labelMois
            // 
            this.labelMois.AutoSize = true;
            this.labelMois.Location = new System.Drawing.Point(12, 166);
            this.labelMois.Name = "labelMois";
            this.labelMois.Size = new System.Drawing.Size(32, 13);
            this.labelMois.TabIndex = 8;
            this.labelMois.Text = "Mois:";
            // 
            // label7j
            // 
            this.label7j.AutoSize = true;
            this.label7j.Location = new System.Drawing.Point(12, 137);
            this.label7j.Name = "label7j";
            this.label7j.Size = new System.Drawing.Size(41, 13);
            this.label7j.TabIndex = 9;
            this.label7j.Text = "7 jours:";
            // 
            // label24h
            // 
            this.label24h.AutoSize = true;
            this.label24h.Location = new System.Drawing.Point(12, 109);
            this.label24h.Name = "label24h";
            this.label24h.Size = new System.Drawing.Size(28, 13);
            this.label24h.TabIndex = 10;
            this.label24h.Text = "24h:";
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Location = new System.Drawing.Point(12, 199);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(41, 13);
            this.labelAnnee.TabIndex = 11;
            this.labelAnnee.Text = "Année:";
            // 
            // labelVie
            // 
            this.labelVie.AutoSize = true;
            this.labelVie.Location = new System.Drawing.Point(12, 228);
            this.labelVie.Name = "labelVie";
            this.labelVie.Size = new System.Drawing.Size(25, 13);
            this.labelVie.TabIndex = 12;
            this.labelVie.Text = "Vie:";
            // 
            // labelNbEquipesActives
            // 
            this.labelNbEquipesActives.AutoSize = true;
            this.labelNbEquipesActives.Location = new System.Drawing.Point(368, 49);
            this.labelNbEquipesActives.Name = "labelNbEquipesActives";
            this.labelNbEquipesActives.Size = new System.Drawing.Size(132, 13);
            this.labelNbEquipesActives.TabIndex = 13;
            this.labelNbEquipesActives.Text = "Nombre d\'équipes actives:";
            // 
            // labelNbPartiesJouées
            // 
            this.labelNbPartiesJouées.Location = new System.Drawing.Point(368, 109);
            this.labelNbPartiesJouées.Name = "labelNbPartiesJouées";
            this.labelNbPartiesJouées.Size = new System.Drawing.Size(100, 30);
            this.labelNbPartiesJouées.TabIndex = 14;
            this.labelNbPartiesJouées.Text = "Nombre de parties jouées au total:";
            // 
            // dataGridViewPerformances
            // 
            this.dataGridViewPerformances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerformances.Location = new System.Drawing.Point(12, 258);
            this.dataGridViewPerformances.Name = "dataGridViewPerformances";
            this.dataGridViewPerformances.Size = new System.Drawing.Size(568, 173);
            this.dataGridViewPerformances.TabIndex = 15;
            // 
            // labelPerformances
            // 
            this.labelPerformances.AutoSize = true;
            this.labelPerformances.Location = new System.Drawing.Point(234, 242);
            this.labelPerformances.Name = "labelPerformances";
            this.labelPerformances.Size = new System.Drawing.Size(124, 13);
            this.labelPerformances.TabIndex = 16;
            this.labelPerformances.Text = "Meilleures performances:";
            // 
            // labelActuellementResultat
            // 
            this.labelActuellementResultat.AutoSize = true;
            this.labelActuellementResultat.Location = new System.Drawing.Point(89, 81);
            this.labelActuellementResultat.Name = "labelActuellementResultat";
            this.labelActuellementResultat.Size = new System.Drawing.Size(13, 13);
            this.labelActuellementResultat.TabIndex = 17;
            this.labelActuellementResultat.Text = "0";
            // 
            // labelNbPartiesTotalesResultat
            // 
            this.labelNbPartiesTotalesResultat.AutoSize = true;
            this.labelNbPartiesTotalesResultat.Location = new System.Drawing.Point(474, 126);
            this.labelNbPartiesTotalesResultat.Name = "labelNbPartiesTotalesResultat";
            this.labelNbPartiesTotalesResultat.Size = new System.Drawing.Size(13, 13);
            this.labelNbPartiesTotalesResultat.TabIndex = 18;
            this.labelNbPartiesTotalesResultat.Text = "0";
            // 
            // labelNbEquipesActivesResultat
            // 
            this.labelNbEquipesActivesResultat.AutoSize = true;
            this.labelNbEquipesActivesResultat.Location = new System.Drawing.Point(506, 49);
            this.labelNbEquipesActivesResultat.Name = "labelNbEquipesActivesResultat";
            this.labelNbEquipesActivesResultat.Size = new System.Drawing.Size(13, 13);
            this.labelNbEquipesActivesResultat.TabIndex = 19;
            this.labelNbEquipesActivesResultat.Text = "0";
            // 
            // labelVieResultat
            // 
            this.labelVieResultat.AutoSize = true;
            this.labelVieResultat.Location = new System.Drawing.Point(43, 228);
            this.labelVieResultat.Name = "labelVieResultat";
            this.labelVieResultat.Size = new System.Drawing.Size(13, 13);
            this.labelVieResultat.TabIndex = 20;
            this.labelVieResultat.Text = "0";
            // 
            // labelAnneeResultat
            // 
            this.labelAnneeResultat.AutoSize = true;
            this.labelAnneeResultat.Location = new System.Drawing.Point(59, 199);
            this.labelAnneeResultat.Name = "labelAnneeResultat";
            this.labelAnneeResultat.Size = new System.Drawing.Size(13, 13);
            this.labelAnneeResultat.TabIndex = 21;
            this.labelAnneeResultat.Text = "0";
            // 
            // labelMoisResultat
            // 
            this.labelMoisResultat.AutoSize = true;
            this.labelMoisResultat.Location = new System.Drawing.Point(50, 166);
            this.labelMoisResultat.Name = "labelMoisResultat";
            this.labelMoisResultat.Size = new System.Drawing.Size(13, 13);
            this.labelMoisResultat.TabIndex = 22;
            this.labelMoisResultat.Text = "0";
            // 
            // label7jResultat
            // 
            this.label7jResultat.AutoSize = true;
            this.label7jResultat.Location = new System.Drawing.Point(59, 137);
            this.label7jResultat.Name = "label7jResultat";
            this.label7jResultat.Size = new System.Drawing.Size(13, 13);
            this.label7jResultat.TabIndex = 23;
            this.label7jResultat.Text = "0";
            // 
            // label24hResultat
            // 
            this.label24hResultat.AutoSize = true;
            this.label24hResultat.Location = new System.Drawing.Point(46, 109);
            this.label24hResultat.Name = "label24hResultat";
            this.label24hResultat.Size = new System.Drawing.Size(13, 13);
            this.label24hResultat.TabIndex = 24;
            this.label24hResultat.Text = "0";
            // 
            // FormTableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 443);
            this.Controls.Add(this.label24hResultat);
            this.Controls.Add(this.label7jResultat);
            this.Controls.Add(this.labelMoisResultat);
            this.Controls.Add(this.labelAnneeResultat);
            this.Controls.Add(this.labelVieResultat);
            this.Controls.Add(this.labelNbEquipesActivesResultat);
            this.Controls.Add(this.labelNbPartiesTotalesResultat);
            this.Controls.Add(this.labelActuellementResultat);
            this.Controls.Add(this.labelPerformances);
            this.Controls.Add(this.dataGridViewPerformances);
            this.Controls.Add(this.labelNbPartiesJouées);
            this.Controls.Add(this.labelNbEquipesActives);
            this.Controls.Add(this.labelVie);
            this.Controls.Add(this.labelAnnee);
            this.Controls.Add(this.label24h);
            this.Controls.Add(this.label7j);
            this.Controls.Add(this.labelMois);
            this.Controls.Add(this.labelActuellement);
            this.Controls.Add(this.labelActif);
            this.Controls.Add(this.labelPong);
            this.Name = "FormTableauBord";
            this.Text = "Tableau de bord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Label labelActif;
        private System.Windows.Forms.Label labelActuellement;
        private System.Windows.Forms.Label labelMois;
        private System.Windows.Forms.Label label7j;
        private System.Windows.Forms.Label label24h;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.Label labelVie;
        private System.Windows.Forms.Label labelNbEquipesActives;
        private System.Windows.Forms.Label labelNbPartiesJouées;
        private System.Windows.Forms.DataGridView dataGridViewPerformances;
        private System.Windows.Forms.Label labelPerformances;
        private System.Windows.Forms.Label labelActuellementResultat;
        private System.Windows.Forms.Label labelNbPartiesTotalesResultat;
        private System.Windows.Forms.Label labelNbEquipesActivesResultat;
        private System.Windows.Forms.Label labelVieResultat;
        private System.Windows.Forms.Label labelAnneeResultat;
        private System.Windows.Forms.Label labelMoisResultat;
        private System.Windows.Forms.Label label7jResultat;
        private System.Windows.Forms.Label label24hResultat;
    }
}