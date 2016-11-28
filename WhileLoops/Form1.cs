using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WhileLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int counter, numStars;

            g.Clear(Color.Black);
            numStars = Convert.ToInt16(starInput.Text);

            //initialize
            counter = 1;

            //test
            while (counter <= numStars)
            {
                //act
                g.FillEllipse(drawBrush, 20 * counter, 50, 20, 20);

                //change
                counter = counter + 1;
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
    
            //initialize
           
            int y = 150;

            //test
            for (int x = this.Width - 10; x >1; x = x - 1)	
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, x, y, 10, 10);

                Thread.Sleep(10);    

            }
        }

        private void growButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            
          	    
            //test
            for (int x = 1; x < 50; x++)	
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, 50 - x / 2, 150 - x / 2, 10 + x, 10 + x);
                    
                Thread.Sleep(10);

                //change
 	
            }
        }

        private void fadeButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
          

            //test
            for (int x = 1; x < 256; x++)
            {
                //act
                g.Clear(Color.Black);
                drawBrush.Color = Color.FromArgb(255, 255 - x , 0 + x);
                g.FillRectangle(drawBrush, 50, 150, 50, 50);

                Thread.Sleep(10);

                //change
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
