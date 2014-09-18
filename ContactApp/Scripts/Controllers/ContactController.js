
var ContactController = function ($scope, $location, ContactsFactory) {    

    $scope.contacts = [];

    $scope.editContact = function (item) {        
        $location.path("/NewContact/" + item.Id)
    };

    $scope.deleteContact = function (item) {

        var result = confirm('Are you sure that you want to delete contact: ' + item.FirstName);

        if (result == false)
            return;

        ContactsFactory.deleteContact(item.Id).then(function (results) {
            refresh();            
            },
        function (results) {
            //reject
            refresh();
            alert(results.ExceptionMessage);
        });

    };    

    var refresh = function () {
        ContactsFactory.getContacts('').then(function (results) {
            //resolve
            angular.copy(results.data, $scope.contacts);
        },
        function (results) {
            //reject
            alert(results.data.ExceptionMessage);
        });
    };    
    
    refresh();
}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
ContactController.$inject = ['$scope', '$location' , 'ContactsFactory'];