using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamLines.Core.Domain.Entities
{
    public class Cabintype
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int nid { get; set; }
        public int ship_id { get; set; }
        public int company_id { get; set; }

        public string title { get; set; }
    }
}
