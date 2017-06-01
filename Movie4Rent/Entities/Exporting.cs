namespace Movie4Rent.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exporting")]
    public partial class Exporting
    {
        [Key]
        public int ExportID { get; set; }

        public int? StaffID { get; set; }

        public DateTime? ExportDate { get; set; }

        public int? TotalQuant { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
