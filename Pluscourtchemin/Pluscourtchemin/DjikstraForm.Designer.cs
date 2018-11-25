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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxEntrerNoeud = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelNoeud = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(35, 349);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(122, 251);
            this.listBoxgraphe.TabIndex = 10;
            // 
            // txtBox_Open
            // 
            this.txtBox_Open.Location = new System.Drawing.Point(86, 71);
            this.txtBox_Open.Name = "txtBox_Open";
            this.txtBox_Open.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Open.TabIndex = 13;
            // 
            // txtBox_Closed
            // 
            this.txtBox_Closed.Location = new System.Drawing.Point(86, 33);
            this.txtBox_Closed.Name = "txtBox_Closed";
            this.txtBox_Closed.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Closed.TabIndex = 12;
            // 
            // lbl_Open
            // 
            this.lbl_Open.AutoSize = true;
            this.lbl_Open.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Open.Location = new System.Drawing.Point(4, 71);
            this.lbl_Open.Name = "lbl_Open";
            this.lbl_Open.Size = new System.Drawing.Size(76, 24);
            this.lbl_Open.TabIndex = 13;
            this.lbl_Open.Text = "Ouvert :";
            // 
            // lbl_Closed
            // 
            this.lbl_Closed.AutoSize = true;
            this.lbl_Closed.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Closed.Location = new System.Drawing.Point(6, 28);
            this.lbl_Closed.Name = "lbl_Closed";
            this.lbl_Closed.Size = new System.Drawing.Size(74, 24);
            this.lbl_Closed.TabIndex = 14;
            this.lbl_Closed.Text = "Fermé :";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(52, 114);
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
            this.lbl_F.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F.Location = new System.Drawing.Point(70, 33);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(37, 18);
            this.lbl_F.TabIndex = 17;
            this.lbl_F.Text = "F={}";
            // 
            // lbl_O
            // 
            this.lbl_O.AutoSize = true;
            this.lbl_O.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_O.Location = new System.Drawing.Point(70, 77);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(45, 18);
            this.lbl_O.TabIndex = 18;
            this.lbl_O.Text = "O={1}";
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(52, 114);
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
            this.label1.Size = new System.Drawing.Size(940, 95);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 331);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Closed);
            this.groupBox1.Controls.Add(this.txtBox_Open);
            this.groupBox1.Controls.Add(this.txtBox_Closed);
            this.groupBox1.Controls.Add(this.btn_End);
            this.groupBox1.Controls.Add(this.lbl_Open);
            this.groupBox1.Controls.Add(this.btn_Next);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(266, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 181);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A remplir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_F);
            this.groupBox2.Controls.Add(this.lbl_O);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(574, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 181);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Correction";
            // 
            // buttonValider
            // 
            this.buttonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonValider.Location = new System.Drawing.Point(407, 255);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(110, 40);
            this.buttonValider.TabIndex = 29;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxEntrerNoeud
            // 
            this.textBoxEntrerNoeud.Location = new System.Drawing.Point(407, 146);
            this.textBoxEntrerNoeud.Name = "textBoxEntrerNoeud";
            this.textBoxEntrerNoeud.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntrerNoeud.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Controls.Add(this.labelNoeud);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxEntrerNoeud);
            this.groupBox3.Controls.Add(this.buttonValider);
            this.groupBox3.Location = new System.Drawing.Point(815, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 329);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // labelNoeud
            // 
            this.labelNoeud.AutoSize = true;
            this.labelNoeud.Location = new System.Drawing.Point(465, 113);
            this.labelNoeud.Name = "labelNoeud";
            this.labelNoeud.Size = new System.Drawing.Size(18, 13);
            this.labelNoeud.TabIndex = 32;
            this.labelNoeud.Text = "sd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Entrez le noeud correspondant à";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(49, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(206, 226);
            this.treeView1.TabIndex = 33;
            // 
            // DjikstraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_InfoReponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxgraphe);
            this.Name = "DjikstraForm";
            this.Text = "DjikstraForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxEntrerNoeud;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelNoeud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeView1;
    }
}