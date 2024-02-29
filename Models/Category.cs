namespace SoundLocator_WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [Key]
        public int id_Category { get; set; }

        [Column("Category")]
        [Required]
        public string Category1 { get; set; }

        public virtual Sound Sound { get; set; }
    }
}
