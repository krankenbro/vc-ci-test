angular.module('CITest')
    .factory('CITest.webApi', ['$resource', function ($resource) {
        return $resource('api/ci-test');
    }]);
