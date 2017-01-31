using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawExample {

    /*
     * Notice: You can't use FormLoad to draw.
     * You can't see the line because the form is not yet visible when the Load event runs.  
     * Calling DrawLine in a button's Click event produces visible output, but you'll lose it as soon as the form needs to redrawn.
     * For example, minimize and restore the form to see it gone. 
     */

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        public void drawline(Color color, int y ,int x) {

            //Paper
            Graphics paper = this.CreateGraphics();

            //Pen
            Pen pen = new Pen(color, 3);

            //Draw with Pen on Paper
            paper.DrawLine(pen, 100, y, 650, x);

            //Free memory
            paper.Dispose();

        }

        public void drawelipse(Color color) {

            //Paper
            Graphics paper = this.CreateGraphics();

            //Pen
            Pen pen = new Pen(color, 3);

            //Draw with Pen on Paper
            paper.DrawEllipse(pen, 297, 280, 80, 80);

            //Free memory
            paper.Dispose();

        }

        private void button1_Click(object sender, EventArgs e) {

            drawline(Color.Blue, 25, 25);

        }

        private void button2_Click(object sender, EventArgs e) {

            drawline(Color.Red, 70, 70);

        }

        private void button4_Click(object sender, EventArgs e) {

            drawline(Color.Green, 115, 115);

        }

        private void button3_Click(object sender, EventArgs e) {

            drawline(Color.Yellow, 160, 160);

        }

        private void button5_Click(object sender, EventArgs e) {

            drawelipse(Color.Red);

        }

        private void button6_Click(object sender, EventArgs e) {

            drawline(Color.CadetBlue, Convert.ToInt32(txty.Text) , Convert.ToInt32(txtx.Text));

        }

    }
}
