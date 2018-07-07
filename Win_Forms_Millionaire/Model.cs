using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Win_Forms_Millionaire
{
    class Model
    {
        List<Questions> quest = new List<Questions>();
        List<int> number = new List<int>();
        public int[] money = new int[] { 0, 100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000,
        32000, 64000, 125000, 250000, 500000, 1000000};
        public Questions Current_question;

        public bool a_right;
        public bool b_right;
        public bool c_right;
        public bool d_right;

        public void Load_Questions()
        {
            int question_count = 0;
            int inc_answer_count = 0;
            int rght_answer_count = 0;
            try
            {
                OdbcConnection connection = new OdbcConnection(@"Driver={SQL Server};Server=220-4P;Trusted_Connection=Yes;Database=_Million_;");
                connection.Open();

                OdbcCommand command = new OdbcCommand();

                command.Connection = connection;

                command.CommandText = "select count(*) from Question";

                int res = (int)command.ExecuteScalar();
                while (question_count != res)
                {
                    command.CommandText = "select * from Question";
                    OdbcDataReader reader = command.ExecuteReader();
                    
                    Questions a = new Questions();
                    a.question = 
                    a.right_answer = 
                    a.incorrect_answer1 = 
                    a.incorrect_answer2 = 
                    a.incorrect_answer3 = 
                    quest.Add(a);
                }
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // StreamReader sr = new StreamReader("../../Q/question.txt", Encoding.Unicode);

            //while (!sr.EndOfStream)
            //{
            //    Questions a = new Questions();
            //    a.question = sr.ReadLine();
            //    a.right_answer = sr.ReadLine();
            //    a.incorrect_answer1 = sr.ReadLine();
            //    a.incorrect_answer2 = sr.ReadLine();
            //    a.incorrect_answer3 = sr.ReadLine();
            //    quest.Add(a);
            //}
        }
        public Questions Return_Rand_Question()
        {
            Random r = new Random();
            return quest[r.Next(0, quest.Count)];
        }

        public Images Load_Images()
        {
            Images all_im = new Images();
            all_im.call_enabled = Image.FromFile(@"../../phone.jpg", false);
            all_im.call_disabled = Image.FromFile(@"../../phone_disable.jpg", false);
            all_im.fifty_fifty_endbled = Image.FromFile(@"../../50-50-icon.jpg", false);
            all_im.fifty_fifty_disabled = Image.FromFile(@"../../disable5050.jpg", false);
            all_im.people_help_enabled = Image.FromFile(@"../../people_help_enb.png", false);
            all_im.people_help_disabled = Image.FromFile(@"../../Help_disable.jpg", false);
            all_im.person = Image.FromFile(@"../../person.jpg", false);
            return all_im;
        }

        public void new_game_pressed()
        {
            Load_Questions();
        }

        public void Win()
        {

        }
        public Friend Call_Friend()
        {
            Friend fr = new Friend();
            Random r = new Random();
            fr.ico = Image.FromFile(@"../../friend.jpg", false);
            switch (r.Next(0, 1))
            {
                case 0:
                    if (a_right == true)
                        fr.answer = "Друг: Это легко, ответ А!";
                    else if (b_right == true)
                        fr.answer = "Друг: Легкотня, ответ B";
                    else if (c_right == true || d_right == true)
                        fr.answer = "Друг: Я не уверен, но кажется ответ D";
                    break;
                case 1:
                    fr.answer = "Эм....хм....ну.....я не знаю";
                    break;
            }
            return fr;
        }

        public string People_Help()
        {
            int a = 0, b = 0, c = 0, d = 0;
            Random r = new Random();
            for (int i = 1; i != 100; i++)
            {
                switch (r.Next(1, 5))
                {
                    case 1:
                        a++;
                        break;
                    case 2:
                        b++;
                        break;
                    case 3:
                        c++;
                        break;
                    case 4:
                        d++;
                        break;
                }
            }
            string s = "A: " + a.ToString() + "% B: " + b.ToString() + "% C: " + c.ToString() + "% D: " + d.ToString() + "%";
            return s;
        }

        public int Fifty_Help()
        {
            int n = 0;
            if (a_right == true)
                n = 1;
            else if (b_right == true)
                n = 2;
            else if (c_right == true)
                n = 3;
            else if (d_right == true)
                n = 4;
            int n2 = 0;
            do
            {
                Random r = new Random();
                n2 = r.Next(1, 5);
            } while (n2 == n);
            return n2;
        }
    }
}
