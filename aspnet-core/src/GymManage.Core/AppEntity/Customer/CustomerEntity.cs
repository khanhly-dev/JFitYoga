using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Customer
{
    [Table("KhachHang")]
    public class CustomerEntity : Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("SoDienThoai")]
        public string PhoneNumber { get; set; }
        [Column("DiaChi")]
        public string Adress { get; set; }
        [Column("NgaySinh")]
        public DateTime? Born { get; set; }
        [Column("TaiKhoan")]
        public string UserName { get; set; }
        [Column("MatKhau")]
        public string Password { get; set; }
        [Column("Email")]
        public string Email { get; set; }
    }
}
