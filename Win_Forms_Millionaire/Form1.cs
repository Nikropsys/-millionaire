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
using System.Threading;
using System.Data.SqlClient;


namespace Win_Forms_Millionaire
{
    public delegate void MyDel();

    interface Form_Interface
    {
        void Win_Game();
        void Show();
        int New_Question(Questions a);
        void Freind_Answer(Friend f);
        void Set_Images(Images im);
        void Fifty_Fifty_Show(int n, int n2);

        void A_Right(bool win);
        void B_Right(bool win);
        void C_Right(bool win);
        void D_Right(bool win);

        string Get_A_Text
        { get; }
        string Get_B_Text
        { get; }
        string Get_C_Text
        { get; }
        string Get_D_Text
        { get; }

        string Money_Current
        { set; }
        string Money_Next
        { set; }

        string Dialog_Set
        { set;}

        event MyDel b_a;
        event MyDel b_b;
        event MyDel b_c;
        event MyDel b_d;
        event MyDel new_game;
        event MyDel right_answer;
        event MyDel Call_friend;
        event MyDel People_Help;
        event MyDel fifty_fifty;
    }
    
    public partial class Form1 : Form, Form_Interface
    {
       public Images all_images;

        public event MyDel b_a;
        public event MyDel b_b;
        public event MyDel b_c;
        public event MyDel b_d;
        public event MyDel new_game;
        public event MyDel right_answer;
        public event MyDel Call_friend;
        public event MyDel People_Help;
        public event MyDel fifty_fifty;

        public Form1()
        {
            InitializeComponent();
        }

       public void Set_Images(Images i)
        {
            all_images = i;
        }

