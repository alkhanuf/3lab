namespace _3lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var volumeTypes = new string[]
            {
                "м3",
                "мл",
                "л",
                "б"
            };

            cmbFirstType.DataSource = new List<string>(volumeTypes);
            cmbSecondType.DataSource = new List<string>(volumeTypes);
            cmbResultType.DataSource = new List<string>(volumeTypes);
        }

        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                var firstVolume = new Volume(firstValue, VolumeType.m3);
                var secondVolume = new Volume(secondValue, VolumeType.m3);

                Volume sumVolume;

                switch (cmbOperation.Text)
                {
                    case "+":
                        sumVolume = firstVolume + secondVolume;
                        break;
                    case "-":
                        sumVolume = firstVolume - secondVolume;
                        break;
                    default:
                        sumVolume = new Volume(0, VolumeType.m3);
                        break;
                }

                txtResult.Text = sumVolume.Verbose();
            }
            catch (FormatException)
            {

            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
