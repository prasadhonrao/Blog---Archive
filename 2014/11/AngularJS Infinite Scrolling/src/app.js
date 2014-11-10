var myApp = angular.module('myApp', ['infinite-scroll']);

var numbersController = function($scope){
    $scope.numbers = [];
    $scope.counter = 0;

    $scope.loadMore = function () {
        for (var i = 0; i < 25; i++) {
            $scope.numbers.push(++$scope.counter);
        };
    }
    $scope.loadMore();
}

myApp.controller('numbersController', numbersController);