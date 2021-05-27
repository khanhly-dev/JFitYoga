using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.AppEntity.SessionWork
{
    [Table("Ca")]
    public class SessionWorkEntity : Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("ThoiGianBatDau")]
        public DateTime FromTime { get; set; }
        [Column("ThoiGianKetThuc")]
        public DateTime ToTime { get; set; }
    }
}
