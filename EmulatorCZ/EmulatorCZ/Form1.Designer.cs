﻿namespace EmulatorCZ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.newgame = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 73);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickMark);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 73);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClickMark);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 73);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClickMark);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 73);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClickMark);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 73);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClickMark);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 73);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ClickMark);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 73);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ClickMark);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(92, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 73);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ClickMark);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(172, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 73);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ClickMark);
            // 
            // newgame
            // 
            this.newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newgame.Location = new System.Drawing.Point(13, 250);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(108, 37);
            this.newgame.TabIndex = 9;
            this.newgame.Text = "New Game";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(219, 259);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(28, 18);
            this.score.TabIndex = 10;
            this.score.Text = "0:0";
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop.Location = new System.Drawing.Point(127, 250);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(82, 37);
            this.stop.TabIndex = 11;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 301);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.score);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "CZ League Desktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button stop;
    }
}

