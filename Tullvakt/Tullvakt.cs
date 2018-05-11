using System;
using Tullvakt;

namespace Tullvakt
{
    public static class FeeCalc
    {
        public const int LightWeightVehicleFee = 500;
        public const int HeavyWeightVehicleFee = 1000;
        public const int StandardTruckFee = 1000;
        public const double NightTollFeeMultiplier = 1.5;

        public const int StandardWeightInKgs = 1000;
    }


    interface ITollfee
    {
        void Tollfee();
    }

    public class Vehicle
    {

        public int Weight { get; set; }
        public int Fee { get; set; }
        public TimeSpan PassageTime { get; set; }

        public Vehicle(int weight)
        {

            if (weight >= FeeCalc.StandardWeightInKgs)
            {
                Fee = FeeCalc.HeavyWeightVehicleFee;
            }

            if (weight < FeeCalc.StandardWeightInKgs)
            {
                Fee = FeeCalc.LightWeightVehicleFee;
            }

            Weight = weight;
        }


    }

    public class Truck : Vehicle
    {

        public Truck(int weight) : base(weight)
        {
            Weight = weight;
            Fee = FeeCalc.StandardTruckFee;

        }
    }

    public class PrivateCar : Vehicle
    {

        public PrivateCar(int weight) : base(weight)
        {

            Weight = Weight;
            Fee = FeeCalc.LightWeightVehicleFee;
        }


    }

    public class Motobike : Vehicle
    {

        public Motobike(int weight, int fee) : base(weight)

        {

        }

    }

    public class Toll
    {



    }


}
