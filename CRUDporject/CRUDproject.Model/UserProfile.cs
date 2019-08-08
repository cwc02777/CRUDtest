namespace CRUDproject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using static CRUDproject.Model.Common.Enums;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [StringLength(25)]
        public string Name { get; set; }

        [Display(Name = "性別")]
        public SexStatus Gender { get; set; }

        [Display(Name = "生日")]
        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }
    }
}
