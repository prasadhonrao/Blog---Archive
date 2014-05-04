(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var customerList = [];
    var dataList = [];
    var result;

    function SaveCustomerData(response) {
        result = response.responseXML;
    }

    function DisplayCustomerData() {
        var items = result.querySelectorAll("entry");

        for (var ctr = 0; ctr < items.length; ctr++) {
            var customer = {};
            customer.ContactName = items[ctr].querySelector("ContactName").textContent;
            customer.Address = items[ctr].querySelector("Address").textContent;
            customer.City = items[ctr].querySelector("City").textContent;
            customer.PostalCode = items[ctr].querySelector("PostalCode").textContent;
            customer.Country = items[ctr].querySelector("Country").textContent;
            customerList.push(customer);
        }

        dataList = new WinJS.Binding.List(customerList);
        var customerListView = document.getElementById('customerListView').winControl;
        customerListView.itemDataSource = dataList.dataSource;
    }

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Customers" })
                    .then(SaveCustomerData)
                    .done(DisplayCustomerData);

            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.start();
})();
