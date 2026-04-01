using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scot_Water_Application.Models
{
   
        public static class GlobalVariables
        {
            // ---------------- SYSTEM SETTINGS ----------------
            public static double WaterReserveLevel = 100; // percentage

            // ---------------- STANDARD RATES ----------------
            public static double StandardRate1 = 0.41; // 0-40 units
            public static double StandardRate2 = 0.64; // 41-80 units
            public static double StandardRate3 = 1.35; // 81+

            // ---------------- LOW RESERVE RATES ----------------
            public static double LowReserveRate1 = 0.47;
            public static double LowReserveRate2 = 0.82;
            public static double LowReserveRate3 = 2.25;

            // ---------------- RECYCLING DISCOUNTS ----------------
            public static double RecycleDiscount1 = 0.05; // 0-5
            public static double RecycleDiscount2 = 0.15; // 6-20
            public static double RecycleDiscount3 = 0.25; // 21+

            // ---------------- CURRENT USER ----------------
            public static string UserLogIn = "";

            // ---------------- CURRENT BUSINESS ----------------
            public static int SelectedBusinessID = 0;
            public static string SelectedBusinessName = "";

            // ---------------- UI SETTINGS ----------------
            public static string CompanyName = "Scot-Water";
        }
    }


