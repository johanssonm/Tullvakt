using System;
using Tullvakt;

namespace Tullvakt
{
    public static class FeeCalc
    {
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

        public static double DetermineFeeByWeight(double weight)
        {
            if (weight <= FeeCalc.StandardWeightInKgs)
            {
                return FeeCalc.LightWeightVehicleFee;
            }

            return FeeCalc.HeavyWeightVehicleFee;

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

    public class Vehicle
    {

        public int Weight { get; set; }
        public double Fee { get; set; }
        public bool EnviromentFriendly { get; set; }
        public TimeSpan PassageTime { get; set; }
        public DayOfWeek PassageDay { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(int weight)
        {
            Fee = FeeCalc.DetermineFeeByWeight(weight);
            Weight = weight;
        }


    }

    public class Truck : Vehicle
    {

        public Truck()
        {
            Fee = FeeCalc.StandardTruckFee;

        }
    }

    public class PrivateCar : Vehicle
    {
        public PrivateCar(int weight)

        {
            Fee = FeeCalc.DetermineFeeByWeight(weight);

            Weight = weight;

        }

    }

    public class MotorCycle : Vehicle
    {

        public MotorCycle(int weight)

        {
            Fee = FeeCalc.DetermineFeeByWeight(weight) * FeeCalc.MotorCycleDiscount;

            Weight = weight;

        }

    }

}
