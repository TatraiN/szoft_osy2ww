namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int oszlop = 0; oszlop < 20; oszlop++)
            {
                for (int sor = 0; sor < 20; sor++)
                {
                    VillogoGomb b = new VillogoGomb();

                   
                    b.Left = oszlop*20 + ClientRectangle.Width / 2-10*20;
                    b.Top = sor*20 + ClientRectangle.Height / 2-10*20;
                    b.Width = 20;
                    b.Height = 20;
                    Controls.Add(b);
                }
            }
        }
    }
}
//( - b.Width / 2)