using System.Collections.Generic;

namespace ShinyTrain.Domain
{
    public interface IShinyDataRepository
    {
        void RegisterPlayer(Player player);
        void CreateGame(TwixTGame player);
        IList<TwixTGame> ListGames();
        IList<Player> ListPlayers();
    }
}