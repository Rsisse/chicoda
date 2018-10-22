namespace Questionnaire
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
            this.labelTest = new System.Windows.Forms.Label();
            this.grpBox_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(47, 59);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(94, 24);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Question";
            // 
            // grpBox_1
            // 
            this.grpBox_1.Controls.Add(this.radBtn_Rep3);
            this.grpBox_1.Controls.Add(this.radBtn_Rep2);
            this.grpBox_1.Controls.Add(this.radBtn_Rep1);
            this.grpBox_1.Location = new System.Drawing.Point(12, 279);
            this.grpBox_1.Name = "grpBox_1";
            this.grpBox_1.Size = new System.Drawing.Size(712, 146);
            this.grpBox_1.TabIndex = 1;
            this.grpBox_1.TabStop = false;
            this.grpBox_1.Text = "Réponses";
            // 
            // radBtn_Rep3
            // 
            this.radBtn_Rep3.AutoSize = true;
            this.radBtn_Rep3.Location = new System.Drawing.Point(33, 113);
            this.radBtn_Rep3.Name = "radBtn_Rep3";
            this.radBtn_Rep3.Size = new System.Drawing.Size(51, 17);
            this.radBtn_Rep3.TabIndex = 4;
            this.radBtn_Rep3.TabStop = true;
            this.radBtn_Rep3.Text = "Rep3";
            this.radBtn_Rep3.UseVisualStyleBackColor = true;
            // 
            // radBtn_Rep2
            // 
            this.radBtn_Rep2.AutoSize = true;
            this.radBtn_Rep2.Location = new System.Drawing.Point(33, 70);
            this.radBtn_Rep2.Name = "radBtn_Rep2";
            this.radBtn_Rep2.Size = new System.Drawing.Size(51, 17);
            this.radBtn_Rep2.TabIndex = 3;
            this.radBtn_Rep2.TabStop = true;
            this.radBtn_Rep2.Text = "Rep2";
            this.radBtn_Rep2.UseVisualStyleBackColor = true;
            // 
            // radBtn_Rep1
            // 
            this.radBtn_Rep1.AutoSize = true;
            this.radBtn_Rep1.Location = new System.Drawing.Point(33, 29);
            this.radBtn_Rep1.Name = "radBtn_Rep1";
            this.radBtn_Rep1.Size = new System.Drawing.Size(51, 17);
            this.radBtn_Rep1.TabIndex = 2;
            this.radBtn_Rep1.TabStop = true;
            this.radBtn_Rep1.Text = "Rep1";
            this.radBtn_Rep1.UseVisualStyleBackColor = true;
            // 
            // labelEnnoncé
            // 
            this.labelEnnoncé.AutoSize = true;
            this.labelEnnoncé.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnnoncé.Location = new System.Drawing.Point(93, 103);
            this.labelEnnoncé.Name = "labelEnnoncé";
            this.labelEnnoncé.Size = new System.Drawing.Size(107, 24);
            this.labelEnnoncé.TabIndex = 2;
            this.labelEnnoncé.Text = "Ennoncé :";
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifier.Location = new System.Drawing.Point(93, 146);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(73, 18);
            this.labelModifier.TabIndex = 3;
            this.labelModifier.Text = "Qmodifier";
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(317, 443);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(97, 32);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(96, 186);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 5;
            this.labelTest.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 482);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelModifier);
            this.Controls.Add(this.labelEnnoncé);
            this.Controls.Add(this.grpBox_1);
            this.Controls.Add(this.lbl_Question);
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
        private System.Windows.Forms.Label labelTest;
    }
}

