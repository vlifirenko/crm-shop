using CrmBl.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrmUi
{
    public partial class Catalog : Form
    {
        private Type _dataType;
        private CrmContext _db;
        private DbSet<Product> _productSet;

        public Catalog()
        {
            InitializeComponent();
        }

        public void LoadData<T>(CrmContext db) where T : class
        {
            _dataType = typeof(T);
            _db = db;
            if (_dataType == typeof(Product))
                _productSet = db.Set<Product>();

            _productSet.Load();
            dataGridView.DataSource = _productSet.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_dataType == typeof(Product))
            {
                var form = new SellerForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _db.Sellers.Add(form.Seller);
                    _db.SaveChanges();
                }
            }
            else if (_dataType == typeof(Seller))
            {
            }
            else if (_dataType == typeof(Customer))
            {
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (_dataType == typeof(Product))
            {
                var product = _productSet.Find(id);
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