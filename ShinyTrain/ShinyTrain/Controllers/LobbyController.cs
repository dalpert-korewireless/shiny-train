using System.Security;
using System.Web.Http;
using ShinyTrain.Domain;

namespace ShinyTrain.Controllers
{
    public class LobbyController : ApiController
    {
        //
        // GET: /Lobby/
        [System.Web.Http.HttpGet]
        public TwixtLobby Index()
        {
            return new TwixtLobby
            {
                Players = WebApp.ShinyData.ListPlayers(),
                Games = WebApp.ShinyData.ListGames()
            };
        }
    }
}
