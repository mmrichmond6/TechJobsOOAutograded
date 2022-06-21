using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System.Reflection;
using System.Collections.Generic;

namespace TechJobsOOTests
{
    [TestClass]
    public class TestTask3
    {
        [TestMethod]    //1a
        public void Test_JobClass_Has_No_Arg_Constructor()
        {
            Type jobType = typeof(Job);
            ConstructorInfo[] constructorInfos = jobType.GetConstructors();
            List<string> conNames = new List<string>();
            string nameCheck = "No Arg Constructor";
            string existsCheck = "";

            foreach (var name in constructorInfos)
            {
                conNames.Add(name.ToString());
                
            }

            foreach (string name in conNames)
            {
               if( name.Equals("Void .ctor()"))
               {
                    existsCheck += "No Arg Constructor";
                    break;
                }
            }

            Console.WriteLine(existsCheck);
            //verify
            Assert.AreEqual(existsCheck, nameCheck);

        }

        [TestMethod]
        public void Test_No_Arg_Constructor_Sets_Id()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.AreNotEqual(testJob1, testJob2);
            Assert.AreEqual(testJob2, testJob2);
        }

        [TestMethod]  //2
        public void Test_JobClass_Has_Second_Constructror()
        {
            //setup
            Type jobType = typeof(Job);
            ConstructorInfo[] constructorInfos = jobType.GetConstructors();
            List<string> conNames = new List<string>();
            string nameCheck = "Second Constructor";
            string existsCheck = "";

            foreach (var name in constructorInfos)
            {
                conNames.Add(name.ToString());
            }
            
            foreach (string name in conNames)
            {
                if (name.Contains("Void .ctor(System.String, TechJobsOO.Employer,"))
                {
                    existsCheck += "Second Constructor";
                    break;
                }
            }
            //verify
            Assert.AreEqual(existsCheck, nameCheck);
        }

        //Test what second constructor contains ??


        [TestMethod]    //3a
        public void Test_JobClass_Has_Accessors_SetUp()
        {
            //See task 2 for ideas
        }

        [TestMethod]    //3b
        public void Test_JobClass_Accessors_Output()
        {
            //See task 2 for ideas
        }


        [TestMethod]    //4a
        public void Test_Equals_Method_Setup()
        {
            //See task 2 for ideas
        }

        [TestMethod]  //4b
        public void Test_Equals_Method_Output()
        {
            //See task 2 for ideas
        }

        [TestMethod]  //5a
        public void Test_GetHashCode_Setup()
        {
            //See task 2 for ideas
        }

        [TestMethod]  //5b
        public void Test_GetHashCode_Output()
        {
            //See task 2 for ideas
        }




    }
}
