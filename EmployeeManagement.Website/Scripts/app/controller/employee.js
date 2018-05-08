app.controller('empController', function ($scope, employeeService, $timeout) {
    $scope.employeeData = "";
    $scope.initEmployeeTable = function () {
        employeeService.GetAllEmployee()
           .then(function (employees) {
               $scope.employeeData = employees;
           });
    }
});