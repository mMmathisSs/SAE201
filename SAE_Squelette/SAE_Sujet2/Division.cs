using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SAE_Sujet2
{
    /// <summary>
    /// Permet de cr�er et de stocker une division avec comme information son id, l'id du corps d'arm�e auquel il appartient, 
    /// son libell� et une liste de mission
    /// </summary>
    public class Division : ICRUD<Division>
    {
        private long idDivision;
        private long idCorpsArmee;
        private string libelleDivision;
        private List<Mission> lesMissions = new List<Mission>();

        /// <summary>
        /// Constructeur de Division avec tous les param�tres
        /// </summary>
        /// <param name="idDivision"></param>
        /// <param name="idCorpsArmee"></param>
        /// <param name="libelleDivision"></param>
        /// <param name="lesMissions"></param>
        public Division(long idDivision, long idCorpsArmee, string libelleDivision, List<Mission> lesMissions)
        {
            this.IdDivision = idDivision;
            this.IdCorpsArmee = idCorpsArmee;
            this.LibelleDivision = libelleDivision;
            this.LesMissions = lesMissions;
        }

        /// <summary>
        /// Constructeur de Division sans liste
        /// </summary>
        /// <param name="idDivision"></param>
        /// <param name="libelleDivision"></param>
        /// <param name="lesMissions"></param>
        public Division(long idDivision, string libelleDivision, List<Mission> lesMissions)
        {
            this.IdDivision = idDivision;
            this.LibelleDivision = libelleDivision;
            this.LesMissions = lesMissions;
        }

        /// <summary>
        /// Constructeur vide de Division
        /// </summary>
        public Division()
        {
        }

        /// <summary>
        /// Propri�t� de l'id de la division
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
                    throw new ArgumentException("idDivision < 0");
                }
                else
                {
                    this.idDivision = value;
                }
            }
        }

        /// <summary>
        /// Propri�t� de l'id du corps d'arm�e
        /// </summary>
        public long IdCorpsArmee
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

        /// <summary>
        /// Propri�t� du libell� de la division
        /// </summary>
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

        /// <summary>
        /// Propri�t� de la liste de missions
        /// </summary>
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

        /// <summary>
        /// M�thode pour supprimer une division
        /// </summary>
        public void Delete()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData($"delete from [iut-acy\\claviozm].DIVISON where IDDIVISION = '{this.IdDivision}';"))
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
        /// M�thode pour mettre � jour une division
        /// </summary>
        public void Update()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData($"UPDATE [iut-acy\\claviozm].DIVISON SET LIBELLEDIVISION = '{this.LibelleDivision}' " +
                        $"WHERE IDDIVISION ={this.IdDivision};"))
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
        /// M�thode pour lire une division
        /// </summary>
        public void Read()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData("select * from [iut-acy\\claviozm].DIVISON;"))
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
        /// M�thode pour cr�er un division
        /// </summary>
        public void Create()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.OpenConnection())
                {
                    if (access.SetData($"INSERT INTO [iut-acy\\claviozm].DIVISON (LIBELLEDIVISION) VALUES('{this.LibelleDivision}');"))
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
        /// M�thode pour extraire les divisions d'une BD
        /// </summary>
        /// <returns></returns>
        public List<Division> FindAll()
        {
            List<Division> listeDivision = new List<Division>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData("select * from [iut-acy\\claviozm].DIVISION;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Division uneDivision = new Division();
                            uneDivision.IdDivision = reader.GetInt64(0);
                            uneDivision.IdCorpsArmee = reader.GetInt64(1);
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

        /// <summary>
        /// M�thode pour extraire les divisions d'une BD avec un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<Division> FindBySelection(string criteres)
        {
            List<Division> listeDivision = new List<Division>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData($"select * from [iut-acy\\claviozm].DIVISON where LIBELLEDIVISION = {this.LibelleDivision};");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Division uneDivision = new Division();
                            uneDivision.IdDivision = reader.GetInt64(0);
                            uneDivision.IdCorpsArmee = reader.GetInt64(1);
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
    }
}