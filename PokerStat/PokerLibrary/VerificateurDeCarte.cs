namespace PokerLibrary
{
    public class VerificateurDeCarte : IVerificateurDeCarte
    {
        public bool VerifierCarte(int val, string signe)
        {
            bool check = false;

            List<string> array = ["pique","trefle","coeur","carreau"];
            foreach (var sig in array)
            {
                if (signe == sig)
                {
                    check = true;
                }
            }
            return val > 0 && val < 14 && check;
        }
    }
}
