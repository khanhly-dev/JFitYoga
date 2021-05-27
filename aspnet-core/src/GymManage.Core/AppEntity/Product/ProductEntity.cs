using Abp.Domain.Entities;
using GymManage.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Product
{
    [Table("BoMon")]
    public class ProductEntity :Entity
    {
        [Column("Ten")]
        public string Name { get; set; }
        [Column("MoTa")]
        public string Description { get; set; }
    }
}
