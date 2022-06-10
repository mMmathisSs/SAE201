using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SAE_Squelette
{
    public class Mission : ICRUD<Mission>
    {

        private int idMission;
        private string libelleMission;
        private DateTime dateAffectation;
        private string commentaire;
        private static int numAuto = 0;

        public Mission()
        {
        }

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
            this.Commentaire = null;
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
                if (String.IsNullOrEmpty(value))
                    this.commentaire = "Pas de commentaire";
                else
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
            List<Mission> listeMissions = new List<Mission>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData("select * from [iut-acy\\claviozm].Mission;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Mission uneMission = new Mission();
                            uneMission.IdMission = reader.GetInt32(0);
                            uneMission.LibelleMission = reader.GetString(1);
                            uneMission.DateAffectation = reader.GetDateTime(2);
                            uneMission.Commentaire = reader.GetString(3);
                            listeMissions.Add(uneMission);
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
            return listeMissions;
        }
        public List<Mission> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}