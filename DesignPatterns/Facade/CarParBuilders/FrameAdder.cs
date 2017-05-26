using System;
using DesignPatterns.Facade.Models;

namespace DesignPatterns.Facade.CarParBuilders
{
    public class FrameAdder
    {
        public FrameAdder()
        {
        }
    }


	public interface IFrameAdder
	{
		Frame AddNewFrame();
	}
}
