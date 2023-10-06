namespace SageKiller
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void ButtnImage_Click(object sender, EventArgs e)
        {

            Random rdnx = new Random();
            Random rdny = new Random();
            int x = rdnx.Next(0, 713);
            int y = rdny.Next(117, 332);
            ButtnImage.Location = new Point(x, y);
            contador++;
            label1.Text = "Puntos: " + contador;
            if (contador == 50)
            {
           
            }





        }
    }
}