(function() {
  var appConfig;
  appConfig = function($locationProvider, $stateProvider, $urlRouterProvider) {
    console.log($stateProvider);
    $locationProvider.html5Mode(false);
    $urlRouterProvider.otherwise('/lobby');
    return $stateProvider.state('app', {
      abstract: true,
      template: '<div ui-view=""></div>',
      url: ''
    }).state('app.lobby', {
      controller: 'lobbyController',
      templateUrl: '/Content/app/partials/lobby.html',
      url: '/lobby'
    });
  };
  return angular.module('app', ['ui.router']).config(appConfig, ['$locationProvider', '$stateProvider', '$urlRouterProvider']);
})();
