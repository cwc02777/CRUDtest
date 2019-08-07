namespace CRUDproject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        public int Id { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        public byte? Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }
    }
}
