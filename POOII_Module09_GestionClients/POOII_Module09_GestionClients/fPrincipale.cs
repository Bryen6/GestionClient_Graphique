using GC.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POOII_Module09_GestionClients
{
    public partial class fPrincipale : Form
    {
        public IDepotClients m_depotClient;
        public fPrincipale(IDepotClients p_depotClient)
        {
            InitializeComponent();
            m_depotClient = p_depotClient;
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {

            Client clientNull = null;
            fSaisieClient fenetreSaisieClient = new fSaisieClient(clientNull);

            DialogResult result = fenetreSaisieClient.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Client nouveauClient = fenetreSaisieClient.Resultat;
                this.m_depotClient.AjouterClient(nouveauClient);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox_fprincipale.Items.Clear();
            List<Client> clientFiltres = this.m_depotClient.RechercherClients(textBox1.Text);
            listBox_fprincipale.Items.AddRange(clientFiltres.ToArray());
        }

        private void listBox_fprincipale_DoubleClick(object sender, EventArgs e)
        {
            Client clientSelectione = (Client)listBox_fprincipale.SelectedItem;
            if (clientSelectione != null)
            {
                fSaisieClient fenetreSaisieClient = new fSaisieClient(clientSelectione);

                DialogResult result = fenetreSaisieClient.ShowDialog(this);

                if (result == DialogResult.OK && fenetreSaisieClient.Resultat != null)
                {
                    this.m_depotClient.ModifierClient(fenetreSaisieClient.Resultat);

                    int index = listBox_fprincipale.SelectedIndex;
                    listBox_fprincipale.Items[index] = fenetreSaisieClient.Resultat;
                }
                
            }
        }
    }
}