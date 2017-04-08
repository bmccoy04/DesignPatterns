using System;

namespace DesignPatterns
{
    public class Facade
    {
        private IDoorAdder _doorAdder;
        private IFrameAdder _frameAdder;
        private ICarFinisher _carFinisher;
        public Facade(IDoorAdder doorAdder, IFrameAdder frameAdder, ICarFinisher carFinisher){
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

    public interface ICarFinisher
    {
        TheRest FinishCar();
    }

    public class TheRest
    {
    }

    public class DoorAdder : IDoorAdder
    {
        public Door AddNewDoor(){
            return new Door();
        }
    }

    public interface IFrameAdder {
        Frame AddNewFrame();
    }
    public class Frame{
        
    }

    public interface IDoorAdder{
        Door AddNewDoor();
    }

    public class Car
    {
        public Door Door { get; set; }
        public Frame Frame { get; internal set; }
        public object TheRest { get; internal set; }
    }

    public class Door{
        
    }
}
