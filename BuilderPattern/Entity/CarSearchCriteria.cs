using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Entity
{
    public class CarSearchCriteria
    {
        public BodyStyle BodyStyle { get; set; }
        public FuelType FuelType { get; set; }
        public int? CylinderCount { get; set; }
        public int? MinMileage { get; set; }
        public int? MaxMileage { get; set; }
        public int? MinYear { get; set; }
        public int? MaxYear { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public bool? HasSunroof { get; set; }
        public int? DoorCount { get; set; }

        public CarSearchCriteria()
        {
        }

        /// <summary>
        /// This is a constructor we do NOT want to have
        /// </summary>
        public CarSearchCriteria(BodyStyle bodyStyle,
                                 FuelType fuelType,
                                 int? cylinderCount,
                                 int? minMileage,
                                 int? maxMileage,
                                 int? minYear,
                                 int? maxYear,
                                 int? minPrice,
                                 int? maxPrice,
                                 bool? hasSunroof,
                                 int? doorCount)
        {
            this.BodyStyle = bodyStyle;
            this.FuelType = fuelType;
            this.CylinderCount = cylinderCount;
            this.MinMileage = minMileage;
            this.MaxMileage = maxMileage;
            this.MinYear = minYear;
            this.MaxYear = maxYear;
            this.MinPrice = minPrice;
            this.MaxPrice = maxPrice;
            this.HasSunroof = hasSunroof;
        }
    }
}
