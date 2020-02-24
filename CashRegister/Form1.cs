//Drew Johnson
//Feb 19, 2020
//Cash Register Project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //some global variables
        long RedPotions = 0;
        double RedPrice = 0;
        long BluePotions = 0;
        double BluePrice = 0;
        long GreenPotions = 0;
        double GreenPrice = 0;

        //some more global variables
        double SubTotal;
        double TaxCalc;
        double Total;
        double Tendered;
        double Change;

        //SOUND DECLARATION
        readonly SoundPlayer ambience = new SoundPlayer(Properties.Resources.Busy_Medival);
        readonly SoundPlayer writing = new SoundPlayer(Properties.Resources.Writing);

        public Form1()
        {
            InitializeComponent();

            //clears all text boxes we will rewrite over later
            OrderPrint.Text = "";
            PricePrint.Text = "";
            TotalsOutputPrint.Text = "";
            CalcNum.Text = "";
            ChangeOutput.Text = "";
            Error.Text = "";
            ReceiptCover.Text = "";
            ReceiptCover.Location = new Point(300, 35);
            ambience.PlayLooping();
            
        }

        private void OrderPrint_Click(object sender, EventArgs e)
        {
            //don't touch, this was an accident and I don't want it here but if I delete it it messes stuff up
        }

        private void CalcTotalButton_Click(object sender, EventArgs e)
        {
            //some local variable only used for this section
            int DefaultRedPrice = 3;
            int DefaultBluePrice = 5;
            int DefaultGreenPrice = 10;
            double TaxDefault = 0.13;

            try
            {
                //grabs the numbers of potions ordered
                if (GPInput.Text == null || GPInput.Text == "")
                {
                    GPInput.Text = "0";
                }
                if (BPInput.Text == null || BPInput.Text == "")
                {
                    BPInput.Text = "0";
                }
                if (RPInput.Text == null || RPInput.Text == "")
                {
                    RPInput.Text = "0";
                }
                RedPotions = Convert.ToInt16(RPInput.Text);
                BluePotions = Convert.ToInt16(BPInput.Text);
                GreenPotions = Convert.ToInt16(GPInput.Text);
                
                //calculates prices per different items
                RedPrice = RedPotions * DefaultRedPrice;
                BluePrice = BluePotions * DefaultBluePrice;
                GreenPrice = GreenPotions * DefaultGreenPrice;
                SubTotal = RedPrice + BluePrice + GreenPrice;
                TaxCalc = TaxDefault * SubTotal;
                Total = TaxCalc + SubTotal;

                //displays calculations
                CalcNum.Text = "" + SubTotal.ToString("0.00");
                CalcNum.Text += "\n\n " + TaxCalc.ToString("0.00");
                CalcNum.Text += "\n\n " + Total.ToString("0.00");
                Error.Text = "";
            }
            catch //if tried and failed, display error message
            {
                Error.Text = "Error; please input NUMBERS for order";
            }
        }

        private void CalcChangeButton_Click(object sender, EventArgs e)
        {
            try //try to gather if tendered number is enough
            {
                //gathers the number input for money tendered and change
                Tendered = Convert.ToInt16(TendInput.Text);
                Change = Tendered - Total;
                
                //displays calculations
                ChangeOutput.Text = "" + Change.ToString("0.00");
                Error.Text = "";

                //error message if tendered amount isn't enough
                if (Change < 0)
                {
                    Error.Text = "Error; change is negative, need more change";
                }
            }
            catch //if tried and failed
            {
                //error message ensuring proper information was input
                Error.Text = "Error; please total and input the tendered amount";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //same here don't touchie
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            //some cool error messages and stuff
            if (Change < 0)
            {
                Error.Text = "Error; change is negative, need more change";
            }
            else if (Total < 1)
            {
                Error.Text = "Error; please input an order";
            }else{

            //just formatting stuff :)    
            OrderPrint.Text = "\n";
            PricePrint.Text = "\n";

                if (RedPotions > 0) //if any red potions ordered, display number ordered and price
                {
                    OrderPrint.Text += "   R. Potions x" + RedPotions.ToString() + "\n";
                    PricePrint.Text += "" + RedPrice.ToString("0.00") + "   \n";
                }
                if (BluePotions > 0) //if any blue potions ordered, display number and price
                {
                    OrderPrint.Text += "   B. Potions x" + BluePotions.ToString() + "\n";
                    PricePrint.Text += "" + BluePrice.ToString("0.00") + "   \n";
                }
                if (GreenPotions > 0) //if any green potions ordered, display number and price
                {
                    OrderPrint.Text += "   G. Potions x" + GreenPotions.ToString() + "\n";
                    PricePrint.Text += "" + GreenPrice.ToString("0.00") + "   \n";
                }

                //displays total and change and stuff
                TotalsOutputPrint.Text = "" + SubTotal.ToString("0.00") + "   \n" + TaxCalc.ToString("0.00") + "   \n" + Total.ToString("0.00");
                TotalsOutputPrint.Text += "   \n\n" + Tendered.ToString("0.00") + "   \n" + Change.ToString("0.00") + "   ";

            //clears the error box if there are any errors
            Error.Text = "";

                writing.Play();

                //moves the receipt cover down
                while (ReceiptCover.Location.Y < 475)
                {
                    ReceiptCover.Location = new Point(ReceiptCover.Location.X, ReceiptCover.Location.Y + 16);
                    Refresh();
                    Thread.Sleep(250);
                }
                writing.Stop();
                ambience.PlayLooping();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReceiptCover.Location = new Point(300, 35);
            RedPotions = 0;
            BluePotions = 0;
            GreenPotions = 0;
            Change = 0;
            Tendered = 0;
            TaxCalc = 0;

            RPInput.Text = "0";
            BPInput.Text = "0";
            GPInput.Text = "0";
            TendInput.Text = "0";
            CalcNum.Text = "";
            ChangeOutput.Text = "";
            Error.Text = "";
        }
    }
}