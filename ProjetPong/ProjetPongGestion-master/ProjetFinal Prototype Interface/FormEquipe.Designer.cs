namespace ProjetFinal_Prototype_Interface
{
    partial class FormEquipe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.textBoxNomEquipe = new System.Windows.Forms.TextBox();
            this.labelDescriptionEquipe = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonRejoindreEquipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelNomEquipe
            // 
            this.labelNomEquipe.AutoSize = true;
            this.labelNomEquipe.Location = new System.Drawing.Point(12, 232);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(89, 13);
            this.labelNomEquipe.TabIndex = 1;
            this.labelNomEquipe.Text = "Nom de l\'équipe: ";
            // 
            // textBoxNomEquipe
            // 
            this.textBoxNomEquipe.Location = new System.Drawing.Point(107, 229);
            this.textBoxNomEquipe.Name = "textBoxNomEquipe";
            this.textBoxNomEquipe.ReadOnly = true;
            this.textBoxNomEquipe.Size = new System.Drawing.Size(264, 20);
            this.textBoxNomEquipe.TabIndex = 2;
            // 
            // labelDescriptionEquipe
            // 
            this.labelDescriptionEquipe.AutoSize = true;
            this.labelDescriptionEquipe.Location = new System.Drawing.Point(12, 262);
            this.labelDescriptionEquipe.Name = "labelDescriptionEquipe";
            this.labelDescriptionEquipe.Size = new System.Drawing.Size(63, 13);
            this.labelDescriptionEquipe.TabIndex = 3;
            this.labelDescriptionEquipe.Text = "Description:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 262);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(264, 71);
            this.textBox2.TabIndex = 4;
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(248, 348);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(123, 23);
            this.buttonStats.TabIndex = 5;
            this.buttonStats.Text = "Statistiques de l\'équipe";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonRejoindreEquipe
            // 
            this.buttonRejoindreEquipe.Location = new System.Drawing.Point(123, 348);
            this.buttonRejoindreEquipe.Name = "buttonRejoindreEquipe";
            this.buttonRejoindreEquipe.Size = new System.Drawing.Size(119, 23);
            this.buttonRejoindreEquipe.TabIndex = 6;
            this.buttonRejoindreEquipe.Text = "Rejoindre une équipe";
            this.buttonRejoindreEquipe.UseVisualStyleBackColor = true;
            this.buttonRejoindreEquipe.Click += new System.EventHandler(this.buttonRejoindreEquipe_Click);
            // 
            // FormEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 383);
            this.Controls.Add(this.buttonRejoindreEquipe);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelDescriptionEquipe);
            this.Controls.Add(this.textBoxNomEquipe);
            this.Controls.Add(this.labelNomEquipe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEquipe";
            this.Text = "Votre équipe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.TextBox textBoxNomEquipe;
        private System.Windows.Forms.Label labelDescriptionEquipe;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonRejoindreEquipe;
    }
}