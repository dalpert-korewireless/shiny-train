using System.Collections.Generic;

namespace ShinyTrain.Domain
{
    public interface IShinyDataRepository
    {
        void RegisterPlayer(string playerName);
        IList<TwixTGame> ListGames();
        IList<Player> ListPlayers();
    }
}