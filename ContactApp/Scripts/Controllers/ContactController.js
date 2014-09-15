
var ContactController = function ($scope, ContactsFactory) {    

    $scope.contacts = ContactsFactory.contacts;

    ContactsFactory.getContacts();    
}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
ContactController.$inject = ['$scope', 'ContactsFactory'];