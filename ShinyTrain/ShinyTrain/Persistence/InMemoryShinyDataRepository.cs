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

        public void RegisterPlayer(Player player)
        {
            if (_players.ContainsKey(player.Name))
            {
                throw new PlayerAlreadyExistsException(player.Name);
            }

            _players.Add(player.Name, player);
        }

        public void CreateGame(TwixTGame game)
        {
            if (_games.ContainsKey(game.Name))
            {
                throw new GameAlreadExistsException(game.Name);
            }

            _games.Add(game.Name, game);
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