using System;

namespace Tullvakt
{
    public class Rules
    {

        public static double Rule1_Rule2(Vehicles vehicle, double fee)
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
            var toll = new Toll();

            if (datetime.DayOfWeek == DayOfWeek.Saturday ||
                datetime.DayOfWeek == DayOfWeek.Sunday)
            {
                return fee;
            }

            if (datetime.TimeOfDay > toll.startNightFee ||
                datetime.TimeOfDay < toll.endNightFee)
            {
                return fee * Toll.NightTollDiscount;
            }

            return fee;
            

        }

        public static double Rule4(Vehicles vehicle, double fee)
        {
            var toll = new Toll();

            if (vehicle is Truck)
            {
                return Toll.StandardTruckFee;
            }

            return fee;
        }

        public static double Rule5(Vehicles vehicle, double fee)
        {
            var toll = new Toll();

            if (vehicle is Car)
            {
                return Rule1_Rule2(vehicle, fee);
            }

            return fee;


        }

        public static double DetermineOvertimePay(Vehicles vehicle, DateTime time, double fee)
        {
            var toll = new Toll();

            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle));
            }


                if (vehicle is Truck)
                {
                    return fee;
                }

                if (time.DayOfWeek == DayOfWeek.Saturday ||
                    time.DayOfWeek == DayOfWeek.Sunday)
                {
                    return fee;
                }

                if (time.TimeOfDay > toll.startNightFee ||
                    time.TimeOfDay < toll.endNightFee)
                {
                    return fee * Toll.NightTollDiscount;
                }

            return fee;

            }
        }


    
}


