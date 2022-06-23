using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsTests;

namespace TechJobsOOTests
{
    //Tests to verify if the tests were created by students

    [TestClass]
    public class TestTask4
    {
        
        Type testType = typeof(JobTests);
       

        [TestMethod] //1
        public void Test_For_TestSettingJobId()
        {
           
            MemberInfo[] memberInfos = testType.GetMembers();

            List<object> checkThisOut = new List<object>();
            string testExists = "";
            string assertExists = "";

            foreach( var mInfo in memberInfos)
            { 
                
                if(mInfo.Name == "TestSettingJobId")
                {
                    //not quite working...
                    //trying to crack into this method to count tests (> 0)
                    checkThisOut.Add(mInfo);
                    if(checkThisOut.Count > 0)
                    {
                        testExists += "true";
                        assertExists += "true";

                        break;
                    }
                }
            }


            Assert.AreEqual("true", testExists, "'TestSettingJobId does not exist");
            Assert.IsTrue(assertExists == "true");


    
        }
    

        [TestMethod] 
        public void TestJobConstructorSetsAllFields()
        {
            Type testType = typeof(TechJobsTests.JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestJobConstructorSetsAllFields";
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
            Assert.AreEqual("true", existsCheck, "'TestJobConstructorSetsAllFields' created");

        }


        [TestMethod] 
        public void TestJobsForEquality()
        {
            Type testType = typeof(TechJobsTests.JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestJobsForEquality";
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
            Assert.AreEqual("true", existsCheck, "'TestJobsForEquality' created");

        }

        [TestMethod] 
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Type testType = typeof(TechJobsTests.JobTests);
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
            Assert.AreEqual("true", existsCheck, "'TestToStringStartsAndEndsWithNewLine' created");

        }

        [TestMethod] 
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Type testType = typeof(TechJobsTests.JobTests);
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
            Assert.AreEqual("true", existsCheck, "'TestToStringContainsCorrectLabelsAndData' created");
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Type testType = typeof(TechJobsTests.JobTests);
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
            Assert.AreEqual("true", existsCheck, "'TestToStringHandlesEmptyField' created");

        }

    }
}
