using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SAE_Squelette
{
    public class Mission : ICRUD<Mission>
    {

        private int idMission;
        private int idDivision;
        private string libelleMission;
        private DateTime dateAffectation;
        private string commentaire;
        private static int numAuto = 0;

        public Mission()
        {
        }

        public Mission(int idDivision, string libelleMission, DateTime dateAffectation, string commentaire)
        {
            NumAuto++;
            this.IdMission = NumAuto;
            this.IdDivision = idDivision;
            this.LibelleMission = libelleMission;
            this.DateAffectation = dateAffectation;
            this.Commentaire = commentaire;
        }

        public Mission(int idDivision, string libelleMission, DateTime dateAffectation)
        {
            NumAuto++;
            this.IdMission = NumAuto;
            this.IdDivision = idDivision;
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
                if (value < 0)
                {
                    throw new ArgumentException("idmission < 0");
                }
                else
                {
                    this.idMission = value;
                }
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
                    throw new ArgumentException("iddivision < 0");
                }
                else
                {
                    this.idDivision = value;
                }
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
                    reader = access.GetData("select e.*, LIBELLEMISSION from EFFECTUE2 e join MISSION m on e.IDMISSION = m.IDMISSION;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Mission uneMission = new Mission();
                            uneMission.IdMission = reader.GetInt32(0);
                            uneMission.IdDivision = reader.GetInt32(1);
                            uneMission.DateAffectation = reader.GetDateTime(2);
                            uneMission.Commentaire = reader.GetString(3);
                            uneMission.LibelleMission = reader.GetString(4);
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