using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class BMWTests
    {
        // bool assert
        [Fact]
        public void Equals_differentCar_false()
        {
            // arrange 
            BMW bMW = new BMW();
            bMW.velocity = 80;

            // act
            bool isEqual = bMW.Equals(new Toyota());

            // assert
            Assert.False(isEqual);
        }

        // numeric assert
        [Fact]
        public void Accelerate_add5_output20()
        {
            // arrange
            BMW bMW = new BMW();
            bMW.velocity = 5;
            // act
            bMW.Accelerate();
            // assert
            Assert.Equal(20 , bMW.velocity);
            Assert.InRange(bMW.velocity, 20, 30);
        }

        // string assert
        [Fact]
        public void IncreaseVelocity_Add10_Forward()
        {
            // arrange
            BMW bMW = new BMW();
            double addedVelocity = 10;

            // act
            bMW.IncreaseVelocity(addedVelocity);

            // assert
            Assert.StartsWith("For", bMW.drivingMode.ToString());
            Assert.Contains("war", bMW.GetDirection());
            Assert.NotEmpty(bMW.drivingMode.ToString());
            Assert.DoesNotContain("ab" , bMW.GetDirection());
            Assert.DoesNotMatch("^ssd$", bMW.GetDirection());
        }


        // reference assert
        [Fact]
        public void GetMyCar_sameCar_True()
        {
            // arrange
            BMW bmw = new BMW();

            // act
            Car car = bmw.GetMyCar();

            // assert
            Assert.Same(bmw, car);
        }


       // rest of assert tests on carfactoryTests class
    }
}
