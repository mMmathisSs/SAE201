using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public CorpsArmee(string nomCorpsArmee)
        {
            NumAuto++;
            this.IdCorpsArmee = NumAuto;
            this.NomCorpsArmee = nomCorpsArmee;
            this.LesDivisions = lesDivisions;
        }

        public CorpsArmee()
        {
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
            List<CorpsArmee> listeCorpsArmee = new List<CorpsArmee>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData("select * from [iut-acy\\claviozm].CORPS_ARMEE;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CorpsArmee unCorpsArmee = new CorpsArmee();
                            unCorpsArmee.IdCorpsArmee = reader.GetInt32(0);
                            unCorpsArmee.NomCorpsArmee = reader.GetString(1);
                            listeCorpsArmee.Add(unCorpsArmee);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    reader.Close();
                    access.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
            return listeCorpsArmee;
        }
        public List<CorpsArmee> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}