﻿using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianHouseValue
{
    internal class HousingData
    {
        [LoadColumn(0)]
        public float Longitutde { get; set; }

        [LoadColumn(1)]
        public float Latitude { get; set; }

        [LoadColumn(2)]
        public float HousingMedianAge { get; set; }

        [LoadColumn(3)]
        public float TotalRooms { get; set; }

        [LoadColumn(4)]
        public float TotalBedRooms { get; set; }

        [LoadColumn(5)]
        public float Population { get; set; }

        [LoadColumn(6)]
        public float Households { get; set; }

        [LoadColumn(7)]
        public float MedianIncome { get; set; }

        [LoadColumn(8), ColumnName("Label")]
        public float MedianHouseValue { get; set; }

        [LoadColumn(9)]
        public float OceanProximity { get; set; }
    }
}
