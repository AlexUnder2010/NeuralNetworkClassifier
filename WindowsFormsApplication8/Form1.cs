using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApplication8.Properties;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        private static readonly Random Rand = new Random();

        private readonly List<string> _color = new List<string>
        {
            Resources.Form1_button1_Click_Black,
            Resources.Form1_button1_Click_White,
            Resources.Form1_button1_Click_Orange,
            "black",
            "white",
            "orange"
        };

        private readonly List<string> _fleecy = new List<string>
        {
            Resources.Form1_button1_Click_Yes,
            Resources.Form1_button1_Click_No,
            "yes",
            "no"
        };

        private readonly List<string> _size = new List<string>
        {
            "big",
            "small",
            Resources.Form1_button1_Click_Big,
            Resources.Form1_button1_Click_Small
        };

        private readonly List<string> _stripped = new List<string>
        {
            Resources.Form1_button1_Click_Yes,
            Resources.Form1_button1_Click_No,
            "yes",
            "no"
        };

        private double _counter = 1;
        private double _counter1 = 1;
        private double _out;
        private double _w1 = Rand.NextDouble();
        private double _w2 = Rand.NextDouble();
        private double _w3 = Rand.NextDouble();
        private double _w4 = Rand.NextDouble();
        private double _x1 = 0.1;
        private double _x2 = 0.1;
        private double _x3 = 0.1;
        private double _x4 = 0.1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _counter = +1;
            var result = _counter / _counter1 * 100;

            progressBar1.Maximum = 99;
            for (var i = 0; i < result; i++)
                progressBar1.Value = i;
            var colors = _color.Find(x => x == comboBox1.Text);
            var sizes = _size.Find(x => x == comboBox2.Text);
            var stripes = _stripped.Find(x => x == comboBox3.Text);
            var fleecys = _fleecy.Find(x => x == comboBox4.Text);
            if (comboBox1.Text == colors && comboBox2.Text == sizes && comboBox3.Text == stripes &&
                comboBox4.Text == fleecys)
            {
                var net1 = _w1 * _x1;
                var net2 = _w2 * _x2;
                var net3 = _w3 * _x3;
                var net4 = _w4 * _x4;

                var sum = net1 + net2 + net3 + net4;

                _out = 1 / (1 + Math.Tan(sum));
                if (_out <= 0.25)
                    richTextBox1.AppendText("Computer thinks it is a Cat " + DateTime.Now.ToString("(hh:mm:ss)\n"));
                else if (_out > 0.25 && _out <= 0.5)
                    richTextBox1.AppendText("Computer thinks it is a Panther " + DateTime.Now.ToString("(hh:mm:ss)\n"));
                else if (_out > 0.5 && _out <= 0.75)
                    richTextBox1.AppendText("Computer thinks it is a Lion " + DateTime.Now.ToString("(hh:mm:ss)\n"));
                else
                    richTextBox1.AppendText("Computer thinks it is a Tiger " + DateTime.Now.ToString("(hh:mm:ss)\n"));
                textBox3.Text = _w1.ToString(CultureInfo.InvariantCulture);
                textBox4.Text = _w2.ToString(CultureInfo.InvariantCulture);
                textBox5.Text = _w3.ToString(CultureInfo.InvariantCulture);
                textBox6.Text = _w4.ToString(CultureInfo.InvariantCulture);
                textBox7.Text = _out.ToString(CultureInfo.InvariantCulture);
                if (comboBox1.Text == Resources.Form1_button1_Click_Orange &&
                    comboBox2.Text == Resources.Form1_button1_Click_Big && _out >= 0.75)
                {
                    var random = new Random();
                    _out = random.Next(65, 100) / 100.0;
                    pictureBox1.Image = Resources.white_tiger;
                    _w4 += 0.3 * (1 - _w4);
                    _x4 += 0.3 * (1 - _x4);
                    /*_w1 -= 0.3 * (1 - _w1);
                    _w2 -= 0.3 * (1 - _w2);
                    _w3 -= 0.3 * (1 - _w3);
                    _x1 -= 0.3 * (1 - _x1);
                    _x2 -= 0.3 * (1 - _x2);
                    _x3 -= 0.3 * (1 - _x3);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_White &&
                         comboBox2.Text == Resources.Form1_button1_Click_Big && _out >= 0.75)
                {
                    _out = Rand.Next(65, 100) / 100.0;
                    pictureBox1.Image = Resources.white_tiger_;
                    _w4 += 0.3 * (1 - _w4);
                    _x4 += 0.3 * (1 - _x4);
                    /* _w1 -= 0.3 * (1 - _w1);
                     _w2 -= 0.3 * (1 - _w2);
                     _w3 -= 0.3 * (1 - _w3);
                     _x1 -= 0.3 * (1 - _x1);
                     _x2 -= 0.3 * (1 - _x2);
                     _x3 -= 0.3 * (1 - _x3);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_Black &&
                         comboBox2.Text == Resources.Form1_button1_Click_Small && _out <= 0.25)
                {
                    _out = Rand.Next(0, 35) / 100.0;
                    pictureBox1.Image = Resources.black_cat;
                    _w1 += 0.3 * (1 - _w1);
                    _x1 += 0.3 * (1 - _x1);
                    /* _w2 -= 0.3 * (1 - _w2);
                     _w3 -= 0.3 * (1 - _w3);
                     _w4 -= 0.3 * (1 - _w4);
                     _x2 -= 0.3 * (1 - _x2);
                     _x3 -= 0.3 * (1 - _x3);
                     _x4 -= 0.3 * (1 - _x4);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_Orange &&
                         comboBox2.Text == Resources.Form1_button1_Click_Small && _out <= 0.25)
                {
                    _out = Rand.Next(0, 35) / 100.0;
                    pictureBox1.Image = Resources.orange_cat;
                    _w1 += 0.3 * (1 - _w1);
                    _x1 += 0.3 * (1 - _x1);
                    /*  _w2 -= 0.3 * (1 - _w2);
                      _w3 -= 0.3 * (1 - _w3);
                      _w4 -= 0.3 * (1 - _w4);
                      _x2 -= 0.3 * (1 - _x2);
                      _x3 -= 0.3 * (1 - _x3);
                      _x4 -= 0.3 * (1 - _x4);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_White &&
                         comboBox2.Text == Resources.Form1_button1_Click_Small && _out <= 0.25)
                {
                    _out = Rand.Next(0, 35) / 100.0;
                    pictureBox1.Image = Resources.white_cat;
                    _w1 += 0.3 * (1 - _w1);
                    _x1 += 0.3 * (1 - _x1);
                    /* _w2 -= 0.3 * (1 - _w2);
                     _w3 -= 0.3 * (1 - _w3);
                     _w4 -= 0.3 * (1 - _w4);
                     _x2 -= 0.3 * (1 - _x2);
                     _x3 -= 0.3 * (1 - _x3);
                     _x4 -= 0.3 * (1 - _x4);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_Black &&
                         comboBox3.Text == Resources.Form1_button1_Click_No &&
                         comboBox2.Text == Resources.Form1_button1_Click_Big && _out > 0.25 &&
                         _out <= 0.5)
                {
                    _out = Rand.Next(15, 60) / 100.0;
                    pictureBox1.Image = Resources.panther;
                    _w2 += 0.3 * (1 - _w2);
                    _x2 += 0.3 * (1 - _x2);
                    /* _w1 -= 0.3 * (1 - _w1);
                     _w3 -= 0.3 * (1 - _w3);
                     _w4 -= 0.3 * (1 - _w4);
                     _x1 -= 0.3 * (1 - _x1);
                     _x3 -= 0.3 * (1 - _x3);
                     _x4 -= 0.3 * (1 - _x4);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_Orange &&
                         comboBox3.Text == Resources.Form1_button1_Click_Yes &&
                         comboBox4.Text == Resources.Form1_button1_Click_Yes &&
                         comboBox2.Text == Resources.Form1_button1_Click_Big && _out > 0.5 &&
                         _out <= 0.75)
                {
                    _out = Rand.Next(40, 85) / 100.0;
                    pictureBox1.Image = Resources.lion;
                    _w3 += 0.3 * (1 - _w3);
                    _x3 += 0.3 * (1 - _x3);
                    /*  _w1 -= 0.3 * (1 - _w1);
                      _w2 -= 0.3 * (1 - _w2);
                      _w4 -= 0.3 * (1 - _w4);
                      _x1 -= 0.3 * (1 - _x1);
                      _x2 -= 0.3 * (1 - _x2);
                      _x4 -= 0.3 * (1 - _x4);*/
                }
                else if (comboBox1.Text == Resources.Form1_button1_Click_Orange &&
                         comboBox3.Text == Resources.Form1_button1_Click_No &&
                         comboBox4.Text == Resources.Form1_button1_Click_Yes &&
                         comboBox2.Text == Resources.Form1_button1_Click_Big && _out > 0.5 &&
                         _out <= 0.75)
                {
                    _out = Rand.Next(40, 85) / 100.0;
                    pictureBox1.Image = Resources.lion_without;
                    _w3 += 0.3 * (1 - _w3);
                    _x3 += 0.3 * (1 - _x3);
                    /* _w1 -= 0.3 * (1 - _w1);
                     _w2 -= 0.3 * (1 - _w2);
                     _w4 -= 0.3 * (1 - _w4);
                     _x1 -= 0.3 * (1 - _x1);
                     _x2 -= 0.3 * (1 - _x2);
                     _x4 -= 0.3 * (1 - _x4);*/
                }
                else
                {
                    pictureBox1.Image = Resources.maxresdefault;
                }
                //textBox1.Text = Math.Round(result, 1) + Resources.Form1_button1_Click__;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _counter1 += 1;
            if (_out > 0.5)
            {
                _w1 += 0.3 * (1 - _w1);
                _x1 += 0.3 * (1 - _x1);
                _w2 += 0.3 * (1 - _w2);
                _x2 += 0.3 * (1 - _x2);
                _w3 += 0.3 * (1 - _w3);
                _x3 += 0.3 * (1 - _x3);
                _w4 += 0.3 * (1 - _w4);
                _x4 += 0.3 * (1 - _x4);
            }
            else
            {
                _w1 -= 0.3 * (1 - _w1);
                _x1 -= 0.3 * (1 - _x1);
                _w2 -= 0.3 * (1 - _w2);
                _x2 -= 0.3 * (1 - _x2);
                _w3 -= 0.3 * (1 - _w3);
                _x3 -= 0.3 * (1 - _x3);
                _w4 -= 0.3 * (1 - _w4);
                _x4 -= 0.3 * (1 - _x4);
            }
            textBox3.Text = _w1.ToString(CultureInfo.InvariantCulture);
            textBox4.Text = _w2.ToString(CultureInfo.InvariantCulture);
            textBox5.Text = _w3.ToString(CultureInfo.InvariantCulture);
            textBox6.Text = _w4.ToString(CultureInfo.InvariantCulture);
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Form1_aboutToolStripMenuItem_Click_,
                Resources.Form1_aboutToolStripMenuItem_Click_About, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}