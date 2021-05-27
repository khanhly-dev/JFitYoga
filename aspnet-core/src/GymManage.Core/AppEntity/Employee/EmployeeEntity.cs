using Abp.Domain.Entities;
using GymManage.EmployeePosition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Employee
{
    [Table("NhanVien")]
    public class EmployeeEntity :  Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("TaiKhoan")]
        public string UserName { get; set; }
        [Column("MatKhau")]
        public string Password { get; set; }
        [Column("NgaySinh")]
        public DateTime? Born { get; set; }
        [Column("DiaChi")]
        public string Adress { get; set; }
        [Column("SoDienThoai")]
        public string PhoneNumber { get; set; }
        [Column("Luong")]
        public int? Salary { get; set; }
        [Column("NgayBatDau")]
        public DateTime? FromDate { get; set; }
        [Column("TrangThai")]
        public bool? Status { get; set; }


        //khoa ngoai den position
        [ForeignKey(nameof(PositionId))]
        public EmployeePositionEntity EmployeePosition { get; set; }
        [Column("MaChucVu")]
        public int? PositionId { get; set; }
    }
}
