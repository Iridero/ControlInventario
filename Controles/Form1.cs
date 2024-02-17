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
            MessageBox.Show(sexoControl1.Sexo);
        }
    }
}
