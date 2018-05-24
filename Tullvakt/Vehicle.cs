using System;

namespace Tullvakt
{


	public abstract class Vehicle
	{
        
		public int weight { get; set; }
		public bool enviromentFriendly { get; set; }
        
	}

	public class Car : Vehicle
	{
		
	}

	public class Truck : Vehicle
    {

	
	}

	public class Motorcycle : Vehicle
    {

    }


   
}
