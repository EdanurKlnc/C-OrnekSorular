

namespace SayiyiYaziyaCevirmeForm
{
    public class Sayi
    {
        private string _girilenSayi;

        public string GirilenSayi
        {
            get => _girilenSayi;
            set
            {
                if (value.Length != 10)
                    throw new Exception("Telefon Numarası 10 haneli olmalıdır");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon Numarası sadece rakamlardan oluşmalıdır");
                }
                _girilenSayi  = value;
            }
        }
    }
}
