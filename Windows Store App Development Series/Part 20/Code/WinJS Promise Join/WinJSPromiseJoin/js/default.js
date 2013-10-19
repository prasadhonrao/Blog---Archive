(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var customerList = [];
    var employeeList = [];

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            var customerPromise = WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Customers" });
            var employeePromise = WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Employees" });

            var promises = { customer: customerPromise , employee : employeePromise } ;

            WinJS.Promise.join(promises).done(
                function complete(xhr) {

                    var customerResult = xhr.customer.responseXML;
                    var items = customerResult.querySelectorAll("entry");

                    for (var ctr = 0; ctr < items.length; ctr++) {
                        var customer = {};

                        customer.ContactName = items[ctr].querySelector("ContactName").textContent;
                        customer.Address = items[ctr].querySelector("Address").textContent;
                        customer.City = items[ctr].querySelector("City").textContent;
                        customer.PostalCode = items[ctr].querySelector("PostalCode").textContent;
                        customer.Country = items[ctr].querySelector("Country").textContent;
                        customerList.push(customer);
                    }

                    var customerDataList = new WinJS.Binding.List(customerList);
                    var customerListView = document.getElementById('CustomerListView').winControl;
                    customerListView.itemDataSource = customerDataList.dataSource;

                    var employeeResult = xhr.employee.responseXML;
                    var items = employeeResult.querySelectorAll("entry");

                    for (var ctr = 0; ctr < items.length; ctr++) {
                        var employee = {};
                        employee.ContactName = items[ctr].querySelector("FirstName").textContent;
                        employee.Address = items[ctr].querySelector("Address").textContent;
                        employee.City = items[ctr].querySelector("City").textContent;
                        employee.PostalCode = items[ctr].querySelector("PostalCode").textContent;
                        employee.Country = items[ctr].querySelector("Country").textContent;
                        employeeList.push(employee);
                    }

                    var employeeDataList = new WinJS.Binding.List(employeeList);
                    var employeeListView = document.getElementById('EmployeeListView').winControl;
                    employeeListView.itemDataSource = employeeDataList.dataSource;
                    
                },
                function error(xhr) {
                    // Handle error here...
                },
                function progress(xhr) {
                    // Handle progress here...
                }
           );

            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.start();
})();
