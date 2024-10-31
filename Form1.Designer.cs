using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Window_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstProducts = new ListBox();
            lstCart = new ListBox();
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnCheckout = new Button();
            lblTotalPrice = new Label();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(26, 27);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(508, 144);
            lstProducts.TabIndex = 0;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.Location = new Point(569, 27);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(288, 144);
            lstCart.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(322, 241);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(153, 29);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Thêm vào giỏ hàng";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(556, 241);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(155, 29);
            btnRemoveFromCart.TabIndex = 3;
            btnRemoveFromCart.Text = "Xoá khỏi giỏ hàng";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click_1;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(451, 357);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(322, 318);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(160, 20);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = " Tổng giá trị đơn hàng:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 450);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lstCart);
            Controls.Add(lstProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

        }

        #endregion

        private ListBox lstProducts;
        private ListBox lstCart;
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCheckout;
        private Label lblTotalPrice;
    }
}
