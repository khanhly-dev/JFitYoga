using Abp.Domain.Entities;
using GymManage.AppEntity.SessionWork;
using GymManage.Employee;
using GymManage.TrainingClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.TimeTable
{
    [Table("LichHoc")]
    public class TimeTableEntity : Entity
    {
        [ForeignKey(nameof(ClassId))]
        public TrainingClassEntity Class { get; set; }
        [Column("MaLopHoc")]
        public int ClassId { get; set; }


        [ForeignKey(nameof(SessionId))]
        public SessionWorkEntity Session { get; set; }
        [Column("MaCaHoc")]
        public int SessionId { get; set; }

        
        [ForeignKey(nameof(employeeId))]
        public EmployeeEntity Employee { get; set; }
        [Column("MaNhanVien")]
        public int employeeId { get; set; }

        [Column("BaiHoc")]
        public string Lesson { get; set; }
        [Column("Thu")]
        public string Day { get; set; }
        [Column("Ngay")]
        public DateTime Date { get; set; }
    }
}
