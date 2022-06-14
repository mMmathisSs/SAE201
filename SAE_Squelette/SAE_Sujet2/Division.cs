using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SAE_Squelette
{
    public class Division : ICRUD<Division>
    {

        private int idDivision;
        private int idCorpsArmee;
        private string libelleDivision;
        private List<Mission> lesMissions = new List<Mission>();
        private static int numAuto = 0;

        public Division(int idCorpsArmee, string libelleDivision, List<Mission> lesMissions)
        {
            NumAuto++;
            this.IdDivision = NumAuto;
            this.IdCorpsArmee = idCorpsArmee;
            this.LibelleDivision = libelleDivision;
            this.LesMissions = lesMissions;
        }

        public Division(string libelleDivision, List<Mission> lesMissions)
        {
            NumAuto++;
            this.IdDivision = NumAuto;
            this.LibelleDivision = libelleDivision;
            this.LesMissions = lesMissions;
        }

        public Division()
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

        public int IdDivision
        {
            get
            {
                return this.idDivision;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("idDivision < 0");
                }
                else
                {
                    this.idDivision = value;
                }
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
                if (value < 0)
                {
                    throw new ArgumentException("idCorpsArmee < 0");
                }
                else
                {
                    this.idCorpsArmee = value;
                }
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
        public List<Division> FindAll()
        {
            List<Division> listeDivision = new List<Division>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData("select * from [iut-acy\\claviozm].DIVISON;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Division uneDivision = new Division();
                            uneDivision.IdDivision = reader.GetInt32(0);
                            uneDivision.IdCorpsArmee = reader.GetInt32(1);
                            uneDivision.LibelleDivision = reader.GetString(2);
                            listeDivision.Add(uneDivision);
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
            return listeDivision;
        }
        public List<Division> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}