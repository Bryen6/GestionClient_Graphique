using GC.DAL.JSON;
using GC.DAL.XML;
using GC.Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Unity;

namespace GC.ConsoleUI
{
    class Program
    {
        private static string _fichierDepotClientsJSON ;   //path vers le fichier json
        private static string _fichierDepotClientsXML ;
        static void Main(string[] args)
        {
            // PFL : copiez ces fichiers dans votre répertoire de données si nécessaire
            // Les fichiers générés se crées dans le répertoire de l'exécutable de l'application
            GenererFichiersDepotSiNonExistant(false);   

            IConfigurationRoot configuration = new ConfigurationBuilder()           //crée un builder (un peu comme string builder)
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)    //extrait les donné du fichier appsettings.json et les stock dans la variable configuration pour s en servir dans l'application
            .AddJsonFile("appsettings.json", false)
            .Build();

            string repertoireDepotClient = configuration["RepertoireDepotsClients"];    //recupere le path seté dans le fichier appsetting.json
            string nomFichierDepotClient = configuration["NomFichierDepotClients"];     //recupere le nom de fichier du depot seté dans le fichier appsetting.json
            string cheminComplet = Path.Combine(repertoireDepotClient, nomFichierDepotClient);      //concatene le path et le nom de fichier pour avoir le path complet

            if (!File.Exists(cheminComplet))    //vérifie que la concatenation a fonctioné sinon leve une exception
            {
                throw new InvalidOperationException($"Le fichier {cheminComplet} n'existe pas ou est inaccessible");
            }

            _fichierDepotClientsJSON = cheminComplet;
            _fichierDepotClientsXML = cheminComplet;

            string typeDepot = configuration["TypeDepot"];  //recupere le type de fichier indiqué dans appsetting.json

            IUnityContainer conteneur = new UnityContainer();                       //crée une instance de Unity pour l injection de dependance
            conteneur.RegisterInstance(configuration, InstanceLifetime.Singleton);  // le conteneur singleton s'assurera que le depot créer ne pourra pas être utiliser a deux endroit en même temps

            switch (typeDepot.ToLower())    //crée le bon type de depot voulu
            {
                case "json":
                    conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                case "xml":
                    conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                default:
                    throw new InvalidOperationException("le type de dépot n'est pas valide, mettre json ou xml");
            }

            ClientUIConsole clientUIConsole = conteneur.Resolve<ClientUIConsole>();     //container unity pour créer une instance de clientUIConsole
            clientUIConsole.ExecuterUI();                                               // demarer l'appli
        }

        private static void GenererFichiersDepotSiNonExistant(bool p_forceCreation)     //parametre qui determine si on veut forcer la creation du dossier
        {
            bool fichierDepotClientJSONExiste = File.Exists(_fichierDepotClientsJSON);      //verifie si le fichier json existe
            bool fichierDepotClientXMLExiste = File.Exists(_fichierDepotClientsXML);
            
            if (fichierDepotClientJSONExiste && p_forceCreation)        //si il existe déja et qu'on veut forcer sa creation 
            {
                File.Delete(_fichierDepotClientsJSON);  // le fichier est deleté
            }

            if (fichierDepotClientXMLExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsXML);
            }

            if (!fichierDepotClientJSONExiste || p_forceCreation)       //si le fichier n'existe pas ou qu'on veut forcer sa creation
            {
                GenerateurDonnees.GenererDepotJsonClients(_fichierDepotClientsJSON);    //genere un nouveau depot Json et y crée des clients 
            }
            if (!fichierDepotClientXMLExiste || p_forceCreation)        //si le fichier n'existe pas ou qu'on veut forcer sa creation
            {
                GenerateurDonnees.GenererDepotXMLClients(_fichierDepotClientsXML);      //genere un nouveau depot Xml et y crée des clients
            }
        }
    }
}
