(function () {
	angular
		.module('app', ['ui-router'])
		.config(appConfig);
	
	function appConfig() {
		console.log('config');
	}
})();