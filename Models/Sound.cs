namespace SoundLocator_WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sound
    {
        [Key]
        public int id_Sound { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Category Category { get; set; }
    }
}
