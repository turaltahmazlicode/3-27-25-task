using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CarTask
{
    public class CarShowroom
    {
        public CarShowroom() => Cars = [];
        public CarShowroom(Car[] cars) => Cars = cars;

        private Car[] _cars;

        public Car[] Cars
        {
            get => _cars;
            private set => _cars = value ?? [];
        }

        #region methods
        public Car[] GetCars() => Cars;

        public int GetCarCount() => Cars.Length;

        public decimal GetTotalValue() => Cars.Sum(car => car.Price);

        public void AddCar(Car Car)
        {
            Array.Resize(ref _cars, Cars.Length + 1);
            Cars[^1] = Car;
        }

        private Car GetCarBy(Func<Car?, bool>? predicate)
        {
            if (Cars is null || predicate is null)
                return null;
            foreach (var Car in Cars)
                if (predicate(Car))
                    return Car;
            return null;
        }
        public Car GetCarByBrand(string brand) => GetCarBy(car => car.Brand == brand);
        public Car GetCarByModel(string model) => GetCarBy(car => car.Model == model);
        public Car GetCarByColor(string color) => GetCarBy(car => car.Color == color);

        private CarShowroom GetCarsBy(Func<Car?, bool>? predicate)
        {
            Car[] cars = new Car[Cars.Length];
            if (Cars is null || predicate is null)
                return null;
            int i = 0, j = 0;
            for (; i < Cars.Length; i++)
            {
                if (predicate(Cars[i]))
                {
                    cars[j] = Cars[i];
                    j++;
                }
            }
            Array.Resize(ref cars, j);
            return new CarShowroom(cars);
        }
        public CarShowroom GetCarsByPriceRange(decimal min, decimal max) => GetCarsBy(car => min <= car.Price && car.Price <= max);

        private void DeleteCarBy(Func<Car, bool> predicate)
        {
            try
            {
                if (Cars is null || predicate is null)
                    return;
                for (int i = 0; i < Cars.Length; i++)
                    if (predicate(Cars[i]))
                    {
                        Cars[i] = Cars[^1];
                        Array.Resize(ref _cars, Cars.Length - 1);
                        return;
                    }
            }
            catch (Exception)
            {
                throw new Exception("Car with the specified criteria was not found.");
            }
            throw new Exception("Car with the specified criteria was not found.");
        }
        public void DeleteCarByBrand(string brand) => DeleteCarBy(car => car.Brand == brand);
        public void DeleteCarByModel(string model) => DeleteCarBy(car => car.Model == model);
        public void DeleteCarByColor(string color) => DeleteCarBy(car => car.Color == color);

        public void DisplayCarShowroom() => Console.WriteLine(this);

        public override string ToString()
        {
            StringBuilder sb = new();
            if (Cars is not null)
                foreach (var car in Cars)
                    sb.AppendLine(car.ToString());
            return sb.ToString().Trim();
        }
        #endregion
    }
}
