using System;
using System.Drawing;
using System.Windows.Forms;

namespace PierrePapierCiseauxGUI
{
    public partial class Form1 : Form
    {
        // Déclaration des variables pour le score
        private int victoires = 0;
        private int defaites = 0;
        private int egalites = 0;

        // Timer pour le joueur
        private System.Windows.Forms.Timer timer;
        private int tempsRestant = 5; // Temps du joueur
        private bool joueurAChoisi = false; // Pour vérifier si le joueur a fait un choix

        // Timer pour l'ordinateur
        private System.Windows.Forms.Timer timerOrdinateur;
        private bool ordinateurAChoisi = false; // Pour vérifier si l'ordinateur a fait son choix

        private string dernierChoixJoueur = string.Empty; // Stocke le dernier choix du joueur

        public Form1()
        {
            InitializeComponent();
            StyleManager.ApplyComicStyle(this);
            StyleManager.AjusterBoutons(this);
            this.MinimumSize = new Size(800, 600); // Taille minimale de la fenêtre
            InitializeTableLayoutPanel();  // Initialisation du TableLayoutPanel

            InitializeTimer(); // Timer du joueur
            InitializeTimerOrdinateur();  // Nouveau Timer pour l'ordinateur
            BtnPierre.Click += BtnPierre_Click;
            BtnCiseaux.Click += BtnCiseaux_Click;
            BtnPapier.Click += BtnPapier_Click;
        }
        private void InitializeTableLayoutPanel()
        {
            // Création du TableLayoutPanel
            this.tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2,  // Deux colonnes : une pour LblOrdinateur et une autre pour LblTimer et autres éléments
                RowCount = 6,     // Six lignes pour organiser les éléments
                Dock = DockStyle.Fill,  // Remplir tout l'espace disponible
                Padding = new Padding(10),  // Marge autour du TableLayoutPanel
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            // Définir les styles des lignes et des colonnes
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));  // Colonne gauche pour LblOrdinateur
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));  // Colonne droite pour d'autres éléments
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));  // Zone du LblOrdinateur et LblTimer
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));  // Espace entre le LblOrdinateur et LblScore
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));  // Espace entre les boutons et le timer
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));  // Espace entre les boutons et le résultat
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));  // Espace entre les résultats et les boutons
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));  // Zone pour les boutons, timer et autres éléments

            // Ajouter LblOrdinateur à la première colonne et première ligne
            this.tableLayoutPanel.Controls.Add(LblOrdinateur, 0, 0);  // Placer LblOrdinateur en haut à gauche
            this.tableLayoutPanel.SetRowSpan(LblOrdinateur, 2);  // Faire en sorte que LblOrdinateur occupe deux lignes

            // Ajouter LblTimer dans la première colonne, mais dans la première ligne de la deuxième colonne
            this.tableLayoutPanel.Controls.Add(LblTimer, 1, 0);  // Placer LblTimer en haut à droite

            // Ajouter LblScore dans la dernière ligne, occuper les deux colonnes pour le centrer
            this.tableLayoutPanel.Controls.Add(LblScore, 0, 5);  // Placer LblScore dans la dernière ligne, première colonne
            this.tableLayoutPanel.SetColumnSpan(LblScore, 2);  // Étendre LblScore sur les deux colonnes pour le centrer horizontalement
            LblScore.TextAlign = ContentAlignment.MiddleCenter;

            // Ajouter LblResultat au-dessus des boutons, dans la cellule appropriée
            this.tableLayoutPanel.Controls.Add(LblResultat, 0, 3);  // Placer LblResultat dans la cellule vide, au-dessus des boutons
            this.tableLayoutPanel.SetColumnSpan(LblResultat, 2);  // L'étendre sur les deux colonnes pour qu'il soit centré

            // Ajouter BtnPierre, BtnPapier et BtnCiseaux dans la ligne suivante
            this.tableLayoutPanel.Controls.Add(BtnPierre, 0, 3);
            this.tableLayoutPanel.Controls.Add(BtnPapier, 0, 3);
            this.tableLayoutPanel.Controls.Add(BtnCiseaux, 0, 3);

            // Assurez-vous que la fenêtre est bien redimensionnée
            this.Controls.Add(this.tableLayoutPanel);
        }

        // Initialisation du timer pour le joueur
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // Intervalle de 1 seconde
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start(); // Démarre le timer

            // Afficher immédiatement le temps restant à 5 secondes
            LblOrdinateur.Text = "A vous de jouer !";
        }

        // Tick du timer du joueur, affiche le temps restant
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tempsRestant > 0 && !joueurAChoisi)
            {
                tempsRestant--;  // Réduire le temps restant
                LblTimer.Text = $"Temps restant : {tempsRestant} secondes.";
            }
            else
            {
                timer.Stop();  // Arrêter le timer
                if (!joueurAChoisi)
                {
                    // Si le joueur n'a pas fait de choix
                    LblTimer.Text = "Temps écoulé ! Vous devez choisir rapidement.";
                    // Tu peux ajouter ici un comportement par défaut pour l'ordinateur si nécessaire
                }
            }
        }

        // Initialisation du timer pour l'ordinateur
        private void InitializeTimerOrdinateur()
        {
            timerOrdinateur = new System.Windows.Forms.Timer
            {
                Interval = 2000 // Intervalle de 2 secondes pour simuler la réflexion de l'ordinateur
            };
            timerOrdinateur.Tick += new EventHandler(TimerOrdinateur_Tick);
        }

        // Tick du timer de l'ordinateur, affiche "L'ordinateur réfléchit..."
        private void TimerOrdinateur_Tick(object sender, EventArgs e)
        {
            LblOrdinateur.Text = "L'ordinateur réfléchit..."; // Afficher ce message dans LblOrdinateur
            timerOrdinateur.Stop();  // Arrêter le timer de réflexion de l'ordinateur

            // Faire le choix de l'ordinateur après 2 secondes
            string ordinateurChoix = ObtenirChoixOrdinateur();
            string resultat = ComparerChoix(dernierChoixJoueur, ordinateurChoix);

            LblResultat.Text = $"L'ordinateur a choisi {ordinateurChoix}. {resultat}";
            UpdateScore(resultat); // Mettre à jour le score

            // Réinitialiser les timers et l'état pour le prochain tour
            ReinitialiserJeu();
        }

        // Méthode pour obtenir le choix aléatoire de l'ordinateur
        private string ObtenirChoixOrdinateur()
        {
            Random random = new Random();
            int choix = random.Next(1, 4);  // 1 = Pierre, 2 = Papier, 3 = Ciseaux

            switch (choix)
            {
                case 1:
                    return "Pierre";
                case 2:
                    return "Papier";
                case 3:
                    return "Ciseaux";
                default:
                    return string.Empty;
            }
        }

        // Méthode pour comparer les choix du joueur et de l'ordinateur
        private string ComparerChoix(string joueur, string ordinateur)
        {
            if (joueur == ordinateur)
            {
                return "Égalité!";
            }
            else if ((joueur == "Pierre" && ordinateur == "Ciseaux") ||
                     (joueur == "Papier" && ordinateur == "Pierre") ||
                     (joueur == "Ciseaux" && ordinateur == "Papier"))
            {
                return "Vous gagnez!";
            }
            else
            {
                return "Vous perdez!";
            }
        }

        // Méthode pour mettre à jour les scores
        private void UpdateScore(string resultat)
        {
            if (resultat == "Vous gagnez!")
            {
                victoires++;
            }
            else if (resultat == "Vous perdez!")
            {
                defaites++;
            }
            else
            {
                egalites++;
            }

            LblScore.Text = $"Victoires: {victoires} | Défaites: {defaites} | Égalités: {egalites}";
        }

        // Méthode pour réinitialiser le jeu
        private void ReinitialiserJeu()
        {
            timer.Stop();
            timerOrdinateur.Stop();
            tempsRestant = 5;  // Réinitialiser le temps
            joueurAChoisi = false;
            ordinateurAChoisi = false;
            LblOrdinateur.Text = "";  // Effacer le message "L'ordinateur réfléchit..."
            LblOrdinateur.Text = "A vous de jouer !";
            timer.Start(); // Redémarrer le timer pour le joueur
        }

        // Gérer les choix du joueur (Pierre, Papier, Ciseaux)
        private void BtnPierre_Click(object sender, EventArgs e)
        {
            dernierChoixJoueur = "Pierre";
            joueurAChoisi = true;
            timer.Stop();  // Arrêter le timer du joueur

            // Démarrer le timer de l'ordinateur
            LblOrdinateur.Text = "L'ordinateur réfléchit...";
            timerOrdinateur.Start();
        }

        private void BtnPapier_Click(object sender, EventArgs e)
        {
            dernierChoixJoueur = "Papier";
            joueurAChoisi = true;
            timer.Stop();  // Arrêter le timer du joueur

            // Démarrer le timer de l'ordinateur
            LblOrdinateur.Text = "L'ordinateur réfléchit...";
            timerOrdinateur.Start();
        }

        private void BtnCiseaux_Click(object sender, EventArgs e)
        {
            dernierChoixJoueur = "Ciseaux";
            joueurAChoisi = true;
            timer.Stop();  // Arrêter le timer du joueur

            // Démarrer le timer de l'ordinateur
            LblOrdinateur.Text = "L'ordinateur réfléchit...";
            timerOrdinateur.Start();
        }

        private void LblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
