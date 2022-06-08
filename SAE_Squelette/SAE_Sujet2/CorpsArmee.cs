using System;
using System.Collections.Generic;
using System.IO;

namespace SAE_Squelette
{
    public class CorpsArmee : ICRUD
    {

        private int idCorpsArmee;
        private string nomCorpsArmee;
        private List<Division> lesDivisions = new List<Division>();

        public CorpsArmee(int idCorpsArmee, string nomCorpsArmee, List<Division> lesDivisions)
        {
            this.IdCorpsArmee = idCorpsArmee;
            this.NomCorpsArmee = nomCorpsArmee;
            this.LesDivisions = lesDivisions;
        }

        public int IdCorpsArmee
        {
            get
            {
                return this.idCorpsArmee;
            }

            set
            {
                this.idCorpsArmee = value;
            }
        }

        public string NomCorpsArmee
        {
            get
            {
                return this.nomCorpsArmee;
            }

            set
            {
                this.nomCorpsArmee = value;
            }
        }

        public List<Division> LesDivisions
        {
            get
            {
                return this.lesDivisions;
            }

            set
            {
                this.lesDivisions = value;
            }
        }

        public CorpsArmee(object nomCorpsArmee)
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