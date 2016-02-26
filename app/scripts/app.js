(function () {
	angular
		.module('app', ['ui.router'])
		.config(appConfig, ['$locationProvider', '$stateProvider', '$urlRouterProvider']);
	
	function appConfig($locationProvider, $stateProvider, $urlRouterProvider) {
		console.log($stateProvider);
		$locationProvider.html5Mode(true);
		$urlRouterProvider.otherwise('/');
		 
		$stateProvider
			.state('app', {
      			url: '',
				template: '<div ui-view=""></div>',
				abstract: true
    		})
			.state('app.game', {
				url: '/game',
				templateUrl: '/app/partials/game.html'
			});
	}
})();