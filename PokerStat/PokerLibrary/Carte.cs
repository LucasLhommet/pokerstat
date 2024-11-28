namespace PokerLibrary
{
    public class Carte
    {
        public int Val
        {
            get => _val;
            set
            {
                if (_val != value)
                {
                    _val = value;
                }
            }
        }
        private int _val;

        public string Signe
        {
            get => _signe;
            set
            {
                if (_signe != value)
                {
                    _signe = value;
                }
            }
        }

        private string _signe;

        public Carte(int val, string signe)
        {
            IVerificateurDeCarte vdc = new VerificateurDeCarte();

            if (vdc.VerifierCarte(val, signe))
            {
                _val = val;
                _signe = signe;
            }
            else
            {
                throw new ArgumentException("carte non conforme");
            }
        }
    }
}
