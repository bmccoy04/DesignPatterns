using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DesignPatterns.Facade.CarParBuilders;
using DesignPatterns.Facade.Models;

namespace DesignPatterns.Test
{
    [TestClass]
    public class FacadeTests
    {
        private Mock<ICarFinisher> _carFinisher;
        private Mock<IDoorAdder> _doorAdder;
        private Mock<IFrameAdder> _frameAdder;
        private CarBuilderFacade _carBuilderFacade;

        [TestInitialize]
        public void init(){
            _carFinisher = new Mock<ICarFinisher>();
            _doorAdder = new Mock<IDoorAdder>();
            _frameAdder = new Mock<IFrameAdder>();

            _carBuilderFacade = new CarBuilderFacade(_doorAdder.Object, 
                                                     _frameAdder.Object, 
                                                     _carFinisher.Object);
        }


        [TestMethod]
        public void BuildCar()
        {
            var expected = new Car();
            var door = new Door();
            var frame = new Frame();
            var theRest = new TheRest();
            expected.Door = door;
            expected.Frame = frame;
            expected.TheRest = theRest;

            _doorAdder.Setup(x => x.AddNewDoor()).Returns(door);
            _frameAdder.Setup(x => x.AddNewFrame()).Returns(frame);
            _carFinisher.Setup(x => x.FinishCar()).Returns(theRest);

            var acatual = _carBuilderFacade.BuildCar();

            Assert.IsNotNull(acatual);
            Assert.AreEqual(expected.Door, acatual.Door);
            Assert.AreEqual(expected.Frame, acatual.Frame);
            Assert.AreEqual(expected.TheRest, acatual.TheRest);

        }
    }
}