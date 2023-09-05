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
        private Client m_client;       // la valeur est nulle si la fenêtre va servir pour saisir un nouveau client, non nulle si c'est pour modifier un client existant
        private bool m_nouveau => m_client == null;     // renvoie vrai si la fenêtre est utilisée pour créer un nouveau client, faux sinon (Indice : dépend de la valeur de la propriété "Client")
        private Client m_resultat { get; set; }     // servira à contenir la nouvelle valeur d'un client si l'utilisateur clique sur "Enregistrer"


        public fSaisieClient()
        {
            InitializeComponent();
        }

        public fSaisieClient(Client p_client)
        {
            m_client = p_client;
            InitializeComponent();
        }

        private void fSaisieClient_Load(object sender, EventArgs e)
        {
            ChangerTitreDefSaisieClient();
        }

        void ChangerTitreDefSaisieClient()
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

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            new Client(Guid.NewGuid(),textBox_nom.Text,textBox_prenom.Text, GenerateurDonnees.GenererAdresseAleatoire());
        }
    }
}
