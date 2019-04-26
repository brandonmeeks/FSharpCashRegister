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
            this.AvailableProducts = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AvailableProducts
            // 
            this.AvailableProducts.FormattingEnabled = true;
            this.AvailableProducts.Location = new System.Drawing.Point(12, 12);
            this.AvailableProducts.Name = "AvailableProducts";
            this.AvailableProducts.Size = new System.Drawing.Size(198, 277);
            this.AvailableProducts.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(12, 301);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 14);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(86, 298);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(32, 20);
            this.Quantity.TabIndex = 4;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(135, 296);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 333);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.AvailableProducts);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button btnAddToCart;
    }
}