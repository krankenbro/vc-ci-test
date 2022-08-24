angular.module('CITest')
    .controller('CITest.helloWorldController', ['$scope', 'CITest.webApi', function ($scope, api) {
        var blade = $scope.blade;
        blade.title = 'CITest';

        blade.refresh = function () {
            api.get(function (data) {
                blade.title = 'CITest.blades.hello-world.title';
                blade.data = data.result;
                blade.isLoading = false;
            });
        };

        blade.refresh();
    }]);
