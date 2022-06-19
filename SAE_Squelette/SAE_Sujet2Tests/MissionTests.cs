using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAE_Sujet2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAE_Sujet2.Tests
{
    [TestClass()]
    public class MissionTests
    {
        [TestInitialize()]
        public void Init()
        {
            Mission mission = new Mission(1, 1, "test", new DateTime(2022, 12, 12), "waou");
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

        }

        [TestMethod()]
        public void UpdateTest()
        {

        }

        [TestMethod()]
        public void ReadTest()
        {

        }

        [TestMethod()]
        public void CreateTest()
        {

        }

        [TestMethod()]
        public void FindAllTest()
        {

        }

        [TestMethod()]
        public void FindBySelectionTest()
        {

        }
    }
}