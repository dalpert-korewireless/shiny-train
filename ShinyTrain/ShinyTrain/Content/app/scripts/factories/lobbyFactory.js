(function () {
	angular
		.module('app')
		.factory('lobbyFactory', ['$http', lobbyFactory])
		
	function lobbyFactory($http) {
		return {
			get: getLobby
		}
		
		function getLobby() {
			
		}
	}
})()