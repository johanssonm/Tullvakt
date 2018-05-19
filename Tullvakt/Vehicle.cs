using System;

namespace Tullvakt
{


	public abstract class Vehicle
	{

		public int Weight { get; set; }
		public bool EnviromentFriendly { get; set; }

		public Vehicle()
		{
		}
	}

   
	public class Truck : Vehicle
    {
    
    }

    public class PrivateCar : Vehicle
    {


    }

    public class MotorCycle : Vehicle
    {
    

    }


}
