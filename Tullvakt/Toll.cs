using System;

namespace Tullvakt
{
	public class Toll
	{
        public TimeSpan startNightFee => new TimeSpan(18,00,00);
        public TimeSpan endNightFee => new TimeSpan(06,00,00);

		public const double LightWeightVehicleFee = 500;
		public const double HeavyWeightVehicleFee = 1000;
		public const double StandardTruckFee = 2000;

		public const double NightTollDiscount = 0.5;
		public const double MotorCycleDiscount = 0.7;
		public const double WeekendAndHolidayMultiplier = 2;
		public const double DutyFree = 0;

		public const double StandardWeightInKgs = 1000;

        public static double CalculateFee(Vehicles vehicle, DateTime datetime)
        {
            double fee = 0;

            fee = Rules.Rule1_Rule2(vehicle, fee);
            fee = Rules.Rule3(datetime, fee);
            fee = Rules.Rule4(vehicle, fee);

            return fee;

        }

	}

}
