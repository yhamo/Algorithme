namespace presentation
{
    partial class FormVille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVille));
            this.lbl_Ville = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Departement = new System.Windows.Forms.Label();
            this.lbl_TelFixe = new System.Windows.Forms.Label();
            this.lbl_Port1 = new System.Windows.Forms.Label();
            this.lbl_Port2 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Ville = new System.Windows.Forms.TextBox();
            this.txt_CodePostal = new System.Windows.Forms.TextBox();
            this.txt_TelFixe = new System.Windows.Forms.TextBox();
            this.txt_Port1 = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Port2 = new System.Windows.Forms.TextBox();
            this.lbl_AixMarseille = new System.Windows.Forms.Label();
            this.lbl_SelectDep = new System.Windows.Forms.Label();
            this.cb_Dep = new System.Windows.Forms.ComboBox();
            this.lbl_UrlP = new System.Windows.Forms.Label();
            this.lbl_UrlE = new System.Windows.Forms.Label();
            this.txt_UrlP = new System.Windows.Forms.TextBox();
            this.txt_UrlE = new System.Windows.Forms.TextBox();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_generer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ville
            // 
            this.lbl_Ville.AutoSize = true;
            this.lbl_Ville.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville.Location = new System.Drawing.Point(129, 221);
            this.lbl_Ville.Name = "lbl_Ville";
            this.lbl_Ville.Size = new System.Drawing.Size(72, 25);
            this.lbl_Ville.TabIndex = 0;
            this.lbl_Ville.Text = "Ville  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Région  :";
            // 
            // lbl_Departement
            // 
            this.lbl_Departement.AutoSize = true;
            this.lbl_Departement.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Departement.Location = new System.Drawing.Point(66, 257);
            this.lbl_Departement.Name = "lbl_Departement";
            this.lbl_Departement.Size = new System.Drawing.Size(135, 25);
            this.lbl_Departement.TabIndex = 2;
            this.lbl_Departement.Text = "Code Postal :";
            // 
            // lbl_TelFixe
            // 
            this.lbl_TelFixe.AutoSize = true;
            this.lbl_TelFixe.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelFixe.Location = new System.Drawing.Point(96, 296);
            this.lbl_TelFixe.Name = "lbl_TelFixe";
            this.lbl_TelFixe.Size = new System.Drawing.Size(105, 25);
            this.lbl_TelFixe.TabIndex = 3;
            this.lbl_TelFixe.Text = "Tél Fixe  :";
            // 
            // lbl_Port1
            // 
            this.lbl_Port1.AutoSize = true;
            this.lbl_Port1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Port1.Location = new System.Drawing.Point(80, 334);
            this.lbl_Port1.Name = "lbl_Port1";
            this.lbl_Port1.Size = new System.Drawing.Size(121, 25);
            this.lbl_Port1.TabIndex = 4;
            this.lbl_Port1.Text = "Portable 1 :";
            // 
            // lbl_Port2
            // 
            this.lbl_Port2.AutoSize = true;
            this.lbl_Port2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Port2.Location = new System.Drawing.Point(80, 373);
            this.lbl_Port2.Name = "lbl_Port2";
            this.lbl_Port2.Size = new System.Drawing.Size(121, 25);
            this.lbl_Port2.TabIndex = 5;
            this.lbl_Port2.Text = "Portable 2 :";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(117, 412);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(84, 25);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email  :";
            // 
            // txt_Ville
            // 
            this.txt_Ville.Location = new System.Drawing.Point(232, 221);
            this.txt_Ville.Name = "txt_Ville";
            this.txt_Ville.Size = new System.Drawing.Size(169, 20);
            this.txt_Ville.TabIndex = 9;
            // 
            // txt_CodePostal
            // 
            this.txt_CodePostal.Location = new System.Drawing.Point(232, 262);
            this.txt_CodePostal.Name = "txt_CodePostal";
            this.txt_CodePostal.Size = new System.Drawing.Size(100, 20);
            this.txt_CodePostal.TabIndex = 11;
            // 
            // txt_TelFixe
            // 
            this.txt_TelFixe.Location = new System.Drawing.Point(232, 301);
            this.txt_TelFixe.Name = "txt_TelFixe";
            this.txt_TelFixe.Size = new System.Drawing.Size(100, 20);
            this.txt_TelFixe.TabIndex = 12;
            // 
            // txt_Port1
            // 
            this.txt_Port1.Location = new System.Drawing.Point(232, 339);
            this.txt_Port1.Name = "txt_Port1";
            this.txt_Port1.Size = new System.Drawing.Size(100, 20);
            this.txt_Port1.TabIndex = 13;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(232, 417);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(207, 20);
            this.txt_Email.TabIndex = 15;
            // 
            // txt_Port2
            // 
            this.txt_Port2.Location = new System.Drawing.Point(232, 378);
            this.txt_Port2.Name = "txt_Port2";
            this.txt_Port2.Size = new System.Drawing.Size(100, 20);
            this.txt_Port2.TabIndex = 14;
            // 
            // lbl_AixMarseille
            // 
            this.lbl_AixMarseille.AutoSize = true;
            this.lbl_AixMarseille.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AixMarseille.Location = new System.Drawing.Point(543, 35);
            this.lbl_AixMarseille.Name = "lbl_AixMarseille";
            this.lbl_AixMarseille.Size = new System.Drawing.Size(391, 33);
            this.lbl_AixMarseille.TabIndex = 23;
            this.lbl_AixMarseille.Text = "Générateur pour page des villes";
            this.lbl_AixMarseille.Visible = false;
            // 
            // lbl_SelectDep
            // 
            this.lbl_SelectDep.AutoSize = true;
            this.lbl_SelectDep.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectDep.Location = new System.Drawing.Point(4, 115);
            this.lbl_SelectDep.Name = "lbl_SelectDep";
            this.lbl_SelectDep.Size = new System.Drawing.Size(293, 25);
            this.lbl_SelectDep.TabIndex = 26;
            this.lbl_SelectDep.Text = "Selectionner le Département :";
            // 
            // cb_Dep
            // 
            this.cb_Dep.FormattingEnabled = true;
            this.cb_Dep.Location = new System.Drawing.Point(318, 119);
            this.cb_Dep.Name = "cb_Dep";
            this.cb_Dep.Size = new System.Drawing.Size(121, 21);
            this.cb_Dep.TabIndex = 27;
            // 
            // lbl_UrlP
            // 
            this.lbl_UrlP.AutoSize = true;
            this.lbl_UrlP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UrlP.Location = new System.Drawing.Point(545, 216);
            this.lbl_UrlP.Name = "lbl_UrlP";
            this.lbl_UrlP.Size = new System.Drawing.Size(223, 25);
            this.lbl_UrlP.TabIndex = 7;
            this.lbl_UrlP.Text = "Url Page Particuliers  :";
            // 
            // lbl_UrlE
            // 
            this.lbl_UrlE.AutoSize = true;
            this.lbl_UrlE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UrlE.Location = new System.Drawing.Point(544, 252);
            this.lbl_UrlE.Name = "lbl_UrlE";
            this.lbl_UrlE.Size = new System.Drawing.Size(224, 25);
            this.lbl_UrlE.TabIndex = 8;
            this.lbl_UrlE.Text = "Url Page Entreprises  :";
            // 
            // txt_UrlP
            // 
            this.txt_UrlP.Location = new System.Drawing.Point(774, 216);
            this.txt_UrlP.Name = "txt_UrlP";
            this.txt_UrlP.Size = new System.Drawing.Size(284, 20);
            this.txt_UrlP.TabIndex = 16;
            // 
            // txt_UrlE
            // 
            this.txt_UrlE.Location = new System.Drawing.Point(774, 257);
            this.txt_UrlE.Name = "txt_UrlE";
            this.txt_UrlE.Size = new System.Drawing.Size(284, 20);
            this.txt_UrlE.TabIndex = 17;
            // 
            // txt_Region
            // 
            this.txt_Region.Location = new System.Drawing.Point(249, 35);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(100, 20);
            this.txt_Region.TabIndex = 28;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.BackColor = System.Drawing.Color.White;
            this.btn_Fermer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fermer.Image")));
            this.btn_Fermer.Location = new System.Drawing.Point(1016, 447);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(42, 34);
            this.btn_Fermer.TabIndex = 20;
            this.btn_Fermer.UseVisualStyleBackColor = false;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(931, 447);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(79, 34);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_generer
            // 
            this.btn_generer.BackColor = System.Drawing.Color.White;
            this.btn_generer.Image = ((System.Drawing.Image)(resources.GetObject("btn_generer.Image")));
            this.btn_generer.Location = new System.Drawing.Point(883, 447);
            this.btn_generer.Name = "btn_generer";
            this.btn_generer.Size = new System.Drawing.Size(42, 34);
            this.btn_generer.TabIndex = 18;
            this.btn_generer.UseVisualStyleBackColor = false;
            this.btn_generer.Click += new System.EventHandler(this.btn_generer_Click);
            // 
            // FormVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1101, 502);
            this.Controls.Add(this.txt_Region);
            this.Controls.Add(this.cb_Dep);
            this.Controls.Add(this.lbl_SelectDep);
            this.Controls.Add(this.lbl_AixMarseille);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_generer);
            this.Controls.Add(this.txt_Port2);
            this.Controls.Add(this.txt_UrlE);
            this.Controls.Add(this.txt_UrlP);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Port1);
            this.Controls.Add(this.txt_TelFixe);
            this.Controls.Add(this.txt_CodePostal);
            this.Controls.Add(this.txt_Ville);
            this.Controls.Add(this.lbl_UrlE);
            this.Controls.Add(this.lbl_UrlP);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Port2);
            this.Controls.Add(this.lbl_Port1);
            this.Controls.Add(this.lbl_TelFixe);
            this.Controls.Add(this.lbl_Departement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Ville);
            this.DoubleBuffered = true;
            this.Name = "FormVille";
            this.Text = "Paramètres des pages";
            this.Load += new System.EventHandler(this.SaisieLyonIndicia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ville;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Departement;
        private System.Windows.Forms.Label lbl_TelFixe;
        private System.Windows.Forms.Label lbl_Port1;
        private System.Windows.Forms.Label lbl_Port2;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Ville;
        private System.Windows.Forms.TextBox txt_CodePostal;
        private System.Windows.Forms.TextBox txt_TelFixe;
        private System.Windows.Forms.TextBox txt_Port1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Port2;
        private System.Windows.Forms.Button btn_generer;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Label lbl_AixMarseille;
        private System.Windows.Forms.Label lbl_SelectDep;
        private System.Windows.Forms.ComboBox cb_Dep;
        private System.Windows.Forms.Label lbl_UrlP;
        private System.Windows.Forms.Label lbl_UrlE;
        private System.Windows.Forms.TextBox txt_UrlP;
        private System.Windows.Forms.TextBox txt_UrlE;
        private System.Windows.Forms.TextBox txt_Region;
    }
}