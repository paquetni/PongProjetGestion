namespace ProjetFinal_Prototype_Interface
{
    partial class FormInscriptionTournoi
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
            this.dataGridViewTournois = new System.Windows.Forms.DataGridView();
            this.buttonRejoindre = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.labelPong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournois)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTournois
            // 
            this.dataGridViewTournois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournois.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTournois.Name = "dataGridViewTournois";
            this.dataGridViewTournois.Size = new System.Drawing.Size(465, 213);
            this.dataGridViewTournois.TabIndex = 0;
            // 
            // buttonRejoindre
            // 
            this.buttonRejoindre.Location = new System.Drawing.Point(12, 226);
            this.buttonRejoindre.Name = "buttonRejoindre";
            this.buttonRejoindre.Size = new System.Drawing.Size(116, 23);
            this.buttonRejoindre.TabIndex = 1;
            this.buttonRejoindre.Text = "Rejoindre un tournoi";
            this.buttonRejoindre.UseVisualStyleBackColor = true;
            this.buttonRejoindre.Click += new System.EventHandler(this.buttonRejoindre_Click);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(134, 226);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(100, 23);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Créer un tournoi";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(240, 213);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(225, 49);
            this.labelPong.TabIndex = 3;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInscriptionTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.labelPong);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonRejoindre);
            this.Controls.Add(this.dataGridViewTournois);
            this.Name = "FormInscriptionTournoi";
            this.Text = "Tournois";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournois)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTournois;
        private System.Windows.Forms.Button buttonRejoindre;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Label labelPong;
    }
}