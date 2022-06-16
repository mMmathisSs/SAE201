using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SAE_Sujet2
{
    /// <summary>
    /// Permet de cr�er et de stocker une mission avec comme information son id, l'id de la division auquelle elle appartient, 
    /// son libell�, sa date et un commentaire
    /// </summary>
    public class Mission : ICRUD<Mission>
    {

        private int idMission;
        private int idDivision;
        private string libelleMission;
        private DateTime dateAffectation;
        private string commentaire;

        /// <summary>
        /// Constructeur de Mission avec tous les param�tres 
        /// </summary>
        /// <param name="idDivision"></param>
        /// <param name="libelleMission"></param>
        /// <param name="dateAffectation"></param>
        /// <param name="commentaire"></param>
        public Mission(int idMission, int idDivision, string libelleMission, DateTime dateAffectation, string commentaire)
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
        public Mission(int idMission ,int idDivision, string libelleMission, DateTime dateAffectation)
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
        /// Propri�t� de l'id de la mission
        /// </summary>
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

        /// <summary>
        /// Propri�t� de l'id de la division
        /// </summary>
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

        /// <summary>
        /// Propri�t� du libell� de la mission
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
        /// Propri�t� de la date d'affectation de la mission
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
        /// Propori�t� du commentaire de la mission
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
        /// M�thode pour supprimer une mission
        /// </summary>
        public void Delete()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// M�thode pour mettre � jour une mission
        /// </summary>
        public void Update()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// M�thode pour lire une mission
        /// </summary>
        public void Read()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// M�thode pour cr�er un  mission
        /// </summary>
        public void Create()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// M�thode pour extraire les missions d'une BD
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

        /// <summary>
        /// M�thode pour extraire les missions d'une BD avec un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<Mission> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}