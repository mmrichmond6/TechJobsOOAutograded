using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests

    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;


        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }


        [TestMethod]
        public void TestSettingJobId()
        {
            //Assert.IsFalse(job1.Id == job2.Id && (job1.Id + 1) == job2.Id);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }



        // task 5 ------------
        //[TestMethod]
        //public void TestToStringStartsAndEndsWithNewLine()
        //{
        //    string testString = job3.ToString();
        //    char firstChar = testString[0];
        //    char lastChar = testString[testString.Length - 1];
        //    Assert.IsTrue(firstChar == lastChar);
        //}


        //[TestMethod]
        //public void TestToStringContainsCorrectLabelsAndData()
        //{
        //    string testOutput = Environment.NewLine + $"ID: {job3.Id}" +
        //        Environment.NewLine + $"Name: {job3.Name}" +
        //        Environment.NewLine + $"Employer: {job3.EmployerName.Value}" +
        //        Environment.NewLine + $"Location: { job3.EmployerLocation.Value}" +
        //        Environment.NewLine + $"Position Type: {job3.JobType.Value}" +
        //        Environment.NewLine + "Core Competency: {job3.JobCoreCompetency.Value}" +
        //        Environment.NewLine;

        //    Console.WriteLine(testOutput);
        //    Assert.AreEqual(testOutput, job3.ToString());
        //}


        //[TestMethod]
        //public void TestToStringHandlesEmptyField()
        //{
        //    job3.EmployerName.Value = "";
        //    job3.JobType.Value = "";
        //    string testOutput = Environment.NewLine + $"ID: {job3.Id}" +
        //        Environment.NewLine + $"Name: {job3.Name}" +
        //        Environment.NewLine + $"Employer: Data not available" +
        //        Environment.NewLine + $"Location: {job3.EmployerLocation.Value}" +
        //        Environment.NewLine + $"Position Type: Data not available" +
        //        Environment.NewLine + $"Core Competency: {job3.JobCoreCompetency.Value}" +
        //        Environment.NewLine;

        //    Console.WriteLine(testOutput);
        //    Assert.AreEqual(testOutput, job3.ToString());
        //}

    }
}
