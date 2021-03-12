using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_book_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] y=new int[8];
        int x=0;
        public void random_function()
        {
            Random random = new Random();
            y[0]= random.Next(7); y[4] = random.Next(7);
            y[1] = random.Next(7); y[5] = random.Next(7);
            y[2] = random.Next(7); y[6] = random.Next(7);
            y[3] = random.Next(7); y[7] = random.Next(7);
            pictureBox9.Image = imageList1.Images[y[0]];
            pictureBox2.Image = imageList2.Images[y[1]];
            pictureBox3.Image = imageList3.Images[y[2]];
            pictureBox4.Image = imageList4.Images[y[3]];
            pictureBox5.Image = imageList5.Images[y[4]];
            pictureBox6.Image = imageList1.Images[y[5]];
            pictureBox7.Image = imageList3.Images[y[6]];
            pictureBox8.Image = imageList2.Images[y[7]];
        }


        
        public void design()
        {
            if (x == 0)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            if (x == 1) {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            if (x == 2)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            if (x == 3)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Blue;
                label4.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            if (x == 4)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Blue;
                label6.ForeColor = Color.Black;
            }
            if (x == 5)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label6.ForeColor = Color.Blue;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
            pictureBox3.Image = imageList1.Images[1];
            pictureBox4.Image = imageList1.Images[2];
            pictureBox5.Image = imageList1.Images[3];
            pictureBox6.Image = imageList1.Images[4];
            pictureBox7.Image = imageList1.Images[5];
            pictureBox8.Image = imageList1.Images[6];
            pictureBox9.Image = imageList1.Images[7];
            x = 1;
            design();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            pictureBox2.Image = imageList2.Images[0];
            pictureBox3.Image = imageList2.Images[1];
            pictureBox4.Image = imageList2.Images[2];
            pictureBox5.Image = imageList2.Images[3];
            pictureBox6.Image = imageList2.Images[4];
            pictureBox7.Image = imageList2.Images[5];
            pictureBox8.Image = imageList2.Images[6];
            pictureBox9.Image = imageList2.Images[7];
            x = 2;
            design();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList3.Images[0];
            pictureBox3.Image = imageList3.Images[1];
            pictureBox4.Image = imageList3.Images[2];
            pictureBox5.Image = imageList3.Images[3];
            pictureBox6.Image = imageList3.Images[4];
            pictureBox7.Image = imageList3.Images[5];
            pictureBox8.Image = imageList3.Images[6];
            pictureBox9.Image = imageList3.Images[7];
            x = 3;
            design();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList4.Images[0];
            pictureBox3.Image = imageList4.Images[1];
            pictureBox4.Image = imageList4.Images[2];
            pictureBox5.Image = imageList4.Images[3];
            pictureBox6.Image = imageList4.Images[4];
            pictureBox7.Image = imageList4.Images[5];
            pictureBox8.Image = imageList4.Images[6];
            pictureBox9.Image = imageList4.Images[7];
            x = 4;
            design();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList5.Images[0];
            pictureBox3.Image = imageList5.Images[1];
            pictureBox4.Image = imageList5.Images[2];
            pictureBox5.Image = imageList5.Images[3];
            pictureBox6.Image = imageList5.Images[4];
            pictureBox7.Image = imageList5.Images[5];
            pictureBox8.Image = imageList5.Images[6];
            pictureBox9.Image = imageList5.Images[7];
            x = 5;
            design();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random_function();
        }

        private void CATEGORY_Click(object sender, EventArgs e)
        {
            random_function();
            x = 0;
            design();
        }
    }
}
