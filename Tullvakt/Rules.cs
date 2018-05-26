using System;

namespace Tullvakt
{
    public class Rules
    {

        public static double IsVehicleLightOrHeavy(Vehicles vehicle, double fee)
        {

            if (vehicle.weight <= Toll.StandardWeightInKgs)
            {
                fee = Toll.LightWeightVehicleFee;
                return fee;
            }

            fee = Toll.HeavyWeightVehicleFee;
            return fee;

        }

        public static double IsItNightTime(DateTime datetime, double fee)
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

        public static double IsVehicleATruck(Vehicles vehicle, double fee)
        {
            var toll = new Toll();

            if (vehicle is Truck)
            {
                return Toll.StandardTruckFee;
            }

            return fee;
        }

        public static double IsVehicleAMotoCycle(Vehicles vehicle, double fee)
        {
            var toll = new Toll();

            if (vehicle is Motorcycle)
            {
                return fee * Toll.MotorCycleDiscount;
            }

            return fee;


        }

        public static double IsItWeekendOrAHoliday(Vehicles vehicle, DateTime time, double fee)
        {
            var toll = new Toll();

            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle));
            }


            if (time.DayOfWeek == DayOfWeek.Saturday ||
                time.DayOfWeek == DayOfWeek.Sunday
                )
            {
                return fee * Toll.WeekendAndHolidayMultiplier;
            }

            return fee;

        }


        public static double IsVehicleEnviromentFriendly(Vehicles vehicle, double fee)
        {
            var toll = new Toll();

            if (vehicle.enviromentFriendly == true)
            {
                return Toll.DutyFree;
            }

            return fee;


        }

    }


}


