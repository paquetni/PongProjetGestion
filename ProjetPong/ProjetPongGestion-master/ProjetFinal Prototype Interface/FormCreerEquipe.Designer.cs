namespace ProjetFinal_Prototype_Interface
{
    partial class FormCreerEquipe
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
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.textBoxNomEquipe = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPong
            // 
            this.labelPong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPong.ForeColor = System.Drawing.Color.Yellow;
            this.labelPong.Location = new System.Drawing.Point(-3, -1);
            this.labelPong.Name = "labelPong";
            this.labelPong.Size = new System.Drawing.Size(287, 39);
            this.labelPong.TabIndex = 7;
            this.labelPong.Text = "PONG!";
            this.labelPong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNomEquipe
            // 
            this.labelNomEquipe.AutoSize = true;
            this.labelNomEquipe.Location = new System.Drawing.Point(12, 66);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(86, 13);
            this.labelNomEquipe.TabIndex = 8;
            this.labelNomEquipe.Text = "Nom de l\'équipe:";
            // 
            // textBoxNomEquipe
            // 
            this.textBoxNomEquipe.Location = new System.Drawing.Point(104, 63);
            this.textBoxNomEquipe.Name = "textBoxNomEquipe";
            this.textBoxNomEquipe.Size = new System.Drawing.Size(168, 20);
            this.textBoxNomEquipe.TabIndex = 9;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 100);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(104, 97);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(168, 113);
            this.textBoxDescription.TabIndex = 11;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(15, 226);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(257, 23);
            this.buttonCreer.TabIndex = 12;
            this.buttonCreer.Text = "Créer l\'équipe";
            this.buttonCreer.UseVisualStyleBackColor = true;
            // 
            // FormCreerEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxNomEquipe);
            this.Controls.Add(this.labelNomEquipe);
            this.Controls.Add(this.labelPong);
            this.Name = "FormCreerEquipe";
            this.Text = "FormCreerEquipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPong;
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.TextBox textBoxNomEquipe;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCreer;
    }
}