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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Importing()
        {
            ImportingDetails = new HashSet<ImportingDetail>();
        }

        [Key]
        public int ImportID { get; set; }

        public int? StaffID { get; set; }

        public DateTime? ImportDate { get; set; }

        public int? TotalQuant { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportingDetail> ImportingDetails { get; set; }
    }
}
