namespace Arenda1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ТЦ
    {
        [Key]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column("Количество павильонов")]
        [StringLength(10)]
        public string Количество_павильонов { get; set; }

        [StringLength(50)]
        public string Город { get; set; }

        [StringLength(50)]
        public string Стоимость { get; set; }

        [Column("Коэффициент добавочной стоимости")]
        [StringLength(10)]
        public string Коэффициент_добавочной_стоимости { get; set; }

        [StringLength(10)]
        public string Этажность { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }

        public virtual ТЦ ТЦ1 { get; set; }

        public virtual ТЦ ТЦ2 { get; set; }
    }
}
