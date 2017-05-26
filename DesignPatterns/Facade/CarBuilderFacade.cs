using System;
using DesignPatterns.Facade.CarParBuilders;
using DesignPatterns.Facade.Models;

namespace DesignPatterns
{
    public class CarBuilderFacade
    {
        private IDoorAdder _doorAdder;
        private IFrameAdder _frameAdder;
        private ICarFinisher _carFinisher;

        public CarBuilderFacade(IDoorAdder doorAdder, IFrameAdder frameAdder, ICarFinisher carFinisher){
            _doorAdder = doorAdder;
            _frameAdder = frameAdder;
            _carFinisher = carFinisher;
        }

        public Car BuildCar(){
            var car = new Car();

            car.Door = _doorAdder.AddNewDoor();
            car.Frame = _frameAdder.AddNewFrame();
            car.TheRest = _carFinisher.FinishCar();
            
            return car;
        }
    }




 

}
