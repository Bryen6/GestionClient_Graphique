using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GC.Entites;


namespace POOII_Module09_GestionClients
{
    public partial class fSaisieClient : Form
    {
        private Client? m_client;
        private bool m_nouveau => m_client == null;
        
        private Client m_resultat; 

        public Client Resultat
        {
            get { return m_resultat; } 
            private set {  m_resultat = value; }
        }


        public fSaisieClient(Client? p_client)
        {
            m_client = p_client;
            InitializeComponent();
        }

        private void fSaisieClient_Load(object sender, EventArgs e)
        {
            ChangerTitreDefSaisieClient();
            ModifierValeurTextbox();
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            Client clientAEnregistrer;
            if (m_nouveau)
            {
                clientAEnregistrer = new Client(Guid.NewGuid(), textBox_nom.Text, textBox_prenom.Text);
            }
            else
            {
                clientAEnregistrer = new Client(m_client.ClientId, textBox_nom.Text, textBox_prenom.Text);
            }
            this.m_resultat = clientAEnregistrer;
        }

        private void ModifierValeurTextbox()
        {
            if (!m_nouveau)
            {
                this.textBox_nom.Text = m_client.Nom;
                this.textBox_prenom.Text = m_client.Prenom;
            }
        }

        private void ChangerTitreDefSaisieClient()
        {
            if (m_nouveau)
            {
                this.Text = "Saisie d'un nouveau client";
            }
            else
            {
                this.Text = "Modification d'un client";
            }
        }

    }
}
