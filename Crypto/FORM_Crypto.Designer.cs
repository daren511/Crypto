namespace Crypto
{
    partial class FORM_Crypto
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
            this.GB_Algorithmes = new System.Windows.Forms.GroupBox();
            this.RB_ALGO_Perso = new System.Windows.Forms.RadioButton();
            this.RB_ALGO_Circulaire = new System.Windows.Forms.RadioButton();
            this.RB_ALGO_Rotation = new System.Windows.Forms.RadioButton();
            this.BTN_Connexion = new System.Windows.Forms.Button();
            this.TB_Chiffrer = new System.Windows.Forms.TextBox();
            this.BTN_Deconnexion = new System.Windows.Forms.Button();
            this.BTN_CHERC_Chiffrer = new System.Windows.Forms.Button();
            this.BTN_Chiffrer = new System.Windows.Forms.Button();
            this.TB_Dechiffrer = new System.Windows.Forms.TextBox();
            this.BTN_Dechiffrer = new System.Windows.Forms.Button();
            this.BTN_CHERC_Dechiffrer = new System.Windows.Forms.Button();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.TB_NewText = new System.Windows.Forms.TextBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.PB_Connexion = new System.Windows.Forms.PictureBox();
            this.GB_Algorithmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Connexion)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Algorithmes
            // 
            this.GB_Algorithmes.Controls.Add(this.RB_ALGO_Perso);
            this.GB_Algorithmes.Controls.Add(this.RB_ALGO_Circulaire);
            this.GB_Algorithmes.Controls.Add(this.RB_ALGO_Rotation);
            this.GB_Algorithmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Algorithmes.Location = new System.Drawing.Point(12, 12);
            this.GB_Algorithmes.Name = "GB_Algorithmes";
            this.GB_Algorithmes.Size = new System.Drawing.Size(108, 111);
            this.GB_Algorithmes.TabIndex = 0;
            this.GB_Algorithmes.TabStop = false;
            this.GB_Algorithmes.Text = "ALGORITHMES";
            // 
            // RB_ALGO_Perso
            // 
            this.RB_ALGO_Perso.AutoSize = true;
            this.RB_ALGO_Perso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_ALGO_Perso.Location = new System.Drawing.Point(8, 78);
            this.RB_ALGO_Perso.Name = "RB_ALGO_Perso";
            this.RB_ALGO_Perso.Size = new System.Drawing.Size(71, 17);
            this.RB_ALGO_Perso.TabIndex = 2;
            this.RB_ALGO_Perso.TabStop = true;
            this.RB_ALGO_Perso.Text = "Personnel";
            this.RB_ALGO_Perso.UseVisualStyleBackColor = true;
            // 
            // RB_ALGO_Circulaire
            // 
            this.RB_ALGO_Circulaire.AutoSize = true;
            this.RB_ALGO_Circulaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_ALGO_Circulaire.Location = new System.Drawing.Point(8, 55);
            this.RB_ALGO_Circulaire.Name = "RB_ALGO_Circulaire";
            this.RB_ALGO_Circulaire.Size = new System.Drawing.Size(67, 17);
            this.RB_ALGO_Circulaire.TabIndex = 1;
            this.RB_ALGO_Circulaire.TabStop = true;
            this.RB_ALGO_Circulaire.Text = "Circulaire";
            this.RB_ALGO_Circulaire.UseVisualStyleBackColor = true;
            // 
            // RB_ALGO_Rotation
            // 
            this.RB_ALGO_Rotation.AutoSize = true;
            this.RB_ALGO_Rotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_ALGO_Rotation.Location = new System.Drawing.Point(8, 32);
            this.RB_ALGO_Rotation.Name = "RB_ALGO_Rotation";
            this.RB_ALGO_Rotation.Size = new System.Drawing.Size(64, 17);
            this.RB_ALGO_Rotation.TabIndex = 0;
            this.RB_ALGO_Rotation.TabStop = true;
            this.RB_ALGO_Rotation.Text = "Rotation";
            this.RB_ALGO_Rotation.UseVisualStyleBackColor = true;
            // 
            // BTN_Connexion
            // 
            this.BTN_Connexion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_Connexion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Connexion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Connexion.Location = new System.Drawing.Point(12, 129);
            this.BTN_Connexion.Name = "BTN_Connexion";
            this.BTN_Connexion.Size = new System.Drawing.Size(108, 23);
            this.BTN_Connexion.TabIndex = 1;
            this.BTN_Connexion.Text = "Connexion";
            this.BTN_Connexion.UseVisualStyleBackColor = true;
            this.BTN_Connexion.Click += new System.EventHandler(this.BTN_Connexion_Click);
            // 
            // TB_Chiffrer
            // 
            this.TB_Chiffrer.Location = new System.Drawing.Point(141, 22);
            this.TB_Chiffrer.MaxLength = 75;
            this.TB_Chiffrer.Name = "TB_Chiffrer";
            this.TB_Chiffrer.Size = new System.Drawing.Size(331, 20);
            this.TB_Chiffrer.TabIndex = 3;
            this.TB_Chiffrer.TextChanged += new System.EventHandler(this.TB_Chiffrer_TextChanged);
            // 
            // BTN_Deconnexion
            // 
            this.BTN_Deconnexion.Enabled = false;
            this.BTN_Deconnexion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_Deconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Deconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Deconnexion.Location = new System.Drawing.Point(12, 158);
            this.BTN_Deconnexion.Name = "BTN_Deconnexion";
            this.BTN_Deconnexion.Size = new System.Drawing.Size(108, 23);
            this.BTN_Deconnexion.TabIndex = 5;
            this.BTN_Deconnexion.Text = "Déconnexion";
            this.BTN_Deconnexion.UseVisualStyleBackColor = true;
            this.BTN_Deconnexion.Click += new System.EventHandler(this.BTN_Deconnexion_Click);
            // 
            // BTN_CHERC_Chiffrer
            // 
            this.BTN_CHERC_Chiffrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_CHERC_Chiffrer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_CHERC_Chiffrer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_CHERC_Chiffrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CHERC_Chiffrer.Location = new System.Drawing.Point(478, 21);
            this.BTN_CHERC_Chiffrer.Name = "BTN_CHERC_Chiffrer";
            this.BTN_CHERC_Chiffrer.Size = new System.Drawing.Size(26, 21);
            this.BTN_CHERC_Chiffrer.TabIndex = 6;
            this.BTN_CHERC_Chiffrer.Text = "...";
            this.BTN_CHERC_Chiffrer.UseVisualStyleBackColor = true;
            this.BTN_CHERC_Chiffrer.Click += new System.EventHandler(this.BTN_CHERC_Chiffrer_Click);
            // 
            // BTN_Chiffrer
            // 
            this.BTN_Chiffrer.Enabled = false;
            this.BTN_Chiffrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_Chiffrer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Chiffrer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Chiffrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Chiffrer.Location = new System.Drawing.Point(141, 48);
            this.BTN_Chiffrer.Name = "BTN_Chiffrer";
            this.BTN_Chiffrer.Size = new System.Drawing.Size(331, 21);
            this.BTN_Chiffrer.TabIndex = 7;
            this.BTN_Chiffrer.Text = "Chiffrer";
            this.BTN_Chiffrer.UseVisualStyleBackColor = true;
            this.BTN_Chiffrer.Click += new System.EventHandler(this.BTN_Chiffrer_Click);
            // 
            // TB_Dechiffrer
            // 
            this.TB_Dechiffrer.Location = new System.Drawing.Point(141, 89);
            this.TB_Dechiffrer.MaxLength = 75;
            this.TB_Dechiffrer.Name = "TB_Dechiffrer";
            this.TB_Dechiffrer.Size = new System.Drawing.Size(331, 20);
            this.TB_Dechiffrer.TabIndex = 8;
            this.TB_Dechiffrer.TextChanged += new System.EventHandler(this.TB_Dechiffrer_TextChanged);
            // 
            // BTN_Dechiffrer
            // 
            this.BTN_Dechiffrer.Enabled = false;
            this.BTN_Dechiffrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_Dechiffrer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Dechiffrer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Dechiffrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Dechiffrer.Location = new System.Drawing.Point(141, 115);
            this.BTN_Dechiffrer.Name = "BTN_Dechiffrer";
            this.BTN_Dechiffrer.Size = new System.Drawing.Size(331, 21);
            this.BTN_Dechiffrer.TabIndex = 9;
            this.BTN_Dechiffrer.Text = "Déchiffrer";
            this.BTN_Dechiffrer.UseVisualStyleBackColor = true;
            this.BTN_Dechiffrer.Click += new System.EventHandler(this.BTN_Dechiffrer_Click);
            // 
            // BTN_CHERC_Dechiffrer
            // 
            this.BTN_CHERC_Dechiffrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_CHERC_Dechiffrer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_CHERC_Dechiffrer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_CHERC_Dechiffrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CHERC_Dechiffrer.Location = new System.Drawing.Point(478, 88);
            this.BTN_CHERC_Dechiffrer.Name = "BTN_CHERC_Dechiffrer";
            this.BTN_CHERC_Dechiffrer.Size = new System.Drawing.Size(26, 21);
            this.BTN_CHERC_Dechiffrer.TabIndex = 10;
            this.BTN_CHERC_Dechiffrer.Text = "...";
            this.BTN_CHERC_Dechiffrer.UseVisualStyleBackColor = true;
            this.BTN_CHERC_Dechiffrer.Click += new System.EventHandler(this.BTN_CHERC_Dechiffrer_Click);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.Enabled = false;
            this.BTN_Enregistrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTN_Enregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Enregistrer.Location = new System.Drawing.Point(435, 158);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(69, 23);
            this.BTN_Enregistrer.TabIndex = 11;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = true;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // TB_NewText
            // 
            this.TB_NewText.Location = new System.Drawing.Point(141, 160);
            this.TB_NewText.MaxLength = 75;
            this.TB_NewText.Name = "TB_NewText";
            this.TB_NewText.ReadOnly = true;
            this.TB_NewText.Size = new System.Drawing.Size(288, 20);
            this.TB_NewText.TabIndex = 12;
            this.TB_NewText.TextChanged += new System.EventHandler(this.TB_NewText_TextChanged);
            // 
            // openFD
            // 
            this.openFD.Filter = "Fichiers texte (*.txt)|*.txt";
            this.openFD.InitialDirectory = "C:";
            this.openFD.Title = "Ouvrir";
            // 
            // saveFD
            // 
            this.saveFD.Filter = "Fichiers texte (*.txt)|*.txt";
            this.saveFD.Title = "Enregistrer";
            // 
            // PB_Connexion
            // 
            this.PB_Connexion.Enabled = false;
            this.PB_Connexion.Location = new System.Drawing.Point(12, 187);
            this.PB_Connexion.Name = "PB_Connexion";
            this.PB_Connexion.Size = new System.Drawing.Size(492, 5);
            this.PB_Connexion.TabIndex = 13;
            this.PB_Connexion.TabStop = false;
            // 
            // FORM_Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 200);
            this.Controls.Add(this.PB_Connexion);
            this.Controls.Add(this.TB_NewText);
            this.Controls.Add(this.BTN_Enregistrer);
            this.Controls.Add(this.BTN_CHERC_Dechiffrer);
            this.Controls.Add(this.BTN_Dechiffrer);
            this.Controls.Add(this.TB_Dechiffrer);
            this.Controls.Add(this.BTN_Chiffrer);
            this.Controls.Add(this.BTN_CHERC_Chiffrer);
            this.Controls.Add(this.BTN_Deconnexion);
            this.Controls.Add(this.TB_Chiffrer);
            this.Controls.Add(this.BTN_Connexion);
            this.Controls.Add(this.GB_Algorithmes);
            this.Name = "FORM_Crypto";
            this.Text = "Cryptographie";
            this.Load += new System.EventHandler(this.FORM_Crypto_Load);
            this.GB_Algorithmes.ResumeLayout(false);
            this.GB_Algorithmes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Connexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Algorithmes;
        private System.Windows.Forms.RadioButton RB_ALGO_Perso;
        private System.Windows.Forms.RadioButton RB_ALGO_Circulaire;
        private System.Windows.Forms.RadioButton RB_ALGO_Rotation;
        private System.Windows.Forms.Button BTN_Connexion;
        private System.Windows.Forms.TextBox TB_Chiffrer;
        private System.Windows.Forms.Button BTN_Deconnexion;
        private System.Windows.Forms.Button BTN_CHERC_Chiffrer;
        private System.Windows.Forms.Button BTN_Chiffrer;
        private System.Windows.Forms.TextBox TB_Dechiffrer;
        private System.Windows.Forms.Button BTN_Dechiffrer;
        private System.Windows.Forms.Button BTN_CHERC_Dechiffrer;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.TextBox TB_NewText;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.PictureBox PB_Connexion;
    }
}

