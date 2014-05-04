(function () {
    "use strict";

    var app = WinJS.Application;

    var employees = [
        { name: "Prasad Honrao", expertise:"JavaScript, C#", favoriteColor: "green" },
        { name: "Anil Sathe", expertise: "C#", favoriteColor: "lightblue" },
        { name: "Pulkit Mehta", expertise: "C#", favoriteColor: "orange" },
        { name: "Yogesh Jangam", expertise: ".Net", favoriteColor: "maroon" },
        { name: "Pradeep Patidar", expertise: "C#", favoriteColor: "cyan" },
        { name: "Milly Mishra", expertise: "C#, VSTO", favoriteColor: "yellow" },
        { name: "Colin Gray", expertise: ".Net, Design Patterns", favoriteColor: "khaki" },
        { name: "Gaurav Hate", expertise: "Java", favoriteColor: "lightgreen" }
    ];

    WinJS.Namespace.define("Data", {
        employees: employees
    });
    
    app.onactivated = function (args) {
        WinJS.UI.processAll();
    };

    app.onready = function () {
        var dataList = new WinJS.Binding.List(Data.employees);
        var employeesList = document.getElementById('employeesListView').winControl;
        employeesList.itemDataSource = dataList.dataSource;
    }

    app.start();
})();
