﻿using System;
using Tullvakt;

namespace Tullvakt
{
    public static class FeeCalc
    {
        public const double LightWeightVehicleFee = 500;
        public const double HeavyWeightVehicleFee = 1000;
        public const double StandardTruckFee = 2000;
        public const double NightTollFeeMultiplier = 0.5;

        public const int StandardWeightInKgs = 1000;


    }


    interface ITollfee
    {
        void Tollfee();
    }

    public class Vehicle
    {

        public int Weight { get; set; }
        public double Fee { get; set; }
        public TimeSpan PassageTime { get; set; }
        public DayOfWeek PassageDay { get; set; }

        public Vehicle()
        {
        }

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

        public Truck()
        {
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
