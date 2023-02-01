namespace Lents.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderComposition")]
    public partial class OrderComposition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_number { get; set; }

        [StringLength(10)]
        public string article_number { get; set; }

        public int? number_of_prices { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
