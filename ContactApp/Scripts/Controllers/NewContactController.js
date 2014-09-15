
var NewContactController = function ($scope) {
    $scope.contactForm =
        {
            firstName : '',
            lastName : '',
            address: '',
            postcode: '',
            city: '',
            country: ''
        };

    $scope.save = function () {
        alert('Pozdrav ' + $scope.contactForm.firstName + ' ' + $scope.contactForm.lastName);
    };

}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
NewContactController.$inject = ['$scope'];