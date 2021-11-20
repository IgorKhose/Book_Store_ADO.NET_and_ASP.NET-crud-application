namespace BookStoreCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int BookID { get; set; }

        public virtual Book Book { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
