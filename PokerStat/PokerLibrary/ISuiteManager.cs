namespace PokerLibrary
{
    public interface ISuiteManager
    {
        public List<Carte>? isSuite(List<Carte> board, List<Carte> main); //return null si pas de suite
    }
}
