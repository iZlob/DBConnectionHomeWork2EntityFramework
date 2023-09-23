using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionHomeWork2EntityFramework.DB
{
    public class Orders
    {
        public int Id { get; set; }
        public int AccepcerId { get; set; }
        public int RepairerId { get; set; }
        public int CarId { get; set; }
        public string Defect { get; set; }
        public string Fixed { get; set; }
    }
}
