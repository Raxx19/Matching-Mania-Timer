namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int timer = 5;
        string screen = "M";
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time.Text = "00:00";
            Time.Hide();
            menuHide();
            Ready.Hide();
            Back.Hide();
            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(timer1_Tick);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time.Show();
            Back.Show();
            menuShow();
            titleHide();
        }

        private void button2_Click(object sender, EventArgs e) //Easy Button
        {
            menuHide();
            Easy.Show();
            Easy.Enabled = false;
            Ready.Show();
            screen = "R";
            Time.Text = "01:00";
            timer = 60;
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            menuHide();
            Medium.Show();
            Medium.Enabled = false;
            Ready.Show();
            screen = "R";
            Time.Text = "00:45";
            timer = 45;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Extreme_Click(object sender, EventArgs e)
        {
            menuHide();
            Extreme.Show();
            Extreme.Enabled = false;
            Ready.Show();
            screen = "R";
            Time.Text = "00:15";
            timer = 15;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (screen == "M") //Main Menu
            {
                titleShow();
                menuHide();
                Back.Hide();
                Time.Hide();
            }
            else if (screen == "R") //Ready?
            {
                menuShow();
                Ready.Hide();
                screen = "M";
                Time.Text = "00:00";
            }
        }

        private void titleShow()
        {
            Title.Show();
            Start.Show();
        }
        private void titleHide()
        {
            Title.Hide();
            Start.Hide();
        }
        private void menuShow()
        {
            Easy.Show();
            Easy.Enabled = true;
            Medium.Show();
            Medium.Enabled = true;
            Hard.Show();
            Hard.Enabled = true;
            Extreme.Show();
            Extreme.Enabled = true;
        }
        private void menuHide()
        {
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            Extreme.Hide();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            menuHide();
            Hard.Show();
            Hard.Enabled = false;
            Ready.Show();
            screen = "R";
            Time.Text = "00:30";
            timer = 30;
        }

        private void Ready_Click(object sender, EventArgs e)
        {

        }

        private void Ready_Click_1(object sender, EventArgs e)
        {
            Ready.Hide();
            Back.Hide();
            menuHide();
            myTimer.Start();
            timerCheck();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            timerCheck();
            if (timer <= 0)
            {
                myTimer.Stop();
                MessageBox.Show("Game Over! Play Again?");
                this.Close();
            }
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void timerCheck()
        {
            int minutes = (int)Decimal.Truncate(timer / 60);
            int seconds = (int)Decimal.Truncate(timer - (60 * minutes));
            Time.Text = minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
        }
    }
}