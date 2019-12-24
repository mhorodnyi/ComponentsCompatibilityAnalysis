namespace ComputerComponents.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fan
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Vendor { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int TDP { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Sockets { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Coast { get; set; }
    }
}
