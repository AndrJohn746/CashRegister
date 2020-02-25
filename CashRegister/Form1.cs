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
        long redPotions = 0;
        double redPrice = 0;
        long bluePotions = 0;
        double bluePrice = 0;
        long greenPotions = 0;
        double greenPrice = 0;

        //some more global variables
        double subTotal;
        double taxCalc;
        double total;
        double tendered;
        double change;

        //SOUND DECLARATION
        readonly SoundPlayer ambience = new SoundPlayer(Properties.Resources.Busy_Medival);
        readonly SoundPlayer writing = new SoundPlayer(Properties.Resources.Writing);

        public Form1()
        {
            InitializeComponent();

            //clears all text boxes we will rewrite over later
            orderPrint.Text = "";
            pricePrint.Text = "";
            totalsOutputPrint.Text = "";
            calcNum.Text = "";
            changeOutput.Text = "";
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
            int defaultRedPrice = 3;
            int defaultBluePrice = 5;
            int defaultGreenPrice = 10;
            double taxDefault = 0.13;

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
                redPotions = Convert.ToInt16(RPInput.Text);
                bluePotions = Convert.ToInt16(BPInput.Text);
                greenPotions = Convert.ToInt16(GPInput.Text);

                //calculates prices per different items
                redPrice = redPotions * defaultRedPrice;
                bluePrice = bluePotions * defaultBluePrice;
                greenPrice = greenPotions * defaultGreenPrice;
                subTotal = redPrice + bluePrice + greenPrice;
                taxCalc = taxDefault * subTotal;
                total = taxCalc + subTotal;

                //displays calculations
                calcNum.Text = "" + subTotal.ToString("0.00");
                calcNum.Text += "\n\n " + taxCalc.ToString("0.00");
                calcNum.Text += "\n\n " + total.ToString("0.00");
                Error.Text = "";
            }
            catch //if tried and failed, display error message
            {
                Error.Text = "Error; please input VALID NUMBERS for order";
            }
        }

        private void CalcChangeButton_Click(object sender, EventArgs e)
        {
            try //try to gather if tendered number is enough
            {
                //gathers the number input for money tendered and change
                tendered = Convert.ToInt16(tendInput.Text);
                change = tendered - total;

                //displays calculations
                changeOutput.Text = "" + change.ToString("0.00");
                Error.Text = "";

                //error message if tendered amount isn't enough
                if (change < 0)
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
            if (change < 0)
            {
                Error.Text = "Error; change is negative, need more change";
            }
            else if (total < 1)
            {
                Error.Text = "Error; please input an order";
            }
            else
            {

                //just formatting stuff :)    
                orderPrint.Text = "\n";
                pricePrint.Text = "\n";

                if (redPotions > 0) //if any red potions ordered, display number ordered and price
                {
                    orderPrint.Text += "   R. Potions x" + redPotions.ToString() + "\n";
                    pricePrint.Text += "" + redPrice.ToString("0.00") + "   \n";
                }
                if (bluePotions > 0) //if any blue potions ordered, display number and price
                {
                    orderPrint.Text += "   B. Potions x" + bluePotions.ToString() + "\n";
                    pricePrint.Text += "" + bluePrice.ToString("0.00") + "   \n";
                }
                if (greenPotions > 0) //if any green potions ordered, display number and price
                {
                    orderPrint.Text += "   G. Potions x" + greenPotions.ToString() + "\n";
                    pricePrint.Text += "" + greenPrice.ToString("0.00") + "   \n";
                }

                //displays total and change and stuff
                totalsOutputPrint.Text = "" + subTotal.ToString("0.00") + "   \n" + taxCalc.ToString("0.00") + "   \n" + total.ToString("0.00");
                totalsOutputPrint.Text += "   \n\n" + tendered.ToString("0.00") + "   \n" + change.ToString("0.00") + "   ";

                //clears the error box if there are any errors
                Error.Text = "";

                writing.Play();

                //moves the receipt cover down
                while (ReceiptCover.Location.Y < 425)
                {
                    ReceiptCover.Location = new Point(ReceiptCover.Location.X, ReceiptCover.Location.Y + 16);
                    Refresh();
                    Thread.Sleep(300);
                }
                writing.Stop();
                ambience.PlayLooping();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReceiptCover.Location = new Point(300, 35);
            redPotions = 0;
            bluePotions = 0;
            greenPotions = 0;
            change = 0;
            tendered = 0;
            taxCalc = 0;

            RPInput.Text = "0";
            BPInput.Text = "0";
            GPInput.Text = "0";
            tendInput.Text = "0";
            calcNum.Text = "";
            changeOutput.Text = "";
            Error.Text = "";
        }
    }
}