using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cryptographie;

namespace Crypto
{
    public partial class FORM_Crypto : Form
    {
        public FORM_Crypto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Les variables de la DLL
        /// </summary>
        Rotation rot = new Rotation();
        Circulaire cir = new Circulaire();
        Phrase phr = new Phrase();

        private void FORM_Crypto_Load(object sender, EventArgs e)
        {
            PB_Connexion.BackColor = Color.Red;
        }

        /// <summary>
        /// Aller chercher un fichier texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CHERC_Chiffrer_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() != DialogResult.Cancel)
                TB_Chiffrer.Text = File.ReadAllText(openFD.FileName);
        }

        /// <summary>
        /// Aller chercher un fichier texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CHERC_Dechiffrer_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() != DialogResult.Cancel)
                TB_Dechiffrer.Text = File.ReadAllText(openFD.FileName);
        }

        /// <summary>
        /// Enregistrer le texte chiffré/déchiffré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() != DialogResult.Cancel)
                File.WriteAllText(saveFD.FileName, TB_NewText.Text);
        }

        /// <summary>
        /// Connecte l'usager et active les différents boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Connexion_Click(object sender, EventArgs e)
        {
            BTN_Connexion.Enabled = false;
            BTN_Deconnexion.Enabled = true;
            GB_Algorithmes.Enabled = false;
            if (TB_Chiffrer.Text.Trim() != "")
                BTN_Chiffrer.Enabled = true;
            if (TB_Dechiffrer.Text.Trim() != "")
                BTN_Dechiffrer.Enabled = true;
            PB_Connexion.BackColor = Color.Green;
        }

        /// <summary>
        /// Déconnecte l'usager et désactive les différents boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Deconnexion_Click(object sender, EventArgs e)
        {
            BTN_Connexion.Enabled = true;
            BTN_Deconnexion.Enabled = false;
            BTN_Chiffrer.Enabled = false;
            BTN_Dechiffrer.Enabled = false;
            GB_Algorithmes.Enabled = true;
            PB_Connexion.BackColor = Color.Red;
        }

        /// <summary>
        /// Active le bouton pour chiffrer le texte n'est pas vide
        /// et si l'usager est connecté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Chiffrer_TextChanged(object sender, EventArgs e)
        {
            if (TB_Chiffrer.Text.Trim() != "" && !BTN_Connexion.Enabled)
                BTN_Chiffrer.Enabled = true;
            else
                BTN_Chiffrer.Enabled = false;
        }

        /// <summary>
        /// Active le bouton pour déchiffrer le texte n'est pas vide
        /// et si l'usager est connecté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Dechiffrer_TextChanged(object sender, EventArgs e)
        {
            if (TB_Dechiffrer.Text.Trim() != "" && !BTN_Connexion.Enabled)
                BTN_Dechiffrer.Enabled = true;
            else
                BTN_Dechiffrer.Enabled = false;
        }

        /// <summary>
        /// Active le bouton enregistrer lors du remplissage du textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_NewText_TextChanged(object sender, EventArgs e)
        {
            BTN_Enregistrer.Enabled = true;
        }

        /// <summary>
        /// Chiffre le texte selon l'algorithme choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Chiffrer_Click(object sender, EventArgs e)
        {
            if (RB_ALGO_Rotation.Checked)   // Si l'algorithme rotation a été choisi
                TB_NewText.Text = rot.Chiffrer(TB_Chiffrer.Text);
            else if (RB_ALGO_Circulaire.Checked)    // Si l'algorithme circulaire a été choisi
                TB_NewText.Text = cir.Chiffrer(TB_Chiffrer.Text);
            else if (RB_ALGO_Perso.Checked)     // Si l'algorithme personnel a été choisi
                TB_NewText.Text = phr.Chiffrer(TB_Chiffrer.Text);
        }

        /// <summary>
        /// Déchiffre le texte selon l'algorithme choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Dechiffrer_Click(object sender, EventArgs e)
        {
            if (RB_ALGO_Rotation.Checked)   // Si l'algorithme rotation a été choisi
                TB_NewText.Text = rot.Dechiffrer(TB_Dechiffrer.Text);
            else if (RB_ALGO_Circulaire.Checked)    // Si l'algorithme circulaire a été choisi
                TB_NewText.Text = cir.Dechiffrer(TB_Dechiffrer.Text);
            else if (RB_ALGO_Perso.Checked)     // Si l'algorithme personnel a été choisi
                TB_NewText.Text = phr.Dechiffrer(TB_Dechiffrer.Text);
        }
    }
}