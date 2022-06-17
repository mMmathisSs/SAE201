using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SAE_Sujet2
{
    /// <summary>
    /// Permet de créer et de stocker une mission avec comme information son id, l'id de la division auquelle elle appartient, 
    /// son libellé, sa date et un commentaire
    /// </summary>
    public class Mission : ICRUD<Mission>
    {

        private long idMission;
        private long idDivision;
        private string libelleMission;
        private DateTime dateAffectation;
        private string commentaire;

        /// <summary>
        /// Constructeur de Mission avec tous les paramètres 
        /// </summary>
        /// <param name="idDivision"></param>
        /// <param name="libelleMission"></param>
        /// <param name="dateAffectation"></param>
        /// <param name="commentaire"></param>
        public Mission(long idMission, long idDivision, string libelleMission, DateTime dateAffectation, string commentaire)
        {
            this.IdMission = idMission;
            this.IdDivision = idDivision;
            this.LibelleMission = libelleMission;
            this.DateAffectation = dateAffectation;
            this.Commentaire = commentaire;
        }

        /// <summary>
        /// Constructeur de Mission sans commentaire
        /// </summary>
        /// <param name="idDivision"></param>
        /// <param name="libelleMission"></param>
        /// <param name="dateAffectation"></param>
        public Mission(long idMission ,long idDivision, string libelleMission, DateTime dateAffectation)
        {
            this.IdMission = idMission;
            this.IdDivision = idDivision;
            this.LibelleMission = libelleMission;
            this.DateAffectation = dateAffectation;
        }

        /// <summary>
        /// Constructeur vide de Mission
        /// </summary>
        public Mission()
        {
        }

        /// <summary>
        /// Propriété de l'id de la mission
        /// </summary>
        public long IdMission
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

        /// <summary>
        /// Propriété de l'id de la division
        /// </summary>
        public long IdDivision
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

        /// <summary>
        /// Propriété du libellé de la mission
        /// </summary>
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

        /// <summary>
        /// Propriété de la date d'affectation de la mission
        /// </summary>
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

        /// <summary>
        /// Proporiété du commentaire de la mission
        /// </summary>
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

        /// <summary>
        /// Méthode pour supprimer une mission
        /// </summary>
        public void Delete()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData($"delete from [iut-acy\\claviozm].MISSION where IDMISSION = '{this.IdMission}';" +
                        $"delete from [iut-acy\\claviozm].EFFECTUE2 where IDMISSION = '{this.IdMission}';"))
                    {

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    access.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
        }

        /// <summary>
        /// Méthode pour mettre à jour une mission
        /// </summary>
        public void Update()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData($"UPDATE [iut-acy\\claviozm].MISSION SET LIBELLEMISSION = '{this.LibelleMission}' " +
                        $"WHERE IDMISSION ={this.IdMission};" +
                        $"UPDATE [iut-acy\\claviozm].EFFECTUE2 SET DATEAFFECT = '{this.DateAffectation}', COMMENTAIRE = '{this.Commentaire}' " +
                        $"WHERE IDMISSION ={this.IdMission};"))
                    {

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    access.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
        }

        /// <summary>
        /// Méthode pour lire une mission
        /// </summary>
        public void Read()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData("select e.*, LIBELLEMISSION from EFFECTUE2 e join MISSION m on e.IDMISSION = m.IDMISSION;"))
                    {

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    access.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
        }

        /// <summary>
        /// Méthode pour créer un  mission
        /// </summary>
        public void Create()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData($"INSERT INTO [iut-acy\\claviozm].MISSION (LIBELLEMISSION) VALUES('{this.LibelleMission}');" +
                        "DECLARE @IDMISSION as bigint;" +
                        "SET @IDMISSION = SCOPE_IDENTITY();" +
                        $"INSERT INTO [iut-acy\\claviozm].EFFECTUE2 (IDMISSION, IDDIVISION, DATEAFFECT, COMMENTAIRE) VALUES(@IDMISSION, '{this.IdDivision}','{this.DateAffectation}', '{this.Commentaire}')"))
                    {

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    access.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
        }

        /// <summary>
        /// Méthode pour extraire les missions d'une BD
        /// </summary>
        /// <returns></returns>
        public List<Mission> FindAll()
        {
            List<Mission> listeMissions = new List<Mission>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData("select e.*, LIBELLEMISSION from [IUT-ACY\\claviozm].[EFFECTUE2] e join [IUT-ACY\\claviozm].[MISSION] m on e.IDMISSION = m.IDMISSION;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Mission uneMission = new Mission();
                            uneMission.IdMission = reader.GetInt64(0);
                            uneMission.IdDivision = reader.GetInt64(1);
                            uneMission.DateAffectation = reader.GetDateTime(2);
                            if (reader.GetValue(3) is string)
                            {
                                uneMission.Commentaire = reader.GetString(3);
                            }
                            else
                            {
                                uneMission.Commentaire = null;
                            }
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

        /// <summary>
        /// Méthode pour extraire les missions d'une BD avec un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<Mission> FindBySelection(string criteres)
        {
            List<Mission> listeMissions = new List<Mission>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData($"select e.*, LIBELLEMISSION from EFFECTUE2 e join MISSION m on e.IDMISSION = m.IDMISSION" +
                        $"where m.LIBELLEMISSION = {this.LibelleMission};");
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
    }
}