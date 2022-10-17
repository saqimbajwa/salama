using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salama.Models
{
    public static class SetupData
    {
        public static List<CarMake> getCarMakeList()
        {
            List<CarMake> carModels = new List<CarMake>();
            carModels.Add(new CarMake()
            {
                Id = 1,
                IsActive = true,
                Name = "Suzuki",
                SetupId = 1
            });
            carModels.Add(new CarMake()
            {
                Id = 2,
                IsActive = true,
                Name = "Honda",
                SetupId = 1
            });
            carModels.Add(new CarMake()
            {
                Id = 3,
                IsActive = true,
                Name = "Toyota",
                SetupId = 1
            });
            return carModels;
        }

        public static List<CarBodyType> getCarBodyTypeList()
        {
            List<CarBodyType> carModels = new List<CarBodyType>();
            carModels.Add(new CarBodyType()
            {
                Id = 7,
                IsActive = true,
                Name = "Hatchback",
                SetupId = 3
            });
            carModels.Add(new CarBodyType()
            {
                Id = 8,
                IsActive = true,
                Name = "Solo",
                SetupId = 3
            });
            carModels.Add(new CarBodyType()
            {
                Id = 9,
                IsActive = true,
                Name = "Jeep",
                SetupId = 3
            });
            return carModels;
        }

        public static List<CarModel> getCarModelList()
        {
            List<CarModel> carModels = new List<CarModel>();
            carModels.Add(new CarModel()
            {
                Id = 4,
                IsActive = true,
                Name = "2020",
                SetupId = 2
            });
            carModels.Add(new CarModel()
            {
                Id = 5,
                IsActive = true,
                Name = "2021",
                SetupId = 2
            });
            carModels.Add(new CarModel()
            {
                Id = 6,
                IsActive = true,
                Name = "2022",
                SetupId = 2
            });
            return carModels;
        }

        public static List<Trim> getTrimList()
        {
            List<Trim> carModels = new List<Trim>();
            carModels.Add(new Trim()
            {
                Id = 10,
                IsActive = true,
                Name = "A",
                SetupId = 4
            });
            carModels.Add(new Trim()
            {
                Id = 11,
                IsActive = true,
                Name = "B",
                SetupId = 4
            });
            carModels.Add(new Trim()
            {
                Id = 12,
                IsActive = true,
                Name = "C",
                SetupId = 4
            });
            return carModels;
        }
    }
}
