using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManage.Catalog.ClassManage.TrainingClass.Request
{
    public class CreateOrUpdateTrainingClassRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int TrainingClassCategoryId { get; set; }
    }
}
