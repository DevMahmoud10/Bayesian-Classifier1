using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Task1
{
    public class Recognetion
    {
        public int width;
        public int height;

        public section[] classes = new section[4];

        public Recognetion() { }

       
        
        public Recognetion(int w, int h,
            string c1rm, string c1gm, string c1bm, string c1rs, string c1gs, string c1bs,
            string c2rm, string c2gm, string c2bm, string c2rs, string c2gs, string c2bs,
            string c3rm, string c3gm, string c3bm, string c3rs, string c3gs, string c3bs,
            string c4rm, string c4gm, string c4bm, string c4rs, string c4gs, string c4bs
            ) //c1rm --> class1 red mu  
        {
            this.width = w;
            this.height = h;

            //initialization of sections 
            for(int i=0;i<classes.Length;i++)
            {
                classes[i] = new section();
            }
            
            classes[0].start = 0;
            classes[0].end = (0.25 * width) - 1;
            classes[0].r.mu = Convert.ToDouble(c1rm);
            classes[0].r.sigma = Convert.ToDouble(c1rs);
            classes[0].g.mu = Convert.ToDouble(c1gm);
            classes[0].g.sigma = Convert.ToDouble(c1gs);
            classes[0].b.mu = Convert.ToDouble(c1bm);
            classes[0].b.sigma = Convert.ToDouble(c1bs);

            classes[1].start = (0.25 * width);
            classes[1].end = (0.5 * width) - 1;
            classes[1].r.mu = Convert.ToDouble(c2rm);
            classes[1].r.sigma = Convert.ToDouble(c2rs);
            classes[1].g.mu = Convert.ToDouble(c2gm);
            classes[1].g.sigma = Convert.ToDouble(c2gs);
            classes[1].b.mu = Convert.ToDouble(c2bm);
            classes[1].b.sigma = Convert.ToDouble(c2bs);

            classes[2].start = (0.5 * width);
            classes[2].end = (0.75 * width) - 1;
            classes[2].r.mu = Convert.ToDouble(c3rm);
            classes[2].r.sigma = Convert.ToDouble(c3rs);
            classes[2].g.mu = Convert.ToDouble(c3gm);
            classes[2].g.sigma = Convert.ToDouble(c3gs);
            classes[2].b.mu = Convert.ToDouble(c3bm);
            classes[2].b.sigma = Convert.ToDouble(c3bs);

            classes[3].start = (0.75 * width);
            classes[3].end = width - 1;
            classes[3].r.mu = Convert.ToDouble(c4rm);
            classes[3].r.sigma = Convert.ToDouble(c4rs);
            classes[3].g.mu = Convert.ToDouble(c4gm);
            classes[3].g.sigma = Convert.ToDouble(c4gs);
            classes[3].b.mu = Convert.ToDouble(c4bm);
            classes[3].b.sigma = Convert.ToDouble(c4bs);
        }


        public double generateNDnumber()// generate normal distributed number 
        {
            double r1,r2,z; //  normal distributed number 
            Random r = new Random();
            r1 = r.NextDouble(); // l7d dlw2ty uniform 
            r2 = r.NextDouble();


            z = (-2 * (Math.Log(r1, Math.E))) + Math.Cos(2 * Math.PI * r2);            //3ayzeen n3mlo normal 

            return z;
        }

        public void colorPixel(section s, int x, int y, Bitmap img)
        {
            //apply el color elly t7t 3la el pixel
            img.SetPixel(x, y, Color.FromArgb(Convert.ToInt32(s.p.R), Convert.ToInt32(s.p.G), Convert.ToInt32(s.p.B)));
        }

        public void generateColoredImage(double height, double width, Bitmap img)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i >= classes[0].start && i <= classes[0].end)
                    {
                        classes[0].p.R = classes[0].r.mu + (classes[0].r.sigma * generateNDnumber());
                        classes[0].p.G = classes[0].g.mu + (classes[0].g.sigma * generateNDnumber());
                        classes[0].p.B = classes[0].b.mu + (classes[0].b.sigma * generateNDnumber());

                        colorPixel(classes[0], i, j, img);


                    }

                    else if (i >= classes[1].start && i <= classes[1].end)
                    {
                        classes[1].p.R = classes[1].r.mu + (classes[1].r.sigma * generateNDnumber());
                        classes[1].p.G = classes[1].g.mu + (classes[1].g.sigma * generateNDnumber());
                        classes[1].p.B = classes[1].b.mu + (classes[1].b.sigma * generateNDnumber());

                        colorPixel(classes[1], i, j, img);

                    }

                    else if (i >= classes[2].start && i <= classes[2].end)
                    {
                        classes[2].p.R = classes[2].r.mu + (classes[2].r.sigma * generateNDnumber());
                        classes[2].p.G = classes[2].g.mu + (classes[2].g.sigma * generateNDnumber());
                        classes[2].p.B = classes[2].b.mu + (classes[2].b.sigma * generateNDnumber());

                        colorPixel(classes[2], i, j, img);

                    }
                    else if (i >= classes[3].start && i <= classes[3].end)
                    {
                        classes[3].p.R = classes[3].r.mu + (classes[3].r.sigma * generateNDnumber());
                        classes[3].p.G = classes[3].g.mu + (classes[3].g.sigma * generateNDnumber());
                        classes[3].p.B = classes[3].b.mu + (classes[3].b.sigma * generateNDnumber());

                        colorPixel(classes[3], i, j, img);
                    }


                }
            }
        }
    }
}
