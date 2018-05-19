using System;

namespace Tullvakt
{
    public class Rules
    {
        
        public static double Rule1_Rule2(Vehicle vehicle, double fee)
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
