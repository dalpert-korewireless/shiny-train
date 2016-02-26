using System.Web.Http;
using ShinyTrain.Domain;
using ShinyTrain.Hubs;

namespace ShinyTrain.Controllers
{
    public class PlayersController : ApiController
    {
        [HttpPost]
        public void Index(Player player)
        {
            WebApp.ShinyData.RegisterPlayer(player);
            ShinyBroadcast.PlayerAdded(player);
        }
    }
}