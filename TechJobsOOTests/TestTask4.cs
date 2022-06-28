using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsTests;
using Moq;


namespace TechJobsOOTests
{
    //Tests to verify if the tests were created by students

    [TestClass]
    public class TestTask4
    {

       


        [TestMethod] //1
        public void Test_TestSettingJobIdExists()
        {
            //setup
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestSettingJobId";
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
            Assert.AreEqual("true", existsCheck, "'TestSettingJobId' not created");

        }


        [TestMethod] 
        public void Test_TestJobConstructorSetsAllFields()
        {
            Type testType = typeof(JobTests);
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
        public void Test_JobConstructor_ForAllFields_Mocked()
        {
            
            Mock<JobTests> mockedTests = new Mock<JobTests>();
            mockedTests.Setup(a => a.TestJobConstructorSetsAllFields());
            mockedTests.Verify(v => v.TestJobConstructorSetsAllFields(), Times.AtLeast(2));

            //error:
                //Test method TechJobsOOTests.TestTask4.Test_JobConstructor_ForAllFields_Mocked threw exception: 
                //System.NotSupportedException: Unsupported expression: a => a.TestJobConstructorSetsAllFields()
                //Non - overridable members(here: JobTests.TestJobConstructorSetsAllFields) may not be used in setup / verification expressions.

            //maybe this will help? https://docs.microsoft.com/en-us/visualstudio/msbuild/tutorial-test-custom-task?view=vs-2022

        }

        [TestMethod] 
        public void Test_TestJobsForEquality()
        {
            Type testType = typeof(JobTests);
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
        public void Test_TestToStringStartsAndEndsWithNewLine()
        {
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
            Assert.AreEqual("true", existsCheck, "'TestToStringStartsAndEndsWithNewLine' created");

        }

        [TestMethod] 
        public void Test_TestToStringContainsCorrectLabelsAndData()
        {
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
            Assert.AreEqual("true", existsCheck, "'TestToStringContainsCorrectLabelsAndData' created");
        }

        [TestMethod]
        public void Test_TestToStringHandlesEmptyField()
        {
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
            Assert.AreEqual("true", existsCheck, "'TestToStringHandlesEmptyField' created");

        }

    }
}
