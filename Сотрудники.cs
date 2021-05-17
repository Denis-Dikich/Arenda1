namespace Arenda1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [StringLength(50)]
        public string Логин { get; set; }

        [StringLength(10)]
        public string Пароль { get; set; }

        [StringLength(50)]
        public string Роль { get; set; }

        [Column("Номер телефона")]
        [StringLength(50)]
        public string Номер_телефона { get; set; }

        [StringLength(50)]
        public string Пол { get; set; }

        [Column(TypeName = "image")]
        public byte[] Фото { get; set; }
    }
}
