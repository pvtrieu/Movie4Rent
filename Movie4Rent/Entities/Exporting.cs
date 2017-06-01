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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exporting()
        {
            ExportingDetails = new HashSet<ExportingDetail>();
        }

        [Key]
        public int ExportID { get; set; }

        public int? StaffID { get; set; }

        public DateTime? ExportDate { get; set; }

        public int? TotalQuant { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportingDetail> ExportingDetails { get; set; }
    }
}
