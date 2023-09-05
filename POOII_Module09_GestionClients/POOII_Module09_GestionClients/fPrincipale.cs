using GC.ConsoleUI;
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
            fSaisieClient fenetreSaisieClient = new fSaisieClient();
            fenetreSaisieClient.Show();
        }
    }
}