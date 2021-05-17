namespace Arenda1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Аренда
    {
        [Key]
        [Column("ID Аренды", TypeName = "numeric")]
        public decimal ID_Аренды { get; set; }

        [Column("ID Арендатора")]
        [Required]
        [StringLength(10)]
        public string ID_Арендатора { get; set; }

        [StringLength(50)]
        public string Название { get; set; }

        [Column("ID Сотрудников")]
        [Required]
        [StringLength(10)]
        public string ID_Сотрудников { get; set; }

        [Column("№ Павильона")]
        [StringLength(10)]
        public string C__Павильона { get; set; }

        [Column(TypeName = "ntext")]
        public string Статус { get; set; }

        [Column("Начало аренды")]
        [StringLength(10)]
        public string Начало_аренды { get; set; }

        [Column("Окончание аренды")]
        [StringLength(10)]
        public string Окончание_аренды { get; set; }
    }
}
