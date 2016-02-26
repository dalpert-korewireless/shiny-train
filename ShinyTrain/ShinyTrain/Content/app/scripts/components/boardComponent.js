(function () {
	angular
		.module('app')
		.component('board', boardComponent());
		
    var matrix = []
		
	function boardComponent() {
		return {
			templateUrl: '/Content/app/partials/components/board.html',
			controller: boardController,
			bindings: {
				width: '<',
				height: '<'
			}
		}
	}
	
	function boardController() {
		var vm = this;
		var element = document.getElementById('board');
		var context = element.getContext("2d");
	}
})();