using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.ComponentModel;
using System.IO;
using Microsoft.VisualBasic;
using System.Security.Permissions;

namespace Saper
{
    public partial class Vhod : Form
    {
        //SoundPlayer player = new SoundPlayer("synthwave_bomber.wav");
        //string global="", g="";
            SoundPlayer player = new SoundPlayer("synthwave_bomber.wav");
        int k = 3;
        public Vhod()
        {
            




            InitializeComponent();
            
            /*int k ;
            if (Program.global == "")
            {
                k = 3;
                while (k!=0)
                {
                    StreamReader Fil = new StreamReader("Key.txt");
                    string ok = Fil.ReadLine();
                    Fil.Close();
                    string rez;

                    rez = Interaction.InputBox("Введите ключ активации\nОсталость попыток " + k, "Ввод ключа ктивации");
                    
                    Program.global = rez;
                    Program.g = ok;

                    if (rez == ok) { k = 4;MessageBox.Show("Вы ввели верный ключ активации, вы можете играть"); goto L1; }

                    if (rez != ok)
                    {
                        k--;
                        if (k == 0)
                        {
                            MessageBox.Show("Попытки закончились, вы не можете играть");
                            Application.Exit();

                        }
                        this.button1.Enabled = false;
                        //this.button2.Enabled = false;
                        // x3
                    }
                    else { if (rez != ok) { this.button1.Enabled = true; } }
                    
            
                }
            L1:
                ;
            }
            */






        }

        private void Vhod_Load(object sender, EventArgs e)
        {
            this.button3.Text = ("Ввести ключ активации, Осталось попыток: " + k);
            //this.button3.Text = "Ввести ключ активации";

            this.button4.Enabled = false;
            if (Program.global == "")
            {
                this.button1.Enabled = false;
                
                //this.button3.Text = ("Ввести ключ активации, Осталось попыток: " + k);

            }
                //this.button1.Enabled = true;
                //this.button2.Enabled = true;
                //bool n;
                //if (File.Exists("Key.txt"))
                //{ }



                //if (File.Exists("Key.txt"))
                //{


            L1:
                //}
                //if rez ==
                //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            FormWindowState form = new FormWindowState();
            form = FormWindowState.Maximized;
            this.WindowState = form;
            this.label1.Location = new Point(0,0) ;
            this.button1.Location = new Point(0, 103);
            this.button2.Location = new Point(0, 183);
            this.button3.Location = new Point(0, 253);
       

           // bool b;
           // if (Exists("Key.txt"))
            //{ b=false}

           /* string Str="";
            if (Exists("Key.txt"))                                  //Exists("Key.txt"))
                
            
            {
                StreamReader reader = new StreamReader("Key.txt"); 
                string str = reader.ReadLine();
                Str = str;
                reader.Close();
            }
            if (Str == "12345")
            { this.button1.Enabled = true; }
            else { MessageBox.Show("Вы ввели неправильный пароль");
                this.button1.Enabled = false;
            }*/




            player.Load();
            player.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Form1 fi = new Form1();
            this.Hide();
            fi.Show();
            
            player.Stop();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            StreamReader Fil = new StreamReader("Key.txt");
            string ok = Fil.ReadLine();
            Fil.Close();
            string rez;
           // this.button3.Text = ("Ввести ключ активации, Осталось попыток: " + k);

            if (k<1)
            {
                MessageBox.Show("Попытки закончились\nИгра будет закрыта"); this.Close();

            }
              

            rez = Interaction.InputBox("Введите ключ активации\nОсталость попыток " + k, "Ввод ключа ктивации");
            Program.global = rez;
            Program.g = ok;
            if (Program.global == ok)
            {
                MessageBox.Show("Вы ввели верный ключ активации, вы можете играть"); this.button1.Enabled = true;
                this.button3.Enabled = false;
                this.button4.Enabled = true;
                k = 3;
            }
            //if (rez != ok)
            else
            {
                MessageBox.Show("Вы ввели неверный ключ активации, вы не можете играть");



                this.button1.Enabled = false;
                //this.button2.Enabled = false;
                // x3
            }
            
            k--;
            this.button3.Text = ("Ввести ключ активации, Осталось попыток: " + k);














            // if (rez != ok)











            //else { this.button1.Enabled = true;
            // }




















            /*StreamReader Fil = new StreamReader("Key.txt");
            string ok = Fil.ReadLine();
            Fil.Close();
            string rez;
            rez = Interaction.InputBox("Введите ключ активации", "Ввод ключа ктивации");
            if (rez != ok)
            {
                this.button1.Enabled = false;
                
                // x3
            }
            else { this.button1.Enabled = true; }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.global = "";
            string rez = Interaction.InputBox("Введите новый ключ активации", "Ввод нового ключа ктивации");
            if (rez=="")
            {
                rez = null;
                MessageBox.Show("Ключ не должен быть пустым");
                rez = Interaction.InputBox("Введите новый ключ активации", "Ввод нового ключа ктивации"); //return;
                this.button4.Enabled = true;
            }
            if(rez!="")
             { this.button3.Text = "Подтвердите новый ключ";
                StreamWriter Fil = new StreamWriter("Key.txt");
                Fil.WriteLine(rez);
                Fil.Close();
                this.button3.Enabled = true;
                this.button4.Enabled = false;
            }
            
           
            
           
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //StreamWriter Fil = new StreamWriter("key.txt");
        //Fil.
        //}
    }
}
