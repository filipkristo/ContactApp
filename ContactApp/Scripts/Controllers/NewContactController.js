
var NewContactController = function ($scope, $routeParams, ContactsFactory) {

    $scope.contactForm = 
    {
        Id: '',
        FirstName: '',
        LastName: '',
        Address: '',
        PostCode: '',
        City: '',
        Country: ''
    };

    $scope.header = '';

    if ($routeParams.Id != null) {
        $scope.header = 'Edit Contact';

        ContactsFactory.getContact($routeParams.Id).then(function (results) {
            //resolve
            angular.copy(results.data, $scope.contactForm);
        },
        function (results) {
            //reject

            alert(results.data.ExceptionMessage);
        });
    }
    else
        $scope.header = 'New Contact';

    $scope.saveContact = function () {
        ContactsFactory.saveContact($scope.contactForm).then(function (results) {
            //resolve
            alert('Contact saved!');
        },
        function (results) {
            //reject

            alert(results.ExceptionMessage);
        });
    };
    
        
}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
NewContactController.$inject = ['$scope', '$routeParams', 'ContactsFactory'];