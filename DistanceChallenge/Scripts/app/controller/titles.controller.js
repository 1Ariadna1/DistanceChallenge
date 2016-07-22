(function () {
    "use strict";

    angular.module('titles')
        .controller('TitlesController', TitlesController);

    TitlesController.$inject = ['$scope', 'TitlesService'];

    function TitlesController($scope, TitlesService) {
        var vm = this;

        vm.titles = TitlesService.getTitles();
        vm.selectedTitle = null;
    }
})();