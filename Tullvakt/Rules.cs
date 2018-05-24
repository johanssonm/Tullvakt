using System;

namespace Tullvakt
{
    public class Rules
    {
        
        public static double Rule1_Rule2(Vehicle vehicle, double fee)
        {
			
            if (vehicle.weight <= Toll.StandardWeightInKgs)
            {
				fee = Toll.LightWeightVehicleFee;
                return fee;
            }

			fee = Toll.HeavyWeightVehicleFee;
            return fee;

        }

		public static double Rule3(DateTime datetime, double fee)
        {

			DateTime startTollNightFee = new DateTime(Toll.StartNightFee);
			DateTime endTollNightFee = new DateTime(Toll.EndNightFee);
                     
			if (datetime.DayOfWeek == DayOfWeek.Saturday ||
			    datetime.DayOfWeek == DayOfWeek.Sunday)
                {
				return fee;
                }

                if (datetime > startTollNightFee ||
                    datetime < endTollNightFee)
                {
                    return fee * Toll.NightTollDiscount;
                }
                     
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
