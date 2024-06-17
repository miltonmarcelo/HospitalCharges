using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CalcStayCharges()
        {
            int numberofDays = 0;
            if (!string.IsNullOrEmpty(numberOfDaystextBox.Text))
            {
                int.TryParse(numberOfDaystextBox.Text, out numberofDays);
            }
            int stayCharges = 350 * numberofDays;
            return stayCharges;
        }

        private double CalcMiscCharges()
        {
            double totalMiscCharges = 0; //initializing the variable as double
            double medication = 0;
            double surgical = 0;
            double lab = 0;
            double physical = 0;

            if (!string.IsNullOrEmpty(medicationTextBox.Text))
            {
                double.TryParse(medicationTextBox.Text, out medication);
            }

            if (!string.IsNullOrEmpty(surgicalTextBox.Text))
            {
                double.TryParse(surgicalTextBox.Text, out surgical);
            }

            if (!string.IsNullOrEmpty(labFeesTextBox.Text))
            {
                double.TryParse(labFeesTextBox.Text, out lab);
            }

            if (!string.IsNullOrEmpty(physicalTextBox.Text))
            {
                double.TryParse(physicalTextBox.Text, out physical);
            }

            totalMiscCharges = medication + surgical + lab + physical;
            return totalMiscCharges;

        }
        
        private double CalcTotalCharges()
        {
            double total = CalcStayCharges() + CalcMiscCharges();
            return total;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "The total bill is " + CalcTotalCharges().ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberOfDaystextBox.Text = "";
            medicationTextBox.Text = "";
            surgicalTextBox.Text = "";
            labFeesTextBox.Text = "";
            physicalTextBox.Text = "";
            outputLabel.Text = "";
        }
    }
}
