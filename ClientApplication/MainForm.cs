namespace ClientApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            using NewOrderDialog newOrderDialog = new();

            DialogResult result = newOrderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Save new order
            }
        }
    }
}