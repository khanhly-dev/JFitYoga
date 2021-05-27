using Abp.Domain.Entities;
using GymManage.Customer;
using GymManage.TimeTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.AppEntity.CustomerInTimeTable
{
    [Table("KhachHangDangKi")]
    public class CustomerInTimeTableEntity : Entity
    {
        [ForeignKey(nameof(CustomerId))]
        public CustomerEntity Customer { get; set; }
        [Column("MaKhachHang")]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(TimeTableId))]
        public TimeTableEntity TimeTable { get; set; }
        [Column("MaLichHoc")]
        public int TimeTableId { get; set; }

        [Column("CheckIn")]
        public bool Active { get; set; }
    }
}
