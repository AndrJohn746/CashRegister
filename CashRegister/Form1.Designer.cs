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
            this.PSTitle = new System.Windows.Forms.Label();
            this.RPLabel = new System.Windows.Forms.Label();
            this.BPLabel = new System.Windows.Forms.Label();
            this.GPLabel = new System.Windows.Forms.Label();
            this.CalcTotalButton = new System.Windows.Forms.Button();
            this.GPInput = new System.Windows.Forms.TextBox();
            this.BPInput = new System.Windows.Forms.TextBox();
            this.RPInput = new System.Windows.Forms.TextBox();
            this.CalcLabel = new System.Windows.Forms.Label();
            this.CalcNumber = new System.Windows.Forms.Label();
            this.CalcNum = new System.Windows.Forms.Label();
            this.blackBarLabel = new System.Windows.Forms.Label();
            this.TendLabel = new System.Windows.Forms.Label();
            this.TendInput = new System.Windows.Forms.TextBox();
            this.CalcChangeButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ReceiptHeader = new System.Windows.Forms.Label();
            this.OrderAndDate = new System.Windows.Forms.Label();
            this.OrderPrint = new System.Windows.Forms.Label();
            this.PricePrint = new System.Windows.Forms.Label();
            this.TotalPrint = new System.Windows.Forms.Label();
            this.TotalsOutputPrint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeOutput = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.ReceiptCover = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PSTitle
            // 
            this.PSTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PSTitle.Font = new System.Drawing.Font("Gabriola", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PSTitle.Location = new System.Drawing.Point(-1, -17);
            this.PSTitle.Name = "PSTitle";
            this.PSTitle.Size = new System.Drawing.Size(735, 54);
            this.PSTitle.TabIndex = 0;
            this.PSTitle.Text = "Potion Seller\'s Potions";
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
            // CalcTotalButton
            // 
            this.CalcTotalButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTotalButton.Location = new System.Drawing.Point(17, 180);
            this.CalcTotalButton.Name = "CalcTotalButton";
            this.CalcTotalButton.Size = new System.Drawing.Size(291, 37);
            this.CalcTotalButton.TabIndex = 4;
            this.CalcTotalButton.Text = "Calculate Totals";
            this.CalcTotalButton.UseVisualStyleBackColor = true;
            this.CalcTotalButton.Click += new System.EventHandler(this.CalcTotalButton_Click);
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
            // CalcLabel
            // 
            this.CalcLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcLabel.Location = new System.Drawing.Point(64, 220);
            this.CalcLabel.Name = "CalcLabel";
            this.CalcLabel.Size = new System.Drawing.Size(100, 99);
            this.CalcLabel.TabIndex = 8;
            this.CalcLabel.Text = "Sub Total:\r\n\r\nTax:\r\n\r\nTotal:";
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
            // CalcNum
            // 
            this.CalcNum.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcNum.Location = new System.Drawing.Point(170, 220);
            this.CalcNum.Name = "CalcNum";
            this.CalcNum.Size = new System.Drawing.Size(100, 99);
            this.CalcNum.TabIndex = 10;
            this.CalcNum.Text = ".";
            this.CalcNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // TendLabel
            // 
            this.TendLabel.AutoSize = true;
            this.TendLabel.BackColor = System.Drawing.Color.LightCoral;
            this.TendLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TendLabel.Location = new System.Drawing.Point(64, 361);
            this.TendLabel.Name = "TendLabel";
            this.TendLabel.Size = new System.Drawing.Size(129, 18);
            this.TendLabel.TabIndex = 12;
            this.TendLabel.Text = "Shillings Tendered";
            // 
            // TendInput
            // 
            this.TendInput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TendInput.Location = new System.Drawing.Point(236, 361);
            this.TendInput.Name = "TendInput";
            this.TendInput.Size = new System.Drawing.Size(34, 28);
            this.TendInput.TabIndex = 5;
            this.TendInput.Text = "0";
            // 
            // CalcChangeButton
            // 
            this.CalcChangeButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcChangeButton.Location = new System.Drawing.Point(17, 389);
            this.CalcChangeButton.Name = "CalcChangeButton";
            this.CalcChangeButton.Size = new System.Drawing.Size(291, 37);
            this.CalcChangeButton.TabIndex = 6;
            this.CalcChangeButton.Text = "Calculate Change";
            this.CalcChangeButton.UseVisualStyleBackColor = true;
            this.CalcChangeButton.Click += new System.EventHandler(this.CalcChangeButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(64, 429);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(53, 18);
            this.ChangeLabel.TabIndex = 15;
            this.ChangeLabel.Text = "Change";
            // 
            // ReceiptHeader
            // 
            this.ReceiptHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiptHeader.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptHeader.Location = new System.Drawing.Point(410, 56);
            this.ReceiptHeader.Name = "ReceiptHeader";
            this.ReceiptHeader.Size = new System.Drawing.Size(310, 47);
            this.ReceiptHeader.TabIndex = 19;
            this.ReceiptHeader.Text = "\r\nPotion Seller\'s Potions";
            this.ReceiptHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderAndDate
            // 
            this.OrderAndDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderAndDate.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAndDate.Location = new System.Drawing.Point(410, 103);
            this.OrderAndDate.Name = "OrderAndDate";
            this.OrderAndDate.Size = new System.Drawing.Size(310, 58);
            this.OrderAndDate.TabIndex = 20;
            this.OrderAndDate.Text = "   Order Number: 2234\r\n   November 21, 1374";
            // 
            // OrderPrint
            // 
            this.OrderPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderPrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrint.Location = new System.Drawing.Point(410, 157);
            this.OrderPrint.Name = "OrderPrint";
            this.OrderPrint.Size = new System.Drawing.Size(223, 118);
            this.OrderPrint.TabIndex = 21;
            this.OrderPrint.Text = "\r\n   .\r\n   .\r\n   .\r\n";
            this.OrderPrint.Click += new System.EventHandler(this.OrderPrint_Click);
            // 
            // PricePrint
            // 
            this.PricePrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PricePrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePrint.Location = new System.Drawing.Point(607, 159);
            this.PricePrint.Name = "PricePrint";
            this.PricePrint.Size = new System.Drawing.Size(113, 116);
            this.PricePrint.TabIndex = 22;
            this.PricePrint.Text = "\r\n.  ";
            this.PricePrint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalPrint
            // 
            this.TotalPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalPrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrint.Location = new System.Drawing.Point(410, 275);
            this.TotalPrint.Name = "TotalPrint";
            this.TotalPrint.Size = new System.Drawing.Size(176, 141);
            this.TotalPrint.TabIndex = 23;
            this.TotalPrint.Text = "   Sub Total\r\n   Tax\r\n   Total\r\n\r\n   Tendered\r\n   Change";
            // 
            // TotalsOutputPrint
            // 
            this.TotalsOutputPrint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalsOutputPrint.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalsOutputPrint.Location = new System.Drawing.Point(581, 275);
            this.TotalsOutputPrint.Name = "TotalsOutputPrint";
            this.TotalsOutputPrint.Size = new System.Drawing.Size(139, 141);
            this.TotalsOutputPrint.TabIndex = 24;
            this.TotalsOutputPrint.Text = ".   ";
            this.TotalsOutputPrint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 93);
            this.label1.TabIndex = 25;
            this.label1.Text = "Drink responsibly, and have a nice day\r\n\r\nSponsored by Ye Olde Blacksmith Shoppe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangeOutput
            // 
            this.ChangeOutput.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeOutput.Location = new System.Drawing.Point(174, 430);
            this.ChangeOutput.Name = "ChangeOutput";
            this.ChangeOutput.Size = new System.Drawing.Size(96, 23);
            this.ChangeOutput.TabIndex = 17;
            this.ChangeOutput.Text = ".";
            this.ChangeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(20, 460);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(288, 36);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Scribe Receipt";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
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
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(20, 503);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(288, 38);
            this.ResetButton.TabIndex = 28;
            this.ResetButton.Text = "New Order";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ReceiptCover);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalsOutputPrint);
            this.Controls.Add(this.TotalPrint);
            this.Controls.Add(this.PricePrint);
            this.Controls.Add(this.OrderPrint);
            this.Controls.Add(this.OrderAndDate);
            this.Controls.Add(this.ReceiptHeader);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ChangeOutput);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.CalcChangeButton);
            this.Controls.Add(this.TendInput);
            this.Controls.Add(this.TendLabel);
            this.Controls.Add(this.blackBarLabel);
            this.Controls.Add(this.CalcNum);
            this.Controls.Add(this.CalcNumber);
            this.Controls.Add(this.CalcLabel);
            this.Controls.Add(this.RPInput);
            this.Controls.Add(this.BPInput);
            this.Controls.Add(this.GPInput);
            this.Controls.Add(this.CalcTotalButton);
            this.Controls.Add(this.GPLabel);
            this.Controls.Add(this.BPLabel);
            this.Controls.Add(this.RPLabel);
            this.Controls.Add(this.PSTitle);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Potion Seller\'s Potions Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PSTitle;
        private System.Windows.Forms.Label RPLabel;
        private System.Windows.Forms.Label BPLabel;
        private System.Windows.Forms.Label GPLabel;
        private System.Windows.Forms.Button CalcTotalButton;
        private System.Windows.Forms.TextBox GPInput;
        private System.Windows.Forms.TextBox BPInput;
        private System.Windows.Forms.TextBox RPInput;
        private System.Windows.Forms.Label CalcLabel;
        private System.Windows.Forms.Label CalcNumber;
        private System.Windows.Forms.Label CalcNum;
        private System.Windows.Forms.Label blackBarLabel;
        private System.Windows.Forms.Label TendLabel;
        private System.Windows.Forms.TextBox TendInput;
        private System.Windows.Forms.Button CalcChangeButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label ReceiptHeader;
        private System.Windows.Forms.Label OrderAndDate;
        private System.Windows.Forms.Label OrderPrint;
        private System.Windows.Forms.Label PricePrint;
        private System.Windows.Forms.Label TotalPrint;
        private System.Windows.Forms.Label TotalsOutputPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChangeOutput;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label ReceiptCover;
        private System.Windows.Forms.Button ResetButton;
    }
}

