var app = angular.module('MCS_ServiceApp', ['ngRoute', 'ngResource']).config(function () {});

app.controller("MasterController", function ($scope, $rootScope, $location) { $location.path('/dashboard'); });

app.config(['$routeProvider', function ($routeProvider) {

    $routeProvider.when("/dashboard/", {
    	templateUrl: "app/views/dashboard.html",
		controller:"DashCtrl"
    }).otherwise({
        redirectTo: ''
    });

}]);
