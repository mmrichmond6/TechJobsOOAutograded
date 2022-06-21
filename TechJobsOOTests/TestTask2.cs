using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System.Reflection;


namespace TechJobsOOTests
{
    // These tests are only for items contained in Task 2.

    [TestClass]
    public class TestTask2
    {

    // Testing Location --------------------------------------------------------

        //Run after student has completed Location class tasks

        [TestMethod] //1
                     //2nd constructor takes a string value - should not be null
        public void Test_Second_Location_Constructor_Exists()
        { 
            Type locType = typeof(Location);
            Console.WriteLine(locType);
            ConstructorInfo[] constructorInfos = locType.GetConstructors();

            MemberInfo[] memberInfos = locType.GetMembers();
            int memberLength = memberInfos.Length;
            //verify
            Assert.AreEqual(memberLength, 11);
        }

        [TestMethod] //2
                     //Testing if we can update the Value
        public void Test_Second_Location_Constructor_Initializes_Value()
        {
            //setup
            Location testLocation = new Location("Desert");
            Location testLocation2 = new Location("St. Louis");

            //verify
            Assert.AreEqual("Desert", testLocation.Value);
            Assert.AreEqual("St. Louis", testLocation2.Value);


            //For QA:  I'd like to explore the reflection namespace more for this test
            //these tests currently work, but not sure if they are robust enough
            //tests 2-6
            //CF
        }

        [TestMethod] //3
                     //Testing if ': this()' initalizes the location's id
        public void Test_Second_Location_Constructor_Initializes_Id()
        {
            //setup
            Location testLocation = new Location("Desert");

            //verify
            Assert.AreEqual(3, testLocation.Id);
            Assert.IsNotNull(testLocation.Id);
        }

    // Testing CoreCompetency --------------------------------------------------

        [TestMethod] //4
        public void Test_Core_Competency_Has_Value_Accessors()
        {
            CoreCompetency testComp = new CoreCompetency("Persistence");

            Assert.AreEqual("Persistence", testComp.Value);
        }

        [TestMethod]
        public void Test_CoreCompetency_Has_Id_Getter_SetUp()
        {
            //setup
            Type ccType = typeof(CoreCompetency); 
            MemberInfo[] memberInfos = ccType.GetMembers();
            string nameCheck = "get_Id";
            string existsCheck = "";
            
            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    Console.WriteLine(existsCheck);
                    break;
                }
            }
            //verify
            Assert.AreEqual("true", existsCheck);
        }

        [TestMethod] //5b
                     //Verifying that Getter works for Id by creating second CoreComp object
        public void Test_CoreCompetency_Has_Id_Getter_Output()
        {
            CoreCompetency testComp = new CoreCompetency("Persistence");
            CoreCompetency testComp2 = new CoreCompetency("Persistence");

            //testComp.Id = 5  & testComp2.Id should be 6
            Assert.AreNotEqual(testComp.Id, testComp2.Id);
        }

        [TestMethod] //6
                     //should not be able to set the Id - getter only
        public void Test_CoreCompetency_Has_No_Id_Setter_SetUp()
        {
            Type ccType = typeof(CoreCompetency);
            MemberInfo[] memberInfos = ccType.GetMembers();
            string nameCheck = "set_Id";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name != nameCheck)
                {
                    existsCheck += "false";
                    Console.WriteLine(existsCheck);
                    break;
                }
            }
            //verify
            Assert.AreEqual("false", existsCheck);
        }

        // Testing PositionType ----------------------------------------------------


        // testing the ToString, Equals, and GetHashCode methods

        [TestMethod] //7a
        public void Test_PositionType_Equals_Method_SetUp()
        {
            //Get method body information
            MethodInfo mInfo = typeof(PositionType).GetMethod("Equals");
            MethodBody mBody = mInfo.GetMethodBody();

            //isolate testable elements
            int lviCount = mBody.LocalVariables.Count;
            string mName = mInfo.ReflectedType.Name;
            string mGBD = mInfo.GetBaseDefinition().ReflectedType.Name;

            //verify
            Assert.AreNotEqual(mName, mGBD);
            Assert.AreEqual(lviCount, 2);
        }

        [TestMethod] //7b
        public void Test_PositionType_Equals_Method_Output()
        {
            // set up
            PositionType testPosition = new PositionType("Quality Control");
            PositionType testPosition2 = new PositionType("Quality Control");

            Assert.AreEqual(testPosition, testPosition);
            Assert.AreNotEqual(testPosition, testPosition2);
        }

        [TestMethod] //8a
                     // should have 1 local variable once created
        public void Test_PositionType_HashCode_SetUp()
        {
            //setup
            MethodInfo mInfo = typeof(PositionType).GetMethod("GetHashCode");
            MethodBody mBody = mInfo.GetMethodBody();
            int localCount = mBody.LocalVariables.Count;

            //verify
            Assert.IsTrue(localCount > 0);
        }

        [TestMethod] //8b
                    // should create unique hashcode for each object
        public void Test_PositionType_GetHashCode_Method_Output()
        {
            // set up
            PositionType testPosition = new PositionType("Quality Control");
            PositionType testPosition2 = new PositionType("Quality Control");

            //verify 
            Assert.AreNotEqual(testPosition.GetHashCode(), testPosition2.GetHashCode());
        }

        [TestMethod] //9a
                     // should have 1 local variable once created
        public void Test_PositionType_ToString_SetUp()
        {
            //setup
            MethodInfo mInfo = typeof(PositionType).GetMethod("ToString");
            MethodBody mBody = mInfo.GetMethodBody();
            int localCount = mBody.LocalVariables.Count;

            //verify
            Assert.IsTrue(localCount > 0);
        }

        [TestMethod] //9b
                        //returning the value only at this time
        public void Test_PositionType_ToString_Method_Output()
        {
            // set up
            PositionType testPosition = new PositionType("Quality Control");

            Assert.AreEqual(testPosition.Value.ToString(), "Quality Control");
            Assert.AreNotEqual(testPosition.Value.ToString(), "Testing To String Method");
        }


    }
}


/*
 * DUMMY CLASS FOR TESTING(See Job 1 in Program file)
    * Id
    * Job Name: Product tester
    * Employer: ACME
    * Location: Desert
    * PositionType: Quality control
    * CoreCompetency: Persistence
 */

