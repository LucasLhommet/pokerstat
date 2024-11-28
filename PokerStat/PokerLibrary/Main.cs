
namespace PokerLibrary;

public class Main
{
    public List<Carte> Cartes 
    {
        get => _cartes;

        set
        {
            if (_cartes != value)
            {
                _cartes = value;
            }
        }
    }

    private List<Carte> _cartes;

    public Main(Carte carte , Carte carte2)
    {
        _cartes = [carte,carte2];
    }
}
