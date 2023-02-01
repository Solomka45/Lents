namespace Lents.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Placement")]
    public partial class Placement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry_number { get; set; }

        [StringLength(10)]
        public string article_number { get; set; }

        public int? ID_warehouse { get; set; }

        public int? number_of_products { get; set; }

        public virtual Product Product { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
