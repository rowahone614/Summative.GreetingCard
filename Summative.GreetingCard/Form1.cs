using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Summative.GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphics Setup

            Graphics g = this.CreateGraphics();
            Pen buttonPen = new Pen(Color.Cyan);
            SolidBrush drawBrush = new SolidBrush(Color.Cyan);
            Font beginFont = new Font("Courier New", 16, FontStyle.Bold);
            g.Clear(Color.Black);
            //Open Here Text

            g.DrawString("Open Here", beginFont, drawBrush, 325, 185);

            //Open Here Button

            g.DrawRectangle(buttonPen, 315, 172, 143, 50);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.DarkBlue);

            //Colours Used
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush grayBrush = new SolidBrush(Color.LightGray);
            //Pens and Fonts
            Pen blackPen = new Pen(Color.Black, 2);
            Font compFont = new Font("Arial", 16, FontStyle.Bold);
            Font windowFont = new Font("Times New Roman", 16, FontStyle.Bold);
            //DeskTop Setup
            
            //FRAME ONE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 200, 190, 50, 50, 40, 37);
            g.DrawPie(blackPen, 200, 190, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWO

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 195, 187, 50, 50, 40, 37);
            g.DrawPie(blackPen, 195, 187, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THREE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 190, 184, 50, 50, 40, 37);
            g.DrawPie(blackPen, 190, 184, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME FOUR
            
            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 185, 181, 50, 50, 40, 37);
            g.DrawPie(blackPen, 185, 181, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME FIVE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 180, 178, 50, 50, 40, 37);
            g.DrawPie(blackPen, 180, 178, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME SIX

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 175, 175, 50, 50, 40, 37);
            g.DrawPie(blackPen, 175, 175, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME SEVEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 170, 172, 50, 50, 40, 37);
            g.DrawPie(blackPen, 170, 172, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME EIGHT

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 165, 169, 50, 50, 40, 37);
            g.DrawPie(blackPen, 165, 169, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME NINE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 163, 166, 50, 50, 40, 37);
            g.DrawPie(blackPen, 163, 166, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 162, 163, 50, 50, 40, 37);
            g.DrawPie(blackPen, 162, 163, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME ELEVEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 162, 160, 50, 50, 40, 37);
            g.DrawPie(blackPen, 162, 160, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWELVE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 162, 157, 50, 50, 40, 37);
            g.DrawPie(blackPen, 162, 157, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 164, 154, 50, 50, 40, 37);
            g.DrawPie(blackPen, 164, 154, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 165, 151, 50, 50, 40, 37);
            g.DrawPie(blackPen, 165, 151, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME FIFTEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 167, 148, 50, 50, 40, 37);
            g.DrawPie(blackPen, 167, 148, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME SIXTEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 169, 145, 50, 50, 40, 37);
            g.DrawPie(blackPen, 169, 145, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME SEVENTEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 172, 142, 50, 50, 40, 37);
            g.DrawPie(blackPen, 172, 142, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME EIGHTEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 175, 139, 50, 50, 40, 37);
            g.DrawPie(blackPen, 175, 139, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME NINETEEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 178, 136, 50, 50, 40, 37);
            g.DrawPie(blackPen, 178, 136, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 133, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 133, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY ONE
           
            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 130, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 130, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY TWO

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 127, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 127, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY THREE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 122, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 122, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY FOUR

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 117, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 117, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY FIVE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 112, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 112, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

           //FRAME TWENTY SIX
            
            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 107, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 107, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY SEVEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 102, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 102, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY EIGHT

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 97, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 97, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME TWENTY NINE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 92, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 92, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 87, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 87, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY ONE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 82, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 82, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY TWO

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 77, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 77, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY THREE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 75, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 75, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY FOUR

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 70, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 70, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY FIVE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 65, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 65, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY SIX

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 60, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 60, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY SEVEN

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 55, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 55, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY EIGHT

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 50, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 50, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME THIRTY NINE

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 40, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 40, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            Thread.Sleep(100);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY ONE
            //Cursor Shrinks With Click
            g.FillPie(whiteBrush, 184, 32, 40, 40, 40, 37);
            g.DrawPie(blackPen, 184, 32, 40, 40, 40, 37);

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);
            Thread.Sleep(300);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY TWO
            //Cursor Grows With Click
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);

            //File One
            g.FillRectangle(whiteBrush, 20, 20, 30, 45);
            g.FillRectangle(blackBrush, 22, 22, 26, 3);
            g.FillRectangle(blackBrush, 22, 27, 26, 3);
            g.FillRectangle(blackBrush, 22, 32, 26, 3);
            g.FillRectangle(blackBrush, 22, 37, 26, 3);
            //File Two
            g.FillRectangle(whiteBrush, 80, 20, 30, 45);
            g.FillRectangle(blackBrush, 82, 22, 26, 3);
            g.FillRectangle(blackBrush, 82, 27, 26, 3);
            g.FillRectangle(blackBrush, 82, 32, 26, 3);
            g.FillRectangle(blackBrush, 82, 37, 26, 3);
            //File Three
            g.FillRectangle(whiteBrush, 140, 20, 30, 45);
            g.FillRectangle(blackBrush, 142, 22, 26, 3);
            g.FillRectangle(blackBrush, 142, 27, 26, 3);
            g.FillRectangle(blackBrush, 142, 32, 26, 3);
            g.FillRectangle(blackBrush, 142, 37, 26, 3);
            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);
            Thread.Sleep(300);

            //FRAME FOURTY THREE

            //File Four
            g.FillRectangle(whiteBrush, 200, 20, 30, 45);
            g.FillRectangle(blackBrush, 202, 22, 26, 33);
            g.FillRectangle(redBrush, 204, 24, 22, 29);
            //File Five
            g.FillRectangle(whiteBrush, 260, 20, 30, 45);
            g.FillRectangle(blackBrush, 262, 22, 26, 33);
            g.FillRectangle(blueBrush, 264, 24, 22, 29);
            //Window Begins to Appear
            g.FillRectangle(whiteBrush, 0, 0, 200, 100);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            Thread.Sleep(200);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY FOUR

            //Window Continues to Grow
            g.FillRectangle(whiteBrush, 0, 0, 400, 200);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            Thread.Sleep(200);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY FIVE

            //Window Continues to Grow
            g.FillRectangle(whiteBrush, 0, 0, 600, 300);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            Thread.Sleep(200);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY SIX

            //Window Continues to Grow
            g.FillRectangle(whiteBrush, 0, 0, 800, 400);

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            Thread.Sleep(200);
            g.Clear(Color.DarkBlue);

            //FRAME FOURTY EIGHT

            g.Clear(Color.White);
            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            //Task Bar Graphics
            g.FillRectangle(blackBrush, 0, 0, 800, 30);
            g.FillRectangle(redBrush, 760, 0, 40, 30);
            g.DrawString("X", compFont, whiteBrush, 767, 5);
            Thread.Sleep(200);
            g.Clear(Color.White);

            //FRAME FOURTY NINE

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            //Task Bar Graphics
            g.FillRectangle(blackBrush, 0, 0, 800, 30);
            g.FillRectangle(redBrush, 760, 0, 40, 30);
            g.DrawString("X", compFont, whiteBrush, 767, 5);
            g.DrawString("Loading...", windowFont, grayBrush, 340, 195);
            Thread.Sleep(3000);
            g.Clear(Color.White);

            //FRAME FIFTY

            //Cursor Graphics
            g.FillPie(whiteBrush, 181, 35, 50, 50, 40, 37);
            g.DrawPie(blackPen, 181, 35, 50, 50, 40, 37);
            //Task Bar Graphics
            g.FillRectangle(blackBrush, 0, 0, 800, 30);
            g.FillRectangle(redBrush, 760, 0, 40, 30);
            g.DrawString("X", compFont, whiteBrush, 767, 5);
            //Error Window Graphics
            g.FillRectangle(grayBrush, 230, 150, 300, 170);
            g.DrawRectangle(blackPen, 230, 150, 300, 170);
            g.FillRectangle(blackBrush, 230, 150, 300, 30);
            g.FillRectangle(redBrush, 500, 150, 30, 30);
            g.DrawString("X", compFont, whiteBrush, 503, 155);
            g.DrawString("System Error - 1203748", windowFont, whiteBrush, 235, 153);
            g.DrawString("could not load file:", windowFont, blackBrush, 235, 193);
            g.DrawString("GreetingCard.mp4", windowFont, blackBrush, 235, 233);
            g.DrawString("help", windowFont, blackBrush, 460, 280);
            g.DrawRectangle(blackPen, 455, 278, 56, 32);

        }

    }
}
