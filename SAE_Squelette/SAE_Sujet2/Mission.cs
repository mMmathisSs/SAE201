using System;
using System.Collections.Generic;

namespace SAE_Squelette
{
    public class Mission : ICRUD<Mission>
    {

        private int idMission;
        private string libelleMission;
        private DateTime dateAffectation;
        private string commentaire;
        private static int numAuto = 0;

        public Mission(string libelleMission, DateTime dateAffectation, string commentaire)
        {
            NumAuto++;
            this.IdMission = NumAuto;
            this.LibelleMission = libelleMission;
            this.DateAffectation = dateAffectation;
            this.Commentaire = commentaire;
        }

        public Mission(string libelleMission, DateTime dateAffectation)
        {
            NumAuto++;
            this.IdMission = NumAuto;
            this.LibelleMission = libelleMission;
            this.DateAffectation = dateAffectation;
        }

        public static int NumAuto
        {
            get
            {
                return numAuto;
            }

            private set
            {
                numAuto = value;
            }
        }

        public int IdMission
        {
            get
            {
                return this.idMission;
            }

            set
            {
                this.idMission = value;
            }
        }

        public string LibelleMission
        {
            get
            {
                return this.libelleMission;
            }

            set
            {
                this.libelleMission = value;
            }
        }

        public DateTime DateAffectation
        {
            get
            {
                return this.dateAffectation;
            }

            set
            {
                this.dateAffectation = value;
            }
        }

        public string Commentaire
        {
            get
            {
                return this.commentaire;
            }

            private set
            {
                this.commentaire = value;
            }
        }

        public Mission(object libelleMission, object dateAffectation)
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public Mission(object libelleMission)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public void Delete()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void Update()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void Read()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public void Create()
        {
            throw new System.NotImplementedException("Not implemented");
        }
        public List<Mission> FindAll()
        {
            throw new NotImplementedException();
        }
        public List<Mission> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}