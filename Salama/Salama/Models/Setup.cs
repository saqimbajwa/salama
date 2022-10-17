using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salama.Models
{
    public class Setup
    {
        public int CarMakeId { get; set; }
        public int CarModelId { get; set; }
        public int CarBodyTypeId { get; set; }
        public int TrimId { get; set; }
        public List<CarMake> CarMakeList { get; set; } = new List<CarMake>();
        public List<CarModel> CarModelList { get; set; } = new List<CarModel>();
        public List<CarBodyType> CarBodyTypeList { get; set; } = new List<CarBodyType>();
        public List<Trim> TrimList { get; set; } = new List<Trim>();
    }
}
