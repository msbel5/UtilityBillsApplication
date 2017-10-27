using billSolution.Enums;
using billSolution.Interface;
using billSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billSolution.Service
{
   public class Calculate
    {
        private Bill _calculatingType;
        public decimal _result = 0;
        public decimal GetCalculation(Bill bill)
        {
            switch ((EBillKind)Enum.Parse(typeof(EBillKind), bill.BillKind.ToString()))
            {
                case EBillKind.Electricity:
                    _calculatingType = bill as ElectricityBill;
                    break;
                case EBillKind.Water:
                    _calculatingType = bill as WaterBill;
                    break;
                case EBillKind.Gas:
                    _calculatingType = bill as GasBill;
                    break;
                default:
                    break;
            }
            _result = ((ICalculate)bill).TotalCalculation();
            
            return _result;
        }
    }
}
