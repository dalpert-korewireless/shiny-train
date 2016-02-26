using System.Net;
using System.Web.Http;
using RandomNameGeneratorLibrary;
using ShinyTrain.Domain;
using ShinyTrain.Hubs;

namespace ShinyTrain.Controllers
{
    public class GamesController : ApiController
    {
        [HttpPost]
        public void Index()
        {
            var name = new PlaceNameGenerator().GenerateRandomPlaceName();
            var game = new TwixTGame(name);
            WebApp.ShinyData.CreateGame(game);
            ShinyBroadcast.GameCreated(game);
        }
    }
}