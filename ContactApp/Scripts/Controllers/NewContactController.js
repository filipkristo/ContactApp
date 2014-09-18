
var NewContactController = function ($scope, $routeParams, $location, ContactsFactory) {

    $scope.error = '';
    $scope.info = '';

    $scope.contactForm = 
    {
        Id: '',
        FirstName: '',
        LastName: '',
        Address: '',
        PostCode: '',
        City: '',
        Country: '',
        ContactPhone: [],
        ContactEmail: [],
        ContactTag: []
    };

    $scope.header = '';        

    $scope.addNewPhone = function () {
        var newItemNo = $scope.contactForm.ContactPhone.length + 1;
        var newPhone = {Id: '', Phone: '', ContactId: $scope.contactForm.Id};
        $scope.contactForm.ContactPhone.push(newPhone);        
    };
    
    $scope.removePhone = function (item) {        

        if (item.Phone != null)
            return;

        var index = $scope.contactForm.ContactPhone.indexOf(item);
        $scope.contactForm.ContactPhone.splice(index, 1);

        $scope.info = 'Phone removed!';
    };
    
    $scope.addNewEmail = function () {        
        var newEmail = { Id: '', Email: '', ContactId: $scope.contactForm.Id };
        $scope.contactForm.ContactEmail.push(newEmail);        
    };    

    $scope.removeEmail = function (item) {

        if (item.Email != null)
            return;

        var index = $scope.contactForm.ContactEmail.indexOf(item);
        $scope.contactForm.ContactEmail.splice(index, 1);

        $scope.info = 'Email removed!';
    };

    $scope.addNewTag = function () {
        var newTag = { Id: '', Tag: '', ContactId: $scope.contactForm.Id };
        $scope.contactForm.ContactTag.push(newTag);        
    };
    
    $scope.removeTag = function (item) {

        if (item.Tag != null)
            return;

        var index = $scope.contactForm.ContactTag.indexOf(item);
        $scope.contactForm.ContactTag.splice(index, 1);

        $scope.info = 'Tag removed!';
    };

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
        $scope.info = '';
        $scope.error = '';

        ContactsFactory.saveContact($scope.contactForm).then(function (results) {
            //resolve
            $location.path("/AllContacts/");
        },
        function (results) {
            //reject
            $scope.error = results.ExceptionMessage;            
        });
    };       
        
}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
NewContactController.$inject = ['$scope', '$routeParams', '$location', 'ContactsFactory'];