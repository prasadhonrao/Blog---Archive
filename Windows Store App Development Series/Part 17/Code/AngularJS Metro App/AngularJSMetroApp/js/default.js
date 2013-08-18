function EmployeeController($scope) {

    var app = WinJS.Application;
    var dataList;
    var employeesList;

    employees = [
        { name: 'Scott Allen', company: 'OdeToCode' },
        { name: 'Dan Wahlin', company: 'The Wahlin Group' },
        { name: 'Scott Hanselman', company: 'Microsoft' },
        { name: 'John Papa', company: 'Pluralsight' },
    ];

    app.onactivated = function (args) {
        WinJS.UI.processAll();
    };

    app.onready = function () {
        dataList = new WinJS.Binding.List(employees);
        employeesList = document.getElementById('employeesListView').winControl;
        employeesList.itemDataSource = dataList.dataSource;
    }

    $scope.addEmployee = function () {
        dataList.push(
            { name: 'Prasad Honrao', company: 'Cognizant' },
            { name: 'Scott Guthrie', company: 'Microsoft' }
            );
    }

    app.start();
}
