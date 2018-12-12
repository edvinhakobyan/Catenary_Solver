using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cable
{
    public partial class Form1 : Form
    {
        List<CheckBox> chck;
        Catenary_Graph graph;
        public Form1()
        {
            InitializeComponent();
            chck = new List<CheckBox>()
            {
                checkBox_S,
                checkBox_Y,
                checkBox_H,
                checkBox_X,
                checkBox_T
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double r = 10;
            double s;
            double y;
            double h;
            double x;
            double w;
            double c;
            double T0;
            double Ty;
            double T;
            double alfa;



            if (!double.TryParse(textBox_W.Text, out w))
            {
                MessageBox.Show("Invalid Value");
                return;
            }

            if(checkBox_S.Checked && checkBox_X.Checked)
            {
                if (!double.TryParse(textBox_S.Text, out s) || !double.TryParse(textBox_X.Text, out x))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }

                c = Newton_Raphson.NewtonRaphsonSX(s, x, r);
                y = Math.Sqrt(s * s + c * c);
                h = y - c;
                T0 = w * c;
                T = w * y;
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;

                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"y := {y:#.####}";
                textBox3.Text = $"h := {h:#.####}";
                textBox4.Text = $"T0 := {T0:#.####}";
                textBox5.Text = $"Ty := {Ty:#.####}";
                textBox6.Text = $"T := {T:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";

            }
            else if (checkBox_H.Checked && checkBox_X.Checked)
            {
                if (!double.TryParse(textBox_H.Text, out h) || !double.TryParse(textBox_X.Text, out x))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }

                c = Newton_Raphson.NewtonRaphsonHX(h, x, r);
                y = h + c;
                s  = Math.Sqrt(y * y - c * c);
                T0 = w * c;
                T = w * y;
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;

                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"y := {y:#.####}";
                textBox3.Text = $"s := {s:#.####}";
                textBox4.Text = $"T0 := {T0:#.####}";
                textBox5.Text = $"Ty := {Ty:#.####}";
                textBox6.Text = $"T := {T:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";

                graph = new Catenary_Graph(c, x);
                graph.Show();
            }
            else if(checkBox_Y.Checked && checkBox_X.Checked)
            {
                if (!double.TryParse(textBox_Y.Text, out y) || !double.TryParse(textBox_X.Text, out x))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }

                c = Newton_Raphson.NewtonRaphsonYX(y, x, r);
                h = y - c;
                s = Math.Sqrt(y * y - c * c);
                T0 = w * c;
                T = w * y;
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;

                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"h := {h:#.####}";
                textBox3.Text = $"s := {s:#.####}";
                textBox4.Text = $"T0 := {T0:#.####}";
                textBox5.Text = $"Ty := {Ty:#.####}";
                textBox6.Text = $"T := {T:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";
            }
            else if (checkBox_H.Checked && checkBox_S.Checked)
            {

                if (!double.TryParse(textBox_H.Text, out h) || !double.TryParse(textBox_S.Text, out s))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }
                c = (s * s - h * h) / (2 * h);
                y = h + c;
                x = c * Math.Log(s / c + Math.Sqrt(Math.Pow(s / c, 2) + 1));
                T0 = w * c;
                T = w * y;
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;


                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"y := {y:#.####}";
                textBox3.Text = $"x := {x:#.####}";
                textBox4.Text = $"T0 := {T0:#.####}";
                textBox5.Text = $"Ty := {Ty:#.####}";
                textBox6.Text = $"T := {T:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";

            }
            else if(checkBox_H.Checked && checkBox_T.Checked)
            {
                if (!double.TryParse(textBox_H.Text, out h) || !double.TryParse(textBox_T.Text, out T))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }

                T0 = T - w * h;
                c = T0 / h;
                y = h + c;
                s = Math.Sqrt(y * y - c * c);
                x = x = c * Math.Log(y / c + Math.Sqrt(y / c + 1) * Math.Sqrt(y / c - 1));
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;

                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"y := {y:#.####}";
                textBox3.Text = $"x := {x:#.####}";
                textBox4.Text = $"s := {s:#.####}";
                textBox5.Text = $"T0 := {T0:#.####}";
                textBox6.Text = $"Ty := {Ty:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";
            }
            else if(checkBox_S.Checked && checkBox_T.Checked)
            {
                if (!double.TryParse(textBox_S.Text, out s) || !double.TryParse(textBox_T.Text, out T))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }

                c = Math.Sqrt(T * T / (w * w) - s * s);
                y = T / w;
                x = x = c * Math.Log(y / c + Math.Sqrt(y / c + 1) * Math.Sqrt(y / c - 1));
                h = y - c;
                T0 = T - w * h;
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;

                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"y := {y:#.####}";
                textBox3.Text = $"x := {x:#.####}";
                textBox4.Text = $"h := {h:#.####}";
                textBox5.Text = $"T0 := {T0:#.####}";
                textBox6.Text = $"Ty := {Ty:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";
            }
            else if(checkBox_X.Checked && checkBox_T.Checked)
            {
                if (!double.TryParse(textBox_X.Text, out x) || !double.TryParse(textBox_T.Text, out T))
                {
                    MessageBox.Show("Invalid Value");
                    return;
                }
                y = T / w;
                c = Newton_Raphson.NewtonRaphsonTX(y, x, r);
                s = Math.Sqrt(y * y - c * c);
                h = y - c;
                T0 = T - w * h;
                Ty = Math.Sqrt(T * T - T0 * T0);
                alfa = 180.0 * Math.Asin(Ty / T) / Math.PI;

                textBox1.Text = $"c := {c:#.####}";
                textBox2.Text = $"y := {y:#.####}";
                textBox3.Text = $"s := {s:#.####}";
                textBox4.Text = $"h := {h:#.####}";
                textBox5.Text = $"T0 := {T0:#.####}";
                textBox6.Text = $"Ty := {Ty:#.####}";
                textBox7.Text = $"alfa := {alfa:#.####}";

                graph = new Catenary_Graph(c, x);
                graph.Show();
            }




            



        }



        private void checkBox_S_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_S.Checked)
            {
                checkBox_S.Enabled = false;
                checkBox_Y.Enabled = false;
                textBox_S.Enabled = true;
            }
            disableAll();

        }

        private void checkBox_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Y.Checked)
            {
                checkBox_Y.Enabled = false;
                checkBox_S.Enabled = false;
                checkBox_H.Enabled = false;
                checkBox_T.Enabled = false;
                textBox_Y.Enabled = true;
            }
            disableAll();

        }

        private void checkBox_H_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_H.Checked)
            {
                checkBox_H.Enabled = false;
                checkBox_Y.Enabled = false;
                textBox_H.Enabled = true;
            }
            disableAll();

        }

        private void checkBox_X_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_X.Checked)
            {
                checkBox_X.Enabled = false;
                textBox_X.Enabled = true;
            }
            disableAll();

        }
        private void checkBox_T_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T.Checked)
            {
                checkBox_Y.Enabled = false;
                textBox_T.Enabled = true;
            }
            disableAll();
        }

        private void disableAll()
        {
            int count = 0;
            for (int i = 0; i < chck.Count; i++)
                count = chck[i].Checked ? ++count : count;

            if (count == 2)
            {
                for (int i = 0; i < chck.Count; i++)
                    chck[i].Enabled = false;
                if (checkBox_X.Checked && checkBox_Y.Checked)
                    MessageBox.Show("You need to carefully select the coordinate (X;Y).\nIt can not be on the catenary.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chck.Count; i++)
            {
                chck[i].Checked = false;
                chck[i].Enabled = true;
            }

            textBox_S.Clear();
            textBox_Y.Clear();
            textBox_H.Clear();
            textBox_X.Clear();
            textBox_S.Enabled = false;
            textBox_Y.Enabled = false;
            textBox_H.Enabled = false;
            textBox_X.Enabled = false;
        }


    }
}
