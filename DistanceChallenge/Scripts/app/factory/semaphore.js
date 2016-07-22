(function () {
    "use strict";

    angular.module('titles')
		.factory('Semaphore', Semaphore);

    Semaphore.$inject = ['$log'];

    function Semaphore($log) {
        return {
            semaphores: {},
            get: function (name) {
                if (typeof (this.semaphores[name] === 'undefined')) {
                    this.semaphores[name] = {
                        status: 0,
                        open: function () { this.status = 0; },
                        close: function () { this.status = 1; },
                        isOpen: function () { return this.status == 0; },
                        isClosed: function () { return !this.isOpen(); }
                    };
                }

                return this.semaphores[name];
            }
        };
    }
})();