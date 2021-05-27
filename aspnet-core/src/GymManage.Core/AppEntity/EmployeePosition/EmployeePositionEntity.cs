using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.EmployeePosition
{
    [Table("ChucVu")]
    public class EmployeePositionEntity : Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("MoTa")]
        public string Description { get; set; }
        [Column("LuongCoBan")]
        public int BaseSalary { get; set; }
        [Column("PhuCap")]
        public int Bonus { get; set; }
    }
}
