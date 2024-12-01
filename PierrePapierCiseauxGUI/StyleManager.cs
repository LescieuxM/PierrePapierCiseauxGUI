using System;
using System.Drawing;
using System.Windows.Forms;

namespace PierrePapierCiseauxGUI
{
    public static class StyleManager
    {
        // Appliquer le style Comic à tout le formulaire
        public static void ApplyComicStyle(Form form)
        {
            // Change le fond du formulaire
            form.BackColor = Color.Beige;

            // Utiliser une police Comic pour tous les contrôles
            Font comicFont = new Font("Comic Sans MS", 14);

            // Applique le style à chaque contrôle
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Font = comicFont;
                    ctrl.BackColor = Color.LightCoral;
                    ctrl.ForeColor = Color.White;
                }
                else if (ctrl is Label)
                {
                    ctrl.Font = comicFont;
                    ctrl.ForeColor = Color.Black;
                }
            }
        }

        // Ajuster les propriétés des boutons (public pour pouvoir être appelées depuis Form1.cs)
        public static void AjusterBoutons(Form form)
        {
            // Parcours tous les contrôles du formulaire
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    // Redimensionner les boutons pour qu'ils soient suffisamment grands
                    button.Width = 200;
                    button.Height = 80; // Pour donner plus de hauteur aux boutons
                    button.Padding = new Padding(10); // Marge 

                    // Centrer le texte des boutons
                    button.TextAlign = ContentAlignment.MiddleCenter;

                    // Modifier la taille du texte pour qu'il soit bien lisible
                    button.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                    // Ajuster la couleur du texte pour un bon contraste
                    button.ForeColor = Color.White;
                    button.BackColor = Color.DodgerBlue; // Couleur de fond des boutons
                }
            }
        }
    }
}
