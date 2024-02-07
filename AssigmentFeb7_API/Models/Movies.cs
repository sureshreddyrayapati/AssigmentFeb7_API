using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssigmentFeb7_API.Models
{
    [Table("Movies")]
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string MName { get; set; }
        public string starCast { get; set; }
        public string Director { get; set; }
        public string producer { get; set; }
        public DateTime ReleasingDate { get; set; }
    }
}
