using System;
using System.Drawing;
using System.Windows.Forms;

namespace PierrePapierCiseauxGUI
{
    public static class StyleManager
    {
        // Appliquer le style et la disposition des éléments
        public static void ApplyStyleAndPositioning(Form form)
        {
            // Appliquer le style général aux contrôles du formulaire
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button)
                {
                    ApplyButtonStyle(ctrl as Button);
                }
                else if (ctrl is Label)
                {
                    ApplyLabelStyle(ctrl as Label);
                }
            }

            // Positionner les éléments manuellement dans le Formulaire
            PositionElements(form);
        }

        // Appliquer un style spécifique aux boutons
        private static void ApplyButtonStyle(Button button)
        {
            button.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.BackColor = Color.DodgerBlue;
            button.Width = 200;
            button.Height = 80;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }

        // Appliquer un style spécifique aux labels
        private static void ApplyLabelStyle(Label label)
        {
            label.Font = new Font("Comic Sans MS", 14);
            label.ForeColor = Color.Black;
        }

        // Positionner les éléments dans le formulaire
        private static void PositionElements(Form form)
        {
            // LblOrdinateur (en haut à gauche)
            Label lblOrdinateur = form.Controls["LblOrdinateur"] as Label;
            if (lblOrdinateur != null)
                lblOrdinateur.Location = new Point(10, 10);  // Positionner en haut à gauche

            // LblTimer (en haut à droite)
            Label lblTimer = form.Controls["LblTimer"] as Label;
            if (lblTimer != null)
                lblTimer.Location = new Point(form.ClientSize.Width - lblTimer.Width - 10, 10); // En haut à droite

            // LblResultat (au centre au-dessus des boutons)
            Label lblResultat = form.Controls["LblResultat"] as Label;
            if (lblResultat != null)
                lblResultat.Location = new Point((form.ClientSize.Width - lblResultat.Width) / 2, 100); // Centré, juste au-dessus des boutons

            // LblScore (en bas et centré)
            Label lblScore = form.Controls["LblScore"] as Label;
            if (lblScore != null)
                lblScore.Location = new Point((form.ClientSize.Width - lblScore.Width) / 2, form.ClientSize.Height - lblScore.Height - 30); // Centré en bas

            // Boutons : Positionner au centre de l'écran
            Button btnPierre = form.Controls["BtnPierre"] as Button;
            Button btnCiseaux = form.Controls["BtnCiseaux"] as Button;
            Button btnPapier = form.Controls["BtnPapier"] as Button;

            int buttonWidth = 200;
            int totalWidth = 3 * buttonWidth + 40;  // Espace entre les boutons

            if (btnPierre != null && btnCiseaux != null && btnPapier != null)
            {
                btnPierre.Location = new Point((form.ClientSize.Width - totalWidth) / 2, 200); // Centré horizontalement
                btnCiseaux.Location = new Point(btnPierre.Left + buttonWidth + 10, 200);  // À droite de BtnPierre
                btnPapier.Location = new Point(btnCiseaux.Left + buttonWidth + 10, 200);  // À droite de BtnCiseaux
            }
        }
    }
}
