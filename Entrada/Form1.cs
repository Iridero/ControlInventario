namespace Entrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmPinPad f= new FrmPinPad();
            f.AccesoConcedido += F_AccesoConcedido;
            f.ShowDialog();
        }

        private void F_AccesoConcedido(object? sender, EventArgs e)
        {
            label1.Text = "Acceso concedido";
        }
    }
}
