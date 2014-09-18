var ContactsFactory = function ($http, $q) {                            

        var GetContacts = function (filter) {

            var deferredObject = $q.defer();
            var strUrl = '';

            if (filter == '')
                strUrl = '/api/Contact/Contacts/';
            else
                strUrl = '/api/Contact/Contacts?filter=' + encodeURIComponent(filter);

            $http(
                {
                    method: "GET",
                    url: strUrl,
                    headers: {"Content_Type" : "application/json; charset=utf-8"}
                })
                .then(function (results) {
                    //Success
                    deferredObject.resolve(results)
                }, function (results) {
                    //Error
                    deferredObject.reject(results)
                })

            return deferredObject.promise;
        };
        
        
        var GetContact = function (contactID) {

            var deferredObject = $q.defer();

            $http(
                {
                    method: "GET",
                    url: "/api/Contact/Contact?Id=" + contactID,
                    headers: { "Content_Type": "application/json; charset=utf-8" }
                })
                .then(function (results) {
                    //Success                    
                    deferredObject.resolve(results)
                }, function (results) {
                    //Error
                    deferredObject.reject(results)
                })

            return deferredObject.promise;
        };
        
        var SaveContact = function (model) {

            var deferredObject = $q.defer();

            $http(
                {
                    method: "POST",
                    url: "/api/Contact/SaveContact/",
                    data: model,
                    headers: { "Content_Type": "application/json; charset=utf-8" }
                })
                .then(function (data, status, headers, config) {
                    //Success                    
                    deferredObject.resolve(data)
                }, function (data, status, headers, config) {
                    //Error
                    deferredObject.reject(data)
                })

            return deferredObject.promise;
        }
    
        var DeleteContact = function (contactId) {

            var deferredObject = $q.defer();

            $http(
                {
                    method: "DELETE",
                    url: "/api/Contact/DeleteContact?Id=" + contactId,                    
                    headers: { "Content_Type": "application/json; charset=utf-8" }
                })
                .then(function (data, status, headers, config) {
                    //Success                    
                    deferredObject.resolve(data)
                }, function (data, status, headers, config) {
                    //Error
                    deferredObject.reject(data)
                })

            return deferredObject.promise;
        }

        return {            
            getContacts: GetContacts,            
            getContact: GetContact,
            saveContact: SaveContact,
            deleteContact: DeleteContact
        };
    
}

ContactsFactory.$inject = ['$http', '$q'];