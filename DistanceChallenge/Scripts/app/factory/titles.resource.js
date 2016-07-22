(function () {
    "use strict";

    angular.module('titles')
		.constant('TitlesResourceUrl', {
		    get: '/api/titles'
		})
		.factory('TitlesResource', TitlesResource);

    TitlesResource.$inject = ['$http', 'TitlesResourceUrl'];

    function TitlesResource($http, TitlesResourceUrl) {
        return {
            getAll: function () {
                return $http({
                    method: 'GET',
                    url: TitlesResourceUrl.get,
                    params: {},
                    data: null,
                    cache: false
                });
            },
            get: function (id) {
                return $http({
                    method: 'GET',
                    url: TitlesResourceUrl.get + '/' + id,
                    params: {},
                    data: null,
                    cache: false
                });
            }
        };
    }
})();