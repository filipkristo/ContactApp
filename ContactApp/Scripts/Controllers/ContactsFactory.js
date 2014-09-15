var ContactsFactory = function ($http, $q) {    

        var _contacts = [];        
        var _getContacts = function () {

            $http(
                {
                    method: "GET",
                    url: "/api/Contact/Contacts",
                    headers: {"Content_Type" : "application/json; charset=utf-8"}
                })
                .then(function (results) {
                    //Success
                    angular.copy(results.data, _contacts); 
                }, function (results) {
                    //Error
                    alert(results.data.ExceptionMessage);
                })
        };

        return {
            contacts: _contacts,
            getContacts: _getContacts
        };
    
}

ContactsFactory.$inject = ['$http', '$q'];