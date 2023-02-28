

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
               
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("rakamlardan oluşmalıdır");
                }
                _girilenSayi  = value;
            }
        }
        public override string ToString()
        {
            
            return $"{this.GirilenSayi}"; 
        }
    }

   
}
