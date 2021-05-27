using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Service
{
    [Table("DichVu")]
    public class ServiceEntity : Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("MoTa")]
        public string Description { get; set; }
    }
}
