
var ContactFilter = function () {
    return function (rows, text) {        
        //return rows;
        //alert('test: ' + text);

        $http(
            {
                method: "GET",
                url: "/api/Contact/Contacts?filter=" + text,
                headers: { "Content_Type": "application/json; charset=utf-8" }
            })
            .then(function (results) {
                //Success                
                return results.data;
            }, function (results) {
                //Error
                alert('Unknown error');
            })

        //return rows;
        //ContactsFactory.getContacts(text).then(function (results) {
        //    //resolve
        //    return results.data;            
        //},
        //function (results) {
        //    //reject
        //    alert(results.data.ExceptionMessage);
        //    return rows;
        //});

    };

};