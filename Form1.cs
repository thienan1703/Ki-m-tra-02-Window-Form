namespace Window_Form
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart = new ShoppingCart();
        private List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            DisplayProducts();
        }

        private void LoadProducts()
        {
            products.Add(new Product("sp1", 100000, 1));
            products.Add(new Product("sp2", 200000, 1));
            products.Add(new Product("sp3", 300000, 1));
            products.Add(new Product("sp4", 400000, 1));
        }

        private void DisplayProducts()
        {
            lstProducts.Items.Clear();
            foreach (var product in products)
            {
                lstProducts.Items.Add(product);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is Product selectedProduct)
            {
                cart.AddToCart(new Product(selectedProduct.Name, selectedProduct.Price, 1));
                DisplayCart();
                UpdateTotalPrice();
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItem != null)
            {

                var selectedCartItem = lstCart.SelectedItem.ToString();
                string productName = selectedCartItem.Split('-')[0].Trim();
                cart.RemoveFromCart(productName);
                DisplayCart();
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong giỏ hàng để xóa.", "Thông báo");
            }
        }

        private void DisplayCart()
        {
            lstCart.Items.Clear();
            foreach (var item in cart.GetCartItems())
            {
                lstCart.Items.Add($"{item.Name} - Số lượng: {item.Quantity} - Giá: {item.Price * item.Quantity} VND");
            }
        }

        private void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "Tổng giá trị: " + cart.CalculateTotal() + " VND";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Đơn hàng của bạn đã được hoàn tất!", "Thông báo");
                cart.ClearCart();
                DisplayCart();
                UpdateTotalPrice();
            }
        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public override string ToString()
            {
                return $"{Name} - Giá: {Price} VND";
            }
        }

        public class ShoppingCart
        {
            private List<Product> cartItems = new List<Product>();

            public void AddToCart(Product product)
            {
                var existingProduct = cartItems.Find(p => p.Name == product.Name);
                if (existingProduct != null)
                {
                    existingProduct.Quantity += product.Quantity;
                }
                else
                {
                    cartItems.Add(product);
                }
            }

            public void RemoveFromCart(string productName)
            {
                var product = cartItems.Find(p => p.Name == productName);
                if (product != null)
                {
                    cartItems.Remove(product);
                }
            }

            public List<Product> GetCartItems()
            {
                return cartItems;
            }

            public decimal CalculateTotal()
            {
                decimal total = 0;
                foreach (var item in cartItems)
                {
                    total += item.Price * item.Quantity;
                }
                return total;
            }

            public void ClearCart()
            {
                cartItems.Clear();
            }
        }

        private void btnRemoveFromCart_Click_1(object sender, EventArgs e)
        {

        }
    }
}