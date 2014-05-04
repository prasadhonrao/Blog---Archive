(function () {
    "use strict";

    var app = WinJS.Application;

    var employees = [
        { name: "Prasad Honrao", expertise: "JavaScript" },
        { name: "Anil Sathe", expertise: "C#" },
        { name: "Pulkit Mehta", expertise: "C#" },
        { name: "Yogesh Jangam", expertise: "JavaScript" },
        { name: "Pradeep Patidar", expertise: "C#" },
        { name: "Milly Mishra", expertise: "C#" },
        { name: "Colin Gray", expertise: "JavaScript" },
        { name: "Gaurav Hate", expertise: "Java" }
    ];

    WinJS.Namespace.define("Data", {
        employees: employees
    });

    app.onactivated = function (args) {
        args.setPromise(WinJS.UI.processAll().then(function () {
            var employeeListView = document.getElementById('employeesListView');
            employeeListView.winControl.itemTemplate = loadItemTemplate;
        }));
    };

    function loadItemTemplate(itemPromise) {
        return itemPromise.then(function (item) {

            var itemTemplate;
            switch (item.data.expertise) {
                case "C#":
                    itemTemplate = document.getElementById("CSharpTemplate");
                    break;
                case "Java":
                    itemTemplate = document.getElementById("JavaTemplate");
                    break;
                default:
                    itemTemplate = document.getElementById("OtherTemplate");

            }
            
            // Render selected template to DIV container
            var container = document.createElement("div");
            itemTemplate.winControl.render(item.data, container);
            return container;
        });
    }

    app.onready = function () {
        var dataList = new WinJS.Binding.List(Data.employees);
        var employeesList = document.getElementById('employeesListView').winControl;
        employeesList.itemDataSource = dataList.dataSource;
    }

    app.start();
})();
