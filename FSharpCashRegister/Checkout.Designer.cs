namespace FSharpCashRegister {
    partial class Checkout {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(86, 77);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 14);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(96, 51);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(36, 14);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(66, 25);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(66, 14);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(138, 74);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 10;
            // 
            // Tax
            // 
            this.Tax.Location = new System.Drawing.Point(138, 48);
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Size = new System.Drawing.Size(100, 20);
            this.Tax.TabIndex = 9;
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(138, 22);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Size = new System.Drawing.Size(100, 20);
            this.Subtotal.TabIndex = 8;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(12, 103);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(120, 14);
            this.lblPayment.TabIndex = 15;
            this.lblPayment.Text = "Payment Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.Color.Red;
            this.Change.Location = new System.Drawing.Point(10, 129);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(120, 29);
            this.Change.TabIndex = 16;
            this.Change.Text = "Change: ";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckout.Location = new System.Drawing.Point(15, 170);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 17;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(163, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Subtotal);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
    }
}