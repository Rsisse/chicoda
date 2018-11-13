namespace Questionnaire1
{
    partial class MainForm
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
            this.lbl_Question = new System.Windows.Forms.Label();
            this.grpBox_1 = new System.Windows.Forms.GroupBox();
            this.radBtn_Rep3 = new System.Windows.Forms.RadioButton();
            this.radBtn_Rep2 = new System.Windows.Forms.RadioButton();
            this.radBtn_Rep1 = new System.Windows.Forms.RadioButton();
            this.labelEnnoncé = new System.Windows.Forms.Label();
            this.labelModifier = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.labelReponse = new System.Windows.Forms.Label();
            this.labelBonneR = new System.Windows.Forms.Label();
            this.grpBox_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(12, 9);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(94, 24);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Question";
            // 
            // grpBox_1
            // 
            this.grpBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_1.Controls.Add(this.radBtn_Rep3);
            this.grpBox_1.Controls.Add(this.radBtn_Rep2);
            this.grpBox_1.Controls.Add(this.radBtn_Rep1);
            this.grpBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_1.Location = new System.Drawing.Point(16, 107);
            this.grpBox_1.Name = "grpBox_1";
            this.grpBox_1.Size = new System.Drawing.Size(770, 145);
            this.grpBox_1.TabIndex = 1;
            this.grpBox_1.TabStop = false;
            this.grpBox_1.Text = "Réponses";
            // 
            // radBtn_Rep3
            // 
            this.radBtn_Rep3.AutoSize = true;
            this.radBtn_Rep3.Location = new System.Drawing.Point(33, 113);
            this.radBtn_Rep3.Name = "radBtn_Rep3";
            this.radBtn_Rep3.Size = new System.Drawing.Size(33, 20);
            this.radBtn_Rep3.TabIndex = 3;
            this.radBtn_Rep3.TabStop = true;
            this.radBtn_Rep3.Text = "3";
            this.radBtn_Rep3.UseVisualStyleBackColor = true;
            // 
            // radBtn_Rep2
            // 
            this.radBtn_Rep2.AutoSize = true;
            this.radBtn_Rep2.Location = new System.Drawing.Point(33, 70);
            this.radBtn_Rep2.Name = "radBtn_Rep2";
            this.radBtn_Rep2.Size = new System.Drawing.Size(33, 20);
            this.radBtn_Rep2.TabIndex = 2;
            this.radBtn_Rep2.TabStop = true;
            this.radBtn_Rep2.Text = "2";
            this.radBtn_Rep2.UseVisualStyleBackColor = true;
            // 
            // radBtn_Rep1
            // 
            this.radBtn_Rep1.AutoSize = true;
            this.radBtn_Rep1.Location = new System.Drawing.Point(33, 29);
            this.radBtn_Rep1.Name = "radBtn_Rep1";
            this.radBtn_Rep1.Size = new System.Drawing.Size(33, 20);
            this.radBtn_Rep1.TabIndex = 1;
            this.radBtn_Rep1.TabStop = true;
            this.radBtn_Rep1.Text = "1";
            this.radBtn_Rep1.UseVisualStyleBackColor = true;
            // 
            // labelEnnoncé
            // 
            this.labelEnnoncé.AutoSize = true;
            this.labelEnnoncé.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnnoncé.Location = new System.Drawing.Point(24, 42);
            this.labelEnnoncé.Name = "labelEnnoncé";
            this.labelEnnoncé.Size = new System.Drawing.Size(107, 24);
            this.labelEnnoncé.TabIndex = 2;
            this.labelEnnoncé.Text = "Ennoncé :";
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifier.Location = new System.Drawing.Point(137, 48);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(73, 18);
            this.labelModifier.TabIndex = 3;
            this.labelModifier.Text = "Qmodifier";
            // 
            // buttonValider
            // 
            this.buttonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(373, 258);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(150, 32);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(627, 258);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(150, 32);
            this.buttonSuivant.TabIndex = 5;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // labelReponse
            // 
            this.labelReponse.AutoSize = true;
            this.labelReponse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReponse.Location = new System.Drawing.Point(815, 126);
            this.labelReponse.Name = "labelReponse";
            this.labelReponse.Size = new System.Drawing.Size(0, 17);
            this.labelReponse.TabIndex = 6;
            // 
            // labelBonneR
            // 
            this.labelBonneR.AutoSize = true;
            this.labelBonneR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonneR.Location = new System.Drawing.Point(815, 153);
            this.labelBonneR.Name = "labelBonneR";
            this.labelBonneR.Size = new System.Drawing.Size(0, 15);
            this.labelBonneR.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 316);
            this.Controls.Add(this.labelBonneR);
            this.Controls.Add(this.labelReponse);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelModifier);
            this.Controls.Add(this.labelEnnoncé);
            this.Controls.Add(this.grpBox_1);
            this.Controls.Add(this.lbl_Question);
            this.MaximumSize = new System.Drawing.Size(1158, 354);
            this.MinimumSize = new System.Drawing.Size(780, 354);
            this.Name = "MainForm";
            this.Text = "Questionnaire";
            this.grpBox_1.ResumeLayout(false);
            this.grpBox_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.GroupBox grpBox_1;
        private System.Windows.Forms.RadioButton radBtn_Rep2;
        private System.Windows.Forms.RadioButton radBtn_Rep1;
        private System.Windows.Forms.RadioButton radBtn_Rep3;
        private System.Windows.Forms.Label labelEnnoncé;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Label labelReponse;
        private System.Windows.Forms.Label labelBonneR;
    }
}

