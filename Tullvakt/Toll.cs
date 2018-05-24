namespace Tullvakt
{
	public class Toll
	{
		public int Fee { get; set; }
		public const int StartNightFee = 1800;
		public const int EndNightFee = 0600;

		public const double LightWeightVehicleFee = 500;
		public const double HeavyWeightVehicleFee = 1000;
		public const double StandardTruckFee = 2000;

		public const double NightTollDiscount = 0.5;
		public const double MotorCycleDiscount = 0.7;
		public const double WeekendAndHolidayMultiplier = 2;
		public const double DutyFree = 0;

		public const double StandardWeightInKgs = 1000;

	}

}
