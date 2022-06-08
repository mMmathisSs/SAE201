using System;
using System.Collections.Generic;

namespace SAE_Squelette
{
    public class Division : ICRUD
    {

        private int idDivision;
        private string libelleDivision;
        private List<Mission> lesMissions = new List<Mission>();

        public Division(int idDivision, string libelleDivision, List<Mission> lesMissions)
        {
            this.IdDivision = idDivision;
            this.LibelleDivision = libelleDivision;
            this.LesMissions = lesMissions;
        }

        public int IdDivision
        {
            get
            {
                return this.idDivision;
            }

            set
            {
                this.idDivision = value;
            }
        }

        public string LibelleDivision
        {
            get
            {
                return this.libelleDivision;
            }

            set
            {
                this.libelleDivision = value;
            }
        }

        public List<Mission> LesMissions
        {
            get
            {
                return this.lesMissions;
            }

            set
            {
                this.lesMissions = value;
            }
        }

        public Division(object libelleDivision)
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