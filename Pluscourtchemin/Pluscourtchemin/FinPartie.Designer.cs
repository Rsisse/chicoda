namespace Pluscourtchemin
{
    partial class FinPartie
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
            this.labelPartieFinie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonRecommencer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPartieFinie
            // 
            this.labelPartieFinie.AutoSize = true;
            this.labelPartieFinie.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartieFinie.Location = new System.Drawing.Point(68, 30);
            this.labelPartieFinie.Name = "labelPartieFinie";
            this.labelPartieFinie.Size = new System.Drawing.Size(214, 36);
            this.labelPartieFinie.TabIndex = 0;
            this.labelPartieFinie.Text = "La partie est finie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre Score est de :";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(150, 110);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score";
            // 
            // buttonRecommencer
            // 
            this.buttonRecommencer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRecommencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecommencer.Location = new System.Drawing.Point(103, 158);
            this.buttonRecommencer.Name = "buttonRecommencer";
            this.buttonRecommencer.Size = new System.Drawing.Size(139, 36);
            this.buttonRecommencer.TabIndex = 3;
            this.buttonRecommencer.Text = "Recommencer";
            this.buttonRecommencer.UseVisualStyleBackColor = true;
            this.buttonRecommencer.Click += new System.EventHandler(this.buttonRecommencer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(103, 219);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(139, 36);
            this.buttonQuitter.TabIndex = 4;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FinPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 267);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonRecommencer);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPartieFinie);
            this.Name = "FinPartie";
            this.Text = "FinPartie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPartieFinie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonRecommencer;
        private System.Windows.Forms.Button buttonQuitter;
    }
}