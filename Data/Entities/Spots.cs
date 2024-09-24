using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Spots
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public SpotStatus Status { get; set; }
        public string? Plate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
