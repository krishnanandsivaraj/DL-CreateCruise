using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamLines.Core.Domain.Entities
{
    public class Port
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int nid { get; set; }
        public string title { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
    }
}
