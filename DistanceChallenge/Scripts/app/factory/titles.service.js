(function () {
    "use strict";

    angular.module('titles')
		.factory('TitlesService', TitlesService);

    TitlesService.$inject = ['$log', 'Semaphore', 'TitlesResource'];

    function TitlesService($log, Semaphore, TitlesResource) {
        var cacheTimeout = 300000; // 5 minutes

        var service = {
            getTitles: getTitles,
            refresh: refresh
        };

        var titles = {
            lastFetch: 0,
            data: [],
            semaphore: Semaphore.get('titles')
        };

        function getTitles() {
            loadTitles();
            return titles.data;
        }

        function refresh() {
            titles.lastFetch = 0;
            loadTitles();
        }

        function loadTitles() {
            // Don't load if last fetch time was within the cache timeout
            if (Date.now() - titles.lastFetch < cacheTimeout) return;

            // Don't load if another load is already in progress
            if (titles.semaphore.isClosed()) return;

            titles.semaphore.close();

            TitlesResource.getAll().then(
                function (response) {
                    titles.data.splice(0, titles.data.length);
                    angular.extend(titles.data, response.data);
                    titles.lastFetch = Date.now();
                },
                function (message) {
                    $log.error('Unable to load titles!');
                    $log.error(message);
                }
             )
            .finally(function () {
                titles.semaphore.open();
            });
        }

        loadTitles();
        return service;
    }
})();