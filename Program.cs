
using System;
using System.Collections.Generic;
using System.Text;
using BuilderPattern.Entity;

namespace BuilderPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            //var criteria = new CarSearchCriteria(BodyStyle.Hatchback, FuelType.Diesel, null, null, null, 2014, 2019, null, null, null, null);

            var criteria = new CarSearchCriteriaBuilder().HavingBodyStyle(BodyStyle.Hatchback)
                                                         .HavingFuelType(FuelType.Diesel)
                                                         .ProducedInOrAfterYear(2014)
                                                         .ProducedInOrBeforeYear(2019)
                                                         .Build();

            List<Car> results = CarSearcher.Search(criteria);

            // Display results...
        }
    }
}
