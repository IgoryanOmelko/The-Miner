using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using System.ComponentModel;
namespace Saper
{
    public partial class Form1 : Form

    {
        //Button button = new Button();
        int RazmerW;
        int RazmerH;
        int XB;
        int YB;
        int N=0, O=0,I=0;
        //Button button = new Button();
        double R;

        Random rand = new Random();
        
        SoundPlayer player = new SoundPlayer("mine_detected2.wav");
        SoundPlayer playerdet = new SoundPlayer("detonation.wav");
        SoundPlayer playerfon = new SoundPlayer("fon.wav");
        string S,S1;


        

        public Form1()
        {

            Size size = SystemInformation.PrimaryMonitorSize;


            //playerfon.Load();
            //playerfon.PlayLooping();


           






            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerfon.Load();
            playerfon.PlayLooping();



            //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            FormWindowState form = new FormWindowState();
            form = FormWindowState.Maximized;
            this.WindowState = form;






            
            





            







            //this.panel1.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.panel1.Width), 0);





            //изменение размеров элементов под размеры иэкрана
            this.panel1.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 5, Screen.PrimaryScreen.WorkingArea.Height);
            this.buttonGlavEc.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 5, Screen.PrimaryScreen.WorkingArea.Height / 20);



            // if(button.)

            //button.Click += ButtonOnClick;



