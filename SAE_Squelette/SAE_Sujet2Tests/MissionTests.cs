using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAE_Sujet2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SAE_Sujet2.Tests
{
    [TestClass()]
    public class MissionTests
    {
        [TestInitialize()]
        public void Init()
        {
            Mission missionCreate = new Mission(6, "test create 4444", new DateTime(3046, 12, 12), "test create 4444");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MissionIdMissionNegTest()
        {
            Mission missionIdMissionNeg = new Mission(-1, 1, "a", new DateTime(2022, 11, 11), "b");
        }

        [TestMethod()]
        public void MissionIdMission0Test()
        {
            Mission missionIdMission0 = new Mission(0, 1, "a", new DateTime(2022, 11, 11), "b");
        }

        [TestMethod()]
        public void MissionIdMissionPositifTest()
        {
            Mission missionIdMissionPositif = new Mission(1, 1, "a", new DateTime(2022, 11, 11), "b");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MissionIdDivisionNegTest()
        {
            Mission missionIdDivisionNeg = new Mission(1, -1, "a", new DateTime(2022, 11, 11), "b");
        }

        [TestMethod()]
        public void MissionIdDivision0Test()
        {
            Mission missionIdMissionNeg = new Mission(1, 0, "a", new DateTime(2022, 11, 11), "b");
        }

        [TestMethod()]
        public void MissionIdDivisionPositifTest()
        {
            Mission missionIdDivisionPositif = new Mission(1, 1, "a", new DateTime(2022, 11, 11), "b");
        }

        [TestMethod()]
        public void MissionSansCommentaireTest()
        {
            Mission missionSansCommentaire = new Mission(1, 1, "a", new DateTime(2022, 11, 11));
        }

        [TestMethod()]
        public void DeleteTest()
        {
            bool test;
            Mission missionDelete = new Mission(6, "test delete 4444", new DateTime(3046, 12, 12), "test delete 4444");
            DataAccess access = new DataAccess();

            missionDelete.Create();

            missionDelete.Delete();

            List<Mission> listeMissions = FindBySelectionPourLesTests("test delete 4444");

            if (listeMissions[0].IdDivision == 6 && listeMissions[0].LibelleMission == "test delete 4444" && listeMissions[0].DateAffectation == new DateTime(3046, 12, 12) && listeMissions[0].Commentaire == "test delete 4444")
            {
                test = true;
            }
            else
            {
                test = false;
            }

            Assert.IsFalse(test);

            if (access.OpenConnection())
            {
                access.SetData("delete from EFFECTUE2 where COMMENTAIRE = 'test delete 4444';" +
                    "delete from mission where LIBELLEMISSION = 'test delete 4444';");
                access.CloseConnection();
            }
        }

        [TestMethod()]
        public void UpdateTest()
        {
            bool test;
            Mission missionUpdate = new Mission(6, "test update 4444", new DateTime(3046, 12, 12), "test update 4444");
            DataAccess access = new DataAccess();

            missionUpdate.Create();

            missionUpdate.Commentaire = "test update 8888";

            missionUpdate.Update();

            List<Mission> listeMissions = FindBySelectionPourLesTests("test update 8888");

            if (listeMissions[0].IdDivision == 6 && listeMissions[0].LibelleMission == "test update 8888" && listeMissions[0].DateAffectation == new DateTime(3046, 12, 12) && listeMissions[0].Commentaire == "test update 8888")
            {
                test = true;
            }
            else
            {
                test = false;
            }

            Assert.IsTrue(test);

            if (access.OpenConnection())
            {
                access.SetData("delete from EFFECTUE2 where COMMENTAIRE = 'test update 8888';" +
                    "delete from mission where LIBELLEMISSION = 'test update 8888';");
                access.CloseConnection();
            }
        }

        [TestMethod()]
        public void ReadTest()
        {

        }

        [TestMethod()]
        public void CreateTest()
        {
            bool test;
            Mission missionCreate = new Mission(6, "test create 4444", new DateTime(3046, 12, 12), "test create 4444");
            DataAccess access = new DataAccess();

            missionCreate.Create();

            List<Mission> listeMissions = FindBySelectionPourLesTests("test create 4444");

            if (listeMissions[0].IdDivision == 6 && listeMissions[0].LibelleMission == "test create 4444" && listeMissions[0].DateAffectation == new DateTime(3046, 12, 12) && listeMissions[0].Commentaire == "test create 4444")
            {
                test = true;
            }
            else
            {
                test = false;
            }

            Assert.IsTrue(test);

            if (access.OpenConnection())
            {
                access.SetData("delete from EFFECTUE2 where COMMENTAIRE = 'test create 4444';" +
                    "delete from mission where LIBELLEMISSION = 'test create 4444';");
                access.CloseConnection();
            }
        }

        [TestMethod()]
        public void FindAllTest()
        {

        }

        [TestMethod()]
        public void FindBySelectionTest()
        {

        }

        public List<Mission> FindBySelectionPourLesTests(string libelle)
        {
            List<Mission> listeMissions = new List<Mission>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.OpenConnection())
                {
                    reader = access.GetData($"select e.*, LIBELLEMISSION from EFFECTUE2 e join MISSION m on e.IDMISSION = m.IDMISSION" +
                        $" where m.LIBELLEMISSION = '{libelle}';");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Mission uneMission = new Mission();
                            uneMission.IdMission = reader.GetInt64(0);
                            uneMission.IdDivision = reader.GetInt64(1);
                            uneMission.DateAffectation = reader.GetDateTime(2);
                            uneMission.Commentaire = reader.GetString(3);
                            uneMission.LibelleMission = reader.GetString(4);
                            listeMissions.Add(uneMission);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.", "Important Message");
                    }
                    reader.Close();
                    access.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Important Message");
            }
            return listeMissions;
        }
    }
}