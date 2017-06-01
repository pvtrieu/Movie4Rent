namespace Movie4Rent.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Importing")]
    public partial class Importing
    {
        [Key]
        public int ImportID { get; set; }

        public int? StaffID { get; set; }

        [StringLength(100)]
        public string ImportData { get; set; }

        public int? TotalQuant { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
