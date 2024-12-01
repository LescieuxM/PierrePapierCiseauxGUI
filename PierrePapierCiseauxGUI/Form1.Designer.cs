namespace PierrePapierCiseauxGUI
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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.BtnPierre = new System.Windows.Forms.Button();
            this.BtnCiseaux = new System.Windows.Forms.Button();
            this.BtnPapier = new System.Windows.Forms.Button();
            this.LblResultat = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.LblOrdinateur = new System.Windows.Forms.Label();
            this.LblVictoires = new System.Windows.Forms.Label();
            this.LblDefaites = new System.Windows.Forms.Label();
            this.LblEgalites = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPierre
            // 
            this.BtnPierre.Location = new System.Drawing.Point(244, 107);
            this.BtnPierre.Name = "BtnPierre";
            this.BtnPierre.Size = new System.Drawing.Size(75, 23);
            this.BtnPierre.TabIndex = 0;
            this.BtnPierre.Text = "Pierre";
            this.BtnPierre.UseVisualStyleBackColor = true;
            // 
            // BtnCiseaux
            // 
            this.BtnCiseaux.Location = new System.Drawing.Point(363, 107);
            this.BtnCiseaux.Name = "BtnCiseaux";
            this.BtnCiseaux.Size = new System.Drawing.Size(75, 23);
            this.BtnCiseaux.TabIndex = 1;
            this.BtnCiseaux.Text = "Ciseaux";
            this.BtnCiseaux.UseVisualStyleBackColor = true;
            this.BtnCiseaux.Click += new System.EventHandler(this.BtnCiseaux_Click);
            // 
            // BtnPapier
            // 
            this.BtnPapier.Location = new System.Drawing.Point(472, 107);
            this.BtnPapier.Name = "BtnPapier";
            this.BtnPapier.Size = new System.Drawing.Size(75, 23);
            this.BtnPapier.TabIndex = 2;
            this.BtnPapier.Text = "Papier";
            this.BtnPapier.UseVisualStyleBackColor = true;
            this.BtnPapier.Click += new System.EventHandler(this.BtnPapier_Click);
            // 
            // LblResultat
            // 
            this.LblResultat.AutoSize = true;
            this.LblResultat.Location = new System.Drawing.Point(244, 140);
            this.LblResultat.Name = "LblResultat";
            this.LblResultat.Size = new System.Drawing.Size(0, 13);
            this.LblResultat.TabIndex = 4;
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(244, 170);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(175, 13);
            this.LblScore.TabIndex = 5;
            this.LblScore.Text = "Victoires: 0 | Défaites: 0 | Egalités: 0";
            // 
            // LblOrdinateur
            // 
            this.LblOrdinateur.AutoSize = true;
            this.LblOrdinateur.Location = new System.Drawing.Point(81, 107);
            this.LblOrdinateur.Name = "LblOrdinateur";
            this.LblOrdinateur.Size = new System.Drawing.Size(0, 13);
            this.LblOrdinateur.TabIndex = 6;
            // 
            // LblVictoires
            // 
            this.LblVictoires.Location = new System.Drawing.Point(20, 250);
            this.LblVictoires.Name = "LblVictoires";
            this.LblVictoires.Size = new System.Drawing.Size(100, 23);
            this.LblVictoires.TabIndex = 10;
            this.LblVictoires.Text = "Victoires : 0";
            // 
            // LblDefaites
            // 
            this.LblDefaites.Location = new System.Drawing.Point(20, 280);
            this.LblDefaites.Name = "LblDefaites";
            this.LblDefaites.Size = new System.Drawing.Size(100, 23);
            this.LblDefaites.TabIndex = 11;
            this.LblDefaites.Text = "Défaites : 0";
            // 
            // LblEgalites
            // 
            this.LblEgalites.Location = new System.Drawing.Point(20, 310);
            this.LblEgalites.Name = "LblEgalites";
            this.LblEgalites.Size = new System.Drawing.Size(100, 23);
            this.LblEgalites.TabIndex = 12;
            this.LblEgalites.Text = "Égalités : 0";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Location = new System.Drawing.Point(512, 49);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(0, 13);
            this.LblTimer.TabIndex = 7;
            this.LblTimer.Click += new System.EventHandler(this.LblTimer_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.LblOrdinateur);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblResultat);
            this.Controls.Add(this.BtnPapier);
            this.Controls.Add(this.BtnCiseaux);
            this.Controls.Add(this.BtnPierre);
            this.Name = "Form1";
            this.Text = "Pierre-Papier-Ciseaux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPierre;
        private System.Windows.Forms.Button BtnCiseaux;
        private System.Windows.Forms.Button BtnPapier;
        private System.Windows.Forms.Label LblResultat;
        private System.Windows.Forms.Label LblScore;  // Déclaration du label pour le score
        private System.Windows.Forms.Label LblOrdinateur;
        private System.Windows.Forms.Label LblVictoires;
        private System.Windows.Forms.Label LblDefaites;
        private System.Windows.Forms.Label LblEgalites;
        private System.Windows.Forms.Label LblTimer;
    }
}
