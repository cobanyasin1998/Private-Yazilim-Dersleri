namespace GirilenSayiyiRomanRakamlarınaCevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox_KeyPress;

        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        private string ConvertToRoman(int sayi)
        {
            string[] birler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] onlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] yuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] binler = { "", "M", "MM", "MMM" };

            int birlerBasamagi = sayi % 10;
            int onlarBasamagi = (sayi / 10) % 10;
            int yuzlerBasamagi = (sayi / 100) % 10;
            int binlerBasamagi = sayi / 1000;

            string romanRakam = $"{binler[binlerBasamagi]}{yuzler[yuzlerBasamagi]}{onlar[onlarBasamagi]}{birler[birlerBasamagi]}";

            return romanRakam;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int enteredValue))
                {
                    if (enteredValue > 10000)
                    {
                        textBox1.Text = "10000";
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int sayi))
                {
                    textBox2.Text = ConvertToRoman(sayi);
                }
            }
        }
    }
}