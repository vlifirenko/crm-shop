using CrmBl.Model;
using Microsoft.EntityFrameworkCore;

namespace CrmUi
{
    public partial class Catalog : Form
    {
        private Type _dataType;
        private CrmContext _db;

        public Catalog()
        {
            InitializeComponent();
        }

        public void LoadData<T>(CrmContext db) where T : class
        {
            _dataType = typeof(T);
            _db = db;

            if (_dataType == typeof(Product))
            {
                var productSet = db.Set<Product>();
                productSet.Load();
                dataGridView.DataSource = productSet.Local.ToBindingList();
            }
            else if (_dataType == typeof(Customer))
            {
                var customerSet = db.Set<Customer>();
                customerSet.Load();
                dataGridView.DataSource = customerSet.Local.ToBindingList();
            }
            else if (_dataType == typeof(Seller))
            {
                var sellerSet = db.Set<Seller>();
                sellerSet.Load();
                dataGridView.DataSource = sellerSet.Local.ToBindingList();
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_dataType == typeof(Product))
            {
                var form = new ProductForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _db.Products.Add(form.Product);
                    _db.SaveChanges();
                }
            }
            else if (_dataType == typeof(Seller))
            {
                var form = new SellerForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _db.Sellers.Add(form.Seller);
                    _db.SaveChanges();
                }
            }
            else if (_dataType == typeof(Customer))
            {
                var form = new CustomerForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _db.Customers.Add(form.Customer);
                    _db.SaveChanges();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (_dataType == typeof(Product))
            {
                var productSet = _db.Set<Product>();
                var product = productSet.Find(id);
                if (product == null)
                    throw new Exception("product is null");

                var form = new ProductForm(product);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _db.Products.Update(form.Product);
                    _db.SaveChanges();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}