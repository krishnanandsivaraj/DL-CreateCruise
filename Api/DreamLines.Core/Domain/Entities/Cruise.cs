using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DreamLines.Core.Domain.Entities
{
    public class Cruise
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int nid { get; set; }
        public int shipId { get; set; }
        public int cabinType { get; set; }
        public int rId { get; set; } = 0;
        public DateTime departureDate { get; set; }
        public bool isFlight { get; set; }
    }
}
