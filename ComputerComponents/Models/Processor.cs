namespace ComputerComponents.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Processor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Vendor { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string GraphicalCore { get; set; }

        [Required]
        [StringLength(10)]
        public string Socket { get; set; }

        public int TDP { get; set; }

        public int Cores { get; set; }

        public int Threads { get; set; }

        [Column("Coasts", TypeName = "smallmoney")]
        public decimal Coast { get; set; }
    }
}
