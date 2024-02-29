namespace SzamoloGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int oszlop = 0; oszlop < 10; oszlop++)
            {
                for (int sor = 0; sor < 10; sor++)
                {
                    SzamoloGomb c = new SzamoloGomb();
                    Controls.Add(c);
                    c.Left = sor*20;
                    c.Top = oszlop*20;
                    c.Height = 20;
                    c.Width = 20;  

                }
            }
        }
    }
}