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

        [Display(Name = "�m�W")]
        [StringLength(25)]
        public string Name { get; set; }

        [Display(Name = "�ʧO")]
        public SexStatus Gender { get; set; }

        [Display(Name = "�ͤ�")]
        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }
    }
}
