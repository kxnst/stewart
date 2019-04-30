using System;
using System.Windows.Forms;
//&& b+p>y && b+y>p && y+p>b && p+c>x && c+x>p && p+x>c && b+c>a && c+b>a && c+a>b
namespace stewartMAH
{
    public partial class Form1 : Form
    {
        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Створено учнем 41 групи БНВО\"Ліцей - МАН\"\nСтадником Костянтином Петровичем\n Учасником третьго етапу конкурсу - захисту наукових робіт МАН\n Відділення: математика\nСекція: математика ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            istriangle = !istriangle;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public double a, b, c,  x, y, am, bm, cm, xm, ym;
        double p;
        double an; double bn; double cn; double ann; double bnn; double cnn; bool istriangle;
        bool LastCheck(double n)
        {
            if (Math.Sqrt(n) == Math.Round(Math.Sqrt(n)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            istriangle = false;
        }
        public void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Інструкція_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Введіть межі для a, b, c\r\n2. Натисніть \"Знайти корені\"\r\n");
        }

        public void Stewart(double ak, double bk, double ck, double akk, double bkk, double ckk)
        {
            for(a = ak; a <= akk; a++)
            {
                for(c = ck; c<=ckk; c++)
                {
                    for(y =3; y<=50; y++)
                    {
                        for(b = bk; b<bkk; b++)
                        {
                            for(x = 3; x<50; x++)
                            {
                                
                                p = ((b * b * x) / a + (c * c * y) / a) - (x * y);
                              
                                if (p % 1 != 0 )
                                {
                                    continue;
                                }
                                
                                if((b*b*x + c * c * y) / a % 1 != 0)
                                {
                                    continue;
                                }
                                else if (Math.Sqrt(p)!=-1 && Math.Sqrt(p)%1==0 )
                                {
                                   textBox7.Text=textBox7.Text + $"a = {a}, b = {b}, c = {c}, x = {x}, y = {y}, p = {Math.Sqrt(p)}" + "\r\n\r\n";
                                }
                                else
                                {
                                    continue;
                                }                   
                            }
                        }
                    }
                }
            }
        }
        public void StewartTriangle(double ak, double bk, double ck, double akk, double bkk, double ckk)
        {
            for (a = ak; a <= akk; a++)
            {
                for (c = ck; c <= ckk; c++)
                {
                    for (y = 3; y <= 50; y++)
                    {
                        for (b = bk; b < bkk; b++)
                        {
                            for (x = 3; x < 50; x++)
                            {

                                p = ((b * b * x) / a + (c * c * y) / a) - (x * y);

                                if (p % 1 != 0)
                                {
                                    continue;
                                }
                               
                                if ((b * b * x + c * c * y) / a % 1 != 0)
                                {
                                    continue;
                                }
                                else if (Math.Sqrt(p) != -1 && Math.Sqrt(p) % 1 == 0 && b + p > y && b + y > p && y + p > b && p + c > x && c + x > p && p + x > c && b + c > a && c + b > a && c + a > b && x + y == c )
                                {

                                    textBox7.Text = textBox7.Text + $"a = {a}, b = {b}, c = {c}, x = {x}, y = {y}, p = {Math.Sqrt(p)}" + "\r\n\r\n";

                                }
                                else
                                {
                                    continue;
                                }


                            }
                        }
                    }
                }
            }
        }

        public void IsEmpty()
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "3";
            }
            if (textBox3.Text=="")
            {
                textBox3.Text = "6";
            }
            if (textBox2.Text=="")
            {
                textBox2.Text = "3";
            }
            if (textBox4.Text=="")
            {
                textBox4.Text = "6";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "3";
            }
            if (textBox5.Text=="")
            {
                textBox5.Text = "6";
            }
        }

        
        public int IsSquare(double k)
        {
            if (k < 0)
            {
                return -1;
            }
            if (Math.Sqrt(k)%1==0 && Math.Round(k)==k && k%1==0)
            {
                return Convert.ToInt32(Math.Sqrt(k));
            }
            else
            {
                return -1;
            }
        }
        public void Checkerror()
        {
            if(textBox1.Text == null||textBox1.Text=="")
            {
                textBox7.Text = ("error");
            }
            textBox7.Text += ($"{textBox1.Text}, {textBox3.Text}, {textBox2.Text}, {textBox4.Text}, {textBox6.Text}, {textBox5.Text}");
        }
        public void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = null;
            IsEmpty();
          //  Checkerror();
            an = Convert.ToDouble(textBox1.Text);
            bnn = Convert.ToDouble(textBox4.Text);
            bn = Convert.ToDouble(textBox2.Text);
            ann = Convert.ToDouble(textBox3.Text);
            cnn = Convert.ToDouble(textBox5.Text);
            cn = Convert.ToDouble(textBox6.Text);
            if (istriangle)
                StewartTriangle(an, bn, cn, ann, bnn, cnn);
            else if (!istriangle)
                Stewart(an, bn, cn, ann, bnn, cnn);
           
        }   
    }
}
