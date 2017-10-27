using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using billSolution.Enums;
using billSolution.Interface;

namespace billSolution.Models
{
    class WaterBill : Bill, ICalculate
    {
        private EBillKind _billKind = EBillKind.Water;
        private EBillModule _billModule = EBillModule.m3;
        private float _firstIndex;
        private float _lastIndex;
        private decimal _modulePrice = 3;
        
        public override EBillKind BillKind
        {
            get
            {
                return _billKind;
            }

        }
        public override EBillModule BillModule
        {
            get
            {
                return _billModule;
            }
        }
        public override float FirsIndex
        {
            get
            {
                return _firstIndex;
            }

            set
            {
                _firstIndex = value;
                if (FirsIndex < 0)
                {
                    FirsIndex = 0;
                }

            }
        }
        public override float LastIndex
        {
            get
            {
                return _lastIndex;
            }

            set
            {
                _lastIndex = value;
                if (_lastIndex < _firstIndex)
                {
                    _lastIndex = _firstIndex;
                }
            }
        }
        public override decimal ModulePrice
        {
            get
            {
                return _modulePrice;
            }
        }
        public float TotalConsumption()
        {
            return (LastIndex - FirsIndex);
        }
        public decimal TotalCalculation()
        {
            return (_modulePrice * ((decimal)TotalConsumption()));
        }
        public decimal TotalCalculation(int total)
        {
            return (_modulePrice * ((decimal)TotalConsumption())) ;
        }
        public override string ToString()
        {
            return BillKind.ToString();
        }
       
    }
}
