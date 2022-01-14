using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            coinFlip = new Random();
        }

        int heads = 0;
        int tails = 0;
        int hstreak = 1;
        int tstreak = 1;
        int LastResult = -1;
        int hHigh = 0;
        int tHigh = 0;
        double tailsP = 0;
        double headsP = 0;
        Random coinFlip;

        public void Flip()
        {
            
            int result = coinFlip.Next(2);

            if (result == 0)
            {
                heads++;
            }
            else
            {
                tails++; 
            }

            if (LastResult == result && LastResult == 0)
            {
                hstreak++;
            }
            else
            {
                if (hstreak > hHigh)
                {
                    hHigh = hstreak;
                }
                hstreak = 1;
            }
            if (LastResult == result && LastResult == 1)
            {
                tstreak++;
            }
            else
            {
                if (tstreak > tHigh)
                {
                    tHigh = tstreak;
                }
                tstreak = 1;
            }
            LastResult = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int flips = Convert.ToInt32(flipsTxt.Text);
            heads = 0;
            tails = 0;
            tHigh = 0;
            hHigh = 0;
            LastResult = -1;
            for (int count = 0; count < flips; count++)
            {
                Flip();
            }
            headsTxt.Text = heads.ToString("N0");
            tailsTxt.Text = tails.ToString("N0");

            tailsP = ((float)tails / (float)flips) * 100;
            tpTxt.Text = tailsP.ToString("n4");
            headsP = ((float)heads / (float)flips) * 100;
            hpTxt.Text = headsP.ToString("n4");
            rtTxt.Text = tHigh.ToString();
            rhTxt.Text = hHigh.ToString();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            heads = 0;
            tails = 0;
            headsTxt.Text = "0";
            tailsTxt.Text = "0";
            tpTxt.Text = "0";
            hpTxt.Text = "0";
            rhTxt.Text = "0";
            rtTxt.Text = "0";

        }
    }
}
