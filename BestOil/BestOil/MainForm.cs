using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BestOil.Entity;
using BestOil.Repository;

namespace BestOil
{
public partial class MainForm : Form
{
    double TotalRevenuePerDay { get; set; } = 0;
    public MainForm()
    {
        InitializeComponent();
    }

    #region methodsForCafe
    private void checkProductsCafe_CheckedChanged(object sender, EventArgs e)
    {
        if (chkHotDog.Checked)
            tbCountHotDog.ReadOnly = false;
        else
        {
            tbCountHotDog.ReadOnly = true;
            tbCountHotDog.Text = 0.ToString();
        }
        if (chkGamburger.Checked)
            tbCountGamburger.ReadOnly = false;
        else
        {
            tbCountGamburger.ReadOnly = true;
            tbCountGamburger.Text = 0.ToString();
        }
        if (chkChizburger.Checked)
            tbCountChizburger.ReadOnly = false;
        else
        {
            tbCountChizburger.ReadOnly = true;
            tbCountChizburger.Text = 0.ToString();
        }
        if (chkCola.Checked)
            tbCountCola.ReadOnly = false;
        else
        {
            tbCountCola.ReadOnly = true;
            tbCountCola.Text = 0.ToString();
        }
    }
    private void textCountProductsCafe_TextChanged(object sender, EventArgs e)
    {
        double Summa = 0, CountProductsCafe = 0;
        if (tbCountHotDog.ReadOnly == false)
        {
            if (double.TryParse(tbCountHotDog.Text, out CountProductsCafe))
                Summa += Convert.ToDouble(tbHotDog.Text) * CountProductsCafe;
        }
        if (tbCountGamburger.ReadOnly == false)
        {
            if (double.TryParse(tbCountGamburger.Text, out CountProductsCafe))
                Summa += Convert.ToDouble(tbGamburger.Text) * CountProductsCafe;
        }
        if (tbCountChizburger.ReadOnly == false)
        {
            if (double.TryParse(tbCountChizburger.Text, out CountProductsCafe))
                Summa += Convert.ToDouble(tbChizburger.Text) * CountProductsCafe;
        }
        if (tbCountCola.ReadOnly == false)
        {
            if (double.TryParse(tbCountCola.Text, out CountProductsCafe))
                Summa += Convert.ToDouble(tbCola.Text) * CountProductsCafe;
        }
        tbPaymentCafe.Text = Summa.ToString();
    }
    #endregion

    #region methodsForFuell
    private void radCountOil_CheckedChanged(object sender, EventArgs e)
    {
        lbSumOil.Text = "руб.";
        lbCountOil.Text = "л";
        grpPaymentOil.Text = "К оплате";
        double PriceOil = 0, CountOil = 0, tempValue;
        if (double.TryParse(tbPriceOil.Text, out tempValue))
            PriceOil = tempValue;
        if (double.TryParse(tbCountOil.Text, out tempValue))
            CountOil = tempValue;
        tbSumPriceOil.Text = (PriceOil * CountOil).ToString();
        tbPaymentOil.Text = tbSumPriceOil.Text;
    }

    private void radSumOil_CheckedChanged(object sender, EventArgs e)
    {
        lbCountOil.Text = "руб.";
        lbSumOil.Text = "л";
        grpPaymentOil.Text = "К выдаче";
        double PriceOil = 0, CountOil = 0, tempValue;
        if (double.TryParse(tbPriceOil.Text, out tempValue))
            PriceOil = tempValue;
        if (double.TryParse(tbCountOil.Text, out tempValue))
            CountOil = tempValue;
        tbSumPriceOil.Text = (CountOil / PriceOil).ToString("N2");
        tbPaymentOil.Text = CountOil.ToString();
    }

    private void tbCountOil_TextChanged(object sender, EventArgs e)
    {
        double PriceOil = 0, CountOil = 0, tempValue;
        if (double.TryParse(tbPriceOil.Text, out tempValue))
            PriceOil = tempValue;
        if (double.TryParse(tbCountOil.Text, out tempValue))
            CountOil = tempValue;
        if (radCountOil.Checked)
        {
            tbSumPriceOil.Text = (PriceOil * CountOil).ToString();
            tbPaymentOil.Text = tbSumPriceOil.Text;
        }
        else
        {
            tbSumPriceOil.Text = (CountOil / PriceOil).ToString("N2");
            tbPaymentOil.Text = tbCountOil.Text;
        }
    }

    private void cbFuels_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbFuels.SelectedItem != null)
        {
            FuellInfo sel = cbFuels.SelectedItem as FuellInfo;
            tbPriceOil.Text = sel.Price.ToString("N2");
            double PriceOil = 0, CountOil = 0, tempValue;
            if (double.TryParse(tbPriceOil.Text, out tempValue))
                PriceOil = tempValue;
            if (double.TryParse(tbCountOil.Text, out tempValue))
                CountOil = tempValue;
            if (radCountOil.Checked)
            {
                tbSumPriceOil.Text = (PriceOil * CountOil).ToString();
                tbPaymentOil.Text = tbSumPriceOil.Text;
            }
            else
            {
                tbSumPriceOil.Text = (CountOil / PriceOil).ToString("N2");
                tbPaymentOil.Text = tbCountOil.Text;
            }
        }
    }
    #endregion

    #region methodsForMainForms
    private void MainForm_Load(object sender, EventArgs e)
    {
        cbFuels.DisplayMember = "Name";
        cbFuels.DataSource = FuelRepository.GetFuels();
        cbFuels.SelectedIndex = 1;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        MessageBox.Show("Total revenue per day: " + TotalRevenuePerDay.ToString());
    }
    #endregion

    #region Payment
    private void btnTotalPayment_Click(object sender, EventArgs e)
    {
        double TotalPrice = 0, Price = 0;
        if (double.TryParse(tbPaymentCafe.Text, out Price))
            TotalPrice += Price;
        if (double.TryParse(tbPaymentOil.Text, out Price))
            TotalPrice += Price;
        tbTotalPayment.Text = TotalPrice.ToString();
        TotalRevenuePerDay += TotalPrice;
        this.Text = "Автозаправка: " + TotalRevenuePerDay.ToString();
    }
    #endregion
}
}
