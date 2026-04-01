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

            var operations = new string[]
            {
                "+",
                "-",
                "*",
                "/",
                ">",
                "<",
                "=",
                "!="
            };
            cmbOperation.DataSource = new List<string>(operations);
        }

        private VolumeType GetVolumeType(ComboBox comboBox)
        {
            switch (comboBox.Text)
            {
                case "м3":
                    return VolumeType.m3;
                case "мл":
                    return VolumeType.ml;
                case "л":
                    return VolumeType.l;
                case "б":
                    return VolumeType.barr;
                default:
                    return VolumeType.m3;
            }
        }


        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);


                VolumeType firstType = GetVolumeType(cmbFirstType);
                VolumeType secondType = GetVolumeType(cmbSecondType);
                VolumeType resultType = GetVolumeType(cmbResultType);

                var firstVolume = new Volume(firstValue, firstType);
                var secondVolume = new Volume(secondValue, secondType);

                Volume resultVolume;

                if (cmbOperation.Text == "+" || cmbOperation.Text == "-")
                {
                    switch (cmbOperation.Text)
                    {
                        case "+":
                            resultVolume = firstVolume + secondVolume;
                            break;
                        case "-":
                            resultVolume = firstVolume - secondVolume;
                            break;
                        default:
                            resultVolume = new Volume(0, VolumeType.m3);
                            break;
                    }
                    txtResult.Text = resultVolume.To(resultType).Verbose();
                }
                else if (cmbOperation.Text == "*" || cmbOperation.Text == "/")
                {
                    switch (cmbOperation.Text)
                    {
                        case "*":
                            resultVolume = firstVolume * secondValue;
                            break;
                        case "/":
                            if (secondValue == 0)
                            {
                                txtResult.Text = "деление на ноль";
                                return;
                            }
                            resultVolume = firstVolume / secondValue;
                            break;
                        default:
                            resultVolume = new Volume(0, VolumeType.m3);
                            break;
                    }
                    txtResult.Text = resultVolume.To(resultType).Verbose();
                }
                else
                {
                    bool boolResult;
                    switch (cmbOperation.Text)
                    {
                        case ">":
                            boolResult = firstVolume > secondVolume;
                            break;
                        case "<":
                            boolResult = firstVolume < secondVolume;
                            break;
                        case "=":
                            boolResult = firstVolume == secondVolume;
                            break;
                        case "!=":
                            boolResult = firstVolume != secondVolume;
                            break;
                        default:
                            boolResult = false;
                            break;
                    }
                    txtResult.Text = boolResult.ToString();
                }
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

        private void cmbFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbSecondType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbResultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
