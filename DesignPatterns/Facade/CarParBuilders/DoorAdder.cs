using System;
using DesignPatterns.Facade.Models;
namespace DesignPatterns.Facade.CarParBuilders
{

	public interface IDoorAdder
	{
		Door AddNewDoor();
	}

	public class DoorAdder : IDoorAdder
	{
		public Door AddNewDoor()
		{
			return new Door();
		}
	}
}