        public void A_Right(bool win)
        {
            answer_b1.BackColor = Color.Green;
            answer_b2.BackColor = Color.Red;
            answer_b3.BackColor = Color.Red;
            answer_b4.BackColor = Color.Red;
            if (win == true)
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/true.wav");
                sndPlayer.Play();
            }
            else
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/false.wav");
                sndPlayer.Play();
                answer_b1.Enabled = false;
                answer_b2.Enabled = false;
                answer_b3.Enabled = false;
                answer_b4.Enabled = false;
                b_start.Visible = true;
            }
        }

        public void B_Right(bool win)
        {
            answer_b1.BackColor = Color.Red;
            answer_b2.BackColor = Color.Green;
            answer_b3.BackColor = Color.Red;
            answer_b4.BackColor = Color.Red;
            if (win == true)
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/true.wav");
                sndPlayer.Play();
            }
            else
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/false.wav");
                sndPlayer.Play();
                answer_b1.Enabled = false;
                answer_b2.Enabled = false;
                answer_b3.Enabled = false;
                answer_b4.Enabled = false;
                b_start.Visible = true;
            }
        }

        public void C_Right(bool win)
        {
            answer_b1.BackColor = Color.Red;
            answer_b2.BackColor = Color.Red;
            answer_b3.BackColor = Color.Green;
            answer_b4.BackColor = Color.Red;
            if (win == true)
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/true.wav");
                sndPlayer.Play();
            }
            else
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/false.wav");
                sndPlayer.Play();
                answer_b1.Enabled = false;
                answer_b2.Enabled = false;
                answer_b3.Enabled = false;
                answer_b4.Enabled = false;
                b_start.Visible = true;
            }
        }

        public void D_Right(bool win)
        {
            answer_b1.BackColor = Color.Red;
            answer_b2.BackColor = Color.Red;
            answer_b3.BackColor = Color.Red;
            answer_b4.BackColor = Color.Green;
            if (win == true)
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/true.wav");
                sndPlayer.Play();
            }
            else
            {
                SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/false.wav");
                sndPlayer.Play();
                answer_b1.Enabled = false;
                answer_b2.Enabled = false;
                answer_b3.Enabled = false;
                answer_b4.Enabled = false;
                b_start.Visible = true;
            }
        }

        public void Win_Game()
        {
            SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/begin.wav");
            sndPlayer.Play();
            answer_b1.Enabled = false;
            answer_b2.Enabled = false;
            answer_b3.Enabled = false;
            answer_b4.Enabled = false;

            b_start.Visible = true;
        }
        public void Show()
        { Application.Run(this);}

       public void A_Button_click(object sender, EventArgs e)
        {
            b_a();
        }

        public void B_Button_click(object sender, EventArgs e)
        {
            b_b();
        }

        public void C_Button_click(object sender, EventArgs e)
        {
            b_c();
        }

        public void D_Button_click(object sender, EventArgs e)
        {
            b_d();
        }

        public string Get_A_Text
        {get {return answer_b1.Text;}}

        public string Get_B_Text
        {get {return answer_b2.Text;}}

        public string Get_C_Text
        {get {return answer_b3.Text;}}

        public string Get_D_Text
        { get{return answer_b4.Text;}}

        public string Money_Current
        {set {textBox2.Text = value;}}

        public string Money_Next
        { set {textBox4.Text = value;}}

        public string Dialog_Set
        { set { Dialog.Text = value;}}

        public int New_Question(Questions a)
        {
            pictureBox1.BackgroundImage = all_images.person;

            answer_b1.BackColor = Color.Black;
            answer_b2.BackColor = Color.Black;
            answer_b3.BackColor = Color.Black;
            answer_b4.BackColor = Color.Black;

            answer_b1.Text = "A: ";
            answer_b2.Text = "B: ";
            answer_b3.Text = "C: ";
            answer_b4.Text = "D: ";

            question_b.Text = a.question;
            Random r = new Random();
            switch (r.Next(1, 4))
            {
                case 1:
                    answer_b1.Text += a.right_answer;
                    answer_b2.Text += a.incorrect_answer1;
                    answer_b3.Text += a.incorrect_answer2;
                    answer_b4.Text += a.incorrect_answer3;
                    return 1;
                case 2:
                    answer_b1.Text += a.incorrect_answer1;
                    answer_b2.Text += a.right_answer;
                    answer_b3.Text += a.incorrect_answer2;
                    answer_b4.Text += a.incorrect_answer3;
                    return 2;
                case 3:
                    answer_b1.Text += a.incorrect_answer3;
                    answer_b2.Text += a.incorrect_answer1;
                    answer_b3.Text += a.right_answer;
                    answer_b4.Text += a.incorrect_answer2;
                    return 3;
                case 4:
                    answer_b1.Text += a.incorrect_answer1;
                    answer_b2.Text += a.incorrect_answer2;
                    answer_b3.Text += a.incorrect_answer3;
                    answer_b4.Text += a.right_answer;
                    return 4;
                default:
                    return -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Call_Friend(object sender, EventArgs e)
        {
            Call_friend();
        }

        private void Fifty_Help(object sender, EventArgs e)
        {
            fifty_fifty();
        }

        public void Fifty_Fifty_Show(int n, int n2)
        {
            switch(n)
            {
                case 1:
                    answer_b1.BackColor = Color.Blue;
                    break;
                case 2:
                    answer_b2.BackColor = Color.Blue;
                    break;
                case 3:
                    answer_b3.BackColor = Color.Blue;
                    break;
                case 4:
                    answer_b4.BackColor = Color.Blue;
                    break;
            }
            switch(n2)
            {
                case 1:
                    answer_b1.BackColor = Color.Blue;
                    break;
                case 2:
                    answer_b2.BackColor = Color.Blue;
                    break;
                case 3:
                    answer_b3.BackColor = Color.Blue;
                    break;
                case 4:
                    answer_b4.BackColor = Color.Blue;
                    break;
            }
            b_50_50.BackgroundImage = all_images.fifty_fifty_disabled;
        }

        private void Help_People(object sender, EventArgs e)
        {
            People_Help();
            help_b.Enabled = false;
            help_b.BackgroundImage = all_images.people_help_disabled;
        }

        public void Freind_Answer(Friend f)
        {
            Dialog.Text = f.answer;
            pictureBox1.BackgroundImage = f.ico;
            call_friend_b.Enabled = false;
            call_friend_b.BackgroundImage = all_images.call_disabled;
        }

        private void New_Game_Button(object sender, EventArgs e)
        {
            answer_b1.Enabled = true;
            answer_b2.Enabled = true;
            answer_b3.Enabled = true;
            answer_b4.Enabled = true;

            call_friend_b.Enabled = true;
            help_b.Enabled = true;
            b_50_50.Enabled = true;

            call_friend_b.BackgroundImage = all_images.call_enabled;
            help_b.BackgroundImage = all_images.people_help_enabled;
            b_50_50.BackgroundImage = all_images.fifty_fifty_endbled;

            b_start.Visible = false;
            pictureBox1.Visible = true;
            Dialog.Visible = true;
            pictureBox1.BackgroundImage = all_images.person;
            Dialog.Text = "Ведущий: Добро пожаловать, в нашу игру, мы начинаем!";
            SoundPlayer sndPlayer = new SoundPlayer(/*@*/"../../sound/begin.wav");
            sndPlayer.Play();
            //Thread.Sleep(30000);
            new_game();
        }
    }
}
