using Common.Logging;
using Microsoft.AspNet.SignalR;
using ShinyTrain.Domain;
using ShinyTrain.Helpers;

namespace ShinyTrain.Hubs
{
    public class ShinyBroadcast
    {
        public static void PlayerAdded(Player player)
        {
            LogManager.GetLogger<ShinyHub>().InfoFormat("Player added: {0} ", player.Name);
            var shinyHub = GlobalHost.ConnectionManager.GetHubContext<ShinyHub>();
            shinyHub.Clients.All.playerCreated(player.AsJSON());
        }

        public static void GameCreated(TwixTGame game)
        {
            LogManager.GetLogger<ShinyHub>().InfoFormat("Game created: {0} ", game.Name);
            var shinyHub = GlobalHost.ConnectionManager.GetHubContext<ShinyHub>();
            shinyHub.Clients.All.gameCreated(game.AsJSON());
        }
    }
}