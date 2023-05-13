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

        private void button1_Click(object sender, EventArgs e)
        {
            Seller = new Seller
            {
                Name = textBox1.Text
            };

            Close();
        }
    }
}
