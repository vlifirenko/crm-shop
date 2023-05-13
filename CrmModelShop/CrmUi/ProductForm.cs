using CrmBl.Model;

namespace CrmUi
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product;
            textName.Text = product.Name;
            numericPrice.Value = product.Price;
            numericCount.Value = product.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product = new Product
            {
                Name = textName.Text,
                Price = numericPrice.Value,
                Count = Convert.ToInt32(numericCount.Value)
            };

            Close();
        }
    }
}