using System;
using System.Collections.Generic;
using System.IO;

namespace SAE_Squelette
{
    public class CorpsArmee : ICRUD<CorpsArmee>
    {

        private int idCorpsArmee;
        private string nomCorpsArmee;
        private List<Division> lesDivisions = new List<Division>();
        private static int numAuto = 0;

        public CorpsArmee(string nomCorpsArmee, List<Division> lesDivisions)
        {
            NumAuto++;
            this.IdCorpsArmee = NumAuto;
            this.NomCorpsArmee = nomCorpsArmee;
            this.LesDivisions = lesDivisions;
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
        public List<CorpsArmee> FindAll()
        {
            throw new NotImplementedException();
        }
        public List<CorpsArmee> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}