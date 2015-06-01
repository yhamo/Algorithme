namespace presentation
{
    partial class Accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateurLyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.saisieDesDepartementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.generateurLyonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // generateurLyonToolStripMenuItem
            // 
            this.generateurLyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieDesDepartementsToolStripMenuItem,
            this.saisieToolStripMenuItem});
            this.generateurLyonToolStripMenuItem.Name = "generateurLyonToolStripMenuItem";
            this.generateurLyonToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.generateurLyonToolStripMenuItem.Text = "Générateur pour les sites !!!";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.saisieToolStripMenuItem.Text = "Saisie des paramètres";
            this.saisieToolStripMenuItem.Click += new System.EventHandler(this.saisieToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-8, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Générateur de texte";
            // 
            // saisieDesDepartementsToolStripMenuItem
            // 
            this.saisieDesDepartementsToolStripMenuItem.Name = "saisieDesDepartementsToolStripMenuItem";
            this.saisieDesDepartementsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.saisieDesDepartementsToolStripMenuItem.Text = "Saisie des departements";
            this.saisieDesDepartementsToolStripMenuItem.Click += new System.EventHandler(this.saisieDesDepartementsToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::presentation.Properties.Resources.tableau_investipole;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Menu d\'accueil du Générateur ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateurLyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saisieDesDepartementsToolStripMenuItem;
    }
}

