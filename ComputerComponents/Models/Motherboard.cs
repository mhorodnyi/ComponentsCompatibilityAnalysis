namespace ComputerComponents.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Motherboard
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Vendor { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Socket { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Chipset { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal Coast { get; set; }
    }
}
