using Abp.Domain.Entities;
using GymManage.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Bill
{
    [Table("HoaDon")]
    public class BillEntity : Entity
    {
        [ForeignKey(nameof(CustomerId))]
        [Column("MaKhachHang")]
        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }

        [Column("Ten")]
        public string Name { get; set; }    
        private DateTime dateCreated;
        [Column("NgayTao")]
        public DateTime DateCreated { get { return dateCreated; } set { dateCreated = DateTime.Now; } }
        [Column("NguoiTao")]
        public string UserCreated { get; set; }
        [Column("TongTien")]
        public float OriginalPrice { get; set; }
        [Column("GiamGia")]
        public float Discount { get; set; }
        [Column("ThanhTien")]
        public float TotalPrice { get; set; }
        [Column("GhiChu")]
        public string Note { get; set; }
    }
}
