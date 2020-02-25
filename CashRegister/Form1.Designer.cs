namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.RPLabel = new System.Windows.Forms.Label();
            this.BPLabel = new System.Windows.Forms.Label();
            this.GPLabel = new System.Windows.Forms.Label();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.GPInput = new System.Windows.Forms.TextBox();
            this.BPInput = new System.Windows.Forms.TextBox();
            this.RPInput = new System.Windows.Forms.TextBox();
            this.calcLabel = new System.Windows.Forms.Label();
            this.CalcNumber = new System.Windows.Forms.Label();
            this.calcNum = new System.Windows.Forms.Label();
            this.blackBarLabel = new System.Windows.Forms.Label();
            this.tendLabel = new System.Windows.Forms.Label();
            this.tendInput = new System.Windows.Forms.TextBox();
            this.calcChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptHeader = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.orderPrint = new System.Windows.Forms.Label();
            this.pricePrint = new System.Windows.Forms.Label();
            this.totalPrint = new System.Windows.Forms.Label();
            this.totalsOutputPrint = new System.Windows.Forms.Label();
            this.receiptFooter = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.ReceiptCover = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title.Font = new System.Drawing.Font("Gabriola", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(-1, -17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(735, 54);
            this.title.TabIndex = 0;
            this.title.Text = "Potion Seller\'s Potions";
            // 
            // RPLabel
            // 
            this.RPLabel.BackColor = System.Drawing.Color.LightCoral;
            this.RPLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPLabel.Location = new System.Drawing.Point(13, 57);
            this.RPLabel.Name = "RPLabel";
            this.RPLabel.Size = new System.Drawing.Size(312, 40);
            this.RPLabel.TabIndex = 1;
            this.RPLabel.Text = "Number of Red Potions (3 Shillings each)";
            // 
            // BPLabel
            // 
            this.BPLabel.BackColor = System.Drawing.Color.LightCoral;
            this.BPLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPLabel.Location = new System.Drawing.Point(13, 97);
            this.BPLabel.Name = "BPLabel";
            this.BPLabel.Size = new System.Drawing.Size(312, 40);
            this.BPLabel.TabIndex = 2;
            this.BPLabel.Text = "Number of Blue Potions (5 Shillings each)";
            // 
            // GPLabel
            // 
            this.GPLabel.BackColor = System.Drawing.Color.LightCoral;
            this.GPLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPLabel.Location = new System.Drawing.Point(13, 137);
            this.GPLabel.Name = "GPLabel";
            this.GPLabel.Size = new System.Drawing.Size(312, 40);
            this.GPLabel.TabIndex = 3;
            this.GPLabel.Text = "Number of Green Potions (10 Shillings each)";
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTotalButton.Location = new System.Drawing.Point(17, 180);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(291, 37);
            this.calcTotalButton.TabIndex = 4;
            this.calcTotalButton.Text = "Calculate Totals";
            this.calcTotalButton.UseVisualStyleBackColor = true;
            this.calcTotalButton.Click += new System.EventHandler(this.CalcTotalButton_Click);
            // 
            // GPInput
            // 
            this.GPInput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPInput.Location = new System.Drawing.Point(331, 135);
            this.GPInput.Name = "GPInput";
            this.GPInput.Size = new System.Drawing.Size(34, 28);
            this.GPInput.TabIndex = 3;
            this.GPInput.Text = "0";
            // 
            // BPInput
            // 
            this.BPInput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPInput.Location = new System.Drawing.Point(331, 95);
            this.BPInput.Name = "BPInput";
            this.BPInput.Size = new System.Drawing.Size(34, 28);
            this.BPInput.TabIndex = 2;
            this.BPInput.Text = "0";
            // 
            // RPInput
            // 
            this.RPInput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPInput.Location = new System.Drawing.Point(331, 55);
            this.RPInput.Name = "RPInput";
            this.RPInput.Size = new System.Drawing.Size(34, 28);
            this.RPInput.TabIndex = 1;
            this.RPInput.Text = "0";
            // 
            // calcLabel
            // 
            this.calcLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcLabel.Location = new System.Drawing.Point(64, 220);
            this.calcLabel.Name = "calcLabel";
            this.calcLabel.Size = new System.Drawing.Size(100, 99);
            this.calcLabel.TabIndex = 8;
            this.calcLabel.Text = "Sub Total:\r\n\r\nTax:\r\n\r\nTotal:";
            // 
            // CalcNumber
            // 
            this.CalcNumber.AutoSize = true;
            this.CalcNumber.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcNumber.Location = new System.Drawing.Point(170, 220);
            this.CalcNumber.Name = "CalcNumber";
            this.CalcNumber.Size = new System.Drawing.Size(0, 18);
            this.CalcNumber.TabIndex = 9;
            // 
            // calcNum
            // 
            this.calcNum.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcNum.Location = new System.Drawing.Point(170, 220);
            this.calcNum.Name = "calcNum";
            this.calcNum.Size = new System.Drawing.Size(100, 99);
            this.calcNum.TabIndex = 10;
            this.calcNum.Text = ".";
            this.calcNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // blackBarLabel
            // 
            this.blackBarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.blackBarLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackBarLabel.Location = new System.Drawing.Point(17, 328);
            this.blackBarLabel.Name = "blackBarLabel";
            this.blackBarLabel.Size = new System.Drawing.Size(291, 23);
            this.blackBarLabel.TabIndex = 11;
            // 
            // tendLabel
            // 
            this.tendLabel.AutoSize = true;
            this.tendLabel.BackColor = System.Drawing.Color.LightCoral;
            this.tendLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendLabel.Location = new System.Drawing.Point(64, 361);
            this.tendLabel.Name = "tendLabel";
            this.tendLabel.Size = new System.Drawing.Size(129, 18);
            this.tendLabel.TabIndex = 12;
            this.tendLabel.Text = "Shillings Tendered";
            // 
            // tendInput
            // 
            this.tendInput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendInput.Location = new System.Drawing.Point(236, 361);
            this.tendInput.Name = "tendInput";
            this.tendInput.Size = new System.Drawing.Size(34, 28);
            this.tendInput.TabIndex = 5;
            this.tendInput.Text = "0";
            // 
            // calcChangeButton
            // 
            this.calcChangeButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcChangeButton.Location = new System.Drawing.Point(17, 389);
            this.calcChangeButton.Name = "calcChangeButton";
            this.calcChangeButton.Size = new System.Drawing.Size(291, 37);
            this.calcChangeButton.TabIndex = 6;
            this.calcChangeButton.Text = "Calculate Change";
            this.calcChangeButton.UseVisualStyleBackColor = true;
            this.calcChangeButton.Click += new System.EventHandler(this.CalcChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(64, 429);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(53, 18);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change";
            // 
            // receiptHeader
            // 
            this.receiptHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptHeader.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptHeader.Location = new System.Drawing.Point(410, 86);
            this.receiptHeader.Name = "receiptHeader";
            this.receiptHeader.Size = new System.Drawing.Size(310, 47);
            this.receiptHeader.TabIndex = 19;
            this.receiptHeader.Text = "\r\nPotion Seller\'s Potions";
            this.receiptHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderDate
            // 
            this.orderDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDate.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Location = new System.Drawing.Point(410, 133);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(310, 58);
            this.orderDate.TabIndex = 20;
            this.orderDate.Text = "   Order Number: 2234\r\n   November 21, 1374";
            // 
            // orderPrint
            // 
            this.orderPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderPrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPrint.Location = new System.Drawing.Point(410, 187);
            this.orderPrint.Name = "orderPrint";
            this.orderPrint.Size = new System.Drawing.Size(223, 118);
            this.orderPrint.TabIndex = 21;
            this.orderPrint.Text = "\r\n   .\r\n   .\r\n   .\r\n";
            this.orderPrint.Click += new System.EventHandler(this.OrderPrint_Click);
            // 
            // pricePrint
            // 
            this.pricePrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pricePrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePrint.Location = new System.Drawing.Point(607, 189);
            this.pricePrint.Name = "pricePrint";
            this.pricePrint.Size = new System.Drawing.Size(113, 116);
            this.pricePrint.TabIndex = 22;
            this.pricePrint.Text = "\r\n.  ";
            this.pricePrint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalPrint
            // 
            this.totalPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrint.Location = new System.Drawing.Point(410, 305);
            this.totalPrint.Name = "totalPrint";
            this.totalPrint.Size = new System.Drawing.Size(176, 141);
            this.totalPrint.TabIndex = 23;
            this.totalPrint.Text = "   Sub Total\r\n   Tax\r\n   Total\r\n\r\n   Tendered\r\n   Change";
            // 
            // totalsOutputPrint
            // 
            this.totalsOutputPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalsOutputPrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsOutputPrint.Location = new System.Drawing.Point(581, 305);
            this.totalsOutputPrint.Name = "totalsOutputPrint";
            this.totalsOutputPrint.Size = new System.Drawing.Size(139, 141);
            this.totalsOutputPrint.TabIndex = 24;
            this.totalsOutputPrint.Text = ".   ";
            this.totalsOutputPrint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptFooter
            // 
            this.receiptFooter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptFooter.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptFooter.Location = new System.Drawing.Point(410, 446);
            this.receiptFooter.Name = "receiptFooter";
            this.receiptFooter.Size = new System.Drawing.Size(310, 56);
            this.receiptFooter.TabIndex = 25;
            this.receiptFooter.Text = "Drink responsibly, and have a nice day\r\nSponsored by Ye Olde Blacksmith Shoppe";
            this.receiptFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(174, 430);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(96, 23);
            this.changeOutput.TabIndex = 17;
            this.changeOutput.Text = ".";
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(20, 460);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(288, 36);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Scribe Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Error
            // 
            this.Error.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(331, 495);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(401, 36);
            this.Error.TabIndex = 26;
            this.Error.Text = ".";
            this.Error.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReceiptCover
            // 
            this.ReceiptCover.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptCover.Location = new System.Drawing.Point(399, 495);
            this.ReceiptCover.Name = "ReceiptCover";
            this.ReceiptCover.Size = new System.Drawing.Size(333, 462);
            this.ReceiptCover.TabIndex = 27;
            this.ReceiptCover.Text = ".";
            this.ReceiptCover.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(20, 503);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(288, 38);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "New Order";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ReceiptCover);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.receiptFooter);
            this.Controls.Add(this.totalsOutputPrint);
            this.Controls.Add(this.totalPrint);
            this.Controls.Add(this.pricePrint);
            this.Controls.Add(this.orderPrint);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.receiptHeader);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calcChangeButton);
            this.Controls.Add(this.tendInput);
            this.Controls.Add(this.tendLabel);
            this.Controls.Add(this.blackBarLabel);
            this.Controls.Add(this.calcNum);
            this.Controls.Add(this.CalcNumber);
            this.Controls.Add(this.calcLabel);
            this.Controls.Add(this.RPInput);
            this.Controls.Add(this.BPInput);
            this.Controls.Add(this.GPInput);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.GPLabel);
            this.Controls.Add(this.BPLabel);
            this.Controls.Add(this.RPLabel);
            this.Controls.Add(this.title);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Potion Seller\'s Potions Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label RPLabel;
        private System.Windows.Forms.Label BPLabel;
        private System.Windows.Forms.Label GPLabel;
        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.TextBox GPInput;
        private System.Windows.Forms.TextBox BPInput;
        private System.Windows.Forms.TextBox RPInput;
        private System.Windows.Forms.Label calcLabel;
        private System.Windows.Forms.Label CalcNumber;
        private System.Windows.Forms.Label calcNum;
        private System.Windows.Forms.Label blackBarLabel;
        private System.Windows.Forms.Label tendLabel;
        private System.Windows.Forms.TextBox tendInput;
        private System.Windows.Forms.Button calcChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label receiptHeader;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label orderPrint;
        private System.Windows.Forms.Label pricePrint;
        private System.Windows.Forms.Label totalPrint;
        private System.Windows.Forms.Label totalsOutputPrint;
        private System.Windows.Forms.Label receiptFooter;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label ReceiptCover;
        private System.Windows.Forms.Button resetButton;
    }
}

