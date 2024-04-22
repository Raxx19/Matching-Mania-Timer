namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Start = new Button();
            Easy = new Button();
            Medium = new Button();
            Hard = new Button();
            Extreme = new Button();
            Title = new Label();
            Back = new Button();
            Ready = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Time = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.AntiqueWhite;
            Start.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Start.Location = new Point(267, 288);
            Start.Margin = new Padding(4, 3, 4, 3);
            Start.Name = "Start";
            Start.Size = new Size(262, 82);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += button1_Click;
            // 
            // Easy
            // 
            Easy.BackColor = Color.AntiqueWhite;
            Easy.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Easy.ForeColor = SystemColors.ControlText;
            Easy.Location = new Point(354, 317);
            Easy.Margin = new Padding(4, 3, 4, 3);
            Easy.Name = "Easy";
            Easy.Size = new Size(200, 82);
            Easy.TabIndex = 2;
            Easy.Text = "Easy";
            Easy.UseVisualStyleBackColor = false;
            Easy.Click += button2_Click;
            // 
            // Medium
            // 
            Medium.BackColor = Color.AntiqueWhite;
            Medium.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Medium.Location = new Point(588, 317);
            Medium.Margin = new Padding(4, 3, 4, 3);
            Medium.Name = "Medium";
            Medium.Size = new Size(200, 82);
            Medium.TabIndex = 3;
            Medium.Text = "Medium";
            Medium.UseVisualStyleBackColor = false;
            Medium.Click += Medium_Click;
            // 
            // Hard
            // 
            Hard.BackColor = Color.AntiqueWhite;
            Hard.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Hard.Location = new Point(354, 416);
            Hard.Margin = new Padding(4, 3, 4, 3);
            Hard.Name = "Hard";
            Hard.Size = new Size(200, 82);
            Hard.TabIndex = 4;
            Hard.Text = "Hard";
            Hard.UseVisualStyleBackColor = false;
            Hard.Click += Hard_Click;
            // 
            // Extreme
            // 
            Extreme.BackColor = Color.AntiqueWhite;
            Extreme.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Extreme.Location = new Point(588, 416);
            Extreme.Margin = new Padding(4, 3, 4, 3);
            Extreme.Name = "Extreme";
            Extreme.Size = new Size(200, 82);
            Extreme.TabIndex = 5;
            Extreme.Text = "Extreme";
            Extreme.UseVisualStyleBackColor = false;
            Extreme.Click += Extreme_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.AntiqueWhite;
            Title.Font = new Font("Microsoft Sans Serif", 50F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(193, 55);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(464, 76);
            Title.TabIndex = 6;
            Title.Text = "Cards Of Fate";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += Title_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.AntiqueWhite;
            Back.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Back.Location = new Point(11, 416);
            Back.Margin = new Padding(4, 3, 4, 3);
            Back.Name = "Back";
            Back.Size = new Size(200, 82);
            Back.TabIndex = 7;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Ready
            // 
            Ready.BackColor = Color.AntiqueWhite;
            Ready.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Ready.Location = new Point(298, 237);
            Ready.Margin = new Padding(4, 3, 4, 3);
            Ready.Name = "Ready";
            Ready.Size = new Size(200, 82);
            Ready.TabIndex = 8;
            Ready.Text = "Ready?";
            Ready.UseVisualStyleBackColor = false;
            Ready.Click += Ready_Click_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = Color.AntiqueWhite;
            Time.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Time.Location = new Point(639, 81);
            Time.Margin = new Padding(4, 0, 4, 0);
            Time.Name = "Time";
            Time.Size = new Size(100, 42);
            Time.TabIndex = 9;
            Time.Text = "Time";
            Time.Click += Time_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(801, 510);
            Controls.Add(Time);
            Controls.Add(Ready);
            Controls.Add(Back);
            Controls.Add(Title);
            Controls.Add(Extreme);
            Controls.Add(Hard);
            Controls.Add(Medium);
            Controls.Add(Easy);
            Controls.Add(Start);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Start;
        private Button Easy;
        private Button Medium;
        private Button Hard;
        private Button Extreme;
        private Label Title;
        private Button Back;
        private Button Ready;
        private System.Windows.Forms.Timer timer1;
        private Label Time;
        private System.Windows.Forms.Timer timer2;
    }
}