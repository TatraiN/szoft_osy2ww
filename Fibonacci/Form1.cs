namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 30; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {
                Sor újSor = new Sor();
                újSor.Sorszám = i;
                újSor.Érték = Fibonacci(i);

                sorok.Add(újSor);
            }
            dataGridView1.DataSource = sorok;


        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}