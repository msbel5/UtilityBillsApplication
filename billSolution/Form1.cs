using billSolution.Enums;
using billSolution.Interface;
using billSolution.Models;
using billSolution.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billSolution
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(EBillKind)));
            lblilkIndex.Text = "";
            lblSonIndex.Text = "";
            lblKullanım.Text = "";
            lblTutar.Text = "";

        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            Bill bill;
            switch ((EBillKind)((Enum.Parse(typeof(EBillKind), (comboBox1.SelectedItem.ToString())))))
            {
                case EBillKind.Electricity:
                    bill = new ElectricityBill();
                    break;
                case EBillKind.Water:
                    bill = new WaterBill();
                    break;
                case EBillKind.Gas:
                    bill = new GasBill();
                    break;
                default:
                    bill = new ElectricityBill();
                    break;
            }
            Calculate calculator = new Calculate();            
            bill.FirsIndex = (float)numericUpDownilk.Value;
            bill.LastIndex = (float)numericUpDownSon.Value;
            lblKullanım.Text = ((ICalculate)bill).TotalConsumption().ToString();
            lblTutar.Text = (calculator.GetCalculation(bill).ToString());

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((EBillKind)((Enum.Parse(typeof(EBillKind), (comboBox1.SelectedItem.ToString())))))
            {
                case EBillKind.Electricity:
                    lblilkIndex.Text = EBillModule.kw.ToString();
                    lblSonIndex.Text = EBillModule.kw.ToString();
                    break;
                case EBillKind.Water:
                    lblilkIndex.Text = EBillModule.m3.ToString();
                    lblSonIndex.Text = EBillModule.m3.ToString();
                    break;
                case EBillKind.Gas:
                    lblilkIndex.Text = EBillModule.m3.ToString();
                    lblSonIndex.Text = EBillModule.m3.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}


