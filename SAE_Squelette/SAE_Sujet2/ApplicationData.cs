using SAE_Squelette;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAE_Sujet2
{
    public class ApplicationData
    {
        public static List<Mission> listeMissions
        {
            get;
            set;
        }
        public static List<Division> listeDivisions
        {
            get;
            set;
        }
        public static List<CorpsArmee> listeCorpsArmees
        {
            get;
            set;
        }
        public static void loadApplicationData()
        {
            //chargement des tables
            Mission uneMission = new Mission();
            Division uneDivision = new Division();
            CorpsArmee unCorpsArmee = new CorpsArmee();
            //EstNote unEstNote = new EstNote();
            listeMissions = uneMission.FindAll();
            listeDivisions = uneDivision.FindAll();
            listeCorpsArmees = unCorpsArmee.FindAll();
            //listeEstNotes = unEstNote.FindAll();
            //mapping des relations en mode déconnecté
            //relation bi-directionnelle entre eleve et groupe
            //relation eleve -> note
            //relation note -> professeur
        }
    }
}
