using System.Runtime.Intrinsics.Arm;

namespace Calculator
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0")
            {
                this.DisplayScreen.Text = Button1.Text;
            } else
            {
                this.DisplayScreen.Text += Button1.Text;
            }
        }
      
        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0")
            {
                this.DisplayScreen.Text = Button2.Text;
            }
            else
            {
                this.DisplayScreen.Text += Button2.Text;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button3.Text;
            } else {
                this.DisplayScreen.Text += Button3.Text;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button4.Text;
            } else {
                this.DisplayScreen.Text += Button4.Text;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button5.Text;
            } else {
                this.DisplayScreen.Text += Button5.Text;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button6.Text;
            } else {
                this.DisplayScreen.Text += Button6.Text;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button7.Text;
            } else {
                this.DisplayScreen.Text += Button7.Text;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button8.Text;
            } else {
                this.DisplayScreen.Text += Button8.Text;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text == "0") {
                this.DisplayScreen.Text = Button9.Text;
            } else {
                this.DisplayScreen.Text += Button9.Text;
            }
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (!(this.DisplayScreen.Text == "0"))
            {
                this.DisplayScreen.Text += Button0.Text;
            }
      
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            this.DisplayScreen.Text = "0";
        }

        private void PowerOfTwo_Click(object sender, EventArgs e)
        {
            double powerValue = Convert.ToDouble(this.DisplayScreen.Text);
            // powerValue = 0.3 * 0.4;
            powerValue *= powerValue;
            powerValue = Math.Round(powerValue, 5);
            this.DisplayScreen.Text = Convert.ToString(powerValue);
        }

        private void SetMemory_Click(object sender, EventArgs e)
        {
            this.MemoryScreen.Text = this.DisplayScreen.Text;
            this.DisplayScreen.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MemoryScreen.Text = "0";
            this.DisplayScreen.Text = "0";

        }

        private void AddToMemory_Click(object sender, EventArgs e)
        {
            double currentScreenValue = Convert.ToDouble(this.MemoryScreen.Text);
            currentScreenValue += Convert.ToDouble(this.DisplayScreen.Text);
            this.DisplayScreen.Text = "0";
            this.MemoryScreen.Text = Convert.ToString(currentScreenValue);
        }

        private void RevealMemory_Click(object sender, EventArgs e)
        {
            this.DisplayScreen.Text = this.MemoryScreen.Text;
            this.MemoryScreen.Text = "0";
        }

        private void SubstractFromMemory_Click(object sender, EventArgs e)
        {
            double currentScreenValue = Convert.ToDouble(this.MemoryScreen.Text);
            currentScreenValue -= Convert.ToDouble(this.DisplayScreen.Text);
            this.DisplayScreen.Text = "0";
            this.MemoryScreen.Text = Convert.ToString(currentScreenValue);
        }

        private void Module_Click(object sender, EventArgs e)
        {
            if (!(this.DisplayScreen.Text == "0"))
            {
                this.DisplayScreen.Text = Convert.ToString(-1 * Convert.ToDouble(this.DisplayScreen.Text));
            }
        }

        private void Sinus_Click(object sender, EventArgs e)
        {
            this.DisplayScreen.Text = Convert.ToString(Math.Sin(Convert.ToDouble(this.DisplayScreen.Text)));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.DisplayScreen.Text.Length == 1)
            {
                this.DisplayScreen.Text = "0";
            } 
            else
            {
                this.DisplayScreen.Text = this.DisplayScreen.Text.Remove(this.DisplayScreen.Text.Length - 1);
            }
        }

        private void DisplayScreen_TextChanged(object sender, EventArgs e)
        {
            int fromBase = 10;
            int toBaseBin = 2;
            int toBaseOct = 8;
            int toBaseHex = 16;

            try
            {
                if (true)
                {
                    // Binary
                    string result = Convert.ToString(Convert.ToInt64(this.DisplayScreen.Text, fromBase), toBaseBin);
                    this.BinaryScreen.Text = result;

                    // Octal 
                    result = Convert.ToString(Convert.ToInt64(this.DisplayScreen.Text, fromBase), toBaseOct);
                    this.OctalScreen.Text = result;

                    // Hex
                    result = Convert.ToString(Convert.ToInt64(this.DisplayScreen.Text, fromBase), toBaseHex);
                    result = result.ToUpper();
                    this.HexazecimalScreen.Text = result;
                }

            } catch { }
        }

        private void Radical_Click(object sender, EventArgs e)
        {
            double sqrtValue = Convert.ToDouble(this.DisplayScreen.Text);
            sqrtValue = Math.Sqrt(sqrtValue);
            sqrtValue = Math.Round(sqrtValue, 5);
            this.DisplayScreen.Text = Convert.ToString(sqrtValue);
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!(this.DisplayScreen.Text == "0,") && (this.DisplayScreen.Text == "0"))
            {
                this.DisplayScreen.Text = "0,";
            }
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            this.MemoryScreen.Text = "0";
        }
    }
}