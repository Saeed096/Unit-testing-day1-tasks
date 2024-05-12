using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibraryTest
{
    public class CarFactoryTests
    {
        // type assert
        [Fact]
        public void NewCar_toyotaCar_isACar()
        {
            // arrange 

            // act
            Car? car = CarFactory.NewCar(CarTypes.Toyota);

            // assert 
            Assert.IsAssignableFrom<Car>(car);

        }

        // exception assert
        [Fact]
        public void NewCar_hondaCar_NotImplementedException()
        {
            // arrange

            // act 

            // assert

            Assert.Throws<NotImplementedException>(() =>
            {
                CarFactory.NewCar(CarTypes.Honda);
            });
        }
    }
}
