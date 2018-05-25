using System;

namespace Tullvakt
{


	public abstract class Vehicles
	{
        
		public int weight { get; set; }
		public bool enviromentFriendly { get; set; }
        
	}

	public class Car : Vehicles
	{
		
	}

	public class Truck : Vehicles
    {

	
	}

	public class Motorcycle : Vehicles
    {

    }


   
}
