namespace POOII_Module09_GestionClients
{
    partial class fSaisieClient
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
            label_nom = new Label();
            label_prenom = new Label();
            textBox_nom = new TextBox();
            textBox_prenom = new TextBox();
            bAnnuler = new Button();
            bEnregistrer = new Button();
            SuspendLayout();
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(25, 17);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(49, 20);
            label_nom.TabIndex = 0;
            label_nom.Text = "Nom :";
            // 
            // label_prenom
            // 
            label_prenom.AutoSize = true;
            label_prenom.Location = new Point(23, 56);
            label_prenom.Name = "label_prenom";
            label_prenom.Size = new Size(67, 20);
            label_prenom.TabIndex = 1;
            label_prenom.Text = "Prénom :";
            // 
            // textBox_nom
            // 
            textBox_nom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_nom.BackColor = SystemColors.MenuText;
            textBox_nom.ForeColor = SystemColors.Window;
            textBox_nom.Location = new Point(116, 12);
            textBox_nom.MaximumSize = new Size(500, 30);
            textBox_nom.MinimumSize = new Size(500, 30);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(500, 30);
            textBox_nom.TabIndex = 2;
            // 
            // textBox_prenom
            // 
            textBox_prenom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_prenom.BackColor = SystemColors.MenuText;
            textBox_prenom.ForeColor = SystemColors.Window;
            textBox_prenom.Location = new Point(116, 53);
            textBox_prenom.MaximumSize = new Size(500, 30);
            textBox_prenom.MinimumSize = new Size(500, 30);
            textBox_prenom.Name = "textBox_prenom";
            textBox_prenom.Size = new Size(500, 30);
            textBox_prenom.TabIndex = 3;
            // 
            // bAnnuler
            // 
            bAnnuler.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAnnuler.BackColor = SystemColors.ControlText;
            bAnnuler.DialogResult = DialogResult.Cancel;
            bAnnuler.ForeColor = SystemColors.Window;
            bAnnuler.Location = new Point(402, 95);
            bAnnuler.MaximumSize = new Size(100, 40);
            bAnnuler.MinimumSize = new Size(100, 40);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(100, 40);
            bAnnuler.TabIndex = 4;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = false;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEnregistrer.BackColor = SystemColors.ControlText;
            bEnregistrer.DialogResult = DialogResult.OK;
            bEnregistrer.ForeColor = SystemColors.Window;
            bEnregistrer.Location = new Point(516, 95);
            bEnregistrer.MaximumSize = new Size(100, 40);
            bEnregistrer.MinimumSize = new Size(100, 40);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(100, 40);
            bEnregistrer.TabIndex = 5;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = false;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // fSaisieClient
            // 
            AcceptButton = bEnregistrer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            CancelButton = bAnnuler;
            ClientSize = new Size(632, 143);
            Controls.Add(bEnregistrer);
            Controls.Add(bAnnuler);
            Controls.Add(textBox_prenom);
            Controls.Add(textBox_nom);
            Controls.Add(label_prenom);
            Controls.Add(label_nom);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(650, 190);
            MinimumSize = new Size(650, 190);
            Name = "fSaisieClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saisie d'un nouveau client";
            Load += fSaisieClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nom;
        private Label label_prenom;
        private TextBox textBox_nom;
        private TextBox textBox_prenom;
        private Button bAnnuler;
        private Button bEnregistrer;
    }
}