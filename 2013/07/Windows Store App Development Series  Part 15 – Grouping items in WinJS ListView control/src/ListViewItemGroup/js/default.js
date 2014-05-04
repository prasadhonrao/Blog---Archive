(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;

    var employees = [
        { name: "Prasad Honrao", expertise: "VB.Net" },
        { name: "Anil Sathe", expertise: "C#" },
        { name: "Pulkit Mehta", expertise: "C#" },
        { name: "Yogesh Jangam", expertise: "VB.Net" },
        { name: "Pradeep Patidar", expertise: "C#" },
        { name: "Milly Mishra", expertise: "C#" },
        { name: "Colin Gray", expertise: "VB.Net" },
        { name: "Gaurav Hate", expertise: "Java" },
        { name: "Mohan Wakle", expertise: "ASP.Net" },
        { name: "Yogesh Shinde", expertise: "ASP.Net" }
    ];

    var employeeList = new WinJS.Binding.List(employees);

    // Create grouped data source
    var groupedEmployees = employeeList.createGrouped(
        function (dataItem) {
            return dataItem.expertise;
        },
        function (dataItem) {
            return { expertise: dataItem.expertise };
        },
        function (group1, group2) {
            return group1.charCodeAt(0) - group2.charCodeAt(0);
        }
    );

    WinJS.Namespace.define("Data", {
        employees: groupedEmployees
    });


    app.onactivated = function (args) {
        WinJS.UI.processAll()
    };

    app.start();
})();
