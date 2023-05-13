using CrmBl.Model;
using Microsoft.EntityFrameworkCore;

namespace CrmUi
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        public void LoadData<T>(DbSet<T> set) where T : class
        {
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}