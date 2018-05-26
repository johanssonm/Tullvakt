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

            fee = Rules.IsVehicleLightOrHeavy(vehicle, fee);
            fee = Rules.IsItNightTime(datetime, fee);
            fee = Rules.IsVehicleATruck(vehicle, fee);
            fee = Rules.IsVehicleAMotoCycle(vehicle, fee);
            fee = Rules.IsItWeekendOrAHoliday(vehicle, datetime, fee);
            fee = Rules.IsVehicleEnviromentFriendly(vehicle, fee);

            return fee;

        }

	}

}
