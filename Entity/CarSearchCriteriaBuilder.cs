using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Entity
{
    public class CarSearchCriteriaBuilder
    {
        private readonly CarSearchCriteria _criteria;

        public CarSearchCriteriaBuilder()
        {
            _criteria = new CarSearchCriteria();
        }

        public CarSearchCriteriaBuilder HavingBodyStyle(BodyStyle bodyStyle)
        {
            _criteria.BodyStyle = bodyStyle;
            return this;
        }

        public CarSearchCriteriaBuilder HavingFuelType(FuelType fuelType)
        {
            _criteria.FuelType = fuelType;
            return this;
        }

        public CarSearchCriteriaBuilder ProducedInOrAfterYear(int minYear)
        {
            _criteria.MinYear = minYear;
            return this;
        }

        public CarSearchCriteriaBuilder ProducedInOrBeforeYear(int maxYear)
        {
            _criteria.MaxYear = maxYear;
            return this;
        }

        public CarSearchCriteriaBuilder HavingDoors(int doorCount)
        {
            _criteria.DoorCount = doorCount;
            return this;
        }

        public CarSearchCriteriaBuilder HavingCylinders(int cylinderCount)
        {
            _criteria.CylinderCount = cylinderCount;
            return this;
        }

        public CarSearchCriteria Build()
        {
            Validate();

            return _criteria;
        }

        private void Validate()
        {
            if (_criteria.MinYear.HasValue && _criteria.MaxYear.HasValue && _criteria.MinYear > _criteria.MaxYear)
            {
                throw new InvalidOperationException(String.Format("MinYear({0}) cannot be greater than MaxYear({1}).", _criteria.MinYear, _criteria.MaxYear));
            }

            if (_criteria.BodyStyle == BodyStyle.Coupe && _criteria.DoorCount.HasValue && _criteria.DoorCount != 2)
            {
                throw new InvalidOperationException(String.Format("A coupê must always have two doors as opposed to {0}.", _criteria.DoorCount));
            }

            if (_criteria.CylinderCount.HasValue && (_criteria.CylinderCount < 1 || _criteria.CylinderCount > 12))
            {
                throw new InvalidOperationException(String.Format("The number of cylinders a car may have must be between 1 and 12 as opposed to {0}.", _criteria.CylinderCount));
            }
        }
    }
}
