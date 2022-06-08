using System;

namespace SAE_Squelette
{
    public class Mission : ICRUD
    {

        private int idMission;
        private string libelleMission;
        private DateTime dateAffectation;

        public Mission(int idMission, string libelleMission, DateTime dateAffectation)
        {
            this.IdMission = idMission;
            this.LibelleMission = libelleMission;
            this.DateAffectation = dateAffectation;
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

    }
}