using CrmBl.Model;

namespace CrmUi
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            textName.Text = seller.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seller = Seller ?? new Seller();
            seller.Name = textName.Text;

            Close();
        }
    }
}
