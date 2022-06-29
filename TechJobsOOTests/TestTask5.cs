using System;
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
        // and that the method works

        TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        TechJob job2 = new TechJob("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
        TechJob job3 = new TechJob("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine_Test()
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
        public void TestToString_Starts_And_Ends_With_NewLine()
        {
            TechJobs techJobs = new TechJobs();
                techJobs.RunProgram();
            
            var studentBuilder = new StringBuilder();
            studentBuilder.Append(techJobs);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
           

            //this part is working -- not sure its the best way
            var stringBuilder = new StringBuilder();
                stringBuilder.Append(Environment.NewLine + "1" + Environment.NewLine + "Product tester" + Environment.NewLine + "ACME" + Environment.NewLine + "Desert" + Environment.NewLine + "Quality control" + Environment.NewLine + "Persistence" + Environment.NewLine +
                                     Environment.NewLine + "2" + Environment.NewLine + "Web Developer" + Environment.NewLine + "LaunchCode" + Environment.NewLine + "St. Louis" + Environment.NewLine + "Front-end developer" + Environment.NewLine + "JavaScript" + Environment.NewLine +
                                     Environment.NewLine + "3" + Environment.NewLine + "Ice cream tester" + Environment.NewLine + "" + Environment.NewLine + "Home" + Environment.NewLine + "UX" + Environment.NewLine + "Tasting ability" + Environment.NewLine);

            var output = stringWriter.ToString();

            Assert.AreEqual(stringBuilder, output, "Not Working");

            //I would like to try to compare outputs for this test so that my test doesn't give away the solution to the students
            //not sure the best way to do this.  will need to update the program/TechJobs files to make this work.
        }




        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData_Test()
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
        public void TestToStringHandlesEmptyField_Test()
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






    }
}
