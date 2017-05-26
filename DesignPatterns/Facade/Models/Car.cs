using System;
namespace DesignPatterns.Facade.Models
{
    public class Car
    {
        public Door Door { get; set; }
        public Frame Frame { get; set; }
        public object TheRest { get; set; }
    }
}
