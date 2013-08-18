function EmployeeController($scope) {
    $scope.Employees = [
        { name: 'Scott Allen', company: 'OdeToCode' },
        { name: 'Dan Wahlin', company: 'The Wahlin Group' },
        { name: 'Scott Hanselman', company: 'Microsoft' },
        { name: 'John Papa', company: 'Pluralsight' },
    ];

    $scope.addEmployee = function () {
        $scope.Employees.push({
            name: $scope.newEmployee.name,
            company: $scope.newEmployee.company
        });
    }
}

