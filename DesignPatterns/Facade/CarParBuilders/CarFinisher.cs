using System;
using DesignPatterns.Facade.Models;
namespace DesignPatterns.Facade.CarParBuilders
{
    public class CarFinisher
    {
        public CarFinisher()
        {
        }
    }


    public interface ICarFinisher
    {
        TheRest FinishCar();
    }
}
