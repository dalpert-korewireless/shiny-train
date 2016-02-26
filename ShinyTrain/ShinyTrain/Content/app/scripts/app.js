(function () {
	angular
		.module('app', ['ui.router'])
		.config(appConfig, ['$locationProvider', '$stateProvider', '$urlRouterProvider']);
	
	function appConfig($locationProvider, $stateProvider, $urlRouterProvider) {
		console.log($stateProvider);
		$locationProvider.html5Mode(false);
		$urlRouterProvider.otherwise('/lobby');
		 
		$stateProvider
			.state('app', {
      			url: '',
				template: '<div ui-view=""></div>',
				abstract: true
			})
            .state('app.lobby', {
                url: '/lobby',
                templateUrl: '/Content/app/partials/lobby.html',
                controller: 'lobbyController'
            });
	}
})();