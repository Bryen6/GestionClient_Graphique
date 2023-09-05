using GC.ConsoleUI;
using GC.DAL.JSON;
using GC.DAL.XML;
using GC.Entites;
using Microsoft.Extensions.Configuration;
using System;       //copier le using
using System.IO;    //copier le using
using Unity;        //instal� le packet nugget unity et copier le using

namespace POOII_Module09_GestionClients
{
    public static class Program
    {
        private static string _fichierDepotClientsJSON;   
��������private static string _fichierDepotClientsXML;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

             

������������IConfigurationRoot configuration = new ConfigurationBuilder()           //cr�e un builder (un peu comme string builder)
������������.SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)    //extrait les donn� du fichier appsettings.json et les stock dans la variable configuration pour s en servir dans l'application
������������.AddJsonFile("appsettings.json", false)
            .Build();

            string repertoireDepotClient = configuration["RepertoireDepotsClients"];    //recupere le path set� dans le fichier appsetting.json
������������string nomFichierDepotClient = configuration["NomFichierDepotClients"];     //recupere le nom de fichier du depot set� dans le fichier appsetting.json
������������string cheminComplet = Path.Combine(repertoireDepotClient, nomFichierDepotClient);      //concatene le path et le nom de fichier pour avoir le path complet

            _fichierDepotClientsJSON = nomFichierDepotClient;
            _fichierDepotClientsXML = nomFichierDepotClient;

            GenererFichiersDepotSiNonExistant(false);

            if (!File.Exists(cheminComplet))    //v�rifie que la concatenation a fonction� sinon leve une exception
������������{
                throw new InvalidOperationException($"Le�fichier�{cheminComplet}�n'existe�pas�ou�est�inaccessible");
            }

            string typeDepot = configuration["TypeDepot"];  //recupere le type de fichier indiqu� dans appsetting.json

������������IUnityContainer conteneur = new UnityContainer();                       //cr�e une instance de Unity pour l injection de dependance
������������conteneur.RegisterInstance(configuration, InstanceLifetime.Singleton);  // le conteneur singleton s'assurera que le depot cr�er ne pourra pas �tre utiliser a deux endroit en m�me temps

������������switch (typeDepot.ToLower())    //cr�e le bon type de depot voulu
������������{
                case "json":
                    conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                case "xml":
                    conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                default:
                    throw new InvalidOperationException("le�type�de�d�pot�n'est�pas�valide,�mettre�json�ou�xml");
            }

            IDepotClients depot = conteneur.Resolve<IDepotClients>();
            Application.Run(new fPrincipale(depot));
;                                               // demarer l'appli
��������}

        private static void GenererFichiersDepotSiNonExistant(bool p_forceCreation)     //parametre qui determine si on veut forcer la creation du dossier
��������{
            bool fichierDepotClientJSONExiste = File.Exists(_fichierDepotClientsJSON);      //verifie si le fichier json existe
������������bool fichierDepotClientXMLExiste = File.Exists(_fichierDepotClientsXML);

            if (fichierDepotClientJSONExiste && p_forceCreation)        //si il existe d�ja et qu'on veut forcer sa creation 
������������{
                File.Delete(_fichierDepotClientsJSON);  // le fichier est delet�
������������}

            if (fichierDepotClientXMLExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsXML);
            }

            if (!fichierDepotClientJSONExiste || p_forceCreation)       //si le fichier n'existe pas ou qu'on veut forcer sa creation
������������{
                GenerateurDonnees.GenererDepotJsonClients(_fichierDepotClientsJSON);    //genere un nouveau depot Json et y cr�e des clients 
������������}
            if (!fichierDepotClientXMLExiste || p_forceCreation)        //si le fichier n'existe pas ou qu'on veut forcer sa creation
������������{
                GenerateurDonnees.GenererDepotXMLClients(_fichierDepotClientsXML);      //genere un nouveau depot Xml et y cr�e des clients
������������}
        }    
        
    }
}