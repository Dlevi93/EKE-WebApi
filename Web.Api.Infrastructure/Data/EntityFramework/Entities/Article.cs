using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities
{
    public class Article : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Név"), Required]
        public string Name { get; set; }
        [DisplayName("Link")]
        public string Slug { get; set; }
        [DisplayName("Szerző")]
        public string Author { get; set; }
        [DisplayName("Létrehozási dátum")]
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        [DisplayName("Tartalom")]
        public string Description { get; set; }
        [NotMapped]
        public string DescriptionStripped { get; set; }
        [DisplayName("Főpanel")]
        public bool Leading { get; set; }
        [DisplayName("Fájlok")]
        public virtual List<File> Files { get; set; }
        [DisplayName("Kategória")]
        public virtual Category Category { get; set; }
    }
}
