var myApp = angular.module('myApp', ['infinite-scroll']);

var numbersController = function($scope){
    $scope.numbers = [];
    $scope.limit = 25;

    function activate() {
        for (var i = 1; i <= 1000; i++) {
            $scope.numbers.push(i);
        }
    }

    $scope.loadMore = function () {
        $scope.limit = $scope.limit + 25;
    }

    activate();
}


myApp.controller('numbersController', numbersController);

