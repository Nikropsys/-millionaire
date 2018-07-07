namespace Win_Forms_Millionaire
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answer_b1 = new System.Windows.Forms.Button();
            this.answer_b3 = new System.Windows.Forms.Button();
            this.answer_b2 = new System.Windows.Forms.Button();
            this.answer_b4 = new System.Windows.Forms.Button();
            this.question_b = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТекущToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторскийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.call_friend_b = new System.Windows.Forms.Button();
            this.help_b = new System.Windows.Forms.Button();
            this.b_50_50 = new System.Windows.Forms.Button();
            this.Dialog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answer_b1
            // 
            this.answer_b1.BackColor = System.Drawing.Color.Black;
            this.answer_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_b1.ForeColor = System.Drawing.Color.GhostWhite;
            this.answer_b1.Location = new System.Drawing.Point(0, 484);
            this.answer_b1.Name = "answer_b1";
            this.answer_b1.Size = new System.Drawing.Size(336, 55);
            this.answer_b1.TabIndex = 0;
            this.answer_b1.Text = "A: ";
            this.answer_b1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer_b1.UseVisualStyleBackColor = false;
            this.answer_b1.Click += new System.EventHandler(this.A_Button_click);
            // 
            // answer_b3
            // 
            this.answer_b3.BackColor = System.Drawing.Color.Black;
            this.answer_b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_b3.ForeColor = System.Drawing.Color.GhostWhite;
            this.answer_b3.Location = new System.Drawing.Point(578, 484);
            this.answer_b3.Name = "answer_b3";
            this.answer_b3.Size = new System.Drawing.Size(336, 55);
            this.answer_b3.TabIndex = 1;
            this.answer_b3.Text = "C: ";
            this.answer_b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer_b3.UseVisualStyleBackColor = false;
            this.answer_b3.Click += new System.EventHandler(this.C_Button_click);
            // 
            // answer_b2
            // 
            this.answer_b2.BackColor = System.Drawing.Color.Black;
            this.answer_b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_b2.ForeColor = System.Drawing.Color.GhostWhite;
            this.answer_b2.Location = new System.Drawing.Point(0, 573);
            this.answer_b2.Name = "answer_b2";
            this.answer_b2.Size = new System.Drawing.Size(336, 55);
            this.answer_b2.TabIndex = 2;
            this.answer_b2.Text = "B: ";
            this.answer_b2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer_b2.UseVisualStyleBackColor = false;
            this.answer_b2.Click += new System.EventHandler(this.B_Button_click);
            // 
            // answer_b4
            // 
            this.answer_b4.BackColor = System.Drawing.Color.Black;
            this.answer_b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_b4.ForeColor = System.Drawing.Color.GhostWhite;
            this.answer_b4.Location = new System.Drawing.Point(578, 573);
            this.answer_b4.Name = "answer_b4";
            this.answer_b4.Size = new System.Drawing.Size(336, 55);
            this.answer_b4.TabIndex = 3;
            this.answer_b4.Text = "D: ";
            this.answer_b4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer_b4.UseVisualStyleBackColor = false;
            this.answer_b4.Click += new System.EventHandler(this.D_Button_click);
            // 
            // question_b
            // 
            this.question_b.BackColor = System.Drawing.Color.Black;
            this.question_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.question_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question_b.ForeColor = System.Drawing.Color.GhostWhite;
            this.question_b.Location = new System.Drawing.Point(149, 400);
            this.question_b.Name = "question_b";
            this.question_b.Size = new System.Drawing.Size(620, 62);
            this.question_b.TabIndex = 4;
            this.question_b.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.администраторскийРежимToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.сохранитьТекущToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.New_Game_Button);
            // 
            // сохранитьТекущToolStripMenuItem
            // 
            this.сохранитьТекущToolStripMenuItem.Name = "сохранитьТекущToolStripMenuItem";
            this.сохранитьТекущToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.сохранитьТекущToolStripMenuItem.Text = "Сохранить текущюю игру";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // администраторскийРежимToolStripMenuItem
            // 
            this.администраторскийРежимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВопросToolStripMenuItem,
            this.удалитьВопросToolStripMenuItem});
            this.администраторскийРежимToolStripMenuItem.Name = "администраторскийРежимToolStripMenuItem";
            this.администраторскийРежимToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.администраторскийРежимToolStripMenuItem.Text = "Администраторский режим";
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            // 
            // удалитьВопросToolStripMenuItem
            // 
            this.удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            this.удалитьВопросToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            // 
            // call_friend_b
            // 
            this.call_friend_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("call_friend_b.BackgroundImage")));
            this.call_friend_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.call_friend_b.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.call_friend_b.Location = new System.Drawing.Point(0, 41);
            this.call_friend_b.Name = "call_friend_b";
            this.call_friend_b.Size = new System.Drawing.Size(48, 45);
            this.call_friend_b.TabIndex = 6;
            this.call_friend_b.UseVisualStyleBackColor = true;
            this.call_friend_b.Click += new System.EventHandler(this.Call_Friend);
            // 
            // help_b
            // 
            this.help_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_b.BackgroundImage")));
            this.help_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_b.Location = new System.Drawing.Point(0, 108);
            this.help_b.Name = "help_b";
            this.help_b.Size = new System.Drawing.Size(48, 41);
            this.help_b.TabIndex = 7;
            this.help_b.UseVisualStyleBackColor = true;
            this.help_b.Click += new System.EventHandler(this.Help_People);
            // 
            // b_50_50
            // 
            this.b_50_50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_50_50.BackgroundImage")));
            this.b_50_50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_50_50.Location = new System.Drawing.Point(0, 166);
            this.b_50_50.Name = "b_50_50";
            this.b_50_50.Size = new System.Drawing.Size(48, 41);
            this.b_50_50.TabIndex = 8;
            this.b_50_50.UseVisualStyleBackColor = true;
            this.b_50_50.Click += new System.EventHandler(this.Fifty_Help);
            // 
            // Dialog
            // 
            this.Dialog.BackColor = System.Drawing.Color.GhostWhite;
            this.Dialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Dialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dialog.Location = new System.Drawing.Point(418, 340);
            this.Dialog.Name = "Dialog";
            this.Dialog.Size = new System.Drawing.Size(383, 54);
            this.Dialog.TabIndex = 9;
            this.Dialog.UseVisualStyleBackColor = false;
            this.Dialog.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(318, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 126);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(723, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Уже выиграно:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Location = new System.Drawing.Point(723, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox3.Location = new System.Drawing.Point(723, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(175, 22);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Следующий выигрышь:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox4.Location = new System.Drawing.Point(723, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(175, 22);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "100";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.Color.Black;
            this.b_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_start.ForeColor = System.Drawing.Color.GhostWhite;
            this.b_start.Location = new System.Drawing.Point(385, 92);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(171, 67);
            this.b_start.TabIndex = 15;
            this.b_start.Text = "Начать Игру";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.New_Game_Button);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 627);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dialog);
            this.Controls.Add(this.b_50_50);
            this.Controls.Add(this.help_b);
            this.Controls.Add(this.call_friend_b);
            this.Controls.Add(this.question_b);
            this.Controls.Add(this.answer_b4);
            this.Controls.Add(this.answer_b2);
            this.Controls.Add(this.answer_b3);
            this.Controls.Add(this.answer_b1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Кто хочет стать милионером ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer_b1;
        private System.Windows.Forms.Button answer_b3;
        private System.Windows.Forms.Button answer_b2;
        private System.Windows.Forms.Button answer_b4;
        private System.Windows.Forms.Button question_b;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТекущToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторскийРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private System.Windows.Forms.Button call_friend_b;
        private System.Windows.Forms.Button help_b;
        private System.Windows.Forms.Button b_50_50;
        private System.Windows.Forms.Button Dialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button b_start;
    }
}