            this.textBoxX.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 5, Screen.PrimaryScreen.WorkingArea.Height / 20);




            
















                //положение формы не заходя за границы экрана (на всякий случай)
                /*Size size = SystemInformation.PrimaryMonitorSize;
                if (this.Location.X < 0)
                {
                    this.Location = new Point(0, this.Location.Y);
                }

                if (this.Location.Y < 0)
                {
                    this.Location = new Point(this.Location.X, 0);
                }

                if (this.Location.X + this.Width > size.Width)
                {
                    this.Location = new Point(size.Width - this.Width, this.Location.Y);
                }

                if (this.Location.Y + this.Height > size.Height)
                {
                    this.Location = new Point(this.Location.X, size.Height - this.Height);
                */
            
        }

        

        private void buttonGlavEc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int n = (int)this.numericUpDown1.Value;
            N = n;
            //мина кнопка
            Random rand = new Random();
            this.button.Size = new Size(50, 50) ;
            int xw = rand.Next(0, this.Width - this.Width / 5);
            int yh = rand.Next(0, this.Height);
            this.button.Left = xw - this.button.Width;
            //int xw = rand.Next(0, this.Width - this.Width / 5);
            //int yh = rand.Next(0, this.Height);
            playerfon.Load();
            playerfon.PlayLooping();





            button.Top = yh - button.Height;
            //button.Name = "mine";
            //button.Visible = false;
            Bitmap bit = new Bitmap("mines_PNG18.png");
            button.BackgroundImage = bit;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.BackColor = Color.Maroon;
            button.FlatStyle = FlatStyle.Flat;
            //button.BackColor = System.Drawing.Color.Transparent;
            if ((button.Location.X + button.Width) > (Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Width / 5))
            {
                button.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Width / 5) - button.Width, button.Location.Y);
            }
            if ((button.Location.Y + button.Height) > (Screen.PrimaryScreen.WorkingArea.Height - button.Height))
            {
                button.Location = new Point((Screen.PrimaryScreen.WorkingArea.Height - button.Height) - button.Height, button.Location.X);
            }
            if (button.Location.X < 0)
            {
                button.Location = new Point(0, button.Location.Y);
            }
            if (button.Location.Y < 0)
            {
                button.Location = new Point(button.Location.X, 0);
            }

            //this.Controls.Add(button);


            //int xw = rand.Next(0, Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Width / 5);
            //int yh = rand.Next(0, Screen.PrimaryScreen.WorkingArea.Height);
            //top += button.Height + 2;
            // }

            int razmerW = this.button.Width / 2;
            int razmerH = this.button.Height / 2;
            int Xb = this.button.Location.X + razmerW;
            int Yb = this.button.Location.Y + razmerH;
            XB = Xb;
            YB = Yb;
            RazmerH = razmerH;
            RazmerW = razmerW;
        }

        private void buttonVih_Click(object sender, EventArgs e)
        {
            Vhod fv = new Vhod();
            fv.Show();
            this.Close();

        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Vhod fv = new Vhod();
            fv.Show();
            this.Close();

        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            //this.textBoxX.Text = "X: " + e.X + " Y: " + e.Y;
            //double rasst = Math.Round(Math.Sqrt(Math.Pow(XB - e.X, 2) + Math.Pow(YB - e.Y, 2)), 0);
            if ((e.X == button.Width / 2) || (e.Y == button.Height / 2))
            {
                Bitmap biet = new Bitmap("888661d64f8155bc81443d54bd5c20a4.gif");
                button.Image = biet;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                playerdet.Load();
                playerdet.Play();
                MessageBox.Show("Игра окончена\nВы мертвы");
                //button.Visible = false;
                Vhod fv = new Vhod();
                fv.Show();
                this.Close();

                //playerdet.Load();
                // playerdet.Play();
                //MessageBox.Show("Игра окончена\nВы мертвы");
                //this.Close();
            }

                double rasst = Math.Round(Math.Sqrt(Math.Pow(XB - e.X, 2) + Math.Pow(YB - e.Y, 2)), 0);

            if (rasst <= RazmerW / 5)
                {
                    Bitmap bit = new Bitmap("888661d64f8155bc81443d54bd5c20a4.gif");
                    button.Image = bit;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    playerdet.Load();
                    playerdet.Play();
                    MessageBox.Show("Игра окончена\nВы мертвы");
                    button.Visible = false;
                    this.Close();
                    return;

                }


            
        }

        

        private void button_Click_1(object sender, EventArgs e)
        {
            int a, b, t, d, f;
            //Random kod = new Random();
            //a// = kod.Next(0, 2);
            //b = kod.Next(0, 2);
            //t = kod.Next(0, 10);
            //d = kod.Next(0, 10);
            //f = kod.Next(0, 10);
            // string s = Convert.ToString(a);
            //string s1 = Convert.ToString(b);
            // S = s;
            //S1 = s1;

            //MessageBox.Show(s);
           // while (this.button.Width > 10 && this.button.Height > 10)
            ////    this.button.Width -= 10; this.button.Height -= 10;
          //  int w = this.button.Width; int h = this.Height;
           // { this.button.Size = new Size(); }
            this.button.Visible = false;
                int xw = rand.Next(0, this.Width -this.Width / 5);
                int yh = rand.Next(0, this.Height);
            this.button.Left = xw - this.button.Width;
            this.button.Top = yh - this.button.Height;
                Bitmap bit = new Bitmap("mines_PNG18.png");
                if ((button.Location.X + button.Width) > (this.Width - this.Width / 5))
                {
                    button.Location = new Point((this.Width - this.Width / 5) - button.Width, button.Location.Y);
                }
                if ((button.Location.Y + button.Height) > (this.Height))
                {
                    button.Location = new Point((this.Height - button.Height), button.Location.X);
                }
                if (button.Location.X < 0)
                {
                    button.Location = new Point(0, button.Location.Y);
                }
                if (button.Location.Y < 0)
                {
                    button.Location = new Point(button.Location.X, 0);
                }

            

                
                
                
           

            O++;
            int c = N - O;
            this.textBoxNO.Text = ("Найдено мин: "+O+" Осталось мин:"+c);
            //MessageBox.Show("N " + N + " O " + O);
            //MessageBox.Show("Введите код деактивации мины");
            //this.textBox1.Focus();
            //this.textBox1.Text = ("S: " + S + " S1: " + S1);
            //this.button.Width = this.button.Width - 10;
            //button.Height = button.Height - 10;

            //this.button.Size = new Size(this.button.Width--, this.button.Height--);
            //this.button.Width -= 10;
            //this.button.Height -= 10;
            
            
            int razmerW = this.button.Width / 2;
            int razmerH = this.button.Height / 2;
            int Xb = this.button.Location.X + razmerW;
            int Yb = this.button.Location.Y + razmerH;
            XB = Xb;
            YB = Yb;

            RazmerH = razmerH;
            RazmerW = razmerW;
            playerfon.Load();
            playerfon.PlayLooping();

            if (O == N)
            {
                MessageBox.Show("ПОБЕДА\nВы выиграли");
                Vhod fv = new Vhod();
                fv.Show();
                this.Close();
            }

            /*if (S != S1)
            {
                Bitmap biet = new Bitmap("888661d64f8155bc81443d54bd5c20a4.gif");
                button.Image = biet;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                playerdet.Load();
                playerdet.Play();
                MessageBox.Show("Игра окончена\nВы мертвы");
                //button.Visible = false;
                Vhod fv = new Vhod();
                fv.Show();
                this.Close();
            }
            */


            
            
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)

        {


            double rasst = Math.Round(Math.Sqrt(Math.Pow(XB - e.X, 2) + Math.Pow(YB - e.Y, 2)), 0);
            R = rasst;
            if (rasst < RazmerW)
            {
                button.Visible = true;
                this.textBoxrasst.Text = "МИНА!";
            }
            else { button.Visible = false; }
            /*if(rasst>= RazmerW)
            {
                button.Visible = false;
            }*/


            



















            ////
            ///
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// button.Name = "Bliz";
            //button.Visible = true;
            this.textBoxX.Text = "X: " + e.X + " Y: " + e.Y;
            this.textBoxrasst.Text = "Расстояние до мины: " + rasst;
            if (rasst < RazmerW)
            {
                
                this.textBoxrasst.Text = "МИНА!";

                playerfon.Stop();
                 player.Load();
               player.Play();
                
                


                
                

            }
            if(rasst<RazmerW/10)
            {
                Bitmap bit = new Bitmap("888661d64f8155bc81443d54bd5c20a4.gif");
                button.Image = bit;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                playerdet.Load();
                playerdet.Play();
                MessageBox.Show("Игра окончена\nВы мертвы");
                button.Visible = false;
                this.Close();
            return;
            }
        
        
        }

        
        



        /*private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обезвредить мину");
            button.Visible = false;
            MessageBox.Show("Мина обезврежена");
        }
        */


















    }


   















        /*private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/






        //блок содания и управления минами


        /* int n = 0;
         while (n < 10)
         {
             Button btn = new Button();

             btn.Name = "min" + n;

             btn.Size = new Size(50, 50);
             Random rand = new Random();
             int xw = rand.Next(0, Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Width / 5-btn.Width);
             int yh = rand.Next(0, Screen.PrimaryScreen.WorkingArea.Height - btn.Height);
             btn.Location = new Point(xw, yh);
             if ((btn.Location.X + btn.Width) > (Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Width / 5))
             {
                 btn.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Width / 5) - btn.Width);
             }
             if ((btn.Location.Y + btn.Height) > (Screen.PrimaryScreen.WorkingArea.Height - btn.Height))
             {
                 btn.Location = new Point((Screen.PrimaryScreen.WorkingArea.Height - btn.Height) - btn.Height);
             }
             //if(btn)
             btn.BackColor = Color.Black;
             btn.Visible = true;
             btn.DialogResult = DialogResult.OK;

         // Add the button to the form.
         this.Controls.Add(btn);

         n++;
        */

    
}
