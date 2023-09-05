namespace POOII_Module09_GestionClients
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_fprincipale = new ListBox();
            btn_nouveau = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox_fprincipale
            // 
            listBox_fprincipale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_fprincipale.BackColor = SystemColors.MenuText;
            listBox_fprincipale.ForeColor = SystemColors.Window;
            listBox_fprincipale.FormattingEnabled = true;
            listBox_fprincipale.ItemHeight = 20;
            listBox_fprincipale.Location = new Point(12, 47);
            listBox_fprincipale.MinimumSize = new Size(700, 350);
            listBox_fprincipale.Name = "listBox_fprincipale";
            listBox_fprincipale.Size = new Size(708, 344);
            listBox_fprincipale.TabIndex = 0;
            // 
            // btn_nouveau
            // 
            btn_nouveau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nouveau.BackColor = SystemColors.InfoText;
            btn_nouveau.ForeColor = SystemColors.Window;
            btn_nouveau.Location = new Point(620, 3);
            btn_nouveau.MaximumSize = new Size(100, 40);
            btn_nouveau.MinimumSize = new Size(100, 40);
            btn_nouveau.Name = "btn_nouveau";
            btn_nouveau.Size = new Size(100, 40);
            btn_nouveau.TabIndex = 1;
            btn_nouveau.Text = "Nouveau";
            btn_nouveau.UseVisualStyleBackColor = false;
            btn_nouveau.Click += btn_nouveau_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 2;
            label1.Text = "Recherche clients :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(164, 10);
            textBox1.MaximumSize = new Size(0, 30);
            textBox1.MinimumSize = new Size(450, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 3;
            // 
            // fPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(732, 403);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_nouveau);
            Controls.Add(listBox_fprincipale);
            MinimumSize = new Size(750, 450);
            Name = "fPrincipale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de clients";
            Load += fPrincipale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_fprincipale;
        private Button btn_nouveau;
        private Label label1;
        private TextBox textBox1;
    }
}