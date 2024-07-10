namespace CSC240_01_02_TestsInteractiveGUI_DG
{
    public partial class UxTestInteractiveFormDG : Form
    {
        public UxTestInteractiveFormDG()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // STORAGE
            double num1, num2, num3, num4, num5, average, sum;

            // INPUT - get user input from the 5 text boxes
            num1 = Convert.ToDouble(UxNumber1Textbox.Text);
            num2 = Convert.ToDouble(UxNumber2Textbox.Text);
            num3 = Convert.ToDouble(UxNumber3Textbox.Text);
            num4 = Convert.ToDouble(UxNumber4Textbox.Text);
            num5 = Convert.ToDouble(UxNumber5Textbox.Text);

            // PROCESS - calculate the average
            sum = num1 + num2 + num3 + num4 + num5;
            average = sum / 5;

            // OUTPUT - display the average
            UxOutputTextbox.Text = average.ToString();

        }

        private void UxNumber1Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UxOutputTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
