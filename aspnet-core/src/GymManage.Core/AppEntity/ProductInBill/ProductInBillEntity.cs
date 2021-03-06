using Abp.Domain.Entities;
using GymManage.Bill;
using GymManage.Product;
using GymManage.ProductCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.ProductInBill
{
    [Table("ChiTietHoaDon")]
    public class ProductInBillEntity : Entity
    {
        //khoa ngoai den product
        [ForeignKey(nameof(ProductCategoryId))]
        public ProductCategoryEntity ProductCategory { get; set; }
        [Column("MaDanhMucSanPham")]
        public int ProductCategoryId { get; set; }


        //khoa ngoai den bill
        [ForeignKey(nameof(BillId))]
        public BillEntity Bill { get; set; }
        [Column("MaHoaDon")]
        public int BillId { get; set; }

        [Column("NgayBatDau")]
        public DateTime FromDate { get; set; }
        [Column("NgayKetThuc")]
        public DateTime ToDate { get; set; }
    }
}
