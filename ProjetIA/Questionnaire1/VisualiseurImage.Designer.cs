﻿namespace Questionnaire1
{
    partial class VisualiseurImage
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
            this.pictureBox_ImageQuestion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ImageQuestion
            // 
            this.pictureBox_ImageQuestion.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ImageQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_ImageQuestion.Name = "pictureBox_ImageQuestion";
            this.pictureBox_ImageQuestion.Size = new System.Drawing.Size(440, 330);
            this.pictureBox_ImageQuestion.TabIndex = 0;
            this.pictureBox_ImageQuestion.TabStop = false;
            // 
            // VisualiseurImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 327);
            this.Controls.Add(this.pictureBox_ImageQuestion);
            this.Location = new System.Drawing.Point(1158, 200);
            this.Name = "VisualiseurImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VisualiseurImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ImageQuestion;
    }
}