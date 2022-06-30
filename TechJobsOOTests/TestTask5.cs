using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using TechJobsOOAutograded;
using TechJobsTests;

namespace TechJobsOOTests
{
    [TestClass]
    public class TestTask5
    {
        //Task 5 Tests used to verify that students are testing their custom ToString method
        //Some of the tests are used to verify that the test exists -- will need to add notes to the textbook about this
        //Others test functionality of ToString method -- will need to add notes about what to do with the empty string

        TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        TechJob job2 = new TechJob("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
        TechJob job3 = new TechJob("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLineExists()
        {
            //test to verify that TestToStringStartsAndEndsWithNewLine exisits 

            //setup
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestToStringStartsAndEndsWithNewLine";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestToStringStartsAndEndsWithNewLine' not created");

        }


        [TestMethod]
        public void Test_TestToString_Starts_And_Ends_With_NewLine()
        {
            //comparing output to a text file.  id numbers may get a little wonky
            string text = System.IO.File.ReadAllText("StartsAndEndsWithNewLine.txt").ToString();

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var techJobs = new TechJobs();
            techJobs.RunProgram();

            var output = stringWriter.ToString();

           Assert.AreEqual(text, output, "Not Working");
        }



        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData_Exists()
        {
            //test to verify that TestToStringContainsCorrectLabelsAndData exisits

            //setup
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestToStringContainsCorrectLabelsAndData";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestToStringContainsCorrectLabelsAndData' not created");
        }

        [TestMethod]
        public void Test_TestToStringContainsCorrectLabelsAndData()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var techJobs = new TechJobs();
            techJobs.RunProgram();

            var output = stringWriter.ToString();

            //this one feels less "hard coded"  but not sure if it is the best test?  Does it give too much away?
            Assert.IsTrue(output.Contains($"Name: {job1.Name}") && output.Contains($"Employer: {job1.EmployerName}") && output.Contains($"Location: {job1.EmployerLocation}") && output.Contains($"Position Type: {job1.JobType}") && output.Contains($"Core Competency: {job1.JobCoreCompetency}"));

            //this one is very hard coded but perhaps it is better?
            Assert.IsTrue(output.Contains($"Name: Product tester") && output.Contains("Employer: ACME") && output.Contains("Location: Desert") && output.Contains("Position Type: Quality control") && output.Contains("Core Competency: Persistence"));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField_Exists()
        {
            ////test to verify that TestToStringHandlesEmptyField exisits

            //setup
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestToStringHandlesEmptyField";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            //verify test was created
            Assert.AreEqual("true", existsCheck, "'TestToStringHandlesEmptyField' not created");

        }

        [TestMethod]
        public void Test_TestToStringHandlesEmptyField()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var techJobs = new TechJobs();
            techJobs.RunProgram();

            var output = stringWriter.ToString();

            Assert.IsTrue(output.Contains($"Name: {job3.Name}"), "Correct label and value for Name");
            Assert.IsTrue(output.Contains($"Employer: {job3.EmployerName}"), "Incorrect label and value for Employer Name");
            Assert.IsTrue(output.Contains($"Location: {job3.EmployerLocation}"), "Incorrect label and value for Location");
            Assert.IsTrue(output.Contains($"Position Type: {job3.JobType}"), "Incorrect label and value for Position Type");
            Assert.IsTrue(output.Contains($"Core Competency: {job3.JobCoreCompetency}"), "Incorrect label and value for Core Competency");

          //As with Test_TestToStringContainsCorrectLabelsAndData, Is this the best test?  Or does it give too much away?

        }
    }
}
