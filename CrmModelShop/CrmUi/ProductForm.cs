using CrmBl.Model;
using System.Diagnostics;

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
            var product = Product ?? new Product();

            product.Name = textName.Text;
            product.Price = numericPrice.Value;
            product.Count = Convert.ToInt32(numericCount.Value);

            Close();
        }
    }
}