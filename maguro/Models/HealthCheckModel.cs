using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace maguro.Models
{
    public class HealthCheckResponse
    {
        public string status { get; set; }
        public string version { get; set; }
    }

    [Table("healthcheck")]
    public class HealthCheckModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int id { get; set; }

        [Column("message")]
        public string message { get; set; }
    }
}
