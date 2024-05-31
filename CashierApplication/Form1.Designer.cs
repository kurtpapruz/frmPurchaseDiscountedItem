namespace CashierApplication
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
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.DiscountBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.QuantiBox = new System.Windows.Forms.TextBox();
            this.PaymentReceived = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(203, 215);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(89, 33);
            this.ComputeButton.TabIndex = 0;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(28, 67);
            this.ItemName.Multiline = true;
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(264, 34);
            this.ItemName.TabIndex = 1;
            // 
            // DiscountBox
            // 
            this.DiscountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBox.Location = new System.Drawing.Point(314, 67);
            this.DiscountBox.Multiline = true;
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(154, 34);
            this.DiscountBox.TabIndex = 2;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(85, 130);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(207, 34);
            this.PriceBox.TabIndex = 3;
            // 
            // QuantiBox
            // 
            this.QuantiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantiBox.Location = new System.Drawing.Point(410, 130);
            this.QuantiBox.Multiline = true;
            this.QuantiBox.Name = "QuantiBox";
            this.QuantiBox.Size = new System.Drawing.Size(58, 34);
            this.QuantiBox.TabIndex = 4;
            // 
            // PaymentReceived
            // 
            this.PaymentReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentReceived.Location = new System.Drawing.Point(193, 315);
            this.PaymentReceived.Multiline = true;
            this.PaymentReceived.Name = "PaymentReceived";
            this.PaymentReceived.Size = new System.Drawing.Size(173, 34);
            this.PaymentReceived.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(379, 316);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(89, 33);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Discount(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Payment Received:";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.ForeColor = System.Drawing.Color.Black;
            this.totalAmount.Location = new System.Drawing.Point(66, 274);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(121, 20);
            this.totalAmount.TabIndex = 12;
            this.totalAmount.Text = "Total Amount:";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.Color.Black;
            this.Change.Location = new System.Drawing.Point(111, 387);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(76, 20);
            this.Change.TabIndex = 13;
            this.Change.Text = "Change:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 464);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PaymentReceived);
            this.Controls.Add(this.QuantiBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ComputeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox DiscountBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox QuantiBox;
        private System.Windows.Forms.TextBox PaymentReceived;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label Change;
    }
}

