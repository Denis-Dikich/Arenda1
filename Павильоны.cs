namespace Arenda1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Павильоны
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Required]
        [StringLength(50)]
        public string НазваниеТЦ { get; set; }

        [Column("№ Павильона")]
        [Required]
        [StringLength(10)]
        public string C__Павильона { get; set; }

        [StringLength(10)]
        public string Этаж { get; set; }

        [StringLength(50)]
        public string Статус { get; set; }

        [StringLength(10)]
        public string Площадь { get; set; }

        [Column("Стоимость за кв.м.")]
        [StringLength(10)]
        public string Стоимость_за_кв_м_ { get; set; }

        [Column("Коэффициент добавочной стоимости")]
        [StringLength(10)]
        public string Коэффициент_добавочной_стоимости { get; set; }
    }
}
