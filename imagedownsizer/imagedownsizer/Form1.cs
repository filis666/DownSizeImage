using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace imagedownsizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectImageButton_Click_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Изберете изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    Image originalImage = Image.FromFile(selectedImagePath);
                    pictureBox1.Image = originalImage;
                }
            }
        }

        private void DownsizeButton_Click_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Изберете изображение.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(DownscaleFactorTextBox.Text, out double downscaleFactor) || downscaleFactor <= 0 || downscaleFactor > 100)
            {
                MessageBox.Show("Въведете валидна стойност между 0 и 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Image originalImage = pictureBox1.Image;

            Task.Factory.StartNew(() =>
            {
                Image downsizedImage = DownsizeImage(originalImage, downscaleFactor);
                DisplayDownsizedImage(downsizedImage);
            });
        }

        private Image DownsizeImage(Image originalImage, double downscaleFactor)
        {
            int newWidth = (int)(originalImage.Width * downscaleFactor / 100);
            int newHeight = (int)(originalImage.Height * downscaleFactor / 100);

            Bitmap newBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newBitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return newBitmap;
        }
        private void DisplayDownsizedImage(Image downsizedImage)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => DisplayDownsizedImage(downsizedImage)));
            }
            else
            {
                pictureBox1.Image = downsizedImage;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}