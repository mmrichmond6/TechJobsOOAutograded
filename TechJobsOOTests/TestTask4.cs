using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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
            Type testType = typeof(TestSettingJobId);
            MemberInfo[] memberInfos = testType.GetMembers();

            string nameCheck = "TestSettingJobIdTest";
            
            //this is using a separate unit test class to see if we can isolate the assert
            //maybe?

            for(int i = 0; i < memberInfos.Length; i++)
            { 
                if (memberInfos[i].Name == nameCheck)
                {
                    string memberList = memberInfos[i].ToString();
                    Console.WriteLine(memberList);
                    //break;
                }
                for (int j = 0; j < memberInfos.Length; j++)
                {
                    string memberType = (memberInfos[i].MemberType.ToString());
                    Console.WriteLine(memberType);
                }
            }
        }

       

        [TestMethod] 
        public void TestJobConstructorSetsAllFields()
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
        public void TestJobsForEquality()
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
        public void TestToStringStartsAndEndsWithNewLine()
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
        public void TestToStringContainsCorrectLabelsAndData()
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
        public void TestToStringHandlesEmptyField()
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
