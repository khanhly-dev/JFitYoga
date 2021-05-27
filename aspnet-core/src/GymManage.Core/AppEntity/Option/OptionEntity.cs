using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Option
{
    [Table("GoiThoiHan")]
    public class OptionEntity : Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("ChiSo")]
        public int Amount { get; set; }
        [Column("DonVi")]
        public string Unit { get; set; }
        [Column("MoTa")]
        public string Description { get; set; }
    }
}
