using System;
using System.Data.SqlClient;
using System.Windows;

namespace SAE_Sujet2.Tests
{
    /// <summary>
    /// Permet d'accéder à la base de données.
    /// Ne doit être utilisée que par la couche modèle pour implémenter un CRUD.
    /// </summary>
    class DataAccess
    {
        private SqlConnection connection;

        /// <summary>
        /// Connecte la base de données
        /// </summary>
        public Boolean OpenConnection()
        {
            Boolean ret = false;
            try
            {
                this.connection = new SqlConnection();
                
                this.connection.ConnectionString =
                "Data Source=srv-jupiter.iut-acy.local;" +
                "Initial Catalog=BT2;" +
                "Integrated Security=SSPI;";
                
                this.connection.Open();
                if (this.connection.State.Equals(System.Data.ConnectionState.Open))
                {
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Message");
            }

            return ret;
        }

        /// <summary>
        /// Déconnecte la base de données
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (this.connection.State.Equals(System.Data.ConnectionState.Open))
                {
                    this.connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Message");
            }
        }

        /// <summary>
        /// Donne accès à des données en lecture
        /// </summary>
        public SqlDataReader GetData(String getQuery)
        {
            SqlDataReader reader = null;
            
            try
            {
                    SqlCommand command = new SqlCommand(getQuery, this.connection);
                    reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Message");
            }

            return reader;
        }

        /// <summary>
        /// Permet d'insérer, supprimer ou modifier des données
        /// </summary>
        /// <param name="setQuery">Requête SQL permettant d'insérer, supprimer ou modifier des données.</param>
        /// <exception cref="System.Exception">Déclenchée si la connexion, l'écriture/modification/suppression en base ou la déconnexion échouent.</exception> 
        /// <returns>Un booléen indiquant si des lignes ont été ajoutées/supprimées/modifiées.</returns>
        public Boolean SetData(String setQuery)
        {
            Boolean ret = false;

            try
            {
                if (this.OpenConnection())
                {
                    int modifiedLines;
                    SqlCommand command = new SqlCommand(setQuery, this.connection);

                    modifiedLines = command.ExecuteNonQuery();

                    if (modifiedLines > 0)
                    {
                        ret = true;
                    }

                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Message");
            }

            return ret;
        }
    }


}
