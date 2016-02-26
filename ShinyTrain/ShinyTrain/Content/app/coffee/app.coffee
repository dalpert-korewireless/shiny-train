(() ->
  appConfig = ($locationProvider, $stateProvider, $urlRouterProvider) ->
    console.log $stateProvider
    $locationProvider.html5Mode no
    $urlRouterProvider.otherwise '/lobby'

    $stateProvider.state 'app',
      abstract: true
      template: '<div ui-view=""></div>'
      url: ''
    .state 'app.lobby',
      controller: 'lobbyController'
      templateUrl: '/Content/app/partials/lobby.html'
      url: '/lobby'

  angular.module 'app', ['ui.router']
    .config appConfig, ['$locationProvider', '$stateProvider', '$urlRouterProvider']
)()
