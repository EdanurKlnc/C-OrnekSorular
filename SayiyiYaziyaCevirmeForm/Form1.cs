namespace SayiyiYaziyaCevirmeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            try
            {
                Sayi sayi = new Sayi();
                sayi.GirilenSayi = txtSayiGiriniz.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Olu�tu! {ex.Message}");
            }


        }
        public override string ToString()
        {
            return $"{this.txtSayiGiriniz}";
        }
    }
}