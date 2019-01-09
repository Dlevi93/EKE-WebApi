using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Api.Infrastructure.Helpers;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities
{
    public class File : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public string Content { get; set; }
        public FileType FileType { get; set; }

        public virtual Category Category { get; set; }
        public virtual Article Article { get; set; }
    }
}
