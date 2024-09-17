namespace _10_GDI_Grafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void KresliciBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen cerna = new Pen(Color.Black,4);

            Brush modra = new SolidBrush(Color.Blue);



            g.TranslateTransform(250, 250);

            //g.DrawLine(cerna, 57, 32, 57, 141);

            //g.DrawRectangle(cerna, 133, 22, 29, 96);

            //g.DrawEllipse(cerna, 76, 46, 35, 35);

            //g.DrawLine(cerna, -40, 0, 40, 0);
            //g.DrawLine(cerna, 0, 40, 0, -40);


            //g.FillRectangle(modra, 50, 50, 200, 200);



            //Point a = new Point(-20, 10);
            //Point b = new Point(20, 10);
            //Point c = new Point(0, -10);

            //Point[] triangle = { a, b, c };


            Font nasFont = new Font("Segoe UI", 26);

            g.DrawRectangle(Pens.Black,-50,0,200,50);

            float lenght = g.MeasureString("Macík", nasFont).Width;

            g.DrawString("Macik",nasFont,modra,-50 + 100 - lenght /2,0);



            Rectangle obdelnik = new Rectangle(-50, 90, 200, 50);


            g.DrawRectangle(Pens.Black,obdelnik);
            g.DrawString(
                "Macík",
                nasFont,
                Brushes.Black,
                obdelnik, 
                new StringFormat() {Alignment = StringAlignment.Center}
                
                );

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            Brush modra = new SolidBrush(Color.Blue);
            g.FillRectangle(modra, 0, 0, 200, 200);
        }
    }
}
