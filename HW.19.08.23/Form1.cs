namespace HW._19._08._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap myBitmap = new Bitmap(Properties.Resources._11);
                Graphics gFromImage = Graphics.FromImage(myBitmap);
                Brush b = new SolidBrush(Color.Black);
                b = new SolidBrush(Color.FromArgb(200, 255, 0));
                gFromImage.FillEllipse(b, 350, 50, 100, 100);
                b = new SolidBrush(Color.FromArgb(100, 100, 100));
                gFromImage.FillEllipse(b, 370, 75, 15, 15);
                gFromImage.FillEllipse(b, 410, 75, 15, 15);
                gFromImage.FillRectangle(b, 390, 100, 15, 15);
                myBitmap.Save(@"test.bmp");
                myBitmap.Dispose();
                gFromImage.Dispose();

            }
            catch { }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Bitmap myBitmap = new Bitmap(@"test.bmp");
                Graphics g = e.Graphics;
                g.DrawImage(myBitmap, 0, 0, 350, 300);
                myBitmap.Dispose();
                g.Dispose();
            }
            catch { }
        }
    }
}