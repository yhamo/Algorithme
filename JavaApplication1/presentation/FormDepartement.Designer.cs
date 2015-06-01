namespace presentation
{
    partial class FormDepartement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartement));
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_generer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NomDep = new System.Windows.Forms.TextBox();
            this.tb_NumeroDep = new System.Windows.Forms.TextBox();
            this.rtb_DescDep = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.BackColor = System.Drawing.Color.White;
            this.btn_Fermer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fermer.Image")));
            this.btn_Fermer.Location = new System.Drawing.Point(943, 403);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(42, 34);
            this.btn_Fermer.TabIndex = 23;
            this.btn_Fermer.UseVisualStyleBackColor = false;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(858, 403);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(79, 34);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_generer
            // 
            this.btn_generer.BackColor = System.Drawing.Color.White;
            this.btn_generer.Image = ((System.Drawing.Image)(resources.GetObject("btn_generer.Image")));
            this.btn_generer.Location = new System.Drawing.Point(810, 403);
            this.btn_generer.Name = "btn_generer";
            this.btn_generer.Size = new System.Drawing.Size(42, 34);
            this.btn_generer.TabIndex = 21;
            this.btn_generer.UseVisualStyleBackColor = false;
            this.btn_generer.Click += new System.EventHandler(this.btn_generer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Le Numero Du Departement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Le Nom Du Département :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "La Description Du Département :";
            // 
            // tb_NomDep
            // 
            this.tb_NomDep.Location = new System.Drawing.Point(276, 65);
            this.tb_NomDep.Name = "tb_NomDep";
            this.tb_NomDep.Size = new System.Drawing.Size(183, 20);
            this.tb_NomDep.TabIndex = 27;
            // 
            // tb_NumeroDep
            // 
            this.tb_NumeroDep.Location = new System.Drawing.Point(872, 65);
            this.tb_NumeroDep.Name = "tb_NumeroDep";
            this.tb_NumeroDep.Size = new System.Drawing.Size(81, 20);
            this.tb_NumeroDep.TabIndex = 28;
            // 
            // rtb_DescDep
            // 
            this.rtb_DescDep.Location = new System.Drawing.Point(294, 169);
            this.rtb_DescDep.Name = "rtb_DescDep";
            this.rtb_DescDep.Size = new System.Drawing.Size(284, 268);
            this.rtb_DescDep.TabIndex = 29;
            this.rtb_DescDep.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "exemple :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 31;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(711, 184);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(294, 196);
            this.richTextBox2.TabIndex = 32;
            this.richTextBox2.Text = "";
            // 
            // FormDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 463);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_DescDep);
            this.Controls.Add(this.tb_NumeroDep);
            this.Controls.Add(this.tb_NomDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_generer);
            this.Name = "FormDepartement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_generer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NomDep;
        private System.Windows.Forms.TextBox tb_NumeroDep;
        private System.Windows.Forms.RichTextBox rtb_DescDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}