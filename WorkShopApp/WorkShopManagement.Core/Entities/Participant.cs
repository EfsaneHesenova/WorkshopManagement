using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities.Base;

namespace WorkShopManagement.Core.Entities
{
    public class Participant: BaseAuditableEntity
    {
       
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int WorkshopId { get; set; }
        public Workshop? Workshop { get; set; }
    }
}
