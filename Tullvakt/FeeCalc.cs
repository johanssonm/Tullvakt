using System;

namespace Tullvakt
{
    public class Toll
    {
		public int Fee
		{
			get;
			set;
		}
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

		public static double  Rule1_Rule2(Vehicle vehicle, Fee fee)
        {
            if (vehicle.Weight <= Toll.StandardWeightInKgs)
            {
                return Toll.LightWeightVehicleFee;
            }
            
            return Toll.HeavyWeightVehicleFee;

        }

        public static void DetermineNightToll(Vehicle vehicle)
        {

            TimeSpan startTollNightFee = new TimeSpan(StartNightFee);
            TimeSpan endTollNightFee = new TimeSpan(EndNightFee);


            while (true)
            {
                if (vehicle is Truck)
                {
                    break;
                }

                if (vehicle.PassageDay == DayOfWeek.Saturday ||
                    vehicle.PassageDay == DayOfWeek.Sunday)
                {
                    break;
                }

                if (vehicle.PassageTime > startTollNightFee ||
                    vehicle.PassageTime < endTollNightFee)
                {
                    vehicle.Fee = vehicle.Fee * FeeCalc.NightTollDiscount;
                }

                break;

            }
        }

        public static void DetermineOvertimePay(Vehicle vehicle)
        {

            TimeSpan startTollNightFee = new TimeSpan(StartNightFee);
            TimeSpan endTollNightFee = new TimeSpan(EndNightFee);


            while (true)
            {
                if (vehicle is Truck)
                {
                    break;
                }

                if (vehicle.PassageDay == DayOfWeek.Saturday ||
                    vehicle.PassageDay == DayOfWeek.Sunday)
                {
                    break;
                }

                if (vehicle.PassageTime > startTollNightFee ||
                    vehicle.PassageTime < endTollNightFee)
                {
                    vehicle.Fee = vehicle.Fee * FeeCalc.NightTollDiscount;
                }

                break;

            }
        }


    }

}
