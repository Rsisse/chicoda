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
            this.radBtn_A = new System.Windows.Forms.RadioButton();
            this.radBtn_B = new System.Windows.Forms.RadioButton();
            this.radBtn_C = new System.Windows.Forms.RadioButton();
            this.radBtn_D = new System.Windows.Forms.RadioButton();
            this.grpBox_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(342, 116);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(49, 13);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Question";
            // 
            // grpBox_1
            // 
            this.grpBox_1.Controls.Add(this.radBtn_D);
            this.grpBox_1.Controls.Add(this.radBtn_C);
            this.grpBox_1.Controls.Add(this.radBtn_B);
            this.grpBox_1.Controls.Add(this.radBtn_A);
            this.grpBox_1.Location = new System.Drawing.Point(129, 155);
            this.grpBox_1.Name = "grpBox_1";
            this.grpBox_1.Size = new System.Drawing.Size(452, 264);
            this.grpBox_1.TabIndex = 1;
            this.grpBox_1.TabStop = false;
            this.grpBox_1.Text = "Réponses";
            // 
            // radBtn_A
            // 
            this.radBtn_A.AutoSize = true;
            this.radBtn_A.Location = new System.Drawing.Point(33, 49);
            this.radBtn_A.Name = "radBtn_A";
            this.radBtn_A.Size = new System.Drawing.Size(69, 17);
            this.radBtn_A.TabIndex = 0;
            this.radBtn_A.TabStop = true;
            this.radBtn_A.Text = "radBtn_A";
            this.radBtn_A.UseVisualStyleBackColor = true;
            // 
            // radBtn_B
            // 
            this.radBtn_B.AutoSize = true;
            this.radBtn_B.Location = new System.Drawing.Point(33, 81);
            this.radBtn_B.Name = "radBtn_B";
            this.radBtn_B.Size = new System.Drawing.Size(14, 13);
            this.radBtn_B.TabIndex = 1;
            this.radBtn_B.TabStop = true;
            this.radBtn_B.UseVisualStyleBackColor = true;
            // 
            // radBtn_C
            // 
            this.radBtn_C.AutoSize = true;
            this.radBtn_C.Location = new System.Drawing.Point(33, 116);
            this.radBtn_C.Name = "radBtn_C";
            this.radBtn_C.Size = new System.Drawing.Size(85, 17);
            this.radBtn_C.TabIndex = 2;
            this.radBtn_C.TabStop = true;
            this.radBtn_C.Text = "radioButton3";
            this.radBtn_C.UseVisualStyleBackColor = true;
            // 
            // radBtn_D
            // 
            this.radBtn_D.AutoSize = true;
            this.radBtn_D.Location = new System.Drawing.Point(33, 152);
            this.radBtn_D.Name = "radBtn_D";
            this.radBtn_D.Size = new System.Drawing.Size(85, 17);
            this.radBtn_D.TabIndex = 3;
            this.radBtn_D.TabStop = true;
            this.radBtn_D.Text = "radioButton4";
            this.radBtn_D.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 514);
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
        private System.Windows.Forms.RadioButton radBtn_D;
        private System.Windows.Forms.RadioButton radBtn_C;
        private System.Windows.Forms.RadioButton radBtn_B;
        private System.Windows.Forms.RadioButton radBtn_A;
    }
}

