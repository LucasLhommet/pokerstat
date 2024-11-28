using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary;

internal class CouleurManager : ICouleurManager
{
    public List<Carte>? isCouleur(List<Carte> board, List<Carte> main)
    {
        List<Carte> cartes = board.Concat(main).ToList(); //rassemble les deux listes pour en faire qu'une



    }

    private List<Carte>? nbSigne(List<Carte> cartes, string signe)
    {

    }

}
