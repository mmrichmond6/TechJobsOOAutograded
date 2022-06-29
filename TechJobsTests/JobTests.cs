using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests

    {
        //Testing objects
           TechJob job1 = new TechJob();
           TechJob job2 = new TechJob();
           TechJob job3 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
           TechJob job4 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    
        //task 4 -----
            //there are tests in task 4


        [TestMethod] //1
        public void TestSettingJobId()
        {
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsTrue(job1.Id+1 == job2.Id);
            Assert.IsTrue(job1.Id != job2.Id && (job1.Id +1) == job2.Id);
        }


        [TestMethod]  //2
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }


        [TestMethod]  //3
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job3, job4);
        }


        // task 5 ------------
            //there are 3 tests for task 5

        [TestMethod]  //1
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string testString = job3.ToString();
            char firstChar = testString[0];
            char lastChar = testString[testString.Length - 1];
            Assert.IsTrue(firstChar == lastChar);
        }


        [TestMethod]  //2
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string testOutput = Environment.NewLine + $"ID: {job3.Id}" +
                Environment.NewLine + $"Name: {job3.Name}" +
                Environment.NewLine + $"Employer: {job3.EmployerName.Value}" +
                Environment.NewLine + $"Location: { job3.EmployerLocation.Value}" +
                Environment.NewLine + $"Position Type: {job3.JobType.Value}" +
                Environment.NewLine + $"Core Competency: {job3.JobCoreCompetency.Value}" +
                Environment.NewLine;

            Console.WriteLine(testOutput);
            Assert.AreEqual(testOutput, job3.ToString());
        }


        [TestMethod]  //3
        public void TestToStringHandlesEmptyField()
        {
            job3.EmployerName.Value = "";
            job3.JobType.Value = "";
            string testOutput = Environment.NewLine + $"ID: {job3.Id}" +
                Environment.NewLine + $"Name: {job3.Name}" +
                Environment.NewLine + $"Employer: Data not available" +  
                Environment.NewLine + $"Location: {job3.EmployerLocation.Value}" +
                Environment.NewLine + $"Position Type: Data not available" +
                Environment.NewLine + $"Core Competency: {job3.JobCoreCompetency.Value}" +
                Environment.NewLine;

            Console.WriteLine(testOutput);
            Assert.AreEqual(testOutput, job3.ToString());
        }

    }
}
