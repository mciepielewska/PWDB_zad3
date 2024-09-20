using System.Windows.Forms;

namespace PWDB_zad3_1
{
    public partial class Form1 : Form
    {
        private Image loadedImage;
        public Form1()
        {
            InitializeComponent();

            //crop
            numericUpDownWidth.Maximum = 400;   
            numericUpDownHeight.Maximum = 500;

            //scale
            numericUpDownScale.Minimum = 0.1m;      //x0,1
            numericUpDownScale.Maximum = 10.0m;     //x10
            numericUpDownScale.DecimalPlaces = 1;
            numericUpDownScale.Increment = 0.1m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Otwórz plik";

            openFileDialog.Filter = "Wszystkie pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp;*.gif" +
                                    "|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg" +
                                    "|PNG (*.png)|*.png" +
                                    "|BMP (*.bmp)|*.bmp" +
                                    "|GIF (*.gif)|*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Zapisz plik";

                saveFileDialog.Filter = "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg" +
                                        "|PNG (*.png)|*.png" +
                                        "|BMP (*.bmp)|*.bmp" +
                                        "|GIF (*.gif)|*.gif";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();

                    switch (extension)
                    {
                        case ".jpg":
                        case ".jpeg":
                            pictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".png":
                            pictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case ".bmp":
                            pictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case ".gif":
                            pictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        default:
                            MessageBox.Show("Nieobs³ugiwany format pliku.");
                            break;
                    }
                }
            }

            else
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
            }
        }

        private void cropButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int cropWidth = (int)numericUpDownWidth.Value;
                int cropHeight = (int)numericUpDownHeight.Value;
                int cropX = 0;
                int cropY = 0;

                if (cropWidth <= pictureBox1.Image.Width && cropHeight <= pictureBox1.Image.Height)
                {
                    Bitmap originalImage = new Bitmap(pictureBox1.Image);
                    Rectangle cropArea = new Rectangle(cropX, cropY, cropWidth, cropHeight);

                    Bitmap croppedImage = originalImage.Clone(cropArea, originalImage.PixelFormat);

                    pictureBox1.Image = croppedImage;
                }
                else
                {
                    MessageBox.Show("Wymiary przyciêcia s¹ wiêksze ni¿ wymiary obrazu.");
                }
            }
            else
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
            }
        }


        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                decimal scaleFactor = numericUpDownScale.Value;

                int originalWidth = pictureBox1.Image.Width;
                int originalHeight = pictureBox1.Image.Height;

                int newWidth = (int)(originalWidth * scaleFactor);
                int newHeight = (int)(originalHeight * scaleFactor);

                Bitmap scaledImage = new Bitmap(newWidth, newHeight);

                using (Graphics g = Graphics.FromImage(scaledImage))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(pictureBox1.Image, 0, 0, newWidth, newHeight);
                }

                pictureBox1.Image = scaledImage;
            }
            else
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
            }
        }


        private void mirrorButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Refresh();
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }
    }
}
