using Chess_Game.Domain.Entities;
using static Chess_Game.Components.Pages.Show_Games;

namespace Chess_Game.Services
{
    public class SharedDataService
    {
    public List<Game> SharedValue { get; set; } = new List<Game>();

    public List<WLthis> SharedList { get; set; } = new List<WLthis>();


    public List<op> OpeningList { get; set; } = new List<op>();
    }
}
