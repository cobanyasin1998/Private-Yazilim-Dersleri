namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _sayi1;
        private string _sayi2;
        private string _operatorSymbol;

        private readonly Calculator _calculator;

        public Form1()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }
        private void btnFullTemizle_Click(object sender, EventArgs e)
        {
            _sayi1 = null;
            _sayi2 = null;
            txtSonuc.Text = null;
            _calculator.TotalTemizle();
            _operatorSymbol = string.Empty;
        }
        private void SayiButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string sayi = button.Text;

            if (!string.IsNullOrWhiteSpace(_operatorSymbol))
            {
                _sayi2 += sayi;
            }
            else
            {
                _sayi1 += sayi;
            }
            txtSonuc.Text += sayi;
        }

        private void btn1_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn2_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn3_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn4_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn5_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn6_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn7_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn8_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btn9_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btnSifir_Click(object sender, EventArgs e) => SayiButtonClick(sender, e);
        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sayi1) && !string.IsNullOrWhiteSpace(_sayi2))
            {
                decimal sayi1 = decimal.Parse(_sayi1);
                decimal sayi2 = decimal.Parse(_sayi2);

                decimal sonuc = _calculator.Topla(sayi1, sayi2);
                txtSonuc.Text = sonuc.ToString();

                _sayi1 = null;
                _sayi2 = null;
                _operatorSymbol = string.Empty;
            }
            else
            {
                txtSonuc.Text += "+";
                _operatorSymbol = "+";
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sayi1) && !string.IsNullOrWhiteSpace(_sayi2))
            {
                decimal sayi1 = decimal.Parse(_sayi1);
                decimal sayi2 = decimal.Parse(_sayi2);

                decimal sonuc = _calculator.Cikar(sayi1, sayi2);
                txtSonuc.Text = sonuc.ToString();

                _sayi1 = null;
                _sayi2 = null;
                _operatorSymbol = string.Empty;
            }
            else
            {
                txtSonuc.Text += "-";
                _operatorSymbol = "-";
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sayi1) && !string.IsNullOrWhiteSpace(_sayi2))
            {
                decimal sayi1 = decimal.Parse(_sayi1);
                decimal sayi2 = decimal.Parse(_sayi2);

                decimal sonuc = _calculator.Carp(sayi1, sayi2);
                txtSonuc.Text = sonuc.ToString();

                _sayi1 = null;
                _sayi2 = null;
                _operatorSymbol = string.Empty;
            }
            else
            {
                txtSonuc.Text += "*";
                _operatorSymbol = "*";
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sayi1) && !string.IsNullOrWhiteSpace(_sayi2))
            {
                decimal sayi1 = decimal.Parse(_sayi1);
                decimal sayi2 = decimal.Parse(_sayi2);

                if (sayi2 != 0)
                {
                    decimal sonuc = _calculator.Bol(sayi1, sayi2);
                    txtSonuc.Text = sonuc.ToString();

                    _sayi1 = null;
                    _sayi2 = null;
                    _operatorSymbol = string.Empty;
                }
                else
                {
                    MessageBox.Show("Sýfýra bölme hatasý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtSonuc.Text += "/";
                _operatorSymbol = "/";
            }
        }

        private void btnYuzdeAl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sayi1) && !string.IsNullOrWhiteSpace(_sayi2))
            {
                decimal sayi1 = decimal.Parse(_sayi1);
                decimal sayi2 = decimal.Parse(_sayi2);

                decimal sonuc = _calculator.Bol(sayi1, 100) * sayi2;
                txtSonuc.Text = sonuc.ToString();

                _sayi1 = null;
                _sayi2 = null;
                _operatorSymbol = string.Empty;
            }
            else
            {
                MessageBox.Show("Geçerli bir iþlem yapýlamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sayi1) && !string.IsNullOrWhiteSpace(_sayi2) && !string.IsNullOrWhiteSpace(_operatorSymbol))
            {
                decimal sayi1 = decimal.Parse(_sayi1);
                decimal sayi2 = decimal.Parse(_sayi2);

                switch (_operatorSymbol)
                {
                    case "+":
                        txtSonuc.Text = _calculator.Topla(sayi1, sayi2).ToString();
                        break;
                    case "-":
                        txtSonuc.Text = _calculator.Cikar(sayi1, sayi2).ToString();
                        break;
                    case "*":
                        txtSonuc.Text = _calculator.Carp(sayi1, sayi2).ToString();
                        break;
                    case "/":
                        if (sayi2 != 0)
                        {
                            txtSonuc.Text = _calculator.Bol(sayi1, sayi2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Sýfýra bölme hatasý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                }

                _sayi1 = null;
                _sayi2 = null;
                _operatorSymbol = string.Empty;
            }
            else
            {
                MessageBox.Show("Geçerli bir iþlem yapýlamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_operatorSymbol))
            {
                if (string.IsNullOrWhiteSpace(_sayi1))
                {
                    _sayi1 = "0";
                }

                if (!_sayi1.Contains("."))
                {
                    _sayi1 += ".";
                    txtSonuc.Text += ".";
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_sayi2))
                {
                    _sayi2 = "0";
                }

                if (!_sayi2.Contains("."))
                {
                    _sayi2 += ".";
                    txtSonuc.Text += ".";
                }
            }
        }




    }


    public class Calculator
    {
        private decimal Total;

        public decimal Topla(decimal sayi1, decimal sayi2)
        {
            Total = sayi1 + sayi2;
            return Total;
        }
        public decimal Cikar(decimal sayi1, decimal sayi2)
        {
            Total = sayi1 - sayi2;
            return Total;
        }
        public decimal Carp(decimal sayi1, decimal sayi2)
        {
            Total = sayi1 * sayi2;
            return Total;
        }
        public decimal Bol(decimal sayi1, decimal sayi2)
        {
            Total = sayi1 / sayi2;
            return Total;
        }
        public void TotalTemizle()
        {
            Total = 0;
        }
    }
}