using System;
using System.Collections.Generic;
using System.Text;

namespace SAE_Sujet2
{
    /// <summary>
    /// Permet de charger les données d'une BD
    /// </summary>
    public class ApplicationData
    {
        /// <summary>
        /// Déclare une liste de Mission
        /// </summary>
        public static List<Mission> listeMissions
        {
            get;
            set;
        }

        /// <summary>
        /// Déclare une liste de Division
        /// </summary>
        public static List<Division> listeDivisions
        {
            get;
            set;
        }

        /// <summary>
        /// Déclare une liste de Corps d'armée
        /// </summary>
        public static List<CorpsArmee> listeCorpsArmees
        {
            get;
            set;
        }

        /// <summary>
        /// Méthode pour affecter aux listes définit précédement les données contenu dans la BD
        /// </summary>
        public static void loadApplicationData()
        {
            Mission uneMission = new Mission();
            Division uneDivision = new Division();
            CorpsArmee unCorpsArmee = new CorpsArmee();

            listeMissions = uneMission.FindAll();
            listeDivisions = uneDivision.FindAll();
            listeCorpsArmees = unCorpsArmee.FindAll();
        }
    }
}
