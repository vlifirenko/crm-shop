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
            var set = db.Set<T>();

            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

        }
    }
}