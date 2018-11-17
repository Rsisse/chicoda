namespace Pluscourtchemin
{
    partial class DjikstraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DjikstraForm));
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.txtBox_Open = new System.Windows.Forms.TextBox();
            this.txtBox_Closed = new System.Windows.Forms.TextBox();
            this.lbl_Open = new System.Windows.Forms.Label();
            this.lbl_Closed = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_F = new System.Windows.Forms.Label();
            this.lbl_O = new System.Windows.Forms.Label();
            this.btn_End = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_InfoReponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(43, 276);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(122, 251);
            this.listBoxgraphe.TabIndex = 10;
            // 
            // txtBox_Open
            // 
            this.txtBox_Open.Location = new System.Drawing.Point(325, 428);
            this.txtBox_Open.Name = "txtBox_Open";
            this.txtBox_Open.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Open.TabIndex = 13;
            // 
            // txtBox_Closed
            // 
            this.txtBox_Closed.Location = new System.Drawing.Point(325, 390);
            this.txtBox_Closed.Name = "txtBox_Closed";
            this.txtBox_Closed.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Closed.TabIndex = 12;
            // 
            // lbl_Open
            // 
            this.lbl_Open.AutoSize = true;
            this.lbl_Open.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Open.Location = new System.Drawing.Point(243, 428);
            this.lbl_Open.Name = "lbl_Open";
            this.lbl_Open.Size = new System.Drawing.Size(76, 24);
            this.lbl_Open.TabIndex = 13;
            this.lbl_Open.Text = "Ouvert :";
            // 
            // lbl_Closed
            // 
            this.lbl_Closed.AutoSize = true;
            this.lbl_Closed.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Closed.Location = new System.Drawing.Point(245, 385);
            this.lbl_Closed.Name = "lbl_Closed";
            this.lbl_Closed.Size = new System.Drawing.Size(74, 24);
            this.lbl_Closed.TabIndex = 14;
            this.lbl_Closed.Text = "Fermé :";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(271, 483);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(121, 44);
            this.btn_Next.TabIndex = 15;
            this.btn_Next.Text = "Suivant";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_F
            // 
            this.lbl_F.AutoSize = true;
            this.lbl_F.Location = new System.Drawing.Point(257, 318);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(27, 13);
            this.lbl_F.TabIndex = 17;
            this.lbl_F.Text = "F={}";
            // 
            // lbl_O
            // 
            this.lbl_O.AutoSize = true;
            this.lbl_O.Location = new System.Drawing.Point(401, 318);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(35, 13);
            this.lbl_O.TabIndex = 18;
            this.lbl_O.Text = "O={1}";
            // 
            // btn_End
            // 
            this.btn_End.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_End.Location = new System.Drawing.Point(271, 483);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(121, 44);
            this.btn_End.TabIndex = 14;
            this.btn_End.Text = "Fin";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Visible = false;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(940, 76);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Graph à résoudre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "Question 21";
            // 
            // lbl_InfoReponse
            // 
            this.lbl_InfoReponse.AutoSize = true;
            this.lbl_InfoReponse.Location = new System.Drawing.Point(623, 385);
            this.lbl_InfoReponse.Name = "lbl_InfoReponse";
            this.lbl_InfoReponse.Size = new System.Drawing.Size(0, 13);
            this.lbl_InfoReponse.TabIndex = 24;
            // 
            // DjikstraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 600);
            this.Controls.Add(this.lbl_InfoReponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_O);
            this.Controls.Add(this.lbl_F);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lbl_Closed);
            this.Controls.Add(this.lbl_Open);
            this.Controls.Add(this.txtBox_Closed);
            this.Controls.Add(this.txtBox_Open);
            this.Controls.Add(this.listBoxgraphe);
            this.Name = "DjikstraForm";
            this.Text = "DjikstraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TextBox txtBox_Open;
        private System.Windows.Forms.TextBox txtBox_Closed;
        private System.Windows.Forms.Label lbl_Open;
        private System.Windows.Forms.Label lbl_Closed;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_F;
        private System.Windows.Forms.Label lbl_O;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_InfoReponse;
    }
}