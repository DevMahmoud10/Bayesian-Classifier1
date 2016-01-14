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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            //bdl ma ad5l el input kol shwia
/*
            Recognetion r = new Recognetion(600, 600,
            100.ToString(), 110.ToString(), 120.ToString(), 0.7.ToString(), 0.4.ToString(), 0.3.ToString(),
            230.ToString(), 20.ToString(), 20.ToString(), 0.1.ToString(), 0.2.ToString(), 0.6.ToString(),
            210.ToString(), 230.ToString(), 190.ToString(), 0.5.ToString(), 0.4.ToString(), 0.3.ToString(),
            40.ToString(), 10.ToString(), 30.ToString(), 0.4.ToString(), 0.2.ToString(), 0.1.ToString()

            );

           */

            Recognetion r = new Recognetion(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text),
           textBox3.Text, textBox5.Text, textBox7.Text, textBox4.Text, textBox6.Text, textBox8.Text,
          textBox20.Text, textBox18.Text, textBox16.Text, textBox19.Text, textBox17.Text, textBox15.Text,
           textBox14.Text, textBox12.Text, textBox10.Text, textBox13.Text, textBox11.Text, textBox9.Text,
           textBox26.Text, textBox24.Text, textBox22.Text, textBox25.Text, textBox23.Text, textBox21.Text);

            Result frm = new Result(r);
            frm.Show();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            openFD.Title = "Insert an Image";



            string Chosen_File = "";
            Chosen_File = openFD.FileName;
            Image image = Image.FromFile(Chosen_File);

            Result frm = new Result(image);
            frm.Show();
           
            
        }
    }
}
