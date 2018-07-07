using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Win_Forms_Millionaire
{
    class Presenter_Main
    {
        private Model model = new Model();
        private readonly Form_Interface form_main;
        static int prise_counter = -1;

        public Presenter_Main(Form_Interface f)
        {
            form_main = f;

            form_main.Set_Images(model.Load_Images());

            f.new_game += new MyDel(model.new_game_pressed);
            f.new_game += new MyDel(New_Question);
            f.b_a += new MyDel(A_Pressed);
            f.b_b += new MyDel(B_Pressed);
            f.b_c += new MyDel(C_Pressed);
            f.b_d += new MyDel(D_Pressed);
            f.Call_friend += new MyDel(Call_Friend);
            f.People_Help += new MyDel(People_Help);
            f.fifty_fifty += new MyDel(Fifty_fifty_Help);

            form_main.Show();
        }

        public void Fifty_fifty_Help()
        {
            int n = 0;
           int n2 = model.Fifty_Help();
            if (model.a_right == true)
                n = 1;
            else if (model.b_right == true)
                n = 2;
            else if (model.c_right == true)
                n = 3;
            else if (model.d_right == true)
                n = 4;
            form_main.Fifty_Fifty_Show(n, n2);
        }

        public void People_Help()
        {
           form_main.Dialog_Set =  model.People_Help();
        }

        public void Call_Friend()
        {
           form_main.Freind_Answer( model.Call_Friend());
        }

        public void New_Question()
        {
            model.Current_question = model.Return_Rand_Question();
            switch (form_main.New_Question(model.Current_question))
            {
                case 1:
                    model.a_right = true;
                    model.b_right = false;
                    model.c_right = false;
                    model.d_right = false;
                    break;
                case 2:
                    model.a_right = false;
                    model.b_right = true;
                    model.c_right = false;
                    model.d_right = false;
                    break;
                case 3:
                    model.a_right = false;
                    model.b_right = false;
                    model.c_right = true;
                    model.d_right = false;
                    break;
                case 4:
                    model.a_right = false;
                    model.b_right = false;
                    model.c_right = false;
                    model.d_right = true;
                    break;
            }
        }

        public void A_Pressed()
        {
            if (model.a_right == true)
            {
                form_main.Dialog_Set = "Ведущий: И это правильный ответ!";
                prise_counter++;
                form_main.Money_Current = model.money[prise_counter].ToString();
                if (model.money[prise_counter] != 1000000)
                {
                    form_main.Money_Next = model.money[prise_counter + 1].ToString();
                    form_main.A_Right(true);
                    Thread.Sleep(500);
                    form_main.Dialog_Set = "Ведущий: И так, Следующий вопрос!";
                    New_Question();
                }
                else
                {
                    form_main.Dialog_Set = "Ведущий: Поздравляю, вы выиграли миллион!";
                    prise_counter = 0;
                    form_main.Money_Current = model.money[prise_counter].ToString();
                    form_main.Money_Next = model.money[prise_counter + 1].ToString();
                    form_main.Win_Game();
                }
               
            }
            else if (model.b_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.B_Right(false);

            }
            else if (model.c_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.C_Right(false);

            }
            else if (model.d_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.D_Right(false);

            }
        }

        public void B_Pressed()
        {
            if (model.b_right == true)
            {
                form_main.Dialog_Set = "Ведущий: И это правильный ответ!";
                prise_counter++;
                form_main.Money_Current = model.money[prise_counter].ToString();
                if (model.money[prise_counter] != 1000000)
                {
                    form_main.Money_Next = model.money[prise_counter + 1].ToString();
                    form_main.B_Right(true);
                    Thread.Sleep(500);
                    form_main.Dialog_Set = "Ведущий: И так, Следующий вопрос!";
                    New_Question();
                }
                else
                {
                    form_main.Dialog_Set = "Ведущий: Поздравляю, вы выиграли миллион!";
                    form_main.Win_Game();
                }
            }
            else if (model.a_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.A_Right(false);

            }
            else if (model.c_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.C_Right(false);

            }
            else if (model.d_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.D_Right(false);

            }
        }
        public void C_Pressed()
        {
            if (model.c_right == true)
            {
                form_main.Dialog_Set = "Ведущий: И это правильный ответ!";
                prise_counter++;
                form_main.Money_Current = model.money[prise_counter].ToString();
                if (model.money[prise_counter] != 1000000)
                {
                    form_main.Money_Next = model.money[prise_counter + 1].ToString();
                    form_main.C_Right(true);
                    Thread.Sleep(500);
                    form_main.Dialog_Set = "Ведущий: И так, Следующий вопрос!";
                    New_Question();
                }
                else
                {
                    form_main.Dialog_Set = "Ведущий: Поздравляю, вы выиграли миллион!";
                    form_main.Win_Game();
                }
            }
            else if (model.b_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.B_Right(false);

            }
            else if (model.a_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.A_Right(false);

            }
            else if (model.d_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.D_Right(false);

            }
        }

        public void D_Pressed()
        {
            if (model.d_right == true)
            {
                form_main.Dialog_Set = "Ведущий: И это правильный ответ!";
                prise_counter++;
                form_main.Money_Current = model.money[prise_counter].ToString();
                if (model.money[prise_counter] != 1000000)
                {
                    form_main.Money_Next = model.money[prise_counter + 1].ToString();
                    form_main.D_Right(true);
                    Thread.Sleep(500);
                    form_main.Dialog_Set = "Ведущий: И так, Следующий вопрос!";
                    New_Question();
                }
                else
                {
                    form_main.Dialog_Set = "Ведущий: Поздравляю, вы выиграли миллион!";
                    form_main.Win_Game();
                }
            }
            else if (model.b_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.B_Right(false);

            }
            else if (model.c_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.C_Right(false);

            }
            else if (model.a_right == true)
            {
                form_main.Dialog_Set = "Ведущий: К сожелению, вы ошиблись, возможно повезет в следующий раз!";
                form_main.D_Right(false);

            }
        }
    }
}

