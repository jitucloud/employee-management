app.service('employeeService', function ($http, $q) {

    var employees = undefined;

    this.GetAllEmployee = function (filter) {

        var deferred = $q.defer();
        var options = {
            method: 'GET',
            url: '/api/employee',
            params: { filter: filter }
        };

        $http(options).then(function (response) {
            employees = response.data;
            deferred.resolve(employees);
        }, function (error) {
            employees = error;
            deferred.reject(error);
        });
        employees = deferred.promise;
        return $q.when(employees);
    }
});