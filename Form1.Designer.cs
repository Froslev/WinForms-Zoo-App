namespace DjurparkenWinForms
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowInfoBtn = new System.Windows.Forms.Button();
            this.WriteAnimalsBtn = new System.Windows.Forms.Button();
            this.FeedAnimalBtn = new System.Windows.Forms.Button();
            this.PlayWithAnimalBtn = new System.Windows.Forms.Button();
            this.AddVisitorBtn = new System.Windows.Forms.Button();
            this.ShowVisitorBtn = new System.Windows.Forms.Button();
            this.EndProgramBtn = new System.Windows.Forms.Button();
            this.info_output = new System.Windows.Forms.RichTextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.age_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lion_feed = new System.Windows.Forms.Button();
            this.lioncub_feed = new System.Windows.Forms.Button();
            this.wolf_feed = new System.Windows.Forms.Button();
            this.beaver_feed = new System.Windows.Forms.Button();
            this.lion_play = new System.Windows.Forms.Button();
            this.lioncub_play = new System.Windows.Forms.Button();
            this.wolf_play = new System.Windows.Forms.Button();
            this.beaver_play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(36, 35);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(501, 38);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Välkommen till Djurparken\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj ett alternativ:";
            // 
            // ShowInfoBtn
            // 
            this.ShowInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowInfoBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInfoBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowInfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowInfoBtn.Image")));
            this.ShowInfoBtn.Location = new System.Drawing.Point(275, 399);
            this.ShowInfoBtn.Name = "ShowInfoBtn";
            this.ShowInfoBtn.Size = new System.Drawing.Size(125, 159);
            this.ShowInfoBtn.TabIndex = 2;
            this.ShowInfoBtn.Text = "Visa info om Djurparken";
            this.ShowInfoBtn.UseVisualStyleBackColor = false;
            this.ShowInfoBtn.Click += new System.EventHandler(this.ShowInfoBtn_Click);
            // 
            // WriteAnimalsBtn
            // 
            this.WriteAnimalsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WriteAnimalsBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteAnimalsBtn.ForeColor = System.Drawing.Color.Black;
            this.WriteAnimalsBtn.Image = ((System.Drawing.Image)(resources.GetObject("WriteAnimalsBtn.Image")));
            this.WriteAnimalsBtn.Location = new System.Drawing.Point(406, 399);
            this.WriteAnimalsBtn.Name = "WriteAnimalsBtn";
            this.WriteAnimalsBtn.Size = new System.Drawing.Size(134, 159);
            this.WriteAnimalsBtn.TabIndex = 3;
            this.WriteAnimalsBtn.Text = "Skriv ut alla djur";
            this.WriteAnimalsBtn.UseVisualStyleBackColor = false;
            this.WriteAnimalsBtn.Click += new System.EventHandler(this.WriteAnimalsBtn_Click);
            // 
            // FeedAnimalBtn
            // 
            this.FeedAnimalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FeedAnimalBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedAnimalBtn.ForeColor = System.Drawing.Color.White;
            this.FeedAnimalBtn.Image = ((System.Drawing.Image)(resources.GetObject("FeedAnimalBtn.Image")));
            this.FeedAnimalBtn.Location = new System.Drawing.Point(557, 26);
            this.FeedAnimalBtn.Name = "FeedAnimalBtn";
            this.FeedAnimalBtn.Size = new System.Drawing.Size(170, 72);
            this.FeedAnimalBtn.TabIndex = 4;
            this.FeedAnimalBtn.Text = "Mata ett djur";
            this.FeedAnimalBtn.UseVisualStyleBackColor = false;
            this.FeedAnimalBtn.Click += new System.EventHandler(this.FeedAnimalBtn_Click);
            // 
            // PlayWithAnimalBtn
            // 
            this.PlayWithAnimalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayWithAnimalBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayWithAnimalBtn.ForeColor = System.Drawing.Color.White;
            this.PlayWithAnimalBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayWithAnimalBtn.Image")));
            this.PlayWithAnimalBtn.Location = new System.Drawing.Point(560, 319);
            this.PlayWithAnimalBtn.Name = "PlayWithAnimalBtn";
            this.PlayWithAnimalBtn.Size = new System.Drawing.Size(170, 72);
            this.PlayWithAnimalBtn.TabIndex = 5;
            this.PlayWithAnimalBtn.Text = "Lek med ett djur";
            this.PlayWithAnimalBtn.UseVisualStyleBackColor = false;
            this.PlayWithAnimalBtn.Click += new System.EventHandler(this.PlayWithAnimalBtn_Click);
            // 
            // AddVisitorBtn
            // 
            this.AddVisitorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddVisitorBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVisitorBtn.ForeColor = System.Drawing.Color.Black;
            this.AddVisitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddVisitorBtn.Image")));
            this.AddVisitorBtn.Location = new System.Drawing.Point(29, 370);
            this.AddVisitorBtn.Name = "AddVisitorBtn";
            this.AddVisitorBtn.Size = new System.Drawing.Size(108, 83);
            this.AddVisitorBtn.TabIndex = 6;
            this.AddVisitorBtn.Text = "Lägg till besökare";
            this.AddVisitorBtn.UseVisualStyleBackColor = false;
            this.AddVisitorBtn.Click += new System.EventHandler(this.AddVisitorBtn_Click);
            // 
            // ShowVisitorBtn
            // 
            this.ShowVisitorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowVisitorBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVisitorBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowVisitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowVisitorBtn.Image")));
            this.ShowVisitorBtn.Location = new System.Drawing.Point(143, 370);
            this.ShowVisitorBtn.Name = "ShowVisitorBtn";
            this.ShowVisitorBtn.Size = new System.Drawing.Size(108, 83);
            this.ShowVisitorBtn.TabIndex = 7;
            this.ShowVisitorBtn.Text = "Visa besökare";
            this.ShowVisitorBtn.UseVisualStyleBackColor = false;
            this.ShowVisitorBtn.Click += new System.EventHandler(this.ShowVisitorBtn_Click);
            // 
            // EndProgramBtn
            // 
            this.EndProgramBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EndProgramBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndProgramBtn.ForeColor = System.Drawing.Color.White;
            this.EndProgramBtn.Location = new System.Drawing.Point(275, 565);
            this.EndProgramBtn.Name = "EndProgramBtn";
            this.EndProgramBtn.Size = new System.Drawing.Size(265, 38);
            this.EndProgramBtn.TabIndex = 8;
            this.EndProgramBtn.Text = "Avsluta program";
            this.EndProgramBtn.UseVisualStyleBackColor = false;
            this.EndProgramBtn.Click += new System.EventHandler(this.EndProgramBtn_Click);
            // 
            // info_output
            // 
            this.info_output.BackColor = System.Drawing.Color.White;
            this.info_output.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_output.Location = new System.Drawing.Point(29, 482);
            this.info_output.Name = "info_output";
            this.info_output.Size = new System.Drawing.Size(222, 126);
            this.info_output.TabIndex = 9;
            this.info_output.Text = "";
            this.info_output.TextChanged += new System.EventHandler(this.user_input_box_TextChanged);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(29, 227);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(222, 20);
            this.first_name.TabIndex = 10;
            this.first_name.TextChanged += new System.EventHandler(this.förnamn_TextChanged);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(29, 283);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(222, 20);
            this.last_name.TabIndex = 11;
            this.last_name.TextChanged += new System.EventHandler(this.efternamn_TextChanged);
            // 
            // age_input
            // 
            this.age_input.Location = new System.Drawing.Point(29, 342);
            this.age_input.Name = "age_input";
            this.age_input.Size = new System.Drawing.Size(222, 20);
            this.age_input.TabIndex = 12;
            this.age_input.TextChanged += new System.EventHandler(this.ålder_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Förnamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Efternamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ålder:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 69);
            this.label5.TabIndex = 16;
            this.label5.Text = "var vänlig ange \r\ninfo för att lägga \r\ntill besökare:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 242);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Information:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(557, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 36);
            this.label7.TabIndex = 20;
            this.label7.Text = "Klicka på djuret \r\ndu vill mata:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(557, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 54);
            this.label8.TabIndex = 22;
            this.label8.Text = "Klicka på djuret \r\ndu vill leka med:\r\n\r\n";
            // 
            // lion_feed
            // 
            this.lion_feed.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lion_feed.Location = new System.Drawing.Point(560, 143);
            this.lion_feed.Name = "lion_feed";
            this.lion_feed.Size = new System.Drawing.Size(170, 35);
            this.lion_feed.TabIndex = 23;
            this.lion_feed.Text = "Lion";
            this.lion_feed.UseVisualStyleBackColor = true;
            this.lion_feed.Click += new System.EventHandler(this.lion_feed_Click);
            // 
            // lioncub_feed
            // 
            this.lioncub_feed.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lioncub_feed.Location = new System.Drawing.Point(560, 184);
            this.lioncub_feed.Name = "lioncub_feed";
            this.lioncub_feed.Size = new System.Drawing.Size(170, 35);
            this.lioncub_feed.TabIndex = 24;
            this.lioncub_feed.Text = "Lion Cub";
            this.lioncub_feed.UseVisualStyleBackColor = true;
            this.lioncub_feed.Click += new System.EventHandler(this.lioncub_feed_Click);
            // 
            // wolf_feed
            // 
            this.wolf_feed.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolf_feed.Location = new System.Drawing.Point(560, 225);
            this.wolf_feed.Name = "wolf_feed";
            this.wolf_feed.Size = new System.Drawing.Size(170, 36);
            this.wolf_feed.TabIndex = 25;
            this.wolf_feed.Text = "Wolf";
            this.wolf_feed.UseVisualStyleBackColor = true;
            this.wolf_feed.Click += new System.EventHandler(this.wolf_feed_Click);
            // 
            // beaver_feed
            // 
            this.beaver_feed.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beaver_feed.Location = new System.Drawing.Point(560, 267);
            this.beaver_feed.Name = "beaver_feed";
            this.beaver_feed.Size = new System.Drawing.Size(170, 36);
            this.beaver_feed.TabIndex = 26;
            this.beaver_feed.Text = "Beaver";
            this.beaver_feed.UseVisualStyleBackColor = true;
            this.beaver_feed.Click += new System.EventHandler(this.beaver_feed_Click);
            // 
            // lion_play
            // 
            this.lion_play.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lion_play.Location = new System.Drawing.Point(560, 436);
            this.lion_play.Name = "lion_play";
            this.lion_play.Size = new System.Drawing.Size(170, 35);
            this.lion_play.TabIndex = 27;
            this.lion_play.Text = "Lion";
            this.lion_play.UseVisualStyleBackColor = true;
            this.lion_play.Click += new System.EventHandler(this.lion_play_Click);
            // 
            // lioncub_play
            // 
            this.lioncub_play.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lioncub_play.Location = new System.Drawing.Point(560, 477);
            this.lioncub_play.Name = "lioncub_play";
            this.lioncub_play.Size = new System.Drawing.Size(170, 38);
            this.lioncub_play.TabIndex = 28;
            this.lioncub_play.Text = "Lion Cub";
            this.lioncub_play.UseVisualStyleBackColor = true;
            this.lioncub_play.Click += new System.EventHandler(this.lioncub_play_Click);
            // 
            // wolf_play
            // 
            this.wolf_play.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolf_play.Location = new System.Drawing.Point(560, 521);
            this.wolf_play.Name = "wolf_play";
            this.wolf_play.Size = new System.Drawing.Size(170, 37);
            this.wolf_play.TabIndex = 29;
            this.wolf_play.Text = "Wolf";
            this.wolf_play.UseVisualStyleBackColor = true;
            this.wolf_play.Click += new System.EventHandler(this.wolf_play_Click);
            // 
            // beaver_play
            // 
            this.beaver_play.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beaver_play.Location = new System.Drawing.Point(560, 564);
            this.beaver_play.Name = "beaver_play";
            this.beaver_play.Size = new System.Drawing.Size(170, 37);
            this.beaver_play.TabIndex = 30;
            this.beaver_play.Text = "Beaver";
            this.beaver_play.UseVisualStyleBackColor = true;
            this.beaver_play.Click += new System.EventHandler(this.beaver_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 620);
            this.Controls.Add(this.beaver_play);
            this.Controls.Add(this.wolf_play);
            this.Controls.Add(this.lioncub_play);
            this.Controls.Add(this.lion_play);
            this.Controls.Add(this.beaver_feed);
            this.Controls.Add(this.wolf_feed);
            this.Controls.Add(this.lioncub_feed);
            this.Controls.Add(this.lion_feed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.age_input);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.info_output);
            this.Controls.Add(this.EndProgramBtn);
            this.Controls.Add(this.ShowVisitorBtn);
            this.Controls.Add(this.AddVisitorBtn);
            this.Controls.Add(this.PlayWithAnimalBtn);
            this.Controls.Add(this.FeedAnimalBtn);
            this.Controls.Add(this.WriteAnimalsBtn);
            this.Controls.Add(this.ShowInfoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowInfoBtn;
        private System.Windows.Forms.Button WriteAnimalsBtn;
        private System.Windows.Forms.Button FeedAnimalBtn;
        private System.Windows.Forms.Button PlayWithAnimalBtn;
        private System.Windows.Forms.Button AddVisitorBtn;
        private System.Windows.Forms.Button ShowVisitorBtn;
        private System.Windows.Forms.Button EndProgramBtn;
        private System.Windows.Forms.RichTextBox info_output;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox age_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button lion_feed;
        private System.Windows.Forms.Button lioncub_feed;
        private System.Windows.Forms.Button wolf_feed;
        private System.Windows.Forms.Button beaver_feed;
        private System.Windows.Forms.Button lion_play;
        private System.Windows.Forms.Button lioncub_play;
        private System.Windows.Forms.Button wolf_play;
        private System.Windows.Forms.Button beaver_play;
    }
}

