using DB;

namespace HSD_manager
{
    public partial class HSD : Form
    {
        public HSD()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CartPage cartPage = new CartPage();
            cartPage.ShowDialog();
        }
    }
}