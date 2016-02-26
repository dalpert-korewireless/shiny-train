using System;
using System.Collections.Generic;
using System.Linq;
using MemoryCacheT;
using ShinyTrain.Domain;
using ShinyTrain.Domain.Exceptions;

namespace ShinyTrain.Persistence
{
    public class InMemoryShinyDataRepository : IShinyDataRepository
    {
        private readonly Cache<string, Player> _players = new Cache<string, Player>(TimeSpan.FromHours(1));
        private readonly Cache<string, TwixTGame> _games = new Cache<string, TwixTGame>(TimeSpan.FromHours(1));

        public void RegisterPlayer(string playerName)
        {
            var player = new Player(playerName);

            if (_players.ContainsKey(playerName))
            {
                throw new PlayerAlreadyExistsException(playerName);
            }

            _players.Add(player.Name, player);
        }

        public void RegisterGame(string gameName)
        {
            var game = new TwixTGame(gameName);

            if (_games.ContainsKey(gameName))
            {
                throw new GameAlreadExistsException(gameName);
            }

            _games.Add(gameName, game);
        }

        public IList<TwixTGame> ListGames()
        {
            return _games.Values.ToList();
        }

        public IList<Player> ListPlayers()
        {
            return _players.Values.ToList();
        }

        public void TwixtLobby()
        {
            throw new NotImplementedException();
        }
    }
}