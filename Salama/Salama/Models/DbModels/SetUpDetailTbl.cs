using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salama.Models.DbModels
{
    public class SetUpDetailTbl
    {
        public int Id { get; set; }
        public int SetupId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
