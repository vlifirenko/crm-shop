using CrmBl.Model;
using Microsoft.EntityFrameworkCore;

namespace CrmUi
{
    public partial class Catalog<T> : Form where T : class
    {
        private DbSet<Product> products;

        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}