namespace PokerLibrary;

internal class SuiteManager : ISuiteManager
{
    public List<Carte>? isSuite(List<Carte> board, List<Carte> main)
    {
        List<Carte> cartes = board.Concat(main).ToList(); //rassemble les deux listes pour en faire qu'une

        if (cartes.Count < 5) return null; // si il y a moins de 5 cartes , pas de suite 
        Carte? min = plusPetiteCarte(cartes); // recupère la carte la plus petite
        List<Carte> suite = new List<Carte> { min }; // liste qui contiendra la suite si il en a une
        Carte? As = min; // met le min dans As 
        if (min == null || min.Val != 1) As = null; // met null dans As si min n'est pas un as 
        cartes.Remove(min);          
        while(cartes.Count > 0)
        { 
            min = plusPetiteCarte(cartes);
            if (min != null && suite.Last().Val + 1 == min.Val) // si le minimum est bien superieur de 1 que le plus grand de suite
            {
                suite.Add(min);
                cartes.Remove(min);
                if (suite.Count == 5) return suite; // si ya 5 éléments, c'est parfait ya une suite
            }
            else if (suite.Count == 4 && suite.Last().Val == 13 && As != null)
            {
                suite.Add(As);
                return suite;
            }
            else
            {
                suite.Clear();
                suite.Add(min);
                cartes.Remove(min);
            }
        }
        return cartes;
    }

    private Carte? plusPetiteCarte(List<Carte> cartes)
    {
        return cartes.OrderBy(c => c.Val).FirstOrDefault();
    }
}
