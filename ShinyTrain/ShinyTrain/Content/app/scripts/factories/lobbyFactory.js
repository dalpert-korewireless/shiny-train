(function () {
	angular
		.module('app')
		.factory('lobbyFactory', ['$http', lobbyFactory])
		
	function lobbyFactory($http) {
		//store games?
		return {
			get: getLobby,
			add: addGameToLobby
		}
		
		function getLobby() {
			//http get
		}
		
		function addGameToLobby(game) {
			//http post
		}
	}
})()