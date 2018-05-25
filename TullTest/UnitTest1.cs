//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Tullvakt;

//namespace Tulltester
//{
//    [TestClass]
//    public class Regler
//    {
//        [TestMethod]
//        public void Rule1()
//        {
//            // Arrange

//            var heavyvehicle = new Car(1001);
//            var heavyVehicle1 = new Car(1200);

//            //Assert

//            Assert.AreEqual(1000, heavyvehicle.Fee);
//            Assert.AreEqual(1000, heavyVehicle1.Fee);

//        }

//        [TestMethod]
//        public void Rule2()
//        {
//            // Arrange

//            var heavyVehicle = new Car(1001);
//            var heavyVehicle1 = new Car(1200);
//            var lightVehicle = new Car(1000);
//            var lightVehicle1 = new Car(400);

//            //Assert

//            Assert.AreEqual(1000, heavyVehicle.Fee);
//            Assert.AreEqual(1000, heavyVehicle1.Fee);
//            Assert.AreEqual(500, lightVehicle.Fee);
//            Assert.AreEqual(500, lightVehicle1.Fee);
//        }

//        [TestMethod]
//        public void Rule3_NightTimeWeekday()
//        {
//            // Arrange

//            var heavyNightVehicle = new Vehicles(1200);
//            var timespan = new TimeSpan(2200);
//            heavyNightVehicle.timeOfPassage = timespan;
//            heavyNightVehicle.dateOfPassage = new DateTime(2018, 05, 16);

//            var lightNightVehicle = new Vehicles(999);
//            var timespan1 = new TimeSpan(1801);
//            lightNightVehicle.timeOfPassage = timespan1;
//            lightNightVehicle.dateOfPassage = new DateTime(2018, 05, 16);
//            //Act

//            FeeCalc.DetermineNightFee(heavyNightVehicle);
//            FeeCalc.DetermineNightFee(lightNightVehicle);


//            //Assert

//            Assert.AreEqual(500, heavyNightVehicle.Fee);
//            Assert.AreEqual(250, lightNightVehicle.Fee);
//        }

//        [TestMethod]
//        public void Rule3_DayTimeWeekday()
//        {
//            // Arrange

//            var heavyVehicle = new Vehicles(1200);
//            var timespan2 = new TimeSpan(0700);
//            heavyVehicle.timeOfPassage = timespan2;
//            heavyVehicle.dateOfPassage = new DateTime(2018, 05, 14);

//            var lightVehicle = new Vehicles(999);
//            var timespan3 = new TimeSpan(1600);
//            lightVehicle.timeOfPassage = timespan3;
//            lightVehicle.dateOfPassage = new DateTime(2018, 05, 15);
//            //Act

//            FeeCalc.DetermineNightFee(heavyVehicle);
//            FeeCalc.DetermineNightFee(lightVehicle);



//            //Assert

//            Assert.AreEqual(FeeCalc.HeavyWeightVehicleFee, heavyVehicle.Fee);
//            Assert.AreEqual(FeeCalc.LightWeightVehicleFee, lightVehicle.Fee);
//        }

//        [TestMethod]
//        public void Rule3_Weekend()
//        {

//            // Regel 7 ställer till det för regel 3. Avgiften dubblas istället...

//            // Arrange

//            var heavyNightVehicle = new Vehicles(1200);
//            var timespan = new TimeSpan(2200);
//            heavyNightVehicle.timeOfPassage = timespan;
//            heavyNightVehicle.dateOfPassage = new DateTime(2018, 05, 19);

//            var lightNightVehicle = new Vehicles(999);
//            var timespan1 = new TimeSpan(1801);
//            lightNightVehicle.timeOfPassage = timespan1;
//            lightNightVehicle.dateOfPassage = new DateTime(2018, 05, 20);

//            var weekday = lightNightVehicle.weekdayOfPassage;
//            //Act

//            FeeCalc.DetermineOvertimeFee(heavyNightVehicle);
//            FeeCalc.DetermineOvertimeFee(lightNightVehicle);



//            //Assert

//            Assert.AreEqual(2000, heavyNightVehicle.Fee);
//            Assert.AreEqual(1000, lightNightVehicle.Fee);
//        }


//        [TestMethod]
//        public void Rule4()
//        {
//            // Arrange

//            var testVehicle = new Truck();
//            var timespan = new TimeSpan(2200);

//            testVehicle.timeOfPassage = timespan;
//            testVehicle.dateOfPassage = new DateTime(2018, 05, 14);

//            //Act

//            FeeCalc.DetermineNightFee(testVehicle);

//            //Assert

//            Assert.AreEqual(2000, testVehicle.Fee);
//        }

//        [TestMethod]
//        public void Rule5()
//        {
//            // Arrange

//            var testVehicle = new Car(1200);
//            var timespan = new TimeSpan(1600);

//            testVehicle.timeOfPassage = timespan;
//            testVehicle.dateOfPassage = new DateTime(2018, 05, 15);

//            //Act

//            FeeCalc.DetermineNightFee(testVehicle);

//            //Assert

//            Assert.AreEqual(1000, testVehicle.Fee);
//        }

//        [TestMethod]
//        public void Rule6()
//        {
//            // Arrange

//            var heavyTestBike = new MotorCycle(1100);
//            var timespane = new TimeSpan(2200);

//            heavyTestBike.timeOfPassage = timespane;
//            heavyTestBike.dateOfPassage = new DateTime(2018, 05, 14);

//            var lightTestBike = new MotorCycle(800);
//            var timespane1 = new TimeSpan(2200);

//            lightTestBike.timeOfPassage = timespane1;
//            lightTestBike.dateOfPassage = new DateTime(2018, 05, 14);


//            //Act

//            FeeCalc.DetermineNightFee(heavyTestBike);
//            FeeCalc.DetermineNightFee(lightTestBike);

//            //Assert

//            Assert.AreEqual(350, heavyTestBike.Fee);
//            Assert.AreEqual(175, lightTestBike.Fee);
//        }

//        [TestMethod]
//        public void Rule7()
//        {
//            // Arrange

//            var testVehicle = new PrivateCar(1200);
//            var timespan = new TimeSpan(1600);

//            testVehicle.timeOfPassage = timespan;
//            testVehicle.dateOfPassage = new DateTime(2018, 12, 24);


//            //Act

//            FeeCalc.DetermineOvertimeFee(testVehicle);


//            //Assert

//            Assert.AreEqual(2000, testVehicle.Fee);
//        }

//        [TestMethod]
//        public void Rule8()
//        {
//            // Arrange

//            var enviromentFriendlyVehicle = new Car(1000);
//            var nonEnviromentFriendlyVehicle = new Car(1200);

//            enviromentFriendlyVehicle.enviromentFriendly = true;
//            nonEnviromentFriendlyVehicle.enviromentFriendly = false;

//            //Act

//            FeeCalc.DetermineEnviromentFriendlyFee(enviromentFriendlyVehicle);
//            FeeCalc.DetermineEnviromentFriendlyFee(nonEnviromentFriendlyVehicle);

//            //Assert

//            Assert.AreEqual(0, enviromentFriendlyVehicle.Fee);
//            Assert.AreEqual(1000, nonEnviromentFriendlyVehicle.Fee);

//        }t
//    }




//}
