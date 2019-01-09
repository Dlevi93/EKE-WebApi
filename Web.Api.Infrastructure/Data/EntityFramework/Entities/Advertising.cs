using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Api.Infrastructure.Helpers;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities
{
    public class Advertising : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Link"), Required]
        public string Link { get; set; }
        [DisplayName("Név"), Required]
        public string Name { get; set; }
        [DisplayName("Hivatkozás")]
        public string Href { get; set; }
        public Position Position { get; set; }
    }
}
