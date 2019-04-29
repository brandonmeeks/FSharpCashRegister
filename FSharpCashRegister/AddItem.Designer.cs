namespace FSharpCashRegister {
    partial class AddItem {
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(12, 38);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 14);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(86, 35);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(32, 20);
            this.Quantity.TabIndex = 4;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(15, 61);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(65, 6);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(152, 20);
            this.ItemName.TabIndex = 7;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(12, 9);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(47, 14);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "Name:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(174, 35);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(43, 20);
            this.Price.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(124, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 14);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 103);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.lblQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label lblPrice;
    }
}