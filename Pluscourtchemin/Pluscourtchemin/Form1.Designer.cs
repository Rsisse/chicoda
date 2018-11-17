namespace Pluscourtchemin
{
    partial class Form1
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
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.buttonVal = new System.Windows.Forms.Button();
            this.labelO = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(213, 308);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 20);
            this.textBoxF.TabIndex = 0;
            // 
            // textBoxO
            // 
            this.textBoxO.Location = new System.Drawing.Point(696, 308);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(100, 20);
            this.textBoxO.TabIndex = 1;
            // 
            // buttonVal
            // 
            this.buttonVal.Location = new System.Drawing.Point(445, 378);
            this.buttonVal.Name = "buttonVal";
            this.buttonVal.Size = new System.Drawing.Size(75, 23);
            this.buttonVal.TabIndex = 2;
            this.buttonVal.Text = "Valider";
            this.buttonVal.UseVisualStyleBackColor = true;
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(242, 263);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(39, 13);
            this.labelO.TabIndex = 3;
            this.labelO.Text = "Ouvert";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(730, 263);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(36, 13);
            this.labelF.TabIndex = 4;
            this.labelF.Text = "Ferme";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(972, 544);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.buttonVal);
            this.Controls.Add(this.textBoxO);
            this.Controls.Add(this.textBoxF);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TextBox textBoxOuverts;
        private System.Windows.Forms.TextBox textBoxFerme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.Button buttonVal;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelF;
    }
}

