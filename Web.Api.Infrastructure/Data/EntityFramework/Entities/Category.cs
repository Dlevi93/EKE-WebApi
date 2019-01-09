using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities
{
    public class Category : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Név")]
        public string Name { get; set; }
        public int Order { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        [DisplayName("Szülő")]
        public int? ParentId { get; set; }

        public virtual List<Article> Articles { get; set; }
        public virtual List<File> Files { get; set; }

        public Category()
        {
            DateCreated = DateTime.UtcNow.AddHours(2);
        }
    }
}
