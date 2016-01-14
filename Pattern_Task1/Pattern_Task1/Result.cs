using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern_Task1
{
    public partial class Result : Form
    {
        public Result() { }
        public Result(Recognetion r)
        {
            //this.Width = r.width;
            //this.Height = r.height;
            try
            {
                InitializeComponent();
                //Bitmap newbitmap = new Bitmap(100,100);
                //newbitmap.SetPixel(50, 50, Color.FromArgb(255, 5, 5));
                Bitmap image = new Bitmap(r.width, r.height);
                Graphics imageGraphics = Graphics.FromImage(image);
                r.generateColoredImage(r.height, r.width, image);
                pictureBox1.Size = new System.Drawing.Size(r.width, r.height);
                pictureBox1.Image = image;
                this.Size = new Size(Convert.ToInt32(r.width + r.width * 0.25), Convert.ToInt32(r.height + r.height * 0.25));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }

        public Result(Image image)
        {
            InitializeComponent();

            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
            pictureBox1.Size = new Size(image.Width, image.Height);

            this.Size = new Size(Convert.ToInt32(image.Width + image.Width * 0.25), Convert.ToInt32(image.Height + image.Height * 0.25));
          
        }
           
    }
}
