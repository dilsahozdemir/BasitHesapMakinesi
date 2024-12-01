namespace BasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                Hesapla('+');
            }
            private void btnSubtract_Click(object sender, EventArgs e)
            {
                Hesapla('-');
            }
            private void btnMultiply_Click(object sender, EventArgs e)
            {
                Hesapla('*');
            }
            private void btnDivide_Click(object sender, EventArgs e)
            {
                Hesapla('/');
            }
            private void Hesapla(char islem)
            {
                try
                {
                    double sayi1 = Convert.ToDouble(txtNumber1.Text);
                    double sayi2 = Convert.ToDouble(txtNumber2.Text);
                    double sonuc = 0;

                    switch (islem)
                    {
                        case '+':
                            sonuc = sayi1 + sayi2;
                            break;
                        case '-':
                            sonuc = sayi1 - sayi2;
                            break;
                        case '*':
                            sonuc = sayi1 * sayi2;
                            break;
                        case '/':
                            if (sayi2 != 0)
                                sonuc = sayi1 / sayi2;
                            else
                                MessageBox.Show("Sýfýra bölme hatasý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    txtResult.Text = sonuc.ToString();
                }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }

