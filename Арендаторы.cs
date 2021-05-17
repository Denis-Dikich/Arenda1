namespace Arenda1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Арендаторы
    {
        [Key]
        [Column("ID Арендатора", TypeName = "numeric")]
        public decimal ID_Арендатора { get; set; }

        [Column("ID Аренды", TypeName = "numeric")]
        public decimal ID_Аренды { get; set; }

        [StringLength(50)]
        public string Название { get; set; }

        [StringLength(50)]
        public string Номер { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }
    }
}
