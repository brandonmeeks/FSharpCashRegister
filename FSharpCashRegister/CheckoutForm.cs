using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrivialBehind;

namespace FSharpCashRegister {
    public partial class CheckoutForm : Form {
        public CheckoutForm() {
            InitializeComponent();
            TrivialBehinds.CreateComponentBehind(this);
        }

        public CheckoutForm(decimal subtotal, decimal tax, decimal total) {
            InitializeComponent();
            Subtotal.Text = subtotal.ToString();
            Tax.Text = tax.ToString();
            Total.Text = total.ToString();
            TrivialBehinds.CreateComponentBehind(this);
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
