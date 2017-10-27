using billSolution.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billSolution.Models
{
   public abstract class Bill
    {
        public abstract EBillKind BillKind { get; }
        public abstract EBillModule BillModule { get; }
        public abstract decimal ModulePrice { get; }
        public abstract float FirsIndex { get; set; }
        public abstract float LastIndex { get; set; }

    }
}
