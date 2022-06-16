using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace SAE_Sujet2
{
    /// <summary>
    /// Permet de créer et de stocker un corps d'armée avec comme information son id, son nom et une liste de division
    /// </summary>
    public class CorpsArmee : ICRUD<CorpsArmee>
    {
        private long idCorpsArmee;
        private string nomCorpsArmee;
        private List<Division> lesDivisions = new List<Division>();

        /// <summary>
        /// Constructeur de CoprpsArmee avec tous les paramètres
        /// </summary>
        /// <param name="idCorpsArmee"></param>
        /// <param name="nomCorpsArmee"></param>
        /// <param name="lesDivisions"></param>
        public CorpsArmee(long idCorpsArmee, string nomCorpsArmee, List<Division> lesDivisions)
        {
            this.IdCorpsArmee = idCorpsArmee;
            this.NomCorpsArmee = nomCorpsArmee;
            this.LesDivisions = lesDivisions;
        }

        /// <summary>
        /// Constructeur de CorpsArmee sans liste
        /// </summary>
        /// <param name="idCorpsArmee"></param>
        /// <param name="nomCorpsArmee"></param>
        public CorpsArmee(long idCorpsArmee, string nomCorpsArmee)
        {
            this.IdCorpsArmee = idCorpsArmee;
            this.NomCorpsArmee = nomCorpsArmee;
        }

        /// <summary>
        /// Constructeur vide de CorpsArmee
        /// </summary>
        public CorpsArmee()
        {
        }

        /// <summary>
        /// Propriété de l'id du corps d'armée
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
        /// Propriété du nom du corps d'armée
        /// </summary>
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

        /// <summary>
        /// Propriété de la liste de divisions
        /// </summary>
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

        /// <summary>
        /// Méthode pour supprimer un corps d'armée
        /// </summary>
        public void Delete()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// Méthode pour mettre à jour un corps d'armée
        /// </summary>
        public void Update()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// Méthode pour lire un corps d'armée
        /// </summary>
        public void Read()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// Méthode pour créer un corps d'armée
        /// </summary>
        public void Create()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        /// <summary>
        /// Méthode pour extraire les corps d'armée d'une BD
        /// </summary>
        /// <returns></returns>
        public List<CorpsArmee> FindAll()
        {
            List<CorpsArmee> listeCorpsArmee = new List<CorpsArmee>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData("select * from [IUT-ACY\\claviozm].[CORPS_ARMEE];");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CorpsArmee unCorpsArmee = new CorpsArmee();
                            unCorpsArmee.IdCorpsArmee = reader.GetInt64(0);
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

        /// <summary>
        /// Méthode pour extraire les corps d'armée d'une BD en appliquant un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<CorpsArmee> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}