using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamLines.Core.Domain.Entities
{
    public class CruiseLine
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int nid { get; set; }
        
        public string title { get; set; }
    }
}
