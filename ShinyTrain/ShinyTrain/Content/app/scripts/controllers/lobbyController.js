(function () {
	angular
		.module('app')
		.controller('lobbyController', ['$scope', 'lobbyFactory', lobbyController]);
		
	function lobbyController($scope, lobbyFactory) {
		console.log('hitting lobby');
		$scope.lobbies = lobbyFactory.get();
	}
})()