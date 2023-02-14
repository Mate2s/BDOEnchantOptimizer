using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnchantTable
{
    public static class EnchantTable
    {
        public static double[] Weapon { get; } = {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            0.2,
            0.175,
            0.15,
            0.125,
            0.1,
            0.075,
            0.05,
            0.06,
            0.11757,
            0.07687,
            0.06245,
            0.02,
            0.003
        };

        public static double[] WeaponFailstack { get; } = {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0.025,
            0.02,
            0.015,
            0.0125,
            0.0075,
            0.0063,
            0.005,
            0.006,
            0.01176666,
            0.0076979,
            0.0062506,
            0.002,
            0.0003
        };

        public static int[] WeaponMaxFailstack { get; } = {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            13,
            14,
            15,
            16,
            18,
            20,
            25,
            107,
            50,
            82,
            102,
            134,
            999
        };

        public static double[] Armor { get; } = {
            1,
            1,
            1,
            1,
            1,
            0.2,
            0.175,
            0.1625,
            0.15,
            0.125,
            0.1125,
            0.1,
            0.075,
            0.05,
            0.02,
            0.11757,
            0.07687,
            0.06245,
            0.02,
            0.003
        };

        public static double[] ArmorFailstack { get; } = {
            0,
            0,
            0,
            0,
            0,
            0.025,
            0.02,
            0.0175,
            0.015,
            0.0125,
            0.01,
            0.0075,
            0.0063,
            0.005,
            0.002,
            0.01176666,
            0.0076979,
            0.0062506,
            0.002,
            0.0003
        };

        public static int[] ArmorMaxFailstack { get; } = {
            1,
            1,
            1,
            1,
            1,
            13,
            14,
            14,
            15,
            16,
            17,
            18,
            20,
            25,
            134,
            50,
            82,
            102,
            134,
            999
        };

        public static double[] Accessory { get; } = {
            0.25,
            0.1,
            0.075,
            0.025,
            0.005
        };

        public static double[] AccessoryFailstack { get; } = {
            0.025,
            0.01,
            0.0075,
            0.0025,
            0.0005
        };

        public static int[] AccessoryMaxFailstack { get; } = {
            18,
            40,
            44,
            110,
            134
        };
    }
}
