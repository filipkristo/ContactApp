var AwesomeAngularMVCApp = angular.module('ContactApp', ['ngRoute']);

AwesomeAngularMVCApp.controller('HomeController', HomeController);
AwesomeAngularMVCApp.controller('ContactController', ContactController);
AwesomeAngularMVCApp.controller('NewContactController', ContactController);

AwesomeAngularMVCApp.factory('ContactsFactory', ContactsFactory);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/Index', {
            templateUrl: 'Home/Home'
        })
        .when('/AllContacts/', {
            templateUrl: 'Home/AllContacts',
            controller: ContactController
        })
        .when('/NewContact/', {
            templateUrl: 'Home/NewContact',
            controller: NewContactController
        })
        .when('/About', {
            templateUrl: 'home/about'
        });
}

configFunction.$inject = ['$routeProvider'];

AwesomeAngularMVCApp.config(configFunction);
