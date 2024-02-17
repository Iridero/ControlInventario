namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sexoControl1_SexoCambiado(object sender, EventArgs e)
        {

        }

        private void ipAddressInput1_IpAddressChanged(object sender, EventArgs e)
        {
            lblIp.Text = ipAddressInput1.IpAddress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignarIp_Click(object sender, EventArgs e)
        {

            try
            {
                ipAddressInput1.IpAddress = txtIp.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
