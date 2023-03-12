using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QQ73841_EnginYasinKARATAS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnShowResult1, @"İlk iki sayıyı toplar ve toplamı üçüncü sayı ile çarparak ""Sonuç"" alanında gösterir.");
            toolTip.SetToolTip(btnShowResult2, @"1'den 200'e kadar olan sayılar ekrana yazdırılır. Sayılar 3'ün katıysa ""zig"", 5'in katıysa ""zag"" ve hem 3 hem de 5'in katıysa ""zigzag"" yazdırılır. 100'den sonra ise ""zigzag"" yerine ""zagzig"" yazdırılır.");
        }

        /// <summary>
        /// Birinci işlevsellik: Sayı girebileceğim üç tane textbox bulunacak. Bu textbox’lara sayılar gireceğim. “Sonucu Göster” düğmesine bastığımda ilk iki textbox’a girilen sayıların toplamının üçüncü textbox’a girilen sayı ile çarpımının sonucu dördüncü bir textbox’ta gözükecek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResult1_Click(object sender, EventArgs e)
        {
            // Sayısal olmayan bir değer girildiğinde hesaplama işleminin yapılmaması sağlanıyor. Halbuki sayısal olmayan değer girişi önlenmişti fakat hesaba katılmayan bir açık olsa dahi burada hata fırlatmasının önüne geçilmiş, kullanıcı bu konuda uyarılmıştır.
            if (
                decimal.TryParse(txtNumberToBeSummed1.Text, out decimal number1) &&
                decimal.TryParse(txtNumberToBeSummed2.Text, out decimal number2) &&
                decimal.TryParse(txtNumberToBeMultiplied.Text, out decimal number3)
                )
            {
                txtResult.Text = (number1 + number2) * number3 + "";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumberToBeSummed1.Focus();
            }
        }

        /// <summary>
        /// İkinci işlevsellik: Bir düğmeye basıldığında ekrana 1’den 200’e kadar olan sayılar yazılacak. Ancak sayı 3’ün katı ise sayının yerine ‘zig’ yazılacak, sayı 5’in katı ise sayının yerine ‘zag’ yazılacak. Sayı hem 3’ün hem de 5’in katı ise ‘zigzag’ yazılacak. 100’den sonra ‘zigzag’ yerine ‘zagzig’ yazılacak.
        /// 
        /// "1'den 200'e kadar olan sayılar ekrana yazdırılır" denildiği için, kalansız bölünebilme kurallarına bakılmaksızın tüm sayılar yazdırılmıştır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResult2_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            for (int i = 1; i <= 200; i++)
            {
                string _result = "";

                // Bir sayı hem 3'e ve hem de 5'e kalansız bölünebiliyorsa, 15'e tam bölünebilir.
                if (i % 15 == 0)
                {
                    // "100'den itibaren" yerine "100'den sonra" denildiği için 100 sayısı hariç tutulmuştur.
                    _result += i + " " + (i > 100 ? "zagzig" : "zigzag");
                }

                // "if" yerine "else if" kullanılmıştır. Çünkü 15'e kalansız bölünebilen tüm sayılar 3'e de kalansız bölünebilir. Böylece 5'e kalansız bölünemediği halde 3'e kalansız bölünebilen sayılar için bu bloğa girecektir. 3'e kalansız bölünen sayılar 5'e bölünen sayılardan daha çok sayıda olduğu için 5'ten önce kontrol edilmiştir. Böylece daha az kere if kontrolu sağlanmış olacaktır.
                else if (i % 3 == 0)
                {
                    _result += i + " zig";
                }
                else if (i % 5 == 0)
                {
                    _result += i + " zag";
                }
                else
                {
                    _result = i.ToString();
                }
                lstResults.Items.Add(_result);

            }

        }

        /// <summary>
        /// Girilen değer kontrol edilerek sayısal olmayan değer girilmesi, cut/copy-paste ile de olsa engellenmektedir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox _textBox = sender as TextBox;
            int _cursorPosition = _textBox.SelectionStart;
            var _numberFormat = CultureInfo.CurrentCulture.NumberFormat;

            string _filteredText = "";
            foreach (char _char in _textBox.Text)
            {
                if (char.IsDigit(_char) || _char == _numberFormat.NumberDecimalSeparator[0])
                {
                    if (_char == _numberFormat.NumberDecimalSeparator[0] && !_filteredText.Contains(_numberFormat.NumberDecimalSeparator))
                    {
                        _filteredText += _numberFormat.NumberDecimalSeparator;
                    }
                    else if (_char != _numberFormat.NumberDecimalSeparator[0])
                    {
                        _filteredText += _char;
                    }
                }
            }

            _textBox.Text = _filteredText;
            _textBox.SelectionStart = _cursorPosition <= _textBox.Text.Length ? _cursorPosition : _textBox.Text.Length;
        }

        /// <summary>
        /// Üçüncü işlevsellik: Bir textbox’a 1’den 15’e kadar bir tam sayı yazabilirim. Kaç yazarsam, düğmeye bastığımda, ekranda, o sayıya kadar olan çarpım tablosunu görmeliyim. Örneğin 4 girersem şunu görmeliyim (hizalamalara dikkat):
        /// 0   1   2    3    4
        /// 1   1   2    3    4
        /// 2   2   4    6    8
        /// 3   3   6    9   12
        /// 4   4   8   12   16
        /// 
        /// Projede istendiği üzere TextBox kullanılmıştır. Bunun yerine NumericUpDown kullanmak daha uygun olacaktır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResult3_Click(object sender, EventArgs e)
        {
            int _number;

            if (int.TryParse(txtMaxMultiplier.Text, out _number) && _number >= 1 && _number <= 15)
            {
                // Butona tekraren basıldığında tablonun resetlenmesi sağlanıyor ki önceki veriler kalmaya devam etmesin.
                dgvMultiplicationTable.Rows.Clear();
                dgvMultiplicationTable.Columns.Clear();
                dgvMultiplicationTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Her bir sayı için yeni bir kolon oluşturuyor.
                for (int i = 0; i <= _number; i++)
                {
                    dgvMultiplicationTable.Columns.Add(new DataGridViewTextBoxColumn());
                }

                // Kolonlara göre satırlar oluşturuluyor.
                dgvMultiplicationTable.Rows.Add();
                for (int _column = 0; _column <= _number; _column++)
                {
                    dgvMultiplicationTable.Rows[0].Cells[_column].Value = _column;
                }

                for (int _row = 1; _row <= _number; _row++)
                {
                    dgvMultiplicationTable.Rows.Add();
                    for (int _column = 0; _column <= _number; _column++)
                    {
                        dgvMultiplicationTable.Rows[_row].Cells[_column].Value =
                            _column == 0
                            ? _row
                            : dgvMultiplicationTable.Rows[_row].Cells[_column].Value = (_row * (int)dgvMultiplicationTable.Rows[0].Cells[_column].Value);
                    }
                }

            }
        }

        private void txtMaxMultiplier_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!(int.TryParse(txtMaxMultiplier.Text, out number) && number >= 1 && number <= 15))
            {
                MessageBox.Show("Lütfen 1 ilâ 15 arasında bir tam sayı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaxMultiplier.Text = "1";
            }
        }


        /// <summary>
        /// Dördüncü işlevsellik: Bilgisayarımdan bir metin dosyası seçmeme izin vermeli. Bu metin dosyasında sayılar olacak. Bu sayılar “white-space” karakterleri ile ayrılmış olacak (ipucu: white-space karakterlerinin TÜMÜNÜ dikkate aldığınıza emin olun yoksa programınız muhtemelen hata verecektir). Decimal sayıların ondalık haneleri virgül ile ayrılmış olacak. Metin dosyasındaki sayı miktarı belirsiz. Dosyayı seçip düğmeye tıkladığımda metin dosyasındaki tüm sayıları BÜYÜKTEN KÜÇÜĞE doğru sıralanmış bir biçimde ekranda görmeliyim. Örnek bir metin dosyasının içeriği şöyle:
        /// 56   45 6 2 789  
        /// 9 349   -87
        /// 11
        /// 4,34   -198,456
        /// 65
        /// 9,85      45
        /// -1
        ///    99,456
        /// 877 56     34  4
        /// 
        /// "metin dosyasındaki tüm sayıları" denildiği için sayılar tekrarlardan arındırılmamıştır. Fazlaca uyarı bildirimleri kullanıcılara zaman kaybettirdiğinden ve tekrar eden uyarı mesajları kullanıcılar tarafından -genellikle- dikkate alınmadığından "İşlem tamamlanmıştır." benzeri bir MessageBox açtırılmamıştır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResult4_Click(object sender, EventArgs e)
        {
            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                string[] _lines = File.ReadAllLines(ofdMain.FileName);
                List<double> _numbers = new List<double>();

                NumberFormatInfo _nfi = new NumberFormatInfo();
                _nfi.NumberDecimalSeparator = ",";

                foreach (string _line in _lines)
                {
                    string[] _values = _line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string _value in _values)
                    {
                        if (double.TryParse(_value, NumberStyles.Any, _nfi, out double number))
                        {
                            _numbers.Add(number);
                        }
                    }
                }

                var _sortedNumbers = _numbers.OrderByDescending(x => x);
                lstSortedNumbers.Items.Clear();
                foreach (double _number in _sortedNumbers)
                {
                    lstSortedNumbers.Items.Add(_number.ToString(_nfi));
                }
            }
        }   

        private void txtFibonacciPosition_TextChanged(object sender, EventArgs e)
        {
            int number;            
            if (!(int.TryParse(txtFibonacciPosition.Text, out number) && number > 0))
            {
                MessageBox.Show("Lütfen 0'dan büyük bir tam sayı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                txtFibonacciPosition.Text = "1";
            }
        }

        /// <summary>
        /// Beşinci işlevsellik: Bir textbox’a kaç yazarsam, düğmeye basıldığında, ekranda, o sıradaki Fibonacci sayısını görmeliyim. Örneğin kutuya 12 yazarsam, ekranda 89 göstermeli. Fibonacci serisinde, birinci sıradaki sayı 0, ikinci sıradaki sayı 1’dir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResult5_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int.TryParse(txtFibonacciPosition.Text, out int _fibonacciPosition);
            txtFibonacciValue.Text = FibonacciPosition(_fibonacciPosition).ToString();
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Fibonacci sayısını bir formül ile daha kısa sürede bulabilmek mümkündür ama sonuç hassasiyeti kesinlikle doğru olmayabilir. O sebeple uzun da sürse kesin doğru cevabı getirecek şekilde yazılmıştır.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int FibonacciPosition(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (1 + sqrt5) / 2;
            double psi = (1 - sqrt5) / 2;
            double fib = (Math.Pow(phi, n) - Math.Pow(psi, n)) / sqrt5;

            return (int)Math.Round(fib);
        }
    }
}