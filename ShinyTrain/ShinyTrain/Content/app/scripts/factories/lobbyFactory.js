(function () {
	angular
		.module('app')
		.factory('lobbyFactory', ['$http', lobbyFactory])
		
	function lobbyFactory($http) {
		return {
			get: getLobby,
			add: addGameToLobby,
            lobby: {}
		}
		
		function getLobby() {
			//http get
		}
		
		function addGameToLobby(game) {
			//http post
		}
	}
})()